namespace GestionCommerciale
{
    partial class ModifierListeDevis
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
            this.clbDevis = new System.Windows.Forms.CheckedListBox();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbDevis
            // 
            this.clbDevis.FormattingEnabled = true;
            this.clbDevis.Location = new System.Drawing.Point(191, 102);
            this.clbDevis.Name = "clbDevis";
            this.clbDevis.Size = new System.Drawing.Size(405, 140);
            this.clbDevis.TabIndex = 0;
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.Location = new System.Drawing.Point(241, 324);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(97, 35);
            this.btnOuvrir.TabIndex = 1;
            this.btnOuvrir.Text = "Ouvrir";
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // ModifierListeDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOuvrir);
            this.Controls.Add(this.clbDevis);
            this.Name = "ModifierListeDevis";
            this.Text = "ModifierListeDevis";
            this.Load += new System.EventHandler(this.ModifierListeDevis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbDevis;
        private System.Windows.Forms.Button btnOuvrir;
    }
}