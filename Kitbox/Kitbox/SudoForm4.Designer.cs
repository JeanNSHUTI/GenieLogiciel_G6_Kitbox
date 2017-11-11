namespace Kitbox
{
    partial class SudoForm4
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBx_FirstN = new System.Windows.Forms.ComboBox();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1Back = new System.Windows.Forms.Button();
            this.comboBx_LastN = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView_active = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView_passive = new System.Windows.Forms.ListView();
            this.btn_treat = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.txtBx_ID = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBx_FirstN
            // 
            this.comboBx_FirstN.FormattingEnabled = true;
            this.comboBx_FirstN.Location = new System.Drawing.Point(77, 60);
            this.comboBx_FirstN.Name = "comboBx_FirstN";
            this.comboBx_FirstN.Size = new System.Drawing.Size(121, 21);
            this.comboBx_FirstN.TabIndex = 2;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(77, 155);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(121, 23);
            this.buttonRechercher.TabIndex = 3;
            this.buttonRechercher.Text = "Search";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "List of commands";
            // 
            // button1Back
            // 
            this.button1Back.Location = new System.Drawing.Point(19, 494);
            this.button1Back.Name = "button1Back";
            this.button1Back.Size = new System.Drawing.Size(121, 23);
            this.button1Back.TabIndex = 6;
            this.button1Back.Text = "Back";
            this.button1Back.UseVisualStyleBackColor = true;
            this.button1Back.Click += new System.EventHandler(this.button1Back_Click);
            // 
            // comboBx_LastN
            // 
            this.comboBx_LastN.FormattingEnabled = true;
            this.comboBx_LastN.Location = new System.Drawing.Point(77, 87);
            this.comboBx_LastN.Name = "comboBx_LastN";
            this.comboBx_LastN.Size = new System.Drawing.Size(121, 21);
            this.comboBx_LastN.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "First name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Last name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Order ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(222, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 430);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView_active);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(548, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView_active
            // 
            this.listView_active.Location = new System.Drawing.Point(-4, -1);
            this.listView_active.Name = "listView_active";
            this.listView_active.Size = new System.Drawing.Size(556, 409);
            this.listView_active.TabIndex = 0;
            this.listView_active.UseCompatibleStateImageBehavior = false;
            this.listView_active.SelectedIndexChanged += new System.EventHandler(this.listView_active_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView_passive);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(548, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView_passive
            // 
            this.listView_passive.Location = new System.Drawing.Point(-4, -1);
            this.listView_passive.MultiSelect = false;
            this.listView_passive.Name = "listView_passive";
            this.listView_passive.Size = new System.Drawing.Size(556, 409);
            this.listView_passive.TabIndex = 0;
            this.listView_passive.UseCompatibleStateImageBehavior = false;
            // 
            // btn_treat
            // 
            this.btn_treat.Location = new System.Drawing.Point(77, 251);
            this.btn_treat.Name = "btn_treat";
            this.btn_treat.Size = new System.Drawing.Size(121, 23);
            this.btn_treat.TabIndex = 16;
            this.btn_treat.Text = "Treat";
            this.btn_treat.UseVisualStyleBackColor = true;
            this.btn_treat.Click += new System.EventHandler(this.btn_treat_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(77, 203);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(121, 23);
            this.btn_edit.TabIndex = 20;
            this.btn_edit.Text = "Edit order";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 21;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 22;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.ForeColor = System.Drawing.Color.Red;
            this.lbl_info.Location = new System.Drawing.Point(63, 184);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 13);
            this.lbl_info.TabIndex = 1;
            // 
            // txtBx_ID
            // 
            this.txtBx_ID.Location = new System.Drawing.Point(77, 115);
            this.txtBx_ID.Name = "txtBx_ID";
            this.txtBx_ID.Size = new System.Drawing.Size(121, 20);
            this.txtBx_ID.TabIndex = 23;
            // 
            // SudoForm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 529);
            this.Controls.Add(this.txtBx_ID);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_treat);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBx_LastN);
            this.Controls.Add(this.button1Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.comboBx_FirstN);
            this.Controls.Add(this.label1);
            this.Name = "SudoForm4";
            this.Text = "SudoForm4";
            this.Load += new System.EventHandler(this.SudoForm4_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBx_FirstN;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1Back;
        private System.Windows.Forms.ComboBox comboBx_LastN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView_active;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView_passive;
        private System.Windows.Forms.Button btn_treat;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBx_ID;
    }
}