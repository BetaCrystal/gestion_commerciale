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
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOuvrirProduit = new System.Windows.Forms.Button();
            this.codeClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTelephoneClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numFaxClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseMailClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numAdresseFacturationClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rueFacturationClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePostalFacturationClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeFacturationClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numAdresseLivraisonClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rueLivraisonClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePostalLivraisonClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeLivraisonClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSupprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgClient
            // 
            this.dtgClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgClient.AutoGenerateColumns = false;
            this.dtgClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeClientDataGridViewTextBoxColumn,
            this.nomClientDataGridViewTextBoxColumn,
            this.numTelephoneClientDataGridViewTextBoxColumn,
            this.numFaxClientDataGridViewTextBoxColumn,
            this.adresseMailClientDataGridViewTextBoxColumn,
            this.numAdresseFacturationClientDataGridViewTextBoxColumn,
            this.rueFacturationClientDataGridViewTextBoxColumn,
            this.codePostalFacturationClientDataGridViewTextBoxColumn,
            this.villeFacturationClientDataGridViewTextBoxColumn,
            this.numAdresseLivraisonClientDataGridViewTextBoxColumn,
            this.rueLivraisonClientDataGridViewTextBoxColumn,
            this.codePostalLivraisonClientDataGridViewTextBoxColumn,
            this.villeLivraisonClientDataGridViewTextBoxColumn,
            this.btnSupprimer});
            this.dtgClient.DataSource = this.clientBindingSource;
            this.dtgClient.Location = new System.Drawing.Point(0, 121);
            this.dtgClient.Name = "dtgClient";
            this.dtgClient.RowHeadersWidth = 51;
            this.dtgClient.RowTemplate.Height = 24;
            this.dtgClient.Size = new System.Drawing.Size(811, 198);
            this.dtgClient.TabIndex = 0;
            this.dtgClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClient_CellContentClick);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(GestionCommercialeBO.Client);
            // 
            // btnOuvrirProduit
            // 
            this.btnOuvrirProduit.Location = new System.Drawing.Point(65, 74);
            this.btnOuvrirProduit.Name = "btnOuvrirProduit";
            this.btnOuvrirProduit.Size = new System.Drawing.Size(86, 30);
            this.btnOuvrirProduit.TabIndex = 1;
            this.btnOuvrirProduit.Text = "Produit";
            this.btnOuvrirProduit.UseVisualStyleBackColor = true;
            this.btnOuvrirProduit.Click += new System.EventHandler(this.btnOuvrirProduit_Click);
            // 
            // codeClientDataGridViewTextBoxColumn
            // 
            this.codeClientDataGridViewTextBoxColumn.DataPropertyName = "CodeClient";
            this.codeClientDataGridViewTextBoxColumn.HeaderText = "Code Client";
            this.codeClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeClientDataGridViewTextBoxColumn.Name = "codeClientDataGridViewTextBoxColumn";
            // 
            // nomClientDataGridViewTextBoxColumn
            // 
            this.nomClientDataGridViewTextBoxColumn.DataPropertyName = "NomClient";
            this.nomClientDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomClientDataGridViewTextBoxColumn.Name = "nomClientDataGridViewTextBoxColumn";
            // 
            // numTelephoneClientDataGridViewTextBoxColumn
            // 
            this.numTelephoneClientDataGridViewTextBoxColumn.DataPropertyName = "NumTelephoneClient";
            this.numTelephoneClientDataGridViewTextBoxColumn.HeaderText = "Num Telephone";
            this.numTelephoneClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numTelephoneClientDataGridViewTextBoxColumn.Name = "numTelephoneClientDataGridViewTextBoxColumn";
            // 
            // numFaxClientDataGridViewTextBoxColumn
            // 
            this.numFaxClientDataGridViewTextBoxColumn.DataPropertyName = "NumFaxClient";
            this.numFaxClientDataGridViewTextBoxColumn.HeaderText = "Num Fax";
            this.numFaxClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numFaxClientDataGridViewTextBoxColumn.Name = "numFaxClientDataGridViewTextBoxColumn";
            // 
            // adresseMailClientDataGridViewTextBoxColumn
            // 
            this.adresseMailClientDataGridViewTextBoxColumn.DataPropertyName = "AdresseMailClient";
            this.adresseMailClientDataGridViewTextBoxColumn.HeaderText = "Adresse Mail";
            this.adresseMailClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresseMailClientDataGridViewTextBoxColumn.Name = "adresseMailClientDataGridViewTextBoxColumn";
            // 
            // numAdresseFacturationClientDataGridViewTextBoxColumn
            // 
            this.numAdresseFacturationClientDataGridViewTextBoxColumn.DataPropertyName = "NumAdresseFacturationClient";
            this.numAdresseFacturationClientDataGridViewTextBoxColumn.HeaderText = "Num Adresse Facturation";
            this.numAdresseFacturationClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numAdresseFacturationClientDataGridViewTextBoxColumn.Name = "numAdresseFacturationClientDataGridViewTextBoxColumn";
            // 
            // rueFacturationClientDataGridViewTextBoxColumn
            // 
            this.rueFacturationClientDataGridViewTextBoxColumn.DataPropertyName = "RueFacturationClient";
            this.rueFacturationClientDataGridViewTextBoxColumn.HeaderText = "Rue Facturation";
            this.rueFacturationClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rueFacturationClientDataGridViewTextBoxColumn.Name = "rueFacturationClientDataGridViewTextBoxColumn";
            // 
            // codePostalFacturationClientDataGridViewTextBoxColumn
            // 
            this.codePostalFacturationClientDataGridViewTextBoxColumn.DataPropertyName = "CodePostalFacturationClient";
            this.codePostalFacturationClientDataGridViewTextBoxColumn.HeaderText = "Code Postal Facturation";
            this.codePostalFacturationClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codePostalFacturationClientDataGridViewTextBoxColumn.Name = "codePostalFacturationClientDataGridViewTextBoxColumn";
            // 
            // villeFacturationClientDataGridViewTextBoxColumn
            // 
            this.villeFacturationClientDataGridViewTextBoxColumn.DataPropertyName = "VilleFacturationClient";
            this.villeFacturationClientDataGridViewTextBoxColumn.HeaderText = "Ville Facturation";
            this.villeFacturationClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.villeFacturationClientDataGridViewTextBoxColumn.Name = "villeFacturationClientDataGridViewTextBoxColumn";
            // 
            // numAdresseLivraisonClientDataGridViewTextBoxColumn
            // 
            this.numAdresseLivraisonClientDataGridViewTextBoxColumn.DataPropertyName = "NumAdresseLivraisonClient";
            this.numAdresseLivraisonClientDataGridViewTextBoxColumn.HeaderText = "Num Adresse Livraison";
            this.numAdresseLivraisonClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numAdresseLivraisonClientDataGridViewTextBoxColumn.Name = "numAdresseLivraisonClientDataGridViewTextBoxColumn";
            // 
            // rueLivraisonClientDataGridViewTextBoxColumn
            // 
            this.rueLivraisonClientDataGridViewTextBoxColumn.DataPropertyName = "RueLivraisonClient";
            this.rueLivraisonClientDataGridViewTextBoxColumn.HeaderText = "Rue Livraison";
            this.rueLivraisonClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rueLivraisonClientDataGridViewTextBoxColumn.Name = "rueLivraisonClientDataGridViewTextBoxColumn";
            // 
            // codePostalLivraisonClientDataGridViewTextBoxColumn
            // 
            this.codePostalLivraisonClientDataGridViewTextBoxColumn.DataPropertyName = "CodePostalLivraisonClient";
            this.codePostalLivraisonClientDataGridViewTextBoxColumn.HeaderText = "Code Postal Livraison";
            this.codePostalLivraisonClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codePostalLivraisonClientDataGridViewTextBoxColumn.Name = "codePostalLivraisonClientDataGridViewTextBoxColumn";
            // 
            // villeLivraisonClientDataGridViewTextBoxColumn
            // 
            this.villeLivraisonClientDataGridViewTextBoxColumn.DataPropertyName = "VilleLivraisonClient";
            this.villeLivraisonClientDataGridViewTextBoxColumn.HeaderText = "Ville Livraison";
            this.villeLivraisonClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.villeLivraisonClientDataGridViewTextBoxColumn.Name = "villeLivraisonClientDataGridViewTextBoxColumn";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.HeaderText = "Supprimer";
            this.btnSupprimer.MinimumWidth = 6;
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseColumnTextForButtonValue = true;
            // 
            // ListeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOuvrirProduit);
            this.Controls.Add(this.dtgClient);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Name = "ListeClients";
            this.Text = "ListeClients";
            ((System.ComponentModel.ISupportInitialize)(this.dtgClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgClient;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Button btnOuvrirProduit;
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
        private System.Windows.Forms.DataGridViewButtonColumn btnSupprimer;
    }
}