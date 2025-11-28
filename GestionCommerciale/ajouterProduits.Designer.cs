
namespace GestionCommerciale
{
    partial class ajouterProduits
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
            this.btnAjouterProduit = new System.Windows.Forms.Button();
            this.txtNomProduit = new System.Windows.Forms.TextBox();
            this.txtPrixHtProduit = new System.Windows.Forms.TextBox();
            this.lblLibelleProduit = new System.Windows.Forms.Label();
            this.lblPrixHtProduit = new System.Windows.Forms.Label();
            this.cbxProduit = new System.Windows.Forms.ComboBox();
            this.lblCategorieProduit = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAjouterProduit
            // 
            this.btnAjouterProduit.Location = new System.Drawing.Point(286, 299);
            this.btnAjouterProduit.Name = "btnAjouterProduit";
            this.btnAjouterProduit.Size = new System.Drawing.Size(173, 52);
            this.btnAjouterProduit.TabIndex = 0;
            this.btnAjouterProduit.Text = "Ajouter le produit";
            this.btnAjouterProduit.UseVisualStyleBackColor = true;
            this.btnAjouterProduit.Click += new System.EventHandler(this.btnAjouterProduit_Click);
            // 
            // txtNomProduit
            // 
            this.txtNomProduit.Location = new System.Drawing.Point(312, 139);
            this.txtNomProduit.Name = "txtNomProduit";
            this.txtNomProduit.Size = new System.Drawing.Size(132, 22);
            this.txtNomProduit.TabIndex = 1;
            // 
            // txtPrixHtProduit
            // 
            this.txtPrixHtProduit.Location = new System.Drawing.Point(312, 199);
            this.txtPrixHtProduit.Name = "txtPrixHtProduit";
            this.txtPrixHtProduit.Size = new System.Drawing.Size(132, 22);
            this.txtPrixHtProduit.TabIndex = 2;
            // 
            // lblLibelleProduit
            // 
            this.lblLibelleProduit.AutoSize = true;
            this.lblLibelleProduit.Location = new System.Drawing.Point(174, 143);
            this.lblLibelleProduit.Name = "lblLibelleProduit";
            this.lblLibelleProduit.Size = new System.Drawing.Size(98, 16);
            this.lblLibelleProduit.TabIndex = 3;
            this.lblLibelleProduit.Text = "Nom du produit";
            // 
            // lblPrixHtProduit
            // 
            this.lblPrixHtProduit.AutoSize = true;
            this.lblPrixHtProduit.Location = new System.Drawing.Point(186, 202);
            this.lblPrixHtProduit.Name = "lblPrixHtProduit";
            this.lblPrixHtProduit.Size = new System.Drawing.Size(86, 16);
            this.lblPrixHtProduit.TabIndex = 4;
            this.lblPrixHtProduit.Text = "Prix hors taxe";
            // 
            // cbxProduit
            // 
            this.cbxProduit.FormattingEnabled = true;
            this.cbxProduit.Location = new System.Drawing.Point(312, 253);
            this.cbxProduit.Name = "cbxProduit";
            this.cbxProduit.Size = new System.Drawing.Size(121, 24);
            this.cbxProduit.TabIndex = 5;
            // 
            // lblCategorieProduit
            // 
            this.lblCategorieProduit.AutoSize = true;
            this.lblCategorieProduit.Location = new System.Drawing.Point(210, 256);
            this.lblCategorieProduit.Name = "lblCategorieProduit";
            this.lblCategorieProduit.Size = new System.Drawing.Size(66, 16);
            this.lblCategorieProduit.TabIndex = 6;
            this.lblCategorieProduit.Text = "Categorie";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(621, 299);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(131, 51);
            this.btnRetour.TabIndex = 7;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // ajouterProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblCategorieProduit);
            this.Controls.Add(this.cbxProduit);
            this.Controls.Add(this.lblPrixHtProduit);
            this.Controls.Add(this.lblLibelleProduit);
            this.Controls.Add(this.txtPrixHtProduit);
            this.Controls.Add(this.txtNomProduit);
            this.Controls.Add(this.btnAjouterProduit);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Name = "ajouterProduits";
            this.Text = "Ajouter un produit";
            this.Load += new System.EventHandler(this.ajouterProduits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterProduit;
        private System.Windows.Forms.TextBox txtNomProduit;
        private System.Windows.Forms.TextBox txtPrixHtProduit;
        private System.Windows.Forms.Label lblLibelleProduit;
        private System.Windows.Forms.Label lblPrixHtProduit;
        private System.Windows.Forms.ComboBox cbxProduit;
        private System.Windows.Forms.Label lblCategorieProduit;
        private System.Windows.Forms.Button btnRetour;
    }
}