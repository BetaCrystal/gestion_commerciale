namespace GestionCommerciale
{
    partial class SyntheseClients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gestion_commercialeDataSet = new GestionCommerciale.Gestion_commercialeDataSet();
            this.gestioncommercialeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtgSynthese = new System.Windows.Forms.DataGridView();
            this.nomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbDevis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbAccepte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pctAccepte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pctAttente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pctRefuse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRafraichir = new System.Windows.Forms.Button();
            this.lblTotalGeneral = new System.Windows.Forms.Label();
            this.btnOuvrirProduit = new System.Windows.Forms.Button();
            this.btnListeDevis = new System.Windows.Forms.Button();
            this.btnListeClient = new System.Windows.Forms.Button();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.btnFiltrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_commercialeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSynthese)).BeginInit();
            this.SuspendLayout();
            // 
            // gestion_commercialeDataSet
            // 
            this.gestion_commercialeDataSet.DataSetName = "Gestion_commercialeDataSet";
            this.gestion_commercialeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestioncommercialeDataSetBindingSource
            // 
            this.gestioncommercialeDataSetBindingSource.DataSource = this.gestion_commercialeDataSet;
            this.gestioncommercialeDataSetBindingSource.Position = 0;
            // 
            // dtgSynthese
            // 
            this.dtgSynthese.AllowUserToAddRows = false;
            this.dtgSynthese.AllowUserToDeleteRows = false;
            this.dtgSynthese.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgSynthese.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSynthese.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomClient,
            this.nbDevis,
            this.nbAccepte,
            this.pctAccepte,
            this.pctAttente,
            this.pctRefuse,
            this.Montant});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSynthese.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgSynthese.Location = new System.Drawing.Point(51, 86);
            this.dtgSynthese.Name = "dtgSynthese";
            this.dtgSynthese.ReadOnly = true;
            this.dtgSynthese.RowHeadersWidth = 51;
            this.dtgSynthese.RowTemplate.Height = 24;
            this.dtgSynthese.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSynthese.Size = new System.Drawing.Size(727, 150);
            this.dtgSynthese.TabIndex = 0;
            // 
            // nomClient
            // 
            this.nomClient.DataPropertyName = "NomClient";
            this.nomClient.HeaderText = "Nom du client";
            this.nomClient.MinimumWidth = 6;
            this.nomClient.Name = "nomClient";
            this.nomClient.ReadOnly = true;
            this.nomClient.Width = 125;
            // 
            // nbDevis
            // 
            this.nbDevis.DataPropertyName = "NombreDevis";
            this.nbDevis.HeaderText = "Nombre de devis";
            this.nbDevis.MinimumWidth = 6;
            this.nbDevis.Name = "nbDevis";
            this.nbDevis.ReadOnly = true;
            this.nbDevis.Width = 125;
            // 
            // nbAccepte
            // 
            this.nbAccepte.DataPropertyName = "NombreDevisAccepte";
            this.nbAccepte.HeaderText = "Devis acceptés";
            this.nbAccepte.MinimumWidth = 6;
            this.nbAccepte.Name = "nbAccepte";
            this.nbAccepte.ReadOnly = true;
            this.nbAccepte.Width = 125;
            // 
            // pctAccepte
            // 
            this.pctAccepte.DataPropertyName = "PourcentageAccepte";
            this.pctAccepte.HeaderText = " % Accepté";
            this.pctAccepte.MinimumWidth = 6;
            this.pctAccepte.Name = "pctAccepte";
            this.pctAccepte.ReadOnly = true;
            this.pctAccepte.Width = 125;
            // 
            // pctAttente
            // 
            this.pctAttente.DataPropertyName = "PourcentageEnAttente";
            this.pctAttente.HeaderText = "% En Attente";
            this.pctAttente.MinimumWidth = 6;
            this.pctAttente.Name = "pctAttente";
            this.pctAttente.ReadOnly = true;
            this.pctAttente.Width = 125;
            // 
            // pctRefuse
            // 
            this.pctRefuse.DataPropertyName = "PourcentageRefuse";
            this.pctRefuse.HeaderText = "% Refusé";
            this.pctRefuse.MinimumWidth = 6;
            this.pctRefuse.Name = "pctRefuse";
            this.pctRefuse.ReadOnly = true;
            this.pctRefuse.Width = 125;
            // 
            // Montant
            // 
            this.Montant.DataPropertyName = "MontantTotalHT";
            this.Montant.HeaderText = "Montant total HT";
            this.Montant.MinimumWidth = 6;
            this.Montant.Name = "Montant";
            this.Montant.ReadOnly = true;
            this.Montant.Width = 125;
            // 
            // btnRafraichir
            // 
            this.btnRafraichir.Location = new System.Drawing.Point(620, 329);
            this.btnRafraichir.Name = "btnRafraichir";
            this.btnRafraichir.Size = new System.Drawing.Size(90, 30);
            this.btnRafraichir.TabIndex = 1;
            this.btnRafraichir.Text = "Rafraichir";
            this.btnRafraichir.UseVisualStyleBackColor = true;
            this.btnRafraichir.Click += new System.EventHandler(this.btnRafraichir_Click);
            // 
            // lblTotalGeneral
            // 
            this.lblTotalGeneral.AutoSize = true;
            this.lblTotalGeneral.Location = new System.Drawing.Point(35, 379);
            this.lblTotalGeneral.Name = "lblTotalGeneral";
            this.lblTotalGeneral.Size = new System.Drawing.Size(88, 16);
            this.lblTotalGeneral.TabIndex = 2;
            this.lblTotalGeneral.Text = "Montant total :";
            // 
            // btnOuvrirProduit
            // 
            this.btnOuvrirProduit.Location = new System.Drawing.Point(90, 35);
            this.btnOuvrirProduit.Name = "btnOuvrirProduit";
            this.btnOuvrirProduit.Size = new System.Drawing.Size(109, 32);
            this.btnOuvrirProduit.TabIndex = 3;
            this.btnOuvrirProduit.Text = "Produit";
            this.btnOuvrirProduit.UseVisualStyleBackColor = true;
            this.btnOuvrirProduit.Click += new System.EventHandler(this.btnOuvrirProduit_Click);
            // 
            // btnListeDevis
            // 
            this.btnListeDevis.Location = new System.Drawing.Point(222, 35);
            this.btnListeDevis.Name = "btnListeDevis";
            this.btnListeDevis.Size = new System.Drawing.Size(109, 32);
            this.btnListeDevis.TabIndex = 4;
            this.btnListeDevis.Text = "Devis";
            this.btnListeDevis.UseVisualStyleBackColor = true;
            this.btnListeDevis.Click += new System.EventHandler(this.btnListeDevis_Click);
            // 
            // btnListeClient
            // 
            this.btnListeClient.Location = new System.Drawing.Point(355, 35);
            this.btnListeClient.Name = "btnListeClient";
            this.btnListeClient.Size = new System.Drawing.Size(109, 32);
            this.btnListeClient.TabIndex = 5;
            this.btnListeClient.Text = "Client";
            this.btnListeClient.UseVisualStyleBackColor = true;
            this.btnListeClient.Click += new System.EventHandler(this.btnListeClient_Click);
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Location = new System.Drawing.Point(329, 267);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(200, 22);
            this.dtpDateDebut.TabIndex = 6;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(329, 315);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(200, 22);
            this.dtpDateFin.TabIndex = 7;
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(205, 272);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(101, 16);
            this.lblDateDebut.TabIndex = 8;
            this.lblDateDebut.Text = "Date de début : ";
            this.lblDateDebut.Click += new System.EventHandler(this.lblDateDebut_Click);
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(229, 315);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(77, 16);
            this.lblDateFin.TabIndex = 9;
            this.lblDateFin.Text = "Date de fin :";
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.Location = new System.Drawing.Point(370, 362);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(109, 50);
            this.btnFiltrer.TabIndex = 10;
            this.btnFiltrer.Text = "Filtrer par date";
            this.btnFiltrer.UseVisualStyleBackColor = true;
            this.btnFiltrer.Click += new System.EventHandler(this.btnFiltrer_Click);
            // 
            // SyntheseClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFiltrer);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.dtpDateFin);
            this.Controls.Add(this.dtpDateDebut);
            this.Controls.Add(this.btnListeClient);
            this.Controls.Add(this.btnListeDevis);
            this.Controls.Add(this.btnOuvrirProduit);
            this.Controls.Add(this.lblTotalGeneral);
            this.Controls.Add(this.btnRafraichir);
            this.Controls.Add(this.dtgSynthese);
            this.Name = "SyntheseClients";
            this.Text = "Synthese Client";
            this.Load += new System.EventHandler(this.SyntheseClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestion_commercialeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSynthese)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource gestioncommercialeDataSetBindingSource;
        private Gestion_commercialeDataSet gestion_commercialeDataSet;
        private System.Windows.Forms.DataGridView dtgSynthese;
        private System.Windows.Forms.Button btnRafraichir;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbDevis;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbAccepte;
        private System.Windows.Forms.DataGridViewTextBoxColumn pctAccepte;
        private System.Windows.Forms.DataGridViewTextBoxColumn pctAttente;
        private System.Windows.Forms.DataGridViewTextBoxColumn pctRefuse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant;
        private System.Windows.Forms.Label lblTotalGeneral;
        private System.Windows.Forms.Button btnOuvrirProduit;
        private System.Windows.Forms.Button btnListeDevis;
        private System.Windows.Forms.Button btnListeClient;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Button btnFiltrer;
    }
}