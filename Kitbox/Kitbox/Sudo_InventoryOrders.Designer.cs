namespace Kitbox
{
    partial class Sudo_InventoryOrders
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
            this.btn_Order = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_Back = new System.Windows.Forms.Button();
            this.txtBx_Namesearch = new System.Windows.Forms.TextBox();
            this.txtBx_codesearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ManageOrders = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Order
            // 
            this.btn_Order.Location = new System.Drawing.Point(852, 551);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(108, 23);
            this.btn_Order.TabIndex = 0;
            this.btn_Order.Text = "Order";
            this.btn_Order.UseVisualStyleBackColor = true;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(796, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(15, 165);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(950, 346);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(15, 551);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(108, 23);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // txtBx_Namesearch
            // 
            this.txtBx_Namesearch.Location = new System.Drawing.Point(210, 23);
            this.txtBx_Namesearch.Name = "txtBx_Namesearch";
            this.txtBx_Namesearch.Size = new System.Drawing.Size(119, 20);
            this.txtBx_Namesearch.TabIndex = 6;
            this.txtBx_Namesearch.TextChanged += new System.EventHandler(this.txtBx_Namesearch_TextChanged);
            // 
            // txtBx_codesearch
            // 
            this.txtBx_codesearch.Location = new System.Drawing.Point(210, 63);
            this.txtBx_codesearch.Name = "txtBx_codesearch";
            this.txtBx_codesearch.Size = new System.Drawing.Size(119, 20);
            this.txtBx_codesearch.TabIndex = 7;
            this.txtBx_codesearch.TextChanged += new System.EventHandler(this.txtBx_codesearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Search by Name of Elements";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Search by Code";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(841, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Find Elements";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(808, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Search for elemets up for order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            // 
            // btn_ManageOrders
            // 
            this.btn_ManageOrders.Location = new System.Drawing.Point(841, 20);
            this.btn_ManageOrders.Name = "btn_ManageOrders";
            this.btn_ManageOrders.Size = new System.Drawing.Size(119, 23);
            this.btn_ManageOrders.TabIndex = 13;
            this.btn_ManageOrders.Text = "Orders";
            this.btn_ManageOrders.UseVisualStyleBackColor = true;
            this.btn_ManageOrders.Click += new System.EventHandler(this.btn_ManageOrders_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(294, 319);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 13);
            this.lbl_info.TabIndex = 14;
            // 
            // Sudo_InventoryOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 591);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_ManageOrders);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBx_codesearch);
            this.Controls.Add(this.txtBx_Namesearch);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Order);
            this.Name = "Sudo_InventoryOrders";
            this.Text = "Inventory Orders";
            this.Load += new System.EventHandler(this.Sudo_InventoryOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox txtBx_Namesearch;
        private System.Windows.Forms.TextBox txtBx_codesearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ManageOrders;
        private System.Windows.Forms.Label lbl_info;
    }
}