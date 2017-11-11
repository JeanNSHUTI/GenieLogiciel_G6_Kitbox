using System;

namespace Kitbox
{
    partial class Help_Form1
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
            this.label1_help1 = new System.Windows.Forms.Label();
            this.btn_skipto_catalog = new System.Windows.Forms.Button();
            this.label2_help1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1_help1
            // 
            this.label1_help1.AutoSize = true;
            this.label1_help1.Location = new System.Drawing.Point(53, 33);
            this.label1_help1.Name = "label1_help1";
            this.label1_help1.Size = new System.Drawing.Size(0, 13);
            this.label1_help1.TabIndex = 0;
            // 
            // btn_skipto_catalog
            // 
            this.btn_skipto_catalog.Location = new System.Drawing.Point(468, 267);
            this.btn_skipto_catalog.Name = "btn_skipto_catalog";
            this.btn_skipto_catalog.Size = new System.Drawing.Size(96, 23);
            this.btn_skipto_catalog.TabIndex = 2;
            this.btn_skipto_catalog.Text = "Skip to Catalog";
            this.btn_skipto_catalog.UseVisualStyleBackColor = true;
            this.btn_skipto_catalog.Click += new System.EventHandler(this.btn_skipto_catalog_Click);
            // 
            // label2_help1
            // 
            this.label2_help1.AutoSize = true;
            this.label2_help1.Location = new System.Drawing.Point(56, 80);
            this.label2_help1.Name = "label2_help1";
            this.label2_help1.Size = new System.Drawing.Size(0, 13);
            this.label2_help1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 10);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(553, 241);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Help_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 302);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2_help1);
            this.Controls.Add(this.btn_skipto_catalog);
            this.Controls.Add(this.label1_help1);
            this.Name = "Help_Form1";
            this.Text = "Kitbox - Help & Catalog";
            this.Load += new System.EventHandler(this.Help_Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1_help1;
        private System.Windows.Forms.Button btn_skipto_catalog;
        private System.Windows.Forms.Label label2_help1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}