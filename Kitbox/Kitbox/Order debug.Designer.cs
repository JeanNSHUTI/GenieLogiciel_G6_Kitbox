namespace Kitbox
{
    partial class Order_debug
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.checkBox_paid = new System.Windows.Forms.CheckBox();
            this.checkBox_delivered = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 79);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(710, 567);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // checkBox_paid
            // 
            this.checkBox_paid.AutoSize = true;
            this.checkBox_paid.Enabled = false;
            this.checkBox_paid.Location = new System.Drawing.Point(577, 21);
            this.checkBox_paid.Name = "checkBox_paid";
            this.checkBox_paid.Size = new System.Drawing.Size(88, 17);
            this.checkBox_paid.TabIndex = 1;
            this.checkBox_paid.Text = "Mark as Paid";
            this.checkBox_paid.UseVisualStyleBackColor = true;
            this.checkBox_paid.Visible = false;
            this.checkBox_paid.CheckedChanged += new System.EventHandler(this.checkBox_paid_CheckedChanged);
            // 
            // checkBox_delivered
            // 
            this.checkBox_delivered.AutoSize = true;
            this.checkBox_delivered.Enabled = false;
            this.checkBox_delivered.Location = new System.Drawing.Point(577, 56);
            this.checkBox_delivered.Name = "checkBox_delivered";
            this.checkBox_delivered.Size = new System.Drawing.Size(112, 17);
            this.checkBox_delivered.TabIndex = 2;
            this.checkBox_delivered.Text = "Mark as Delivered";
            this.checkBox_delivered.UseVisualStyleBackColor = true;
            this.checkBox_delivered.Visible = false;
            this.checkBox_delivered.CheckedChanged += new System.EventHandler(this.checkBox_delivered_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order details";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(600, 669);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(122, 23);
            this.btn_confirm.TabIndex = 4;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // Order_debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 713);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_delivered);
            this.Controls.Add(this.checkBox_paid);
            this.Controls.Add(this.listView1);
            this.Name = "Order_debug";
            this.Text = "Order_debug";
            this.Load += new System.EventHandler(this.Order_debug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox checkBox_paid;
        private System.Windows.Forms.CheckBox checkBox_delivered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_confirm;
    }
}