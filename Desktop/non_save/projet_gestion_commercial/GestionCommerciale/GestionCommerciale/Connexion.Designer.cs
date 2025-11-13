
namespace GestionCommerciale
{
    partial class Connexion
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
            this.components = new System.ComponentModel.Container();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.textBoxMdp = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(215, 249);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(68, 31);
            this.btnConnexion.TabIndex = 3;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(130, 140);
            this.lblIdentifiant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(62, 13);
            this.lblIdentifiant.TabIndex = 0;
            this.lblIdentifiant.Text = "Identifiant : ";
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Location = new System.Drawing.Point(215, 140);
            this.textBoxIdentifiant.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(76, 20);
            this.textBoxIdentifiant.TabIndex = 1;
            // 
            // textBoxMdp
            // 
            this.textBoxMdp.Location = new System.Drawing.Point(215, 189);
            this.textBoxMdp.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMdp.Name = "textBoxMdp";
            this.textBoxMdp.Size = new System.Drawing.Size(76, 20);
            this.textBoxMdp.TabIndex = 2;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(115, 189);
            this.lblMdp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(76, 13);
            this.lblMdp.TabIndex = 0;
            this.lblMdp.Text = "mot de passe :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Connexion
            // 
            this.AcceptButton = this.btnConnexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.textBoxMdp);
            this.Controls.Add(this.textBoxIdentifiant);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.btnConnexion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.TextBox textBoxMdp;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

