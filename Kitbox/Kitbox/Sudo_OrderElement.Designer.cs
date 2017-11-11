namespace Kitbox
{
    partial class Sudo_OrderElement
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
            this.rtb_element = new System.Windows.Forms.RichTextBox();
            this.rtb_Supplier = new System.Windows.Forms.RichTextBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.txtBx_qty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb_element
            // 
            this.rtb_element.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_element.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtb_element.Location = new System.Drawing.Point(12, 75);
            this.rtb_element.Name = "rtb_element";
            this.rtb_element.ReadOnly = true;
            this.rtb_element.Size = new System.Drawing.Size(356, 112);
            this.rtb_element.TabIndex = 10;
            this.rtb_element.Text = "";
            this.rtb_element.TextChanged += new System.EventHandler(this.rtb_element_TextChanged);
            // 
            // rtb_Supplier
            // 
            this.rtb_Supplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Supplier.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtb_Supplier.Location = new System.Drawing.Point(12, 205);
            this.rtb_Supplier.Name = "rtb_Supplier";
            this.rtb_Supplier.ReadOnly = true;
            this.rtb_Supplier.Size = new System.Drawing.Size(356, 124);
            this.rtb_Supplier.TabIndex = 1;
            this.rtb_Supplier.Text = "";
            this.rtb_Supplier.TextChanged += new System.EventHandler(this.rtb_Supplier_TextChanged);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(15, 356);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(100, 23);
            this.buttonOrder.TabIndex = 2;
            this.buttonOrder.Text = "Order";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // txtBx_qty
            // 
            this.txtBx_qty.Location = new System.Drawing.Point(12, 35);
            this.txtBx_qty.Name = "txtBx_qty";
            this.txtBx_qty.Size = new System.Drawing.Size(100, 20);
            this.txtBx_qty.TabIndex = 3;
            this.txtBx_qty.TextChanged += new System.EventHandler(this.txtBx_qty_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantity of Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please choose a quantity for your order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 11;
            // 
            // Sudo_OrderElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 391);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBx_qty);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.rtb_Supplier);
            this.Controls.Add(this.rtb_element);
            this.Name = "Sudo_OrderElement";
            this.Text = "Sudo_OrderElement";
            this.Load += new System.EventHandler(this.Sudo_OrderElement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_element;
        private System.Windows.Forms.RichTextBox rtb_Supplier;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.TextBox txtBx_qty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}