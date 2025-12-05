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
            this.codedevisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedevisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tauxtvadevisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montanttotalhtdevisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant_ht_avec_remise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tauxremiseglobaldevisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant_tva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant_ttc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codestatutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModifierDevis = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSupprimerDevis = new System.Windows.Forms.DataGridViewButtonColumn();
            this.devisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestioncommercialeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_commercialeDataSet = new GestionCommerciale.Gestion_commercialeDataSet();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new GestionCommerciale.DataSet1();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new GestionCommerciale.DataSet1();
            this.devisTableAdapter = new GestionCommerciale.Gestion_commercialeDataSetTableAdapters.DevisTableAdapter();
            this.contientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contientTableAdapter = new GestionCommerciale.Gestion_commercialeDataSetTableAdapters.ContientTableAdapter();
            this.btnListeProduits = new System.Windows.Forms.Button();
            this.btnListeClients = new System.Windows.Forms.Button();
            this.btnAjouterDevis = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_commercialeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
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
            this.montant_ht_avec_remise,
            this.tauxremiseglobaldevisDataGridViewTextBoxColumn,
            this.montant_tva,
            this.montant_ttc,
            this.nom_client,
            this.nom_statut,
            this.codeclientDataGridViewTextBoxColumn,
            this.codestatutDataGridViewTextBoxColumn,
            this.btnModifierDevis,
            this.btnSupprimerDevis});
            this.dgvDevis.DataSource = this.devisBindingSource;
            this.dgvDevis.Location = new System.Drawing.Point(12, 130);
            this.dgvDevis.Name = "dgvDevis";
            this.dgvDevis.Size = new System.Drawing.Size(487, 150);
            this.dgvDevis.TabIndex = 0;
            this.dgvDevis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevis_CellContentClick);
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
            // montant_ht_avec_remise
            // 
            this.montant_ht_avec_remise.HeaderText = "montant_ht_avec_remise";
            this.montant_ht_avec_remise.Name = "montant_ht_avec_remise";
            // 
            // tauxremiseglobaldevisDataGridViewTextBoxColumn
            // 
            this.tauxremiseglobaldevisDataGridViewTextBoxColumn.DataPropertyName = "taux_remise_global_devis";
            this.tauxremiseglobaldevisDataGridViewTextBoxColumn.HeaderText = "taux_remise_global_devis";
            this.tauxremiseglobaldevisDataGridViewTextBoxColumn.Name = "tauxremiseglobaldevisDataGridViewTextBoxColumn";
            // 
            // montant_tva
            // 
            this.montant_tva.HeaderText = "montant_TVA";
            this.montant_tva.Name = "montant_tva";
            // 
            // montant_ttc
            // 
            this.montant_ttc.HeaderText = "montant_TTC";
            this.montant_ttc.Name = "montant_ttc";
            // 
            // nom_client
            // 
            this.nom_client.HeaderText = "nom_client";
            this.nom_client.Name = "nom_client";
            // 
            // nom_statut
            // 
            this.nom_statut.HeaderText = "statut";
            this.nom_statut.Name = "nom_statut";
            // 
            // codeclientDataGridViewTextBoxColumn
            // 
            this.codeclientDataGridViewTextBoxColumn.DataPropertyName = "code_client";
            this.codeclientDataGridViewTextBoxColumn.HeaderText = "code_client";
            this.codeclientDataGridViewTextBoxColumn.Name = "codeclientDataGridViewTextBoxColumn";
            this.codeclientDataGridViewTextBoxColumn.Visible = false;
            // 
            // codestatutDataGridViewTextBoxColumn
            // 
            this.codestatutDataGridViewTextBoxColumn.DataPropertyName = "code_statut";
            this.codestatutDataGridViewTextBoxColumn.HeaderText = "code_statut";
            this.codestatutDataGridViewTextBoxColumn.Name = "codestatutDataGridViewTextBoxColumn";
            this.codestatutDataGridViewTextBoxColumn.Visible = false;
            // 
            // btnModifierDevis
            // 
            this.btnModifierDevis.HeaderText = "Modifier";
            this.btnModifierDevis.Name = "btnModifierDevis";
            // 
            // btnSupprimerDevis
            // 
            this.btnSupprimerDevis.HeaderText = "Supprimer";
            this.btnSupprimerDevis.Name = "btnSupprimerDevis";
            // 
            // devisBindingSource
            // 
            this.devisBindingSource.DataMember = "Devis";
            this.devisBindingSource.DataSource = this.gestioncommercialeDataSetBindingSource;
            // 
            // gestioncommercialeDataSetBindingSource
            // 
            this.gestioncommercialeDataSetBindingSource.DataSource = this.gestion_commercialeDataSet;
            this.gestioncommercialeDataSetBindingSource.Position = 0;
            // 
            // gestion_commercialeDataSet
            // 
            this.gestion_commercialeDataSet.DataSetName = "Gestion_commercialeDataSet";
            this.gestion_commercialeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // devisTableAdapter
            // 
            this.devisTableAdapter.ClearBeforeFill = true;
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
            // btnListeProduits
            // 
            this.btnListeProduits.Location = new System.Drawing.Point(46, 54);
            this.btnListeProduits.Name = "btnListeProduits";
            this.btnListeProduits.Size = new System.Drawing.Size(75, 23);
            this.btnListeProduits.TabIndex = 2;
            this.btnListeProduits.Text = "Produits";
            this.btnListeProduits.UseVisualStyleBackColor = true;
            this.btnListeProduits.Click += new System.EventHandler(this.btnListeProduits_Click);
            // 
            // btnListeClients
            // 
            this.btnListeClients.Location = new System.Drawing.Point(137, 54);
            this.btnListeClients.Name = "btnListeClients";
            this.btnListeClients.Size = new System.Drawing.Size(75, 23);
            this.btnListeClients.TabIndex = 3;
            this.btnListeClients.Text = "Clients";
            this.btnListeClients.UseVisualStyleBackColor = true;
            this.btnListeClients.Click += new System.EventHandler(this.btnListeClients_Click);
            // 
            // btnAjouterDevis
            // 
            this.btnAjouterDevis.Location = new System.Drawing.Point(204, 343);
            this.btnAjouterDevis.Name = "btnAjouterDevis";
            this.btnAjouterDevis.Size = new System.Drawing.Size(98, 34);
            this.btnAjouterDevis.TabIndex = 4;
            this.btnAjouterDevis.Text = "Ajouter un devis";
            this.btnAjouterDevis.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(525, 130);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(263, 247);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ListeDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnAjouterDevis);
            this.Controls.Add(this.btnListeClients);
            this.Controls.Add(this.btnListeProduits);
            this.Controls.Add(this.dgvDevis);
            this.Name = "ListeDevis";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ListeDevis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_commercialeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
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
        private System.Windows.Forms.BindingSource contientBindingSource;
        private Gestion_commercialeDataSetTableAdapters.ContientTableAdapter contientTableAdapter;
        private System.Windows.Forms.Button btnListeProduits;
        private System.Windows.Forms.Button btnListeClients;
        private System.Windows.Forms.Button btnAjouterDevis;
        private System.Windows.Forms.DataGridViewTextBoxColumn codedevisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedevisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tauxtvadevisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montanttotalhtdevisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant_ht_avec_remise;
        private System.Windows.Forms.DataGridViewTextBoxColumn tauxremiseglobaldevisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant_tva;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant_ttc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_statut;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codestatutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnModifierDevis;
        private System.Windows.Forms.DataGridViewButtonColumn btnSupprimerDevis;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}