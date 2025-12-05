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
            this.grpInfosDevis.Location = new System.Drawing.Point(25, 51);
            this.grpInfosDevis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpInfosDevis.Name = "grpInfosDevis";
            this.grpInfosDevis.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpInfosDevis.Size = new System.Drawing.Size(220, 139);
            this.grpInfosDevis.TabIndex = 0;
            this.grpInfosDevis.TabStop = false;
            this.grpInfosDevis.Text = "Informations du devis";
            // 
            // nudTauxTVA
            // 
            this.nudTauxTVA.Location = new System.Drawing.Point(56, 84);
            this.nudTauxTVA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudTauxTVA.Name = "nudTauxTVA";
            this.nudTauxTVA.Size = new System.Drawing.Size(90, 20);
            this.nudTauxTVA.TabIndex = 5;
            // 
            // lblTauxTVA
            // 
            this.lblTauxTVA.AutoSize = true;
            this.lblTauxTVA.Location = new System.Drawing.Point(4, 84);
            this.lblTauxTVA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTauxTVA.Name = "lblTauxTVA";
            this.lblTauxTVA.Size = new System.Drawing.Size(51, 13);
            this.lblTauxTVA.TabIndex = 4;
            this.lblTauxTVA.Text = "TVA (%) :";
            // 
            // dtpDateDevis
            // 
            this.dtpDateDevis.Location = new System.Drawing.Point(56, 56);
            this.dtpDateDevis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateDevis.Name = "dtpDateDevis";
            this.dtpDateDevis.Size = new System.Drawing.Size(159, 20);
            this.dtpDateDevis.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(20, 56);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date :";
            // 
            // cmbClients
            // 
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(56, 23);
            this.cmbClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(92, 21);
            this.cmbClients.TabIndex = 1;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(17, 25);
            this.lblClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(39, 13);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Client :";
            // 
            // grpProduits
            // 
            this.grpProduits.Controls.Add(this.lblInfosProduit);
            this.grpProduits.Controls.Add(this.chkProduits);
            this.grpProduits.Location = new System.Drawing.Point(267, 51);
            this.grpProduits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpProduits.Name = "grpProduits";
            this.grpProduits.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpProduits.Size = new System.Drawing.Size(293, 235);
            this.grpProduits.TabIndex = 1;
            this.grpProduits.TabStop = false;
            this.grpProduits.Text = "Produits du devis";
            // 
            // lblInfosProduit
            // 
            this.lblInfosProduit.AutoSize = true;
            this.lblInfosProduit.Location = new System.Drawing.Point(14, 208);
            this.lblInfosProduit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfosProduit.Name = "lblInfosProduit";
            this.lblInfosProduit.Size = new System.Drawing.Size(33, 13);
            this.lblInfosProduit.TabIndex = 1;
            this.lblInfosProduit.Text = "Label";
            // 
            // chkProduits
            // 
            this.chkProduits.CheckOnClick = true;
            this.chkProduits.FormattingEnabled = true;
            this.chkProduits.Location = new System.Drawing.Point(16, 32);
            this.chkProduits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkProduits.Name = "chkProduits";
            this.chkProduits.Size = new System.Drawing.Size(204, 139);
            this.chkProduits.TabIndex = 0;
            this.chkProduits.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkProduits_ItemCheck);
            //this.chkProduits.SelectedIndexChanged += new System.EventHandler(this.chkProduits_SelectedIndexChanged);
            // 
            // grpTotaux
            // 
            this.grpTotaux.Controls.Add(this.lblTotalTTC);
            this.grpTotaux.Controls.Add(this.lblMontantTVA);
            this.grpTotaux.Controls.Add(this.lblTotalHT);
            this.grpTotaux.Location = new System.Drawing.Point(25, 219);
            this.grpTotaux.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTotaux.Name = "grpTotaux";
            this.grpTotaux.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTotaux.Size = new System.Drawing.Size(220, 110);
            this.grpTotaux.TabIndex = 2;
            this.grpTotaux.TabStop = false;
            this.grpTotaux.Text = "Montants";
            // 
            // lblTotalTTC
            // 
            this.lblTotalTTC.AutoSize = true;
            this.lblTotalTTC.Location = new System.Drawing.Point(9, 81);
            this.lblTotalTTC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalTTC.Name = "lblTotalTTC";
            this.lblTotalTTC.Size = new System.Drawing.Size(55, 13);
            this.lblTotalTTC.TabIndex = 2;
            this.lblTotalTTC.Text = "Total TTC";
            // 
            // lblMontantTVA
            // 
            this.lblMontantTVA.AutoSize = true;
            this.lblMontantTVA.Location = new System.Drawing.Point(7, 54);
            this.lblMontantTVA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontantTVA.Name = "lblMontantTVA";
            this.lblMontantTVA.Size = new System.Drawing.Size(70, 13);
            this.lblMontantTVA.TabIndex = 1;
            this.lblMontantTVA.Text = "Montant TVA";
            // 
            // lblTotalHT
            // 
            this.lblTotalHT.AutoSize = true;
            this.lblTotalHT.Location = new System.Drawing.Point(7, 26);
            this.lblTotalHT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalHT.Name = "lblTotalHT";
            this.lblTotalHT.Size = new System.Drawing.Size(87, 13);
            this.lblTotalHT.TabIndex = 0;
            this.lblTotalHT.Text = "Montant total HT";
            // 
            // btnAjouterDevis
            // 
            this.btnAjouterDevis.Location = new System.Drawing.Point(313, 301);
            this.btnAjouterDevis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouterDevis.Name = "btnAjouterDevis";
            this.btnAjouterDevis.Size = new System.Drawing.Size(76, 26);
            this.btnAjouterDevis.TabIndex = 3;
            this.btnAjouterDevis.Text = "Ajouter";
            this.btnAjouterDevis.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(466, 304);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(76, 26);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // AjouterDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouterDevis);
            this.Controls.Add(this.grpTotaux);
            this.Controls.Add(this.grpProduits);
            this.Controls.Add(this.grpInfosDevis);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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