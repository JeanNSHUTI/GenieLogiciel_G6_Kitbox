namespace Kitbox
{
    partial class ConfirmOrder
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
            this.label1_Printing = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_Printing
            // 
            this.label1_Printing.AutoSize = true;
            this.label1_Printing.Location = new System.Drawing.Point(95, 39);
            this.label1_Printing.Name = "label1_Printing";
            this.label1_Printing.Size = new System.Drawing.Size(51, 13);
            this.label1_Printing.TabIndex = 1;
            this.label1_Printing.Text = "Printing...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // ConfirmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 136);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label1_Printing);
            this.Name = "ConfirmOrder";
            this.Text = "Kitbox - Print";
            this.Load += new System.EventHandler(this.ConfirmOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1_Printing;
        private System.Windows.Forms.Label label1;
    }
}