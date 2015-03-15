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
    public partial class StockForm : Form
    {
        //#region Les attributs de la classe
        ///// <summary>
        ///// Le produit courant du formulaire
        ///// </summary>
        //Product obj = null;

        ///// <summary>
        ///// La cohérence entre le formulaire et notre produit
        ///// </summary>
        //Binding b = new Binding();
        //#endregion

        //#region Le constructeur de la classe
        ///// <summary>
        ///// Le constructeur de la classe
        ///// </summary>
        ///// <param name="obj"></param>
        //public ProductsForm(Product obj)
        //{
        //    InitializeComponent();
        //    //Cohérence pour l'affichage des titres
        //    this.Text = this.label1.Text = obj.Exists ? "Détail du produit " : " Nouveau produit";
        //    this.obj = obj;
        //}
        //#endregion

        //#region Gestion du chargement de l'affichage du formulaire
        ///// <summary>
        ///// Chargement de l'affichage du formulaire
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void ProductsForm_Load(object sender, EventArgs e)
        //{

        //    //On lie notre objet à notre binding
        //    this.Id.Text = obj.StringId;
        //    b.Bind(this.NameP, "Text", obj, "Name");
        //    b.Bind(this.Designation, "Text", obj, "Designation");
        //    b.Bind(this.EANCode, "Text", obj, "EANCode");

        //    b.Populate();
        //}
        //#endregion

        //#region Gestion de la validation du formulaire
        //private void validateButton_Click(object sender, EventArgs e)
        //{
        //    //On hydrate notre binding
        //    b.Hydrate();
        //    float val = new float();
        //    if (!float.TryParse(this.PurchasePrice.Text, out val))
        //    {
        //        Utils.Warning("Prix d'achat incorrect");
        //        return;
        //    };
        //    obj.PurchasePrice = val;

        //    if (!float.TryParse(this.SellPrice.Text, out val))
        //    {
        //        Utils.Warning("Prix de vente incorrect");
        //        return;
        //    };
        //    obj.SellPrice = val;

        //    obj.TVA = float.Parse(this.TVA.Text);

        //    if (!float.TryParse(this.TVA.Text, out val))
        //    {
        //        Utils.Warning("TVA incorrecte");
        //        return;
        //    };
        //    obj.TVA = val;

        //    //On regarde si notre entité peut être validé en base
        //    if (obj.validate().Count != 0)
        //    {
        //        string error = String.Empty;
        //        foreach (Product.ValidationResult warning in obj.validate())
        //        {
        //            switch (warning)
        //            {
        //                case Product.ValidationResult.WRONG_NAME:
        //                    error += "Erreur dans la saisie du nom ( il doit obligatoirement être rempli )" + Environment.NewLine;
        //                    break;
        //                case Product.ValidationResult.WRONG_DESIGNATION:
        //                    error += "Erreur dans la saisie de la désignation ( elle doit obligatoirement être remplie )" + Environment.NewLine;
        //                    break;
        //                case Product.ValidationResult.WRONG_PURCHASEPRICE:
        //                    error += "Erreur dans la saisie du prix d'achat ( il doit obligatoirement être rempli )" + Environment.NewLine;
        //                    break;
        //                case Product.ValidationResult.WRONG_SELLPRICE:
        //                    error += "Erreur dans la saisie du prix de vente ( il doit obligatoirement être rempli )" + Environment.NewLine;
        //                    break;
        //                case Product.ValidationResult.WRONG_TVA:
        //                    error += "Erreur dans la saisie de la TVA ( elle doit obligatoirement être remplie )" + Environment.NewLine;
        //                    break;
        //                case Product.ValidationResult.WRONG_EANCODE:
        //                    error += "Erreur dans la saisie du code EAN ( 13 caractères obligatoire )" + Environment.NewLine;
        //                    break;
        //            }
        //        }
        //        Utils.Warning(error);
        //        return;
        //    }

        //    else
        //    {
        //        this.DialogResult = System.Windows.Forms.DialogResult.OK;
        //    }
        //}
        //#endregion

        //#region Getter du produit en cours
        //public Product getProduct()
        //{
        //    return obj;
        //}
        //#endregion

        //#region Chargement des villes dans la combobox
        ///// <summary>
        ///// Chargement des villes dans la comboBox
        ///// </summary>
        ///// <param name="cities"></param>
        //private void loadCities(City[] cities)
        //{
        //    this.citiesList = new List<City>(cities);
        //    this.CityName.DataSource = citiesList;
        //    this.CityName.ValueMember = "Id";
        //    this.CityName.DisplayMember = "Name";
        //}
        //#endregion

        //#region Affichage du pays selon la ville
        //private void CityName_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (this.CityName != null)
        //    {
        //        this.Country.Text = ((City)this.CityName.SelectedItem).Country.Name;
        //        return;
        //    }
        //    this.Country.Text = String.Empty;
        //}
        //#endregion
    }
}
