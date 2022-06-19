namespace gestion_rest.UC
{
    partial class ucServeur
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
            this.btnReserver = new System.Windows.Forms.Button();
            this.prenomServeur = new System.Windows.Forms.Label();
            this.nomServeur = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReserver
            // 
            this.btnReserver.BackColor = System.Drawing.Color.Red;
            this.btnReserver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReserver.Location = new System.Drawing.Point(346, 26);
            this.btnReserver.Name = "btnReserver";
            this.btnReserver.Size = new System.Drawing.Size(139, 46);
            this.btnReserver.TabIndex = 5;
            this.btnReserver.Text = "Supprimer";
            this.btnReserver.UseVisualStyleBackColor = false;
            this.btnReserver.Click += new System.EventHandler(this.btnReserver_Click);
            // 
            // prenomServeur
            // 
            this.prenomServeur.AutoSize = true;
            this.prenomServeur.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prenomServeur.Location = new System.Drawing.Point(38, 74);
            this.prenomServeur.Name = "prenomServeur";
            this.prenomServeur.Size = new System.Drawing.Size(118, 37);
            this.prenomServeur.TabIndex = 4;
            this.prenomServeur.Text = "nbPlace";
            // 
            // nomServeur
            // 
            this.nomServeur.AutoSize = true;
            this.nomServeur.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomServeur.Location = new System.Drawing.Point(23, 26);
            this.nomServeur.Name = "nomServeur";
            this.nomServeur.Size = new System.Drawing.Size(157, 37);
            this.nomServeur.TabIndex = 3;
            this.nomServeur.Text = "nameTable";
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.SkyBlue;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModifier.Location = new System.Drawing.Point(346, 88);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(139, 46);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // ucServeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnReserver);
            this.Controls.Add(this.prenomServeur);
            this.Controls.Add(this.nomServeur);
            this.Margin = new System.Windows.Forms.Padding(6, 15, 3, 15);
            this.Name = "ucServeur";
            this.Size = new System.Drawing.Size(544, 148);
            this.Load += new System.EventHandler(this.ucServeur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button btnReserver;
        public Label prenomServeur;
        public Label nomServeur;
        public int id;
        public Button btnModifier;
    }
}
