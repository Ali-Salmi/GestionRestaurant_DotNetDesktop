namespace gestion_rest.UC
{
    partial class ucPlat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.libelle = new System.Windows.Forms.Label();
            this.typePlat = new System.Windows.Forms.Label();
            this.prix = new System.Windows.Forms.Label();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // libelle
            // 
            this.libelle.AutoSize = true;
            this.libelle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.libelle.Location = new System.Drawing.Point(41, 18);
            this.libelle.Name = "libelle";
            this.libelle.Size = new System.Drawing.Size(75, 30);
            this.libelle.TabIndex = 1;
            this.libelle.Text = "libelle";
            // 
            // typePlat
            // 
            this.typePlat.AutoSize = true;
            this.typePlat.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.typePlat.Location = new System.Drawing.Point(41, 77);
            this.typePlat.Name = "typePlat";
            this.typePlat.Size = new System.Drawing.Size(146, 30);
            this.typePlat.TabIndex = 2;
            this.typePlat.Text = "type du plat:";
            this.typePlat.Click += new System.EventHandler(this.typePlat_Click);
            // 
            // prix
            // 
            this.prix.AutoSize = true;
            this.prix.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prix.Location = new System.Drawing.Point(41, 141);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(60, 30);
            this.prix.TabIndex = 3;
            this.prix.Text = "prix:";
            // 
            // btnSupp
            // 
            this.btnSupp.BackColor = System.Drawing.Color.Red;
            this.btnSupp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSupp.Location = new System.Drawing.Point(369, 69);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(126, 46);
            this.btnSupp.TabIndex = 6;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = false;
            this.btnSupp.Click += new System.EventHandler(this.btnReserver_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMod.Location = new System.Drawing.Point(369, 133);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(126, 46);
            this.btnMod.TabIndex = 7;
            this.btnMod.Text = "Modifier";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // ucPlat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.prix);
            this.Controls.Add(this.typePlat);
            this.Controls.Add(this.libelle);
            this.Name = "ucPlat";
            this.Size = new System.Drawing.Size(544, 208);
            this.Load += new System.EventHandler(this.plat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Label libelle;
        public Label typePlat;
        public Label prix;
        public Button btnSupp;
        public Button btnMod;
    }
}
