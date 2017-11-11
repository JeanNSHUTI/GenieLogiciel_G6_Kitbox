namespace Kitbox
{
    partial class SudoForm1
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
            this.buttonGestionStock = new System.Windows.Forms.Button();
            this.buttonGestionCommande = new System.Windows.Forms.Button();
            this.button2Home = new System.Windows.Forms.Button();
            this.button1_Catalog_management = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGestionStock
            // 
            this.buttonGestionStock.Location = new System.Drawing.Point(80, 26);
            this.buttonGestionStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGestionStock.Name = "buttonGestionStock";
            this.buttonGestionStock.Size = new System.Drawing.Size(117, 25);
            this.buttonGestionStock.TabIndex = 0;
            this.buttonGestionStock.Text = "Manage Stock";
            this.buttonGestionStock.UseVisualStyleBackColor = true;
            this.buttonGestionStock.Click += new System.EventHandler(this.buttonGestionStock_Click);
            // 
            // buttonGestionCommande
            // 
            this.buttonGestionCommande.Location = new System.Drawing.Point(80, 61);
            this.buttonGestionCommande.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGestionCommande.Name = "buttonGestionCommande";
            this.buttonGestionCommande.Size = new System.Drawing.Size(117, 25);
            this.buttonGestionCommande.TabIndex = 1;
            this.buttonGestionCommande.Text = "Manage Orders";
            this.buttonGestionCommande.UseVisualStyleBackColor = true;
            this.buttonGestionCommande.Click += new System.EventHandler(this.buttonGestionCommande_Click);
            // 
            // button2Home
            // 
            this.button2Home.Location = new System.Drawing.Point(80, 168);
            this.button2Home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2Home.Name = "button2Home";
            this.button2Home.Size = new System.Drawing.Size(117, 25);
            this.button2Home.TabIndex = 3;
            this.button2Home.Text = "Home";
            this.button2Home.UseVisualStyleBackColor = true;
            this.button2Home.Click += new System.EventHandler(this.button2Home_Click);
            // 
            // button1_Catalog_management
            // 
            this.button1_Catalog_management.Location = new System.Drawing.Point(80, 95);
            this.button1_Catalog_management.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1_Catalog_management.Name = "button1_Catalog_management";
            this.button1_Catalog_management.Size = new System.Drawing.Size(117, 25);
            this.button1_Catalog_management.TabIndex = 4;
            this.button1_Catalog_management.Text = "Manage Catalog";
            this.button1_Catalog_management.UseVisualStyleBackColor = true;
            this.button1_Catalog_management.Click += new System.EventHandler(this.button1_Catalog_management_Click);
            // 
            // SudoForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 217);
            this.Controls.Add(this.button1_Catalog_management);
            this.Controls.Add(this.button2Home);
            this.Controls.Add(this.buttonGestionCommande);
            this.Controls.Add(this.buttonGestionStock);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SudoForm1";
            this.Text = "Kitbox";
            this.Load += new System.EventHandler(this.SudoForm1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGestionStock;
        private System.Windows.Forms.Button buttonGestionCommande;
        private System.Windows.Forms.Button button2Home;
        private System.Windows.Forms.Button button1_Catalog_management;
    }
}