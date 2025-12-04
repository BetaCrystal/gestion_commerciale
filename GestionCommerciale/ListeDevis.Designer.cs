namespace GestionCommerciale
{
    partial class ListeDevis
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
            this.dgvDevis = new System.Windows.Forms.DataGridView();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new GestionCommerciale.DataSet1();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new GestionCommerciale.DataSet1();
            this.gestion_commercialeDataSet = new GestionCommerciale.Gestion_commercialeDataSet();
            this.gestioncommercialeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devisTableAdapter = new GestionCommerciale.Gestion_commercialeDataSetTableAdapters.DevisTableAdapter();
            this.codedevisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedevisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tauxtvadevisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montanttotalhtdevisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tauxremiseglobaldevisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codestatutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLignesDevis = new System.Windows.Forms.DataGridView();
            this.contientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contientTableAdapter = new GestionCommerciale.Gestion_commercialeDataSetTableAdapters.ContientTableAdapter();
            this.codeproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codedevisDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remiseproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_commercialeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLignesDevis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDevis
            // 
            this.dgvDevis.AutoGenerateColumns = false;
            this.dgvDevis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codedevisDataGridViewTextBoxColumn,
            this.datedevisDataGridViewTextBoxColumn,
            this.tauxtvadevisDataGridViewTextBoxColumn,
            this.montanttotalhtdevisDataGridViewTextBoxColumn,
            this.tauxremiseglobaldevisDataGridViewTextBoxColumn,
            this.codeclientDataGridViewTextBoxColumn,
            this.codestatutDataGridViewTextBoxColumn});
            this.dgvDevis.DataSource = this.devisBindingSource;
            this.dgvDevis.Location = new System.Drawing.Point(12, 130);
            this.dgvDevis.Name = "dgvDevis";
            this.dgvDevis.Size = new System.Drawing.Size(487, 150);
            this.dgvDevis.TabIndex = 0;
            this.dgvDevis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // devisBindingSource
            // 
            this.devisBindingSource.DataMember = "Devis";
            this.devisBindingSource.DataSource = this.gestioncommercialeDataSetBindingSource;
            // 
            // devisTableAdapter
            // 
            this.devisTableAdapter.ClearBeforeFill = true;
            // 
            // codedevisDataGridViewTextBoxColumn
            // 
            this.codedevisDataGridViewTextBoxColumn.DataPropertyName = "code_devis";
            this.codedevisDataGridViewTextBoxColumn.HeaderText = "code_devis";
            this.codedevisDataGridViewTextBoxColumn.Name = "codedevisDataGridViewTextBoxColumn";
            this.codedevisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datedevisDataGridViewTextBoxColumn
            // 
            this.datedevisDataGridViewTextBoxColumn.DataPropertyName = "date_devis";
            this.datedevisDataGridViewTextBoxColumn.HeaderText = "date_devis";
            this.datedevisDataGridViewTextBoxColumn.Name = "datedevisDataGridViewTextBoxColumn";
            // 
            // tauxtvadevisDataGridViewTextBoxColumn
            // 
            this.tauxtvadevisDataGridViewTextBoxColumn.DataPropertyName = "taux_tva_devis";
            this.tauxtvadevisDataGridViewTextBoxColumn.HeaderText = "taux_tva_devis";
            this.tauxtvadevisDataGridViewTextBoxColumn.Name = "tauxtvadevisDataGridViewTextBoxColumn";
            // 
            // montanttotalhtdevisDataGridViewTextBoxColumn
            // 
            this.montanttotalhtdevisDataGridViewTextBoxColumn.DataPropertyName = "montant_total_ht_devis";
            this.montanttotalhtdevisDataGridViewTextBoxColumn.HeaderText = "montant_total_ht_devis";
            this.montanttotalhtdevisDataGridViewTextBoxColumn.Name = "montanttotalhtdevisDataGridViewTextBoxColumn";
            // 
            // tauxremiseglobaldevisDataGridViewTextBoxColumn
            // 
            this.tauxremiseglobaldevisDataGridViewTextBoxColumn.DataPropertyName = "taux_remise_global_devis";
            this.tauxremiseglobaldevisDataGridViewTextBoxColumn.HeaderText = "taux_remise_global_devis";
            this.tauxremiseglobaldevisDataGridViewTextBoxColumn.Name = "tauxremiseglobaldevisDataGridViewTextBoxColumn";
            // 
            // codeclientDataGridViewTextBoxColumn
            // 
            this.codeclientDataGridViewTextBoxColumn.DataPropertyName = "code_client";
            this.codeclientDataGridViewTextBoxColumn.HeaderText = "code_client";
            this.codeclientDataGridViewTextBoxColumn.Name = "codeclientDataGridViewTextBoxColumn";
            // 
            // codestatutDataGridViewTextBoxColumn
            // 
            this.codestatutDataGridViewTextBoxColumn.DataPropertyName = "code_statut";
            this.codestatutDataGridViewTextBoxColumn.HeaderText = "code_statut";
            this.codestatutDataGridViewTextBoxColumn.Name = "codestatutDataGridViewTextBoxColumn";
            // 
            // dgvLignesDevis
            // 
            this.dgvLignesDevis.AutoGenerateColumns = false;
            this.dgvLignesDevis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLignesDevis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeproduitDataGridViewTextBoxColumn,
            this.codedevisDataGridViewTextBoxColumn1,
            this.remiseproduitDataGridViewTextBoxColumn,
            this.quantiteproduitDataGridViewTextBoxColumn});
            this.dgvLignesDevis.DataSource = this.contientBindingSource;
            this.dgvLignesDevis.Location = new System.Drawing.Point(520, 130);
            this.dgvLignesDevis.Name = "dgvLignesDevis";
            this.dgvLignesDevis.Size = new System.Drawing.Size(268, 217);
            this.dgvLignesDevis.TabIndex = 1;
            // 
            // contientBindingSource
            // 
            this.contientBindingSource.DataMember = "Contient";
            this.contientBindingSource.DataSource = this.gestioncommercialeDataSetBindingSource;
            // 
            // contientTableAdapter
            // 
            this.contientTableAdapter.ClearBeforeFill = true;
            // 
            // codeproduitDataGridViewTextBoxColumn
            // 
            this.codeproduitDataGridViewTextBoxColumn.DataPropertyName = "code_produit";
            this.codeproduitDataGridViewTextBoxColumn.HeaderText = "code_produit";
            this.codeproduitDataGridViewTextBoxColumn.Name = "codeproduitDataGridViewTextBoxColumn";
            // 
            // codedevisDataGridViewTextBoxColumn1
            // 
            this.codedevisDataGridViewTextBoxColumn1.DataPropertyName = "code_devis";
            this.codedevisDataGridViewTextBoxColumn1.HeaderText = "code_devis";
            this.codedevisDataGridViewTextBoxColumn1.Name = "codedevisDataGridViewTextBoxColumn1";
            // 
            // remiseproduitDataGridViewTextBoxColumn
            // 
            this.remiseproduitDataGridViewTextBoxColumn.DataPropertyName = "remise_produit";
            this.remiseproduitDataGridViewTextBoxColumn.HeaderText = "remise_produit";
            this.remiseproduitDataGridViewTextBoxColumn.Name = "remiseproduitDataGridViewTextBoxColumn";
            // 
            // quantiteproduitDataGridViewTextBoxColumn
            // 
            this.quantiteproduitDataGridViewTextBoxColumn.DataPropertyName = "quantite_produit";
            this.quantiteproduitDataGridViewTextBoxColumn.HeaderText = "quantite_produit";
            this.quantiteproduitDataGridViewTextBoxColumn.Name = "quantiteproduitDataGridViewTextBoxColumn";
            // 
            // ListeDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLignesDevis);
            this.Controls.Add(this.dgvDevis);
            this.Name = "ListeDevis";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ListeDevis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_commercialeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLignesDevis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDevis;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource gestioncommercialeDataSetBindingSource;
        private Gestion_commercialeDataSet gestion_commercialeDataSet;
        private System.Windows.Forms.BindingSource devisBindingSource;
        private Gestion_commercialeDataSetTableAdapters.DevisTableAdapter devisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codedevisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedevisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tauxtvadevisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montanttotalhtdevisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tauxremiseglobaldevisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codestatutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvLignesDevis;
        private System.Windows.Forms.BindingSource contientBindingSource;
        private Gestion_commercialeDataSetTableAdapters.ContientTableAdapter contientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codedevisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn remiseproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteproduitDataGridViewTextBoxColumn;
    }
}