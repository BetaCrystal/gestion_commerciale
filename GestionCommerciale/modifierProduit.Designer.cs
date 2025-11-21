namespace GestionCommerciale
{
    partial class modifierProduit
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
            this.txtNomProduit = new System.Windows.Forms.TextBox();
            this.txtPrixHtProduit = new System.Windows.Forms.TextBox();
            this.cbxProduit = new System.Windows.Forms.ComboBox();
            this.lblLibelleProduit = new System.Windows.Forms.Label();
            this.lblPrixHtProduit = new System.Windows.Forms.Label();
            this.lblCategorieProduit = new System.Windows.Forms.Label();
            this.btnModifierProduit = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomProduit
            // 
            this.txtNomProduit.Location = new System.Drawing.Point(299, 159);
            this.txtNomProduit.Name = "txtNomProduit";
            this.txtNomProduit.Size = new System.Drawing.Size(132, 22);
            this.txtNomProduit.TabIndex = 2;
            // 
            // txtPrixHtProduit
            // 
            this.txtPrixHtProduit.Location = new System.Drawing.Point(299, 227);
            this.txtPrixHtProduit.Name = "txtPrixHtProduit";
            this.txtPrixHtProduit.Size = new System.Drawing.Size(132, 22);
            this.txtPrixHtProduit.TabIndex = 3;
            // 
            // cbxProduit
            // 
            this.cbxProduit.FormattingEnabled = true;
            this.cbxProduit.Location = new System.Drawing.Point(299, 286);
            this.cbxProduit.Name = "cbxProduit";
            this.cbxProduit.Size = new System.Drawing.Size(121, 24);
            this.cbxProduit.TabIndex = 6;
            // 
            // lblLibelleProduit
            // 
            this.lblLibelleProduit.AutoSize = true;
            this.lblLibelleProduit.Location = new System.Drawing.Point(152, 165);
            this.lblLibelleProduit.Name = "lblLibelleProduit";
            this.lblLibelleProduit.Size = new System.Drawing.Size(98, 16);
            this.lblLibelleProduit.TabIndex = 7;
            this.lblLibelleProduit.Text = "Nom du produit";
            // 
            // lblPrixHtProduit
            // 
            this.lblPrixHtProduit.AutoSize = true;
            this.lblPrixHtProduit.Location = new System.Drawing.Point(164, 233);
            this.lblPrixHtProduit.Name = "lblPrixHtProduit";
            this.lblPrixHtProduit.Size = new System.Drawing.Size(86, 16);
            this.lblPrixHtProduit.TabIndex = 8;
            this.lblPrixHtProduit.Text = "Prix hors taxe";
            // 
            // lblCategorieProduit
            // 
            this.lblCategorieProduit.AutoSize = true;
            this.lblCategorieProduit.Location = new System.Drawing.Point(184, 294);
            this.lblCategorieProduit.Name = "lblCategorieProduit";
            this.lblCategorieProduit.Size = new System.Drawing.Size(66, 16);
            this.lblCategorieProduit.TabIndex = 9;
            this.lblCategorieProduit.Text = "Categorie";
            // 
            // btnModifierProduit
            // 
            this.btnModifierProduit.Location = new System.Drawing.Point(282, 358);
            this.btnModifierProduit.Name = "btnModifierProduit";
            this.btnModifierProduit.Size = new System.Drawing.Size(173, 52);
            this.btnModifierProduit.TabIndex = 10;
            this.btnModifierProduit.Text = "Modifier le produit";
            this.btnModifierProduit.UseVisualStyleBackColor = true;
            this.btnModifierProduit.Click += new System.EventHandler(this.btnModifierProduit_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(574, 313);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(131, 51);
            this.btnRetour.TabIndex = 11;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // modifierProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnModifierProduit);
            this.Controls.Add(this.lblCategorieProduit);
            this.Controls.Add(this.lblPrixHtProduit);
            this.Controls.Add(this.lblLibelleProduit);
            this.Controls.Add(this.cbxProduit);
            this.Controls.Add(this.txtPrixHtProduit);
            this.Controls.Add(this.txtNomProduit);
            this.Name = "modifierProduit";
            this.Text = "modifierProduit";
            this.Load += new System.EventHandler(this.modifierProduit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomProduit;
        private System.Windows.Forms.TextBox txtPrixHtProduit;
        private System.Windows.Forms.ComboBox cbxProduit;
        private System.Windows.Forms.Label lblLibelleProduit;
        private System.Windows.Forms.Label lblPrixHtProduit;
        private System.Windows.Forms.Label lblCategorieProduit;
        private System.Windows.Forms.Button btnModifierProduit;
        private System.Windows.Forms.Button btnRetour;
    }
}