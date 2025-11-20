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
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgClient
            // 
            this.dtgClient.AutoGenerateColumns = false;
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
            this.villeLivraisonClientDataGridViewTextBoxColumn});
            this.dtgClient.DataSource = this.clientBindingSource;
            this.dtgClient.Location = new System.Drawing.Point(40, 92);
            this.dtgClient.Name = "dtgClient";
            this.dtgClient.RowHeadersWidth = 51;
            this.dtgClient.RowTemplate.Height = 24;
            this.dtgClient.Size = new System.Drawing.Size(591, 150);
            this.dtgClient.TabIndex = 0;
            // 
            // codeClientDataGridViewTextBoxColumn
            // 
            this.codeClientDataGridViewTextBoxColumn.DataPropertyName = "CodeClient";
            this.codeClientDataGridViewTextBoxColumn.HeaderText = "CodeClient";
            this.codeClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeClientDataGridViewTextBoxColumn.Name = "codeClientDataGridViewTextBoxColumn";
            this.codeClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomClientDataGridViewTextBoxColumn
            // 
            this.nomClientDataGridViewTextBoxColumn.DataPropertyName = "NomClient";
            this.nomClientDataGridViewTextBoxColumn.HeaderText = "NomClient";
            this.nomClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomClientDataGridViewTextBoxColumn.Name = "nomClientDataGridViewTextBoxColumn";
            this.nomClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // numTelephoneClientDataGridViewTextBoxColumn
            // 
            this.numTelephoneClientDataGridViewTextBoxColumn.DataPropertyName = "NumTelephoneClient";
            this.numTelephoneClientDataGridViewTextBoxColumn.HeaderText = "NumTelephoneClient";
            this.numTelephoneClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numTelephoneClientDataGridViewTextBoxColumn.Name = "numTelephoneClientDataGridViewTextBoxColumn";
            this.numTelephoneClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // numFaxClientDataGridViewTextBoxColumn
            // 
            this.numFaxClientDataGridViewTextBoxColumn.DataPropertyName = "NumFaxClient";
            this.numFaxClientDataGridViewTextBoxColumn.HeaderText = "NumFaxClient";
            this.numFaxClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numFaxClientDataGridViewTextBoxColumn.Name = "numFaxClientDataGridViewTextBoxColumn";
            this.numFaxClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresseMailClientDataGridViewTextBoxColumn
            // 
            this.adresseMailClientDataGridViewTextBoxColumn.DataPropertyName = "AdresseMailClient";
            this.adresseMailClientDataGridViewTextBoxColumn.HeaderText = "AdresseMailClient";
            this.adresseMailClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresseMailClientDataGridViewTextBoxColumn.Name = "adresseMailClientDataGridViewTextBoxColumn";
            this.adresseMailClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // numAdresseFacturationClientDataGridViewTextBoxColumn
            // 
            this.numAdresseFacturationClientDataGridViewTextBoxColumn.DataPropertyName = "NumAdresseFacturationClient";
            this.numAdresseFacturationClientDataGridViewTextBoxColumn.HeaderText = "NumAdresseFacturationClient";
            this.numAdresseFacturationClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numAdresseFacturationClientDataGridViewTextBoxColumn.Name = "numAdresseFacturationClientDataGridViewTextBoxColumn";
            this.numAdresseFacturationClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // rueFacturationClientDataGridViewTextBoxColumn
            // 
            this.rueFacturationClientDataGridViewTextBoxColumn.DataPropertyName = "RueFacturationClient";
            this.rueFacturationClientDataGridViewTextBoxColumn.HeaderText = "RueFacturationClient";
            this.rueFacturationClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rueFacturationClientDataGridViewTextBoxColumn.Name = "rueFacturationClientDataGridViewTextBoxColumn";
            this.rueFacturationClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // codePostalFacturationClientDataGridViewTextBoxColumn
            // 
            this.codePostalFacturationClientDataGridViewTextBoxColumn.DataPropertyName = "CodePostalFacturationClient";
            this.codePostalFacturationClientDataGridViewTextBoxColumn.HeaderText = "CodePostalFacturationClient";
            this.codePostalFacturationClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codePostalFacturationClientDataGridViewTextBoxColumn.Name = "codePostalFacturationClientDataGridViewTextBoxColumn";
            this.codePostalFacturationClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // villeFacturationClientDataGridViewTextBoxColumn
            // 
            this.villeFacturationClientDataGridViewTextBoxColumn.DataPropertyName = "VilleFacturationClient";
            this.villeFacturationClientDataGridViewTextBoxColumn.HeaderText = "VilleFacturationClient";
            this.villeFacturationClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.villeFacturationClientDataGridViewTextBoxColumn.Name = "villeFacturationClientDataGridViewTextBoxColumn";
            this.villeFacturationClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // numAdresseLivraisonClientDataGridViewTextBoxColumn
            // 
            this.numAdresseLivraisonClientDataGridViewTextBoxColumn.DataPropertyName = "NumAdresseLivraisonClient";
            this.numAdresseLivraisonClientDataGridViewTextBoxColumn.HeaderText = "NumAdresseLivraisonClient";
            this.numAdresseLivraisonClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numAdresseLivraisonClientDataGridViewTextBoxColumn.Name = "numAdresseLivraisonClientDataGridViewTextBoxColumn";
            this.numAdresseLivraisonClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // rueLivraisonClientDataGridViewTextBoxColumn
            // 
            this.rueLivraisonClientDataGridViewTextBoxColumn.DataPropertyName = "RueLivraisonClient";
            this.rueLivraisonClientDataGridViewTextBoxColumn.HeaderText = "RueLivraisonClient";
            this.rueLivraisonClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rueLivraisonClientDataGridViewTextBoxColumn.Name = "rueLivraisonClientDataGridViewTextBoxColumn";
            this.rueLivraisonClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // codePostalLivraisonClientDataGridViewTextBoxColumn
            // 
            this.codePostalLivraisonClientDataGridViewTextBoxColumn.DataPropertyName = "CodePostalLivraisonClient";
            this.codePostalLivraisonClientDataGridViewTextBoxColumn.HeaderText = "CodePostalLivraisonClient";
            this.codePostalLivraisonClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codePostalLivraisonClientDataGridViewTextBoxColumn.Name = "codePostalLivraisonClientDataGridViewTextBoxColumn";
            this.codePostalLivraisonClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // villeLivraisonClientDataGridViewTextBoxColumn
            // 
            this.villeLivraisonClientDataGridViewTextBoxColumn.DataPropertyName = "VilleLivraisonClient";
            this.villeLivraisonClientDataGridViewTextBoxColumn.HeaderText = "VilleLivraisonClient";
            this.villeLivraisonClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.villeLivraisonClientDataGridViewTextBoxColumn.Name = "villeLivraisonClientDataGridViewTextBoxColumn";
            this.villeLivraisonClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(GestionCommercialeBO.Client);
            // 
            // ListeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgClient);
            this.Name = "ListeClients";
            this.Text = "ListeClients";
            ((System.ComponentModel.ISupportInitialize)(this.dtgClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgClient;
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
        private System.Windows.Forms.BindingSource clientBindingSource;
    }
}