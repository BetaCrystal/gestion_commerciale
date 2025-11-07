
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
            this.dataSet1 = new GestionCommerciale.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colLibelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProduit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgProduit
            // 
            this.dtgProduit.AutoGenerateColumns = false;
            this.dtgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLibelle,
            this.colPrix,
            this.colCategorie});
            this.dtgProduit.DataSource = this.dataSet1BindingSource;
            this.dtgProduit.Location = new System.Drawing.Point(186, 41);
            this.dtgProduit.Name = "dtgProduit";
            this.dtgProduit.RowHeadersWidth = 51;
            this.dtgProduit.RowTemplate.Height = 24;
            this.dtgProduit.Size = new System.Drawing.Size(491, 134);
            this.dtgProduit.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // colLibelle
            // 
            this.colLibelle.DataPropertyName = "libelle_produit";
            this.colLibelle.HeaderText = "Nom du produit";
            this.colLibelle.MinimumWidth = 6;
            this.colLibelle.Name = "colLibelle";
            this.colLibelle.Width = 125;
            // 
            // colPrix
            // 
            this.colPrix.DataPropertyName = "prix_ht_produit";
            this.colPrix.HeaderText = "Prix hors taxe";
            this.colPrix.MinimumWidth = 6;
            this.colPrix.Name = "colPrix";
            this.colPrix.Width = 125;
            // 
            // colCategorie
            // 
            this.colCategorie.DataPropertyName = "nom_categorie";
            this.colCategorie.HeaderText = "Catégorie";
            this.colCategorie.MinimumWidth = 6;
            this.colCategorie.Name = "colCategorie";
            this.colCategorie.Width = 125;
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
            // ListeProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProduit);
            this.Controls.Add(this.dtgProduit);
            this.Name = "ListeProduits";
            this.Text = "Liste des produits";
            this.Load += new System.EventHandler(this.FormListeProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProduit;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLibelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategorie;
        private System.Windows.Forms.Button btnProduit;
    }
}