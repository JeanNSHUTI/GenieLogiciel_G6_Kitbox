namespace Kitbox
{
    partial class Sudo_ManageInventory
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
            this.listV_InventOrders = new System.Windows.Forms.ListView();
            this.btn_applyChanges = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.btn_Find = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listV_InventOrders
            // 
            this.listV_InventOrders.CheckBoxes = true;
            this.listV_InventOrders.Location = new System.Drawing.Point(12, 92);
            this.listV_InventOrders.Name = "listV_InventOrders";
            this.listV_InventOrders.Size = new System.Drawing.Size(735, 305);
            this.listV_InventOrders.TabIndex = 0;
            this.listV_InventOrders.UseCompatibleStateImageBehavior = false;
            // 
            // btn_applyChanges
            // 
            this.btn_applyChanges.Location = new System.Drawing.Point(630, 449);
            this.btn_applyChanges.Name = "btn_applyChanges";
            this.btn_applyChanges.Size = new System.Drawing.Size(123, 23);
            this.btn_applyChanges.TabIndex = 1;
            this.btn_applyChanges.Text = "Save";
            this.btn_applyChanges.UseVisualStyleBackColor = true;
            this.btn_applyChanges.Click += new System.EventHandler(this.btn_applyChanges_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of Orders not yet received";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mark orders as received";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = " \' Check \' an order as received";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(624, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Search by Order ID";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(293, 225);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 13);
            this.lbl_info.TabIndex = 7;
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(624, 63);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(124, 23);
            this.btn_Find.TabIndex = 8;
            this.btn_Find.Text = "Find All";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // Sudo_ManageInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 484);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_applyChanges);
            this.Controls.Add(this.listV_InventOrders);
            this.Name = "Sudo_ManageInventory";
            this.Text = "Sudo_ManageInventory";
            this.Load += new System.EventHandler(this.Sudo_ManageInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listV_InventOrders;
        private System.Windows.Forms.Button btn_applyChanges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Button btn_Find;
    }
}