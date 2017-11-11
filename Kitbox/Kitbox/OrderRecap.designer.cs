namespace Kitbox
{
    partial class OrderRecap
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
            this.btn_ConfirmRecap = new System.Windows.Forms.Button();
            this.btn_back_recap = new System.Windows.Forms.Button();
            this.btn_Edit_personalDetails = new System.Windows.Forms.Button();
            this.lbl_recap_order = new System.Windows.Forms.Label();
            this.lbl_recap_personDetails = new System.Windows.Forms.Label();
            this.listView_Clientdetails = new System.Windows.Forms.ListView();
            this.listView_Order = new System.Windows.Forms.ListView();
            this.btn_Delete_recap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ConfirmRecap
            // 
            this.btn_ConfirmRecap.Location = new System.Drawing.Point(595, 480);
            this.btn_ConfirmRecap.Name = "btn_ConfirmRecap";
            this.btn_ConfirmRecap.Size = new System.Drawing.Size(101, 23);
            this.btn_ConfirmRecap.TabIndex = 0;
            this.btn_ConfirmRecap.Text = "Confirm";
            this.btn_ConfirmRecap.UseVisualStyleBackColor = true;
            this.btn_ConfirmRecap.Click += new System.EventHandler(this.btn_ConfirmRecap_Click);
            // 
            // btn_back_recap
            // 
            this.btn_back_recap.Location = new System.Drawing.Point(19, 480);
            this.btn_back_recap.Name = "btn_back_recap";
            this.btn_back_recap.Size = new System.Drawing.Size(101, 23);
            this.btn_back_recap.TabIndex = 1;
            this.btn_back_recap.Text = "Back";
            this.btn_back_recap.UseVisualStyleBackColor = true;
            this.btn_back_recap.Click += new System.EventHandler(this.precedentRecap_Click);
            // 
            // btn_Edit_personalDetails
            // 
            this.btn_Edit_personalDetails.Location = new System.Drawing.Point(595, 29);
            this.btn_Edit_personalDetails.Name = "btn_Edit_personalDetails";
            this.btn_Edit_personalDetails.Size = new System.Drawing.Size(101, 23);
            this.btn_Edit_personalDetails.TabIndex = 7;
            this.btn_Edit_personalDetails.Text = "Edit details";
            this.btn_Edit_personalDetails.UseVisualStyleBackColor = true;
            this.btn_Edit_personalDetails.Click += new System.EventHandler(this.btn_Edit_personalDetails_Click);
            // 
            // lbl_recap_order
            // 
            this.lbl_recap_order.AutoSize = true;
            this.lbl_recap_order.Location = new System.Drawing.Point(19, 152);
            this.lbl_recap_order.Name = "lbl_recap_order";
            this.lbl_recap_order.Size = new System.Drawing.Size(79, 13);
            this.lbl_recap_order.TabIndex = 8;
            this.lbl_recap_order.Text = "Order Summary";
            // 
            // lbl_recap_personDetails
            // 
            this.lbl_recap_personDetails.AutoSize = true;
            this.lbl_recap_personDetails.Location = new System.Drawing.Point(19, 34);
            this.lbl_recap_personDetails.Name = "lbl_recap_personDetails";
            this.lbl_recap_personDetails.Size = new System.Drawing.Size(83, 13);
            this.lbl_recap_personDetails.TabIndex = 9;
            this.lbl_recap_personDetails.Text = "Personal Details";
            // 
            // listView_Clientdetails
            // 
            this.listView_Clientdetails.Location = new System.Drawing.Point(19, 57);
            this.listView_Clientdetails.MultiSelect = false;
            this.listView_Clientdetails.Name = "listView_Clientdetails";
            this.listView_Clientdetails.Size = new System.Drawing.Size(677, 65);
            this.listView_Clientdetails.TabIndex = 10;
            this.listView_Clientdetails.UseCompatibleStateImageBehavior = false;
            this.listView_Clientdetails.SelectedIndexChanged += new System.EventHandler(this.listView_Clientdetails_SelectedIndexChanged);
            // 
            // listView_Order
            // 
            this.listView_Order.Location = new System.Drawing.Point(19, 176);
            this.listView_Order.MultiSelect = false;
            this.listView_Order.Name = "listView_Order";
            this.listView_Order.Size = new System.Drawing.Size(677, 283);
            this.listView_Order.TabIndex = 11;
            this.listView_Order.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Delete_recap
            // 
            this.btn_Delete_recap.Location = new System.Drawing.Point(595, 147);
            this.btn_Delete_recap.Name = "btn_Delete_recap";
            this.btn_Delete_recap.Size = new System.Drawing.Size(101, 23);
            this.btn_Delete_recap.TabIndex = 5;
            this.btn_Delete_recap.Text = "Full listing";
            this.btn_Delete_recap.UseVisualStyleBackColor = true;
            this.btn_Delete_recap.Click += new System.EventHandler(this.btn_Delete_recap_Click);
            // 
            // OrderRecap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 515);
            this.Controls.Add(this.listView_Order);
            this.Controls.Add(this.listView_Clientdetails);
            this.Controls.Add(this.lbl_recap_personDetails);
            this.Controls.Add(this.lbl_recap_order);
            this.Controls.Add(this.btn_Edit_personalDetails);
            this.Controls.Add(this.btn_Delete_recap);
            this.Controls.Add(this.btn_back_recap);
            this.Controls.Add(this.btn_ConfirmRecap);
            this.Name = "OrderRecap";
            this.Text = "Recapitulation";
            this.Load += new System.EventHandler(this.OrderRecap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ConfirmRecap;
        private System.Windows.Forms.Button btn_back_recap;
        private System.Windows.Forms.Button btn_Edit_personalDetails;
        private System.Windows.Forms.Label lbl_recap_order;
        private System.Windows.Forms.Label lbl_recap_personDetails;
        private System.Windows.Forms.ListView listView_Clientdetails;
        private System.Windows.Forms.ListView listView_Order;
        private System.Windows.Forms.Button btn_Delete_recap;
    }
}