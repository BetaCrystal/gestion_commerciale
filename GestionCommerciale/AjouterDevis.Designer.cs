namespace GestionCommerciale
{
    partial class AjouterDevis
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
            this.grpInfosDevis = new System.Windows.Forms.GroupBox();
            this.nudTauxTVA = new System.Windows.Forms.NumericUpDown();
            this.lblTauxTVA = new System.Windows.Forms.Label();
            this.dtpDateDevis = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.grpProduits = new System.Windows.Forms.GroupBox();
            this.lblInfosProduit = new System.Windows.Forms.Label();
            this.chkProduits = new System.Windows.Forms.CheckedListBox();
            this.grpTotaux = new System.Windows.Forms.GroupBox();
            this.lblTotalTTC = new System.Windows.Forms.Label();
            this.lblMontantTVA = new System.Windows.Forms.Label();
            this.lblTotalHT = new System.Windows.Forms.Label();
            this.btnAjouterDevis = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.grpInfosDevis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTauxTVA)).BeginInit();
            this.grpProduits.SuspendLayout();
            this.grpTotaux.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfosDevis
            // 
            this.grpInfosDevis.Controls.Add(this.nudTauxTVA);
            this.grpInfosDevis.Controls.Add(this.lblTauxTVA);
            this.grpInfosDevis.Controls.Add(this.dtpDateDevis);
            this.grpInfosDevis.Controls.Add(this.lblDate);
            this.grpInfosDevis.Controls.Add(this.cmbClients);
            this.grpInfosDevis.Controls.Add(this.lblClient);
            this.grpInfosDevis.Location = new System.Drawing.Point(33, 63);
            this.grpInfosDevis.Name = "grpInfosDevis";
            this.grpInfosDevis.Size = new System.Drawing.Size(294, 171);
            this.grpInfosDevis.TabIndex = 0;
            this.grpInfosDevis.TabStop = false;
            this.grpInfosDevis.Text = "Informations du devis";
            // 
            // nudTauxTVA
            // 
            this.nudTauxTVA.Location = new System.Drawing.Point(75, 104);
            this.nudTauxTVA.Name = "nudTauxTVA";
            this.nudTauxTVA.Size = new System.Drawing.Size(120, 22);
            this.nudTauxTVA.TabIndex = 5;
            // 
            // lblTauxTVA
            // 
            this.lblTauxTVA.AutoSize = true;
            this.lblTauxTVA.Location = new System.Drawing.Point(6, 104);
            this.lblTauxTVA.Name = "lblTauxTVA";
            this.lblTauxTVA.Size = new System.Drawing.Size(63, 16);
            this.lblTauxTVA.TabIndex = 4;
            this.lblTauxTVA.Text = "TVA (%) :";
            // 
            // dtpDateDevis
            // 
            this.dtpDateDevis.Location = new System.Drawing.Point(75, 69);
            this.dtpDateDevis.Name = "dtpDateDevis";
            this.dtpDateDevis.Size = new System.Drawing.Size(211, 22);
            this.dtpDateDevis.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(27, 69);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 16);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date :";
            // 
            // cmbClients
            // 
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(75, 28);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(121, 24);
            this.cmbClients.TabIndex = 1;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(23, 31);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(46, 16);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Client :";
            // 
            // grpProduits
            // 
            this.grpProduits.Controls.Add(this.lblInfosProduit);
            this.grpProduits.Controls.Add(this.chkProduits);
            this.grpProduits.Location = new System.Drawing.Point(356, 63);
            this.grpProduits.Name = "grpProduits";
            this.grpProduits.Size = new System.Drawing.Size(391, 289);
            this.grpProduits.TabIndex = 1;
            this.grpProduits.TabStop = false;
            this.grpProduits.Text = "Produits du devis";
            // 
            // lblInfosProduit
            // 
            this.lblInfosProduit.AutoSize = true;
            this.lblInfosProduit.Location = new System.Drawing.Point(18, 256);
            this.lblInfosProduit.Name = "lblInfosProduit";
            this.lblInfosProduit.Size = new System.Drawing.Size(41, 16);
            this.lblInfosProduit.TabIndex = 1;
            this.lblInfosProduit.Text = "Label";
            // 
            // chkProduits
            // 
            this.chkProduits.CheckOnClick = true;
            this.chkProduits.FormattingEnabled = true;
            this.chkProduits.Location = new System.Drawing.Point(21, 40);
            this.chkProduits.Name = "chkProduits";
            this.chkProduits.Size = new System.Drawing.Size(270, 174);
            this.chkProduits.TabIndex = 0;
            this.chkProduits.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkProduits_ItemCheck);
            // 
            // grpTotaux
            // 
            this.grpTotaux.Controls.Add(this.lblTotalTTC);
            this.grpTotaux.Controls.Add(this.lblMontantTVA);
            this.grpTotaux.Controls.Add(this.lblTotalHT);
            this.grpTotaux.Location = new System.Drawing.Point(33, 270);
            this.grpTotaux.Name = "grpTotaux";
            this.grpTotaux.Size = new System.Drawing.Size(294, 136);
            this.grpTotaux.TabIndex = 2;
            this.grpTotaux.TabStop = false;
            this.grpTotaux.Text = "Montants";
            // 
            // lblTotalTTC
            // 
            this.lblTotalTTC.AutoSize = true;
            this.lblTotalTTC.Location = new System.Drawing.Point(12, 100);
            this.lblTotalTTC.Name = "lblTotalTTC";
            this.lblTotalTTC.Size = new System.Drawing.Size(68, 16);
            this.lblTotalTTC.TabIndex = 2;
            this.lblTotalTTC.Text = "Total TTC";
            // 
            // lblMontantTVA
            // 
            this.lblMontantTVA.AutoSize = true;
            this.lblMontantTVA.Location = new System.Drawing.Point(9, 66);
            this.lblMontantTVA.Name = "lblMontantTVA";
            this.lblMontantTVA.Size = new System.Drawing.Size(84, 16);
            this.lblMontantTVA.TabIndex = 1;
            this.lblMontantTVA.Text = "Montant TVA";
            // 
            // lblTotalHT
            // 
            this.lblTotalHT.AutoSize = true;
            this.lblTotalHT.Location = new System.Drawing.Point(9, 32);
            this.lblTotalHT.Name = "lblTotalHT";
            this.lblTotalHT.Size = new System.Drawing.Size(104, 16);
            this.lblTotalHT.TabIndex = 0;
            this.lblTotalHT.Text = "Montant total HT";
            // 
            // btnAjouterDevis
            // 
            this.btnAjouterDevis.Location = new System.Drawing.Point(417, 370);
            this.btnAjouterDevis.Name = "btnAjouterDevis";
            this.btnAjouterDevis.Size = new System.Drawing.Size(102, 32);
            this.btnAjouterDevis.TabIndex = 3;
            this.btnAjouterDevis.Text = "Ajouter";
            this.btnAjouterDevis.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(622, 374);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(102, 32);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // AjouterDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouterDevis);
            this.Controls.Add(this.grpTotaux);
            this.Controls.Add(this.grpProduits);
            this.Controls.Add(this.grpInfosDevis);
            this.Name = "AjouterDevis";
            this.Text = "AjouterDevis";
            this.Load += new System.EventHandler(this.AjouterDevis_Load);
            this.grpInfosDevis.ResumeLayout(false);
            this.grpInfosDevis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTauxTVA)).EndInit();
            this.grpProduits.ResumeLayout(false);
            this.grpProduits.PerformLayout();
            this.grpTotaux.ResumeLayout(false);
            this.grpTotaux.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfosDevis;
        private System.Windows.Forms.DateTimePicker dtpDateDevis;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.NumericUpDown nudTauxTVA;
        private System.Windows.Forms.Label lblTauxTVA;
        private System.Windows.Forms.GroupBox grpProduits;
        private System.Windows.Forms.CheckedListBox chkProduits;
        private System.Windows.Forms.Label lblInfosProduit;
        private System.Windows.Forms.GroupBox grpTotaux;
        private System.Windows.Forms.Label lblTotalTTC;
        private System.Windows.Forms.Label lblMontantTVA;
        private System.Windows.Forms.Label lblTotalHT;
        private System.Windows.Forms.Button btnAjouterDevis;
        private System.Windows.Forms.Button btnAnnuler;
    }
}