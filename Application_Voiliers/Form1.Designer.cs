namespace Application_Voiliers
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.chp_NomV = new System.Windows.Forms.TextBox();
            this.dtgv_Voilier = new System.Windows.Forms.DataGridView();
            this.chp_ImmatV = new System.Windows.Forms.TextBox();
            this.chp_MarqueV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chp_Rechercher = new System.Windows.Forms.TextBox();
            this.btn_Rechercher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Voilier)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(82, 233);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajouter.TabIndex = 0;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // chp_NomV
            // 
            this.chp_NomV.Location = new System.Drawing.Point(66, 58);
            this.chp_NomV.Name = "chp_NomV";
            this.chp_NomV.Size = new System.Drawing.Size(100, 22);
            this.chp_NomV.TabIndex = 1;
            this.chp_NomV.TextChanged += new System.EventHandler(this.chp_NomV_TextChanged);
            // 
            // dtgv_Voilier
            // 
            this.dtgv_Voilier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Voilier.Location = new System.Drawing.Point(12, 370);
            this.dtgv_Voilier.Name = "dtgv_Voilier";
            this.dtgv_Voilier.RowTemplate.Height = 24;
            this.dtgv_Voilier.Size = new System.Drawing.Size(801, 234);
            this.dtgv_Voilier.TabIndex = 2;
            this.dtgv_Voilier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Voilier_CellContentClick);
            // 
            // chp_ImmatV
            // 
            this.chp_ImmatV.Location = new System.Drawing.Point(67, 184);
            this.chp_ImmatV.Name = "chp_ImmatV";
            this.chp_ImmatV.Size = new System.Drawing.Size(100, 22);
            this.chp_ImmatV.TabIndex = 3;
            // 
            // chp_MarqueV
            // 
            this.chp_MarqueV.Location = new System.Drawing.Point(67, 116);
            this.chp_MarqueV.Name = "chp_MarqueV";
            this.chp_MarqueV.Size = new System.Drawing.Size(100, 22);
            this.chp_MarqueV.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom du Voilier ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Marque du Voilier ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Immatriculation du Voilier";
            // 
            // chp_Rechercher
            // 
            this.chp_Rechercher.Location = new System.Drawing.Point(12, 342);
            this.chp_Rechercher.Name = "chp_Rechercher";
            this.chp_Rechercher.Size = new System.Drawing.Size(218, 22);
            this.chp_Rechercher.TabIndex = 8;
            // 
            // btn_Rechercher
            // 
            this.btn_Rechercher.Location = new System.Drawing.Point(236, 341);
            this.btn_Rechercher.Name = "btn_Rechercher";
            this.btn_Rechercher.Size = new System.Drawing.Size(94, 23);
            this.btn_Rechercher.TabIndex = 9;
            this.btn_Rechercher.Text = "Rechercher";
            this.btn_Rechercher.UseVisualStyleBackColor = true;
            this.btn_Rechercher.Click += new System.EventHandler(this.btn_Rechercher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 616);
            this.Controls.Add(this.btn_Rechercher);
            this.Controls.Add(this.chp_Rechercher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chp_MarqueV);
            this.Controls.Add(this.chp_ImmatV);
            this.Controls.Add(this.dtgv_Voilier);
            this.Controls.Add(this.chp_NomV);
            this.Controls.Add(this.btn_Ajouter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Voilier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.TextBox chp_NomV;
        private System.Windows.Forms.DataGridView dtgv_Voilier;
        private System.Windows.Forms.TextBox chp_ImmatV;
        private System.Windows.Forms.TextBox chp_MarqueV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox chp_Rechercher;
        private System.Windows.Forms.Button btn_Rechercher;
    }
}

