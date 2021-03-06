﻿namespace Ouatelse
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameEntry = new System.Windows.Forms.TextBox();
            this.passwordEntry = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.forgetPassword = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.quitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameEntry
            // 
            this.usernameEntry.Location = new System.Drawing.Point(81, 191);
            this.usernameEntry.Name = "usernameEntry";
            this.usernameEntry.Size = new System.Drawing.Size(182, 20);
            this.usernameEntry.TabIndex = 0;
            this.usernameEntry.Text = "Identifiant";
            // 
            // passwordEntry
            // 
            this.passwordEntry.Location = new System.Drawing.Point(81, 224);
            this.passwordEntry.Name = "passwordEntry";
            this.passwordEntry.PasswordChar = '*';
            this.passwordEntry.Size = new System.Drawing.Size(182, 20);
            this.passwordEntry.TabIndex = 1;
            this.passwordEntry.Text = "password";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(200, 279);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(118, 33);
            this.btnOk.TabIndex = 4;
            this.btnOk.TabStop = false;
            this.btnOk.Text = "Connexion";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // forgetPassword
            // 
            this.forgetPassword.AutoSize = true;
            this.forgetPassword.Location = new System.Drawing.Point(121, 247);
            this.forgetPassword.Name = "forgetPassword";
            this.forgetPassword.Size = new System.Drawing.Size(111, 13);
            this.forgetPassword.TabIndex = 5;
            this.forgetPassword.TabStop = true;
            this.forgetPassword.Text = "Mot de passe oublié ?";
            this.forgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgetPassword_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ouatelse.Properties.Resources.logo;
            this.pictureBox1.InitialImage = global::Ouatelse.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(81, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.IndianRed;
            this.quitBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.quitBtn.FlatAppearance.BorderSize = 0;
            this.quitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.ForeColor = System.Drawing.Color.White;
            this.quitBtn.Location = new System.Drawing.Point(25, 279);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(118, 33);
            this.quitBtn.TabIndex = 8;
            this.quitBtn.TabStop = false;
            this.quitBtn.Text = "Quitter";
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(353, 336);
            this.ControlBox = false;
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.forgetPassword);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.passwordEntry);
            this.Controls.Add(this.usernameEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ouatelse - Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameEntry;
        private System.Windows.Forms.TextBox passwordEntry;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.LinkLabel forgetPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button quitBtn;
    }
}

