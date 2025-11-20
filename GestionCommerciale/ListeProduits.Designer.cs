
namespace GestionCommerciale
{
    partial class ListeProduits
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
            this.dtgProduit = new System.Windows.Forms.DataGridView();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new GestionCommerciale.DataSet1();
            this.btnProduit = new System.Windows.Forms.Button();
<<<<<<< HEAD
=======
            this.categorieTableAdapter1 = new GestionCommerciale.Gestion_commercialeDataSetTableAdapters.CategorieTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
>>>>>>> f8d224008bb874cc497a689787bf50114e583130
            this.colLibelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
<<<<<<< HEAD
            this.colLibelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new GestionCommerciale.DataSet1();
            this.btnProduit = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
>>>>>>> f8d224008bb874cc497a689787bf50114e583130
            this.SuspendLayout();
            // 
            // dtgProduit
            // 
            this.dtgProduit.AutoGenerateColumns = false;
            this.dtgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLibelle,
            this.colPrix,
            this.colCategorie,
            this.Modifier,
            this.Supprimer});
<<<<<<< HEAD
            this.dtgProduit.DataSource = this.dataSet1BindingSource;
            this.dtgProduit.Location = new System.Drawing.Point(33, 23);
            this.dtgProduit.Name = "dtgProduit";
            this.dtgProduit.RowHeadersWidth = 51;
            this.dtgProduit.RowTemplate.Height = 24;
            this.dtgProduit.Size = new System.Drawing.Size(755, 193);
=======
            this.dtgProduit.DataSource = this.bindingSource1;
            this.dtgProduit.Location = new System.Drawing.Point(12, 40);
            this.dtgProduit.Name = "dtgProduit";
            this.dtgProduit.RowHeadersWidth = 51;
            this.dtgProduit.RowTemplate.Height = 24;
            this.dtgProduit.Size = new System.Drawing.Size(758, 193);
>>>>>>> f8d224008bb874cc497a689787bf50114e583130
            this.dtgProduit.TabIndex = 0;
            this.dtgProduit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduit_CellContentClick);
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
<<<<<<< HEAD
            this.colCategorie});
            this.dtgProduit.DataSource = this.dataSet1BindingSource;
            this.dtgProduit.Location = new System.Drawing.Point(140, 33);
            this.dtgProduit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgProduit.Name = "dtgProduit";
            this.dtgProduit.RowHeadersWidth = 51;
            this.dtgProduit.RowTemplate.Height = 24;
            this.dtgProduit.Size = new System.Drawing.Size(368, 109);
            this.dtgProduit.TabIndex = 0;
            // 
            // colLibelle
            // 
            this.colLibelle.DataPropertyName = "libelle_produit";
=======
            // 
            // categorieTableAdapter1
            // 
            this.categorieTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(GestionCommercialeBO.Produit);
            // 
            // colLibelle
            // 
            this.colLibelle.DataPropertyName = "LibelleProduit";
>>>>>>> f8d224008bb874cc497a689787bf50114e583130
            this.colLibelle.HeaderText = "Nom du produit";
            this.colLibelle.MinimumWidth = 6;
            this.colLibelle.Name = "colLibelle";
            this.colLibelle.Width = 125;
            // 
            // colPrix
            // 
<<<<<<< HEAD
            this.colPrix.DataPropertyName = "prix_vente_ht_produit";
            this.colPrix.DataPropertyName = "prix_ht_produit";
=======
            this.colPrix.DataPropertyName = "PrixVenteHT";
>>>>>>> f8d224008bb874cc497a689787bf50114e583130
            this.colPrix.HeaderText = "Prix hors taxe";
            this.colPrix.MinimumWidth = 6;
            this.colPrix.Name = "colPrix";
            this.colPrix.Width = 125;
            // 
            // colCategorie
            // 
<<<<<<< HEAD
            this.colCategorie.DataPropertyName = "nom_categorie";
=======
            this.colCategorie.DataPropertyName = "CategorieProduit";
>>>>>>> f8d224008bb874cc497a689787bf50114e583130
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
            // ListeProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProduit);
            this.Controls.Add(this.dtgProduit);
<<<<<<< HEAD
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
            this.btnProduit.Location = new System.Drawing.Point(232, 245);
            this.btnProduit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProduit.Name = "btnProduit";
            this.btnProduit.Size = new System.Drawing.Size(136, 39);
            this.btnProduit.TabIndex = 1;
            this.btnProduit.Text = "Ajouter un Produit";
            this.btnProduit.UseVisualStyleBackColor = true;
            this.btnProduit.Click += new System.EventHandler(this.btnProduit_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(13, 13);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(84, 23);
            this.btnDeconnexion.TabIndex = 2;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // ListeProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnProduit);
            this.Controls.Add(this.dtgProduit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
=======
>>>>>>> f8d224008bb874cc497a689787bf50114e583130
            this.Name = "ListeProduits";
            this.Text = "Liste des produits";
            this.Load += new System.EventHandler(this.FormListeProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
<<<<<<< HEAD
=======
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
>>>>>>> f8d224008bb874cc497a689787bf50114e583130
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProduit;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Button btnProduit;
<<<<<<< HEAD
=======
        private Gestion_commercialeDataSetTableAdapters.CategorieTableAdapter categorieTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
>>>>>>> f8d224008bb874cc497a689787bf50114e583130
        private System.Windows.Forms.DataGridViewTextBoxColumn colLibelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategorie;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
<<<<<<< HEAD
        private System.Windows.Forms.DataGridViewTextBoxColumn colLibelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategorie;
        private System.Windows.Forms.Button btnProduit;
        private System.Windows.Forms.Button btnDeconnexion;
=======
>>>>>>> f8d224008bb874cc497a689787bf50114e583130
    }
}