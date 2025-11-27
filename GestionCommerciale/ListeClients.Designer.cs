namespace GestionCommerciale
{
    partial class ListeClients
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
            this.dtgClient = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSupprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOuvrirProduit = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.gestion_commercialeDataSet1 = new GestionCommerciale.Gestion_commercialeDataSet();
            this.dataSet11 = new GestionCommerciale.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_commercialeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgClient
            // 
            this.dtgClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgClient.AutoGenerateColumns = false;
            this.dtgClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.btnModifier,
            this.btnSupprimer});
            this.dtgClient.DataSource = this.bindingSource1;
            this.dtgClient.Location = new System.Drawing.Point(0, 98);
            this.dtgClient.Margin = new System.Windows.Forms.Padding(2);
            this.dtgClient.Name = "dtgClient";
            this.dtgClient.RowHeadersWidth = 51;
            this.dtgClient.RowTemplate.Height = 24;
            this.dtgClient.Size = new System.Drawing.Size(589, 161);
            this.dtgClient.TabIndex = 0;
            this.dtgClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClient_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodeClient";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodeClient";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 83;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomClient";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomClient";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NumTelephoneClient";
            this.dataGridViewTextBoxColumn3.HeaderText = "NumTelephoneClient";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 131;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NumFaxClient";
            this.dataGridViewTextBoxColumn4.HeaderText = "NumFaxClient";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 97;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AdresseMailClient";
            this.dataGridViewTextBoxColumn5.HeaderText = "AdresseMailClient";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 115;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NumAdresseFacturationClient";
            this.dataGridViewTextBoxColumn6.HeaderText = "NumAdresseFacturationClient";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 171;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "RueFacturationClient";
            this.dataGridViewTextBoxColumn7.HeaderText = "RueFacturationClient";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 131;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CodePostalFacturationClient";
            this.dataGridViewTextBoxColumn8.HeaderText = "CodePostalFacturationClient";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 165;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "VilleFacturationClient";
            this.dataGridViewTextBoxColumn9.HeaderText = "VilleFacturationClient";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 130;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NumAdresseLivraisonClient";
            this.dataGridViewTextBoxColumn10.HeaderText = "NumAdresseLivraisonClient";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 160;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "RueLivraisonClient";
            this.dataGridViewTextBoxColumn11.HeaderText = "RueLivraisonClient";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 120;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CodePostalLivraisonClient";
            this.dataGridViewTextBoxColumn12.HeaderText = "CodePostalLivraisonClient";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 154;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "VilleLivraisonClient";
            this.dataGridViewTextBoxColumn13.HeaderText = "VilleLivraisonClient";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 119;
            // 
            // btnModifier
            // 
            this.btnModifier.HeaderText = "Modifier";
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Text = "modifier";
            this.btnModifier.Width = 50;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.HeaderText = "Supprimer";
            this.btnSupprimer.MinimumWidth = 6;
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Text = "supprimer";
            this.btnSupprimer.UseColumnTextForButtonValue = true;
            this.btnSupprimer.Width = 60;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(GestionCommercialeBO.Client);
            // 
            // btnOuvrirProduit
            // 
            this.btnOuvrirProduit.Location = new System.Drawing.Point(49, 60);
            this.btnOuvrirProduit.Margin = new System.Windows.Forms.Padding(2);
            this.btnOuvrirProduit.Name = "btnOuvrirProduit";
            this.btnOuvrirProduit.Size = new System.Drawing.Size(64, 24);
            this.btnOuvrirProduit.TabIndex = 1;
            this.btnOuvrirProduit.Text = "Produit";
            this.btnOuvrirProduit.UseVisualStyleBackColor = true;
            this.btnOuvrirProduit.Click += new System.EventHandler(this.btnOuvrirProduit_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(224, 292);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(106, 38);
            this.btnClient.TabIndex = 2;
            this.btnClient.Text = "Ajouter un client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // gestion_commercialeDataSet1
            // 
            this.gestion_commercialeDataSet1.DataSetName = "Gestion_commercialeDataSet";
            this.gestion_commercialeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ListeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnOuvrirProduit);
            this.Controls.Add(this.dtgClient);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListeClients";
            this.Text = "ListeClients";
            ((System.ComponentModel.ISupportInitialize)(this.dtgClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_commercialeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgClient;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTelephoneClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFaxClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseMailClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numAdresseFacturationClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rueFacturationClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostalFacturationClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeFacturationClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numAdresseLivraisonClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rueLivraisonClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostalLivraisonClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeLivraisonClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOuvrirProduit;
        private System.Windows.Forms.Button btnClient;
        private Gestion_commercialeDataSet gestion_commercialeDataSet1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewButtonColumn btnModifier;
        private System.Windows.Forms.DataGridViewButtonColumn btnSupprimer;
    }
}