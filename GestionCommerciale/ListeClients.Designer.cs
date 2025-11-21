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
            this.btnSupprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOuvrirProduit = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
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
            this.btnSupprimer});
            this.dtgClient.DataSource = this.clientBindingSource;
            this.dtgClient.Location = new System.Drawing.Point(0, 98);
            this.dtgClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgClient.Name = "dtgClient";
            this.dtgClient.RowHeadersWidth = 51;
            this.dtgClient.RowTemplate.Height = 24;
            this.dtgClient.Size = new System.Drawing.Size(608, 161);
            this.dtgClient.TabIndex = 0;
            this.dtgClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClient_CellContentClick);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.HeaderText = "Supprimer";
            this.btnSupprimer.MinimumWidth = 6;
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseColumnTextForButtonValue = true;
            // 
            // btnOuvrirProduit
            // 
            this.btnOuvrirProduit.Location = new System.Drawing.Point(49, 60);
            this.btnOuvrirProduit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // ListeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnOuvrirProduit);
            this.Controls.Add(this.dtgClient);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListeClients";
            this.Text = "ListeClients";
            ((System.ComponentModel.ISupportInitialize)(this.dtgClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewButtonColumn btnSupprimer;
        private System.Windows.Forms.Button btnOuvrirProduit;
        private System.Windows.Forms.Button btnClient;
    }
}