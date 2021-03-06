﻿using Ouatelse.Managers;
using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ouatelse.Forms
{
    public partial class ProductForm : Form
    {
        #region Les attributs de la classe
        /// <summary>
        /// Le produit courant du formulaire
        /// </summary>
        Product obj = null;

        /// <summary>
        /// La cohérence entre le formulaire et notre produit
        /// </summary>
        Binding b = new Binding();
        #endregion

        #region Le constructeur de la classe
        /// <summary>
        /// Le constructeur de la classe
        /// </summary>
        /// <param name="obj"></param>
        public ProductForm(Product obj)
        {
            InitializeComponent();
            //Cohérence pour l'affichage des titres
            this.Text = this.label1.Text = obj.Exists ? "Détail du produit " : " Nouveau produit";
            this.obj = obj;
        }
        #endregion

        #region Gestion du chargement de l'affichage du formulaire
        /// <summary>
        /// Chargement de l'affichage du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductForm_Load(object sender, EventArgs e)
        {

            //On lie notre objet à notre binding
            this.Id.Text = obj.StringId;
            b.Bind(this.Name, "Text", obj, "Name");
            b.Bind(this.Designation, "Text", obj, "Designation");
            b.Bind(this.PurchasePrice, "Text", obj, "PurchasePrice");
            b.Bind(this.SellPrice, "Text", obj, "SellPrice");
            b.Bind(this.TVA, "Text", obj, "TVA");
            b.Bind(this.EANCode, "Text", obj, "EANCode");
            b.Populate();
        }
        #endregion

        #region Gestion de la validation du formulaire
        private void validateButton_Click_1(object sender, EventArgs e)
        {
            //On hydrate notre binding
            b.Hydrate();
            //On regarde si notre entité peut être validé en base
            if (obj.validate().Count != 0)
            {
                string error = String.Empty;
                foreach (Product.ValidationResult warning in obj.validate())
                {
                    switch (warning)
                    {
                        case Product.ValidationResult.WRONG_NAME:
                            error += "Erreur dans la saisie du nom ( il doit obligatoirement être rempli )" + Environment.NewLine;
                            break;
                        case Product.ValidationResult.WRONG_DESIGNATION:
                            error += "Erreur dans la saisie du prénom ( il doit obligatoirement être rempli )" + Environment.NewLine;
                            break;
                        case Product.ValidationResult.WRONG_PURCHASEPRICE:
                            error += "Erreur dans la saisie de l'adresse ( elle doit obligatoirement être rempli )" + Environment.NewLine;
                            break;
                        case Product.ValidationResult.WRONG_SELLPRICE:
                            error += "Erreur dans la saisie de la ville ( elle doit obligatoirement être rempli -> Code Postal )" + Environment.NewLine;
                            break;
                        case Product.ValidationResult.WRONG_TVA:
                            error += "Erreur dans la saisie du mail ( elle doit respecter le format mail )" + Environment.NewLine;
                            break;
                        case Product.ValidationResult.WRONG_EANCODE:
                            error += "Erreur dans la saisie du numéro de téléphone fixe ( 10 caractères obligatoire )" + Environment.NewLine;
                            break;
                    }
                }
                Utils.Warning(error);
                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        #endregion

        #region Chargement des genres dans la comboBox
        /// <summary>
        /// Chargement des genres dans la comboBox
        /// </summary>
        /// <param name="genders">Les genres à charger</param>
        private void loadGenders(Gender[] genders)
        {
            List<Gender> genderList = new List<Gender>(genders);
            this.GenderName.DataSource = genderList;
            this.GenderName.ValueMember = "Id";
            this.GenderName.DisplayMember = "Name";
        }
        #endregion

        #region Chargement des villes dans la combobox
        /// <summary>
        /// Chargement des villes dans la comboBox
        /// </summary>
        /// <param name="cities"></param>
        private void loadCities(City[] cities)
        {
            if (cities == null)
            {
                this.citiesList.Clear();
                return;
            }
            this.citiesList = new List<City>(cities);
            this.CityName.DataSource = citiesList;
            this.CityName.ValueMember = "Id";
            this.CityName.DisplayMember = "Name";
        }
        #endregion

        #region Affichage du pays selon la ville
        private void CityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CityName != null)
            {
                this.Country.Text = ((City)this.CityName.SelectedItem).Country.Name;
                return;
            }
            this.Country.Text = String.Empty;
        }
        #endregion

        #region Contrôle de l'affichage des villes selon le code postal
        private void CityPostalCode_TextChanged(object sender, EventArgs e)
        {
            if (this.TVA.TextLength < 5)
            {
                loadCities(null);
                return;
            }
            loadCities(CityManager.Instance.Filter("WHERE code_postal LIKE '" + this.TVA.Text + "%';"));
        }
        #endregion

        #region Getter du client en cours
        public Customer getCustomer()
        {
            return obj;
        }
        #endregion

        #region Autorisation uniquement de l'entrée de chiffre pour le numéro de téléphone fixe
        private void PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                Utils.Info("Uniquement les chiffres sont autorisés");
                e.Handled = true;
            }
        }
        #endregion

        #region Autorisation uniquement de l'entrée de chiffre pour le numéro de téléphone mobile
        private void MobilePhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                Utils.Info("Uniquement les chiffres sont autorisés");
                e.Handled = true;
            }
        }
        #endregion

        #region Autorisation uniqument de l'entrée de chiffre pour le code postal
        private void CityPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                Utils.Info("Uniquement les chiffres sont autorisés");
                e.Handled = true;
            }
        }
        #endregion

        #region Autorisation uniquement de l'entrée de lettre ou - pour le prénom
        private void FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {

                Utils.Info("Uniquement les lettres ou - sont autorisés");
                e.Handled = true;
            }
        }
        #endregion

        #region Autorisation uniquement de l'entrée de lettre ou - pour le nom
        private void LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                Utils.Info("Uniquement les lettres ou - sont autorisés");
                e.Handled = true;
            }
        }
        #endregion


    }
}
