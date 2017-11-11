namespace Kitbox
{
    partial class Form3
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
            this.label1_form3 = new System.Windows.Forms.Label();
            this.label2_form3 = new System.Windows.Forms.Label();
            this.comboBx_RackHeight_form3 = new System.Windows.Forms.ComboBox();
            this.comboBx_NbrRacks_form3 = new System.Windows.Forms.ComboBox();
            this.label3_form3 = new System.Windows.Forms.Label();
            this.label4_form3 = new System.Windows.Forms.Label();
            this.label5_form3 = new System.Windows.Forms.Label();
            this.btn_next_form3 = new System.Windows.Forms.Button();
            this.btn_back_form3 = new System.Windows.Forms.Button();
            this.label2_form2 = new System.Windows.Forms.Label();
            this.checkBx_idmHeight_form3 = new System.Windows.Forms.CheckBox();
            this.WidthOfCabinet = new System.Windows.Forms.ComboBox();
            this.DepthOfCabinet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_form3
            // 
            this.label1_form3.AutoSize = true;
            this.label1_form3.Location = new System.Drawing.Point(9, 27);
            this.label1_form3.Name = "label1_form3";
            this.label1_form3.Size = new System.Drawing.Size(76, 13);
            this.label1_form3.TabIndex = 0;
            this.label1_form3.Text = "Cabinet details";
            this.label1_form3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2_form3
            // 
            this.label2_form3.AutoSize = true;
            this.label2_form3.Location = new System.Drawing.Point(13, 106);
            this.label2_form3.Name = "label2_form3";
            this.label2_form3.Size = new System.Drawing.Size(79, 13);
            this.label2_form3.TabIndex = 1;
            this.label2_form3.Text = "Height of racks";
            // 
            // comboBx_RackHeight_form3
            // 
            this.comboBx_RackHeight_form3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBx_RackHeight_form3.FormattingEnabled = true;
            this.comboBx_RackHeight_form3.Items.AddRange(new object[] {
            "32",
            "42",
            "52"});
            this.comboBx_RackHeight_form3.Location = new System.Drawing.Point(161, 98);
            this.comboBx_RackHeight_form3.Name = "comboBx_RackHeight_form3";
            this.comboBx_RackHeight_form3.Size = new System.Drawing.Size(121, 21);
            this.comboBx_RackHeight_form3.TabIndex = 2;
            this.comboBx_RackHeight_form3.SelectedIndexChanged += new System.EventHandler(this.comboBx_RackHeight_form3_SelectedIndexChanged);
            // 
            // comboBx_NbrRacks_form3
            // 
            this.comboBx_NbrRacks_form3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBx_NbrRacks_form3.FormattingEnabled = true;
            this.comboBx_NbrRacks_form3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBx_NbrRacks_form3.Location = new System.Drawing.Point(161, 141);
            this.comboBx_NbrRacks_form3.Name = "comboBx_NbrRacks_form3";
            this.comboBx_NbrRacks_form3.Size = new System.Drawing.Size(121, 21);
            this.comboBx_NbrRacks_form3.TabIndex = 3;
            this.comboBx_NbrRacks_form3.SelectedIndexChanged += new System.EventHandler(this.comboBx_NbrRacks_form3_SelectedIndexChanged);
            // 
            // label3_form3
            // 
            this.label3_form3.AutoSize = true;
            this.label3_form3.Location = new System.Drawing.Point(13, 149);
            this.label3_form3.Name = "label3_form3";
            this.label3_form3.Size = new System.Drawing.Size(85, 13);
            this.label3_form3.TabIndex = 4;
            this.label3_form3.Text = "Number of racks";
            // 
            // label4_form3
            // 
            this.label4_form3.AutoSize = true;
            this.label4_form3.Location = new System.Drawing.Point(13, 187);
            this.label4_form3.Name = "label4_form3";
            this.label4_form3.Size = new System.Drawing.Size(85, 13);
            this.label4_form3.TabIndex = 5;
            this.label4_form3.Text = "Width of cabinet";
            // 
            // label5_form3
            // 
            this.label5_form3.AutoSize = true;
            this.label5_form3.Location = new System.Drawing.Point(12, 227);
            this.label5_form3.Name = "label5_form3";
            this.label5_form3.Size = new System.Drawing.Size(86, 13);
            this.label5_form3.TabIndex = 7;
            this.label5_form3.Text = "Depth of cabinet";
            // 
            // btn_next_form3
            // 
            this.btn_next_form3.Location = new System.Drawing.Point(233, 285);
            this.btn_next_form3.Name = "btn_next_form3";
            this.btn_next_form3.Size = new System.Drawing.Size(75, 23);
            this.btn_next_form3.TabIndex = 10;
            this.btn_next_form3.Text = "Next";
            this.btn_next_form3.UseVisualStyleBackColor = true;
            this.btn_next_form3.Click += new System.EventHandler(this.btn_next_form3_Click);
            // 
            // btn_back_form3
            // 
            this.btn_back_form3.Location = new System.Drawing.Point(12, 285);
            this.btn_back_form3.Name = "btn_back_form3";
            this.btn_back_form3.Size = new System.Drawing.Size(75, 23);
            this.btn_back_form3.TabIndex = 11;
            this.btn_back_form3.Text = "Back";
            this.btn_back_form3.UseVisualStyleBackColor = true;
            this.btn_back_form3.Click += new System.EventHandler(this.btn_back_form3_Click);
            // 
            // label2_form2
            // 
            this.label2_form2.AutoSize = true;
            this.label2_form2.Location = new System.Drawing.Point(13, 68);
            this.label2_form2.Name = "label2_form2";
            this.label2_form2.Size = new System.Drawing.Size(123, 13);
            this.label2_form2.TabIndex = 12;
            this.label2_form2.Text = "Identical height for racks";
            // 
            // checkBx_idmHeight_form3
            // 
            this.checkBx_idmHeight_form3.AutoSize = true;
            this.checkBx_idmHeight_form3.Location = new System.Drawing.Point(161, 68);
            this.checkBx_idmHeight_form3.Name = "checkBx_idmHeight_form3";
            this.checkBx_idmHeight_form3.Size = new System.Drawing.Size(15, 14);
            this.checkBx_idmHeight_form3.TabIndex = 13;
            this.checkBx_idmHeight_form3.UseVisualStyleBackColor = true;
            this.checkBx_idmHeight_form3.CheckedChanged += new System.EventHandler(this.checkBx_idmHeight_form3_CheckedChanged_1);
            // 
            // WidthOfCabinet
            // 
            this.WidthOfCabinet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WidthOfCabinet.FormattingEnabled = true;
            this.WidthOfCabinet.Items.AddRange(new object[] {
            "32",
            "42",
            "52",
            "62",
            "80",
            "100",
            "120"});
            this.WidthOfCabinet.Location = new System.Drawing.Point(161, 184);
            this.WidthOfCabinet.Name = "WidthOfCabinet";
            this.WidthOfCabinet.Size = new System.Drawing.Size(121, 21);
            this.WidthOfCabinet.TabIndex = 14;
            this.WidthOfCabinet.SelectedIndexChanged += new System.EventHandler(this.WidthOfCabinet_SelectedIndexChanged);
            // 
            // DepthOfCabinet
            // 
            this.DepthOfCabinet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepthOfCabinet.FormattingEnabled = true;
            this.DepthOfCabinet.Items.AddRange(new object[] {
            "32",
            "42",
            "52",
            "62"});
            this.DepthOfCabinet.Location = new System.Drawing.Point(161, 219);
            this.DepthOfCabinet.Name = "DepthOfCabinet";
            this.DepthOfCabinet.Size = new System.Drawing.Size(121, 21);
            this.DepthOfCabinet.TabIndex = 15;
            this.DepthOfCabinet.SelectedIndexChanged += new System.EventHandler(this.DepthOfCabinet_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 17;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DepthOfCabinet);
            this.Controls.Add(this.WidthOfCabinet);
            this.Controls.Add(this.checkBx_idmHeight_form3);
            this.Controls.Add(this.label2_form2);
            this.Controls.Add(this.btn_back_form3);
            this.Controls.Add(this.btn_next_form3);
            this.Controls.Add(this.label5_form3);
            this.Controls.Add(this.label4_form3);
            this.Controls.Add(this.label3_form3);
            this.Controls.Add(this.comboBx_NbrRacks_form3);
            this.Controls.Add(this.comboBx_RackHeight_form3);
            this.Controls.Add(this.label2_form3);
            this.Controls.Add(this.label1_form3);
            this.Name = "Form3";
            this.Text = "Kitbox - Cabinet details";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_form3;
        private System.Windows.Forms.Label label2_form3;
        private System.Windows.Forms.ComboBox comboBx_RackHeight_form3;
        private System.Windows.Forms.ComboBox comboBx_NbrRacks_form3;
        private System.Windows.Forms.Label label3_form3;
        private System.Windows.Forms.Label label4_form3;
        private System.Windows.Forms.Label label5_form3;
        private System.Windows.Forms.Button btn_next_form3;
        private System.Windows.Forms.Button btn_back_form3;
        private System.Windows.Forms.Label label2_form2;
        private System.Windows.Forms.ComboBox WidthOfCabinet;
        private System.Windows.Forms.ComboBox DepthOfCabinet;
        private System.Windows.Forms.CheckBox checkBx_idmHeight_form3;
        private System.Windows.Forms.Label label2;
    }
}