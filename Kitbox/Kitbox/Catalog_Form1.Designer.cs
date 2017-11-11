namespace Kitbox
{
    partial class Catalog_Form1
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
            this.listView_catalog = new System.Windows.Forms.ListView();
            this.btn_backToForm1 = new System.Windows.Forms.Button();
            this.btn_BackToHelp = new System.Windows.Forms.Button();
            this.lbl_Catalog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView_catalog
            // 
            this.listView_catalog.Location = new System.Drawing.Point(12, 75);
            this.listView_catalog.Name = "listView_catalog";
            this.listView_catalog.Size = new System.Drawing.Size(691, 324);
            this.listView_catalog.TabIndex = 0;
            this.listView_catalog.UseCompatibleStateImageBehavior = false;
            // 
            // btn_backToForm1
            // 
            this.btn_backToForm1.Location = new System.Drawing.Point(574, 429);
            this.btn_backToForm1.Name = "btn_backToForm1";
            this.btn_backToForm1.Size = new System.Drawing.Size(129, 23);
            this.btn_backToForm1.TabIndex = 1;
            this.btn_backToForm1.Text = "Finished";
            this.btn_backToForm1.UseVisualStyleBackColor = true;
            this.btn_backToForm1.Click += new System.EventHandler(this.btn_backToForm1_Click);
            // 
            // btn_BackToHelp
            // 
            this.btn_BackToHelp.Location = new System.Drawing.Point(12, 429);
            this.btn_BackToHelp.Name = "btn_BackToHelp";
            this.btn_BackToHelp.Size = new System.Drawing.Size(119, 23);
            this.btn_BackToHelp.TabIndex = 2;
            this.btn_BackToHelp.Text = "Back";
            this.btn_BackToHelp.UseVisualStyleBackColor = true;
            this.btn_BackToHelp.Click += new System.EventHandler(this.btn_BackToHelp_Click);
            // 
            // lbl_Catalog
            // 
            this.lbl_Catalog.AutoSize = true;
            this.lbl_Catalog.Location = new System.Drawing.Point(12, 29);
            this.lbl_Catalog.Name = "lbl_Catalog";
            this.lbl_Catalog.Size = new System.Drawing.Size(43, 13);
            this.lbl_Catalog.TabIndex = 4;
            this.lbl_Catalog.Text = "Catalog";
            // 
            // Catalog_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 464);
            this.Controls.Add(this.lbl_Catalog);
            this.Controls.Add(this.btn_BackToHelp);
            this.Controls.Add(this.btn_backToForm1);
            this.Controls.Add(this.listView_catalog);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Catalog_Form1";
            this.Text = "Catalog_Form1";
            this.Load += new System.EventHandler(this.Catalog_Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_catalog;
        private System.Windows.Forms.Button btn_backToForm1;
        private System.Windows.Forms.Button btn_BackToHelp;
        private System.Windows.Forms.Label lbl_Catalog;
    }
}