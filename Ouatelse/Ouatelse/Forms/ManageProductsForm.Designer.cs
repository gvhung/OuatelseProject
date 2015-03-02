﻿namespace Ouatelse
{
    partial class ManageProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.newProduct = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.modifyProduct = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.productListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.designation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pixAchat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prixVente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ean = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightClickProduct = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierCeProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerCeProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductsNumber = new System.Windows.Forms.Label();
            this.rightClickProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newProduct
            // 
            this.newProduct.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.newProduct.FlatAppearance.BorderSize = 0;
            this.newProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProduct.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newProduct.Location = new System.Drawing.Point(5, 143);
            this.newProduct.Name = "newProduct";
            this.newProduct.Size = new System.Drawing.Size(204, 41);
            this.newProduct.TabIndex = 38;
            this.newProduct.Text = "Nouveau produit";
            this.newProduct.UseVisualStyleBackColor = false;
            this.newProduct.Click += new System.EventHandler(this.newProduct_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(5, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 41);
            this.button3.TabIndex = 41;
            this.button3.Text = "Réapprovisionner";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // deleteProduct
            // 
            this.deleteProduct.BackColor = System.Drawing.Color.IndianRed;
            this.deleteProduct.FlatAppearance.BorderSize = 0;
            this.deleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProduct.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteProduct.Location = new System.Drawing.Point(425, 143);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(204, 41);
            this.deleteProduct.TabIndex = 40;
            this.deleteProduct.Text = "Supprimer un produit";
            this.deleteProduct.UseVisualStyleBackColor = false;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // modifyProduct
            // 
            this.modifyProduct.BackColor = System.Drawing.Color.DodgerBlue;
            this.modifyProduct.FlatAppearance.BorderSize = 0;
            this.modifyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyProduct.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.modifyProduct.Location = new System.Drawing.Point(215, 143);
            this.modifyProduct.Name = "modifyProduct";
            this.modifyProduct.Size = new System.Drawing.Size(204, 41);
            this.modifyProduct.TabIndex = 39;
            this.modifyProduct.Text = "Modifier un produit";
            this.modifyProduct.UseVisualStyleBackColor = false;
            this.modifyProduct.Click += new System.EventHandler(this.modifyProduct_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(215, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 41);
            this.button4.TabIndex = 42;
            this.button4.Text = "Déstocker";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // productListView
            // 
            this.productListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nom,
            this.designation,
            this.pixAchat,
            this.prixVente,
            this.tva,
            this.ean});
            this.productListView.ContextMenuStrip = this.rightClickProduct;
            this.productListView.FullRowSelect = true;
            this.productListView.GridLines = true;
            this.productListView.Location = new System.Drawing.Point(5, 244);
            this.productListView.Margin = new System.Windows.Forms.Padding(2);
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(823, 254);
            this.productListView.TabIndex = 37;
            this.productListView.UseCompatibleStateImageBehavior = false;
            this.productListView.View = System.Windows.Forms.View.Details;
            this.productListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.productListView_ColumnClick);
            this.productListView.ItemActivate += new System.EventHandler(this.productListView_ItemActivate);
            this.productListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.productListView_MouseClick);
            this.productListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.productListView_MouseDoubleClick);
            // 
            // id
            // 
            this.id.Text = "Référence";
            this.id.Width = 65;
            // 
            // nom
            // 
            this.nom.Text = "Nom";
            this.nom.Width = 150;
            // 
            // designation
            // 
            this.designation.Text = "Désignation";
            this.designation.Width = 129;
            // 
            // pixAchat
            // 
            this.pixAchat.Text = "Prix d\'achat";
            this.pixAchat.Width = 95;
            // 
            // prixVente
            // 
            this.prixVente.Text = "Prix de vente";
            this.prixVente.Width = 106;
            // 
            // tva
            // 
            this.tva.Text = "TVA";
            this.tva.Width = 63;
            // 
            // ean
            // 
            this.ean.Text = "Code EAN";
            this.ean.Width = 193;
            // 
            // rightClickProduct
            // 
            this.rightClickProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierCeProduitToolStripMenuItem,
            this.supprimerCeProduitToolStripMenuItem});
            this.rightClickProduct.Name = "rightClickCustomer";
            this.rightClickProduct.Size = new System.Drawing.Size(187, 48);
            // 
            // modifierCeProduitToolStripMenuItem
            // 
            this.modifierCeProduitToolStripMenuItem.Name = "modifierCeProduitToolStripMenuItem";
            this.modifierCeProduitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.modifierCeProduitToolStripMenuItem.Text = "Modifier ce produit";
            // 
            // supprimerCeProduitToolStripMenuItem
            // 
            this.supprimerCeProduitToolStripMenuItem.Name = "supprimerCeProduitToolStripMenuItem";
            this.supprimerCeProduitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.supprimerCeProduitToolStripMenuItem.Text = "Supprimer ce produit";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Ouatelse.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(558, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(597, 200);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(231, 26);
            this.searchBox.TabIndex = 43;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(151, 44);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(483, 47);
            this.customerLabel.TabIndex = 47;
            this.customerLabel.Text = "Gestion des produits / stock";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ouatelse.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(24, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(-27, -12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1024, 142);
            this.label1.TabIndex = 46;
            // 
            // ProductsNumber
            // 
            this.ProductsNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsNumber.Location = new System.Drawing.Point(702, 500);
            this.ProductsNumber.Name = "ProductsNumber";
            this.ProductsNumber.Size = new System.Drawing.Size(126, 22);
            this.ProductsNumber.TabIndex = 48;
            this.ProductsNumber.Text = "--";
            this.ProductsNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ManageProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 516);
            this.Controls.Add(this.ProductsNumber);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.newProduct);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.modifyProduct);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.productListView);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(855, 555);
            this.Name = "ManageProductForm";
            this.Text = "Gestion des produits / stock";
            this.rightClickProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newProduct;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button modifyProduct;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView productListView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ColumnHeader designation;
        private System.Windows.Forms.ColumnHeader pixAchat;
        private System.Windows.Forms.ColumnHeader prixVente;
        private System.Windows.Forms.ColumnHeader tva;
        private System.Windows.Forms.ColumnHeader ean;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProductsNumber;
        private System.Windows.Forms.ContextMenuStrip rightClickProduct;
        private System.Windows.Forms.ToolStripMenuItem modifierCeProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerCeProduitToolStripMenuItem;

    }
}