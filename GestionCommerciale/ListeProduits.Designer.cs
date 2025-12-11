namespace GestionCommerciale
{
    partial class ListeProduits
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtgProduit = new System.Windows.Forms.DataGridView();
            this.colLibelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.codeProduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleProduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVenteHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieProduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new GestionCommerciale.DataSet1();
            this.btnProduit = new System.Windows.Forms.Button();
            this.categorieTableAdapter1 = new GestionCommerciale.Gestion_commercialeDataSetTableAdapters.CategorieTableAdapter();
            this.btnOuvrirClient = new System.Windows.Forms.Button();
            this.btnListeDevis = new System.Windows.Forms.Button();
            this.btnSyntheseClients = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgProduit
            // 
            this.dtgProduit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProduit.AutoGenerateColumns = false;
            this.dtgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLibelle,
            this.colPrix,
            this.colCategorie,
            this.Modifier,
            this.Supprimer,
            this.codeProduitDataGridViewTextBoxColumn,
            this.libelleProduitDataGridViewTextBoxColumn,
            this.prixVenteHTDataGridViewTextBoxColumn,
            this.categorieProduitDataGridViewTextBoxColumn});
            this.dtgProduit.DataSource = this.bindingSource1;
            this.dtgProduit.Location = new System.Drawing.Point(0, 102);
            this.dtgProduit.Name = "dtgProduit";
            this.dtgProduit.RowHeadersWidth = 51;
            this.dtgProduit.RowTemplate.Height = 24;
            this.dtgProduit.Size = new System.Drawing.Size(758, 193);
            this.dtgProduit.TabIndex = 0;
            this.dtgProduit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduit_CellContentClick);
            // 
            // colLibelle
            // 
            this.colLibelle.DataPropertyName = "LibelleProduit";
            this.colLibelle.HeaderText = "Nom du produit";
            this.colLibelle.MinimumWidth = 6;
            this.colLibelle.Name = "colLibelle";
            this.colLibelle.Width = 125;
            // 
            // colPrix
            // 
            this.colPrix.DataPropertyName = "PrixVenteHT";
            this.colPrix.HeaderText = "Prix hors taxe";
            this.colPrix.MinimumWidth = 6;
            this.colPrix.Name = "colPrix";
            this.colPrix.Width = 125;
            // 
            // colCategorie
            // 
            this.colCategorie.DataPropertyName = "CategorieProduit";
            this.colCategorie.HeaderText = "Catégorie";
            this.colCategorie.MinimumWidth = 6;
            this.colCategorie.Name = "colCategorie";
            this.colCategorie.Width = 125;
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.MinimumWidth = 6;
            this.Modifier.Name = "Modifier";
            this.Modifier.Text = "modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            this.Modifier.Width = 125;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.MinimumWidth = 6;
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Text = "supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            this.Supprimer.Width = 125;
            // 
            // codeProduitDataGridViewTextBoxColumn
            // 
            this.codeProduitDataGridViewTextBoxColumn.DataPropertyName = "CodeProduit";
            this.codeProduitDataGridViewTextBoxColumn.HeaderText = "CodeProduit";
            this.codeProduitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeProduitDataGridViewTextBoxColumn.Name = "codeProduitDataGridViewTextBoxColumn";
            this.codeProduitDataGridViewTextBoxColumn.Visible = false;
            this.codeProduitDataGridViewTextBoxColumn.Width = 125;
            // 
            // libelleProduitDataGridViewTextBoxColumn
            // 
            this.libelleProduitDataGridViewTextBoxColumn.DataPropertyName = "LibelleProduit";
            this.libelleProduitDataGridViewTextBoxColumn.HeaderText = "LibelleProduit";
            this.libelleProduitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.libelleProduitDataGridViewTextBoxColumn.Name = "libelleProduitDataGridViewTextBoxColumn";
            this.libelleProduitDataGridViewTextBoxColumn.Visible = false;
            this.libelleProduitDataGridViewTextBoxColumn.Width = 125;
            // 
            // prixVenteHTDataGridViewTextBoxColumn
            // 
            this.prixVenteHTDataGridViewTextBoxColumn.DataPropertyName = "PrixVenteHT";
            this.prixVenteHTDataGridViewTextBoxColumn.HeaderText = "PrixVenteHT";
            this.prixVenteHTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prixVenteHTDataGridViewTextBoxColumn.Name = "prixVenteHTDataGridViewTextBoxColumn";
            this.prixVenteHTDataGridViewTextBoxColumn.Visible = false;
            this.prixVenteHTDataGridViewTextBoxColumn.Width = 125;
            // 
            // categorieProduitDataGridViewTextBoxColumn
            // 
            this.categorieProduitDataGridViewTextBoxColumn.DataPropertyName = "CategorieProduit";
            this.categorieProduitDataGridViewTextBoxColumn.HeaderText = "CategorieProduit";
            this.categorieProduitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categorieProduitDataGridViewTextBoxColumn.Name = "categorieProduitDataGridViewTextBoxColumn";
            this.categorieProduitDataGridViewTextBoxColumn.Visible = false;
            this.categorieProduitDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(GestionCommercialeBO.Produit);
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnProduit
            // 
            this.btnProduit.Location = new System.Drawing.Point(310, 301);
            this.btnProduit.Name = "btnProduit";
            this.btnProduit.Size = new System.Drawing.Size(182, 48);
            this.btnProduit.TabIndex = 1;
            this.btnProduit.Text = "Ajouter un Produit";
            this.btnProduit.UseVisualStyleBackColor = true;
            this.btnProduit.Click += new System.EventHandler(this.btnProduit_Click);
            // 
            // categorieTableAdapter1
            // 
            this.categorieTableAdapter1.ClearBeforeFill = true;
            // 
            // btnOuvrirClient
            // 
            this.btnOuvrirClient.Location = new System.Drawing.Point(74, 50);
            this.btnOuvrirClient.Name = "btnOuvrirClient";
            this.btnOuvrirClient.Size = new System.Drawing.Size(84, 25);
            this.btnOuvrirClient.TabIndex = 2;
            this.btnOuvrirClient.Text = "Client";
            this.btnOuvrirClient.UseVisualStyleBackColor = true;
            this.btnOuvrirClient.Click += new System.EventHandler(this.btnOuvrirClient_Click);
            // 
            // btnListeDevis
            // 
            this.btnListeDevis.Location = new System.Drawing.Point(177, 50);
            this.btnListeDevis.Name = "btnListeDevis";
            this.btnListeDevis.Size = new System.Drawing.Size(86, 30);
            this.btnListeDevis.TabIndex = 3;
            this.btnListeDevis.Text = "Devis";
            this.btnListeDevis.UseVisualStyleBackColor = true;
            this.btnListeDevis.Click += new System.EventHandler(this.btnListeDevis_Click);
            // 
            // btnSyntheseClients
            // 
            this.btnSyntheseClients.Location = new System.Drawing.Point(283, 50);
            this.btnSyntheseClients.Name = "btnSyntheseClients";
            this.btnSyntheseClients.Size = new System.Drawing.Size(120, 30);
            this.btnSyntheseClients.TabIndex = 4;
            this.btnSyntheseClients.Text = "Synthèse Client";
            this.btnSyntheseClients.UseVisualStyleBackColor = true;
            this.btnSyntheseClients.Click += new System.EventHandler(this.btnSyntheseClients_Click);
            // 
            // ListeProduits
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSyntheseClients);
            this.Controls.Add(this.btnListeDevis);
            this.Controls.Add(this.btnOuvrirClient);
            this.Controls.Add(this.btnProduit);
            this.Controls.Add(this.dtgProduit);
            this.Name = "ListeProduits";
            this.Text = "Liste des produits";
            this.Load += new System.EventHandler(this.FormListeProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProduit;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Button btnProduit;
        private Gestion_commercialeDataSetTableAdapters.CategorieTableAdapter categorieTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnOuvrirClient;
        private System.Windows.Forms.Button btnListeDevis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLibelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategorie;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeProduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleProduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixVenteHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieProduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSyntheseClients;
    }
}