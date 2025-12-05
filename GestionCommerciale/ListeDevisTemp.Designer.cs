namespace GestionCommerciale
{
    partial class ListeDevisTemp
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
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouterDevis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(337, 335);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(130, 42);
            this.btnModifier.TabIndex = 0;
            this.btnModifier.Text = "Modifier un devis";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouterDevis
            // 
            this.btnAjouterDevis.Location = new System.Drawing.Point(554, 335);
            this.btnAjouterDevis.Name = "btnAjouterDevis";
            this.btnAjouterDevis.Size = new System.Drawing.Size(126, 41);
            this.btnAjouterDevis.TabIndex = 1;
            this.btnAjouterDevis.Text = "Ajouter un devis";
            this.btnAjouterDevis.UseVisualStyleBackColor = true;
            this.btnAjouterDevis.Click += new System.EventHandler(this.btnAjouterDevis_Click);
            // 
            // ListeDevisTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouterDevis);
            this.Controls.Add(this.btnModifier);
            this.Name = "ListeDevisTemp";
            this.Text = "ListeDevisTemp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouterDevis;
    }
}