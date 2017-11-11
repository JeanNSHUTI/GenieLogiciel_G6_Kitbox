namespace Kitbox
{
    partial class Sudo_Catalog_management
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
            this.listView1_Add = new System.Windows.Forms.ListView();
            this.columnNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDimensions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDepth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWidth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnInStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMinStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCustomerPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumberOfPart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSupplierPrice1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSupplierTime1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSupplierPrice2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSupplierTime2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1_Remove = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3_Edit = new System.Windows.Forms.Button();
            this.button4_back = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1_Add
            // 
            this.listView1_Add.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumber,
            this.columnCode,
            this.columnName,
            this.columnDimensions,
            this.columnHeight,
            this.columnDepth,
            this.columnWidth,
            this.columnColor,
            this.columnInStock,
            this.columnMinStock,
            this.columnCustomerPrice,
            this.columnNumberOfPart,
            this.columnSupplierPrice1,
            this.columnSupplierTime1,
            this.columnSupplierPrice2,
            this.columnSupplierTime2});
            this.listView1_Add.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.listView1_Add.Location = new System.Drawing.Point(0, 1);
            this.listView1_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1_Add.MultiSelect = false;
            this.listView1_Add.Name = "listView1_Add";
            this.listView1_Add.Size = new System.Drawing.Size(893, 465);
            this.listView1_Add.TabIndex = 0;
            this.listView1_Add.UseCompatibleStateImageBehavior = false;
            this.listView1_Add.View = System.Windows.Forms.View.Details;
            this.listView1_Add.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnNumber
            // 
            this.columnNumber.Text = "N°";
            this.columnNumber.Width = 44;
            // 
            // columnCode
            // 
            this.columnCode.Text = "Code";
            this.columnCode.Width = 88;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 89;
            // 
            // columnDimensions
            // 
            this.columnDimensions.Text = "Dimensions";
            this.columnDimensions.Width = 91;
            // 
            // columnHeight
            // 
            this.columnHeight.Text = "Height";
            this.columnHeight.Width = 0;
            // 
            // columnDepth
            // 
            this.columnDepth.Text = "Depth";
            this.columnDepth.Width = 0;
            // 
            // columnWidth
            // 
            this.columnWidth.Text = "Width";
            this.columnWidth.Width = 0;
            // 
            // columnColor
            // 
            this.columnColor.Text = "Color";
            this.columnColor.Width = 95;
            // 
            // columnInStock
            // 
            this.columnInStock.Text = "InStock";
            this.columnInStock.Width = 75;
            // 
            // columnMinStock
            // 
            this.columnMinStock.Text = "MinStock";
            this.columnMinStock.Width = 0;
            // 
            // columnCustomerPrice
            // 
            this.columnCustomerPrice.Text = "CustomerPrice";
            this.columnCustomerPrice.Width = 109;
            // 
            // columnNumberOfPart
            // 
            this.columnNumberOfPart.Text = "Qty/Rack";
            // 
            // columnSupplierPrice1
            // 
            this.columnSupplierPrice1.Text = "Supplier1Price";
            this.columnSupplierPrice1.Width = 90;
            // 
            // columnSupplierTime1
            // 
            this.columnSupplierTime1.Text = "Supplier1Delay";
            this.columnSupplierTime1.Width = 90;
            // 
            // columnSupplierPrice2
            // 
            this.columnSupplierPrice2.Text = "Supplier2Price";
            this.columnSupplierPrice2.Width = 90;
            // 
            // columnSupplierTime2
            // 
            this.columnSupplierTime2.Text = "Supplier2Delay";
            this.columnSupplierTime2.Width = 90;
            // 
            // button1_Remove
            // 
            this.button1_Remove.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_Remove.Location = new System.Drawing.Point(932, 35);
            this.button1_Remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1_Remove.Name = "button1_Remove";
            this.button1_Remove.Size = new System.Drawing.Size(120, 22);
            this.button1_Remove.TabIndex = 1;
            this.button1_Remove.Text = "Remove";
            this.button1_Remove.UseVisualStyleBackColor = true;
            this.button1_Remove.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.button2.Location = new System.Drawing.Point(932, 77);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3_Edit
            // 
            this.button3_Edit.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.button3_Edit.Location = new System.Drawing.Point(932, 116);
            this.button3_Edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3_Edit.Name = "button3_Edit";
            this.button3_Edit.Size = new System.Drawing.Size(120, 23);
            this.button3_Edit.TabIndex = 3;
            this.button3_Edit.Text = "Edit";
            this.button3_Edit.UseVisualStyleBackColor = true;
            this.button3_Edit.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4_back
            // 
            this.button4_back.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.button4_back.Location = new System.Drawing.Point(932, 433);
            this.button4_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4_back.Name = "button4_back";
            this.button4_back.Size = new System.Drawing.Size(120, 23);
            this.button4_back.TabIndex = 4;
            this.button4_back.Text = "Back";
            this.button4_back.UseVisualStyleBackColor = true;
            this.button4_back.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(948, 170);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.button5.Location = new System.Drawing.Point(932, 217);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(929, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(929, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search for a code";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(929, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(929, 356);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 10;
            // 
            // Sudo_Catalog_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1097, 467);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4_back);
            this.Controls.Add(this.button3_Edit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1_Remove);
            this.Controls.Add(this.listView1_Add);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Sudo_Catalog_management";
            this.Text = "Sudo_Catalog_management";
            this.Load += new System.EventHandler(this.Sudo_Catalog_management_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1_Add;
        private System.Windows.Forms.Button button1_Remove;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3_Edit;
        private System.Windows.Forms.Button button4_back;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnNumber;
        private System.Windows.Forms.ColumnHeader columnCode;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnDimensions;
        private System.Windows.Forms.ColumnHeader columnHeight;
        private System.Windows.Forms.ColumnHeader columnDepth;
        private System.Windows.Forms.ColumnHeader columnWidth;
        private System.Windows.Forms.ColumnHeader columnColor;
        private System.Windows.Forms.ColumnHeader columnInStock;
        private System.Windows.Forms.ColumnHeader columnMinStock;
        private System.Windows.Forms.ColumnHeader columnCustomerPrice;
        private System.Windows.Forms.ColumnHeader columnNumberOfPart;
        private System.Windows.Forms.ColumnHeader columnSupplierPrice1;
        private System.Windows.Forms.ColumnHeader columnSupplierTime1;
        private System.Windows.Forms.ColumnHeader columnSupplierPrice2;
        private System.Windows.Forms.ColumnHeader columnSupplierTime2;
    }
}