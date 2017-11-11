namespace Kitbox
{
    partial class Home
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
            this.btn_admin_home = new System.Windows.Forms.Button();
            this.label1_home = new System.Windows.Forms.Label();
            this.btn_user_home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_admin_home
            // 
            this.btn_admin_home.Location = new System.Drawing.Point(27, 98);
            this.btn_admin_home.Name = "btn_admin_home";
            this.btn_admin_home.Size = new System.Drawing.Size(75, 23);
            this.btn_admin_home.TabIndex = 0;
            this.btn_admin_home.Text = "Administrator";
            this.btn_admin_home.UseVisualStyleBackColor = true;
            this.btn_admin_home.Click += new System.EventHandler(this.btn_admin_home_Click);
            // 
            // label1_home
            // 
            this.label1_home.AutoSize = true;
            this.label1_home.Location = new System.Drawing.Point(91, 50);
            this.label1_home.Name = "label1_home";
            this.label1_home.Size = new System.Drawing.Size(62, 13);
            this.label1_home.TabIndex = 2;
            this.label1_home.Text = "WELCOME";
            // 
            // btn_user_home
            // 
            this.btn_user_home.Location = new System.Drawing.Point(147, 97);
            this.btn_user_home.Name = "btn_user_home";
            this.btn_user_home.Size = new System.Drawing.Size(75, 23);
            this.btn_user_home.TabIndex = 3;
            this.btn_user_home.Text = "Client";
            this.btn_user_home.UseVisualStyleBackColor = true;
            this.btn_user_home.Click += new System.EventHandler(this.btn_user_home_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 176);
            this.Controls.Add(this.btn_user_home);
            this.Controls.Add(this.label1_home);
            this.Controls.Add(this.btn_admin_home);
            this.Name = "Home";
            this.Text = "HOME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_admin_home;
        private System.Windows.Forms.Label label1_home;
        private System.Windows.Forms.Button btn_user_home;
    }
}

