
namespace WindowsFormsApp1
{
    partial class FoodOrder
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnBeverage = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.comboBoxFood = new System.Windows.Forms.ComboBox();
            this.comboBoxBeverages = new System.Windows.Forms.ComboBox();
            this.btnFood = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxPrice = new System.Windows.Forms.ListBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelItemNames = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.buttonClearCart = new System.Windows.Forms.Button();
            this.buttonClearSelected = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Beverages:";
            // 
            // btnBeverage
            // 
            this.btnBeverage.Location = new System.Drawing.Point(102, 226);
            this.btnBeverage.Name = "btnBeverage";
            this.btnBeverage.Size = new System.Drawing.Size(115, 25);
            this.btnBeverage.TabIndex = 4;
            this.btnBeverage.Text = "Add Beverage";
            this.btnBeverage.UseVisualStyleBackColor = true;
            this.btnBeverage.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(380, 276);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(182, 36);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "Continue To Pay";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxFood
            // 
            this.comboBoxFood.DisplayMember = "Select Food Items";
            this.comboBoxFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFood.FormattingEnabled = true;
            this.comboBoxFood.Location = new System.Drawing.Point(162, 65);
            this.comboBoxFood.Name = "comboBoxFood";
            this.comboBoxFood.Size = new System.Drawing.Size(183, 21);
            this.comboBoxFood.TabIndex = 6;
            // 
            // comboBoxBeverages
            // 
            this.comboBoxBeverages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBeverages.FormattingEnabled = true;
            this.comboBoxBeverages.Location = new System.Drawing.Point(162, 179);
            this.comboBoxBeverages.Name = "comboBoxBeverages";
            this.comboBoxBeverages.Size = new System.Drawing.Size(183, 21);
            this.comboBoxBeverages.TabIndex = 7;
            // 
            // btnFood
            // 
            this.btnFood.Location = new System.Drawing.Point(102, 116);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(115, 25);
            this.btnFood.TabIndex = 8;
            this.btnFood.Text = "Add Food";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel1.Controls.Add(this.listBoxPrice, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPrice, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelItemNames, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTotal, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.listBoxNames, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonClearCart, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(362, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.21739F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.78261F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 184);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // listBoxPrice
            // 
            this.listBoxPrice.FormattingEnabled = true;
            this.listBoxPrice.Location = new System.Drawing.Point(115, 26);
            this.listBoxPrice.Name = "listBoxPrice";
            this.listBoxPrice.Size = new System.Drawing.Size(82, 121);
            this.listBoxPrice.TabIndex = 13;
            this.listBoxPrice.Visible = false;
            this.listBoxPrice.SelectedIndexChanged += new System.EventHandler(this.listBoxPrice_SelectedIndexChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(115, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 20);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "Price";
            this.labelPrice.Visible = false;
            // 
            // labelItemNames
            // 
            this.labelItemNames.AutoSize = true;
            this.labelItemNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemNames.Location = new System.Drawing.Point(3, 0);
            this.labelItemNames.Name = "labelItemNames";
            this.labelItemNames.Size = new System.Drawing.Size(95, 20);
            this.labelItemNames.TabIndex = 10;
            this.labelItemNames.Text = "Item Names";
            this.labelItemNames.Visible = false;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(115, 156);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(48, 20);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total:";
            this.labelTotal.Visible = false;
            this.labelTotal.Click += new System.EventHandler(this.labelTotal_Click);
            // 
            // listBoxNames
            // 
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.Location = new System.Drawing.Point(3, 26);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(106, 121);
            this.listBoxNames.TabIndex = 12;
            this.listBoxNames.Visible = false;
            this.listBoxNames.SelectedIndexChanged += new System.EventHandler(this.listBoxNames_SelectedIndexChanged);
            // 
            // buttonClearCart
            // 
            this.buttonClearCart.Location = new System.Drawing.Point(3, 159);
            this.buttonClearCart.Name = "buttonClearCart";
            this.buttonClearCart.Size = new System.Drawing.Size(75, 22);
            this.buttonClearCart.TabIndex = 14;
            this.buttonClearCart.Text = "Clear Cart";
            this.buttonClearCart.UseVisualStyleBackColor = true;
            this.buttonClearCart.Visible = false;
            this.buttonClearCart.Click += new System.EventHandler(this.buttonClearCart_Click);
            // 
            // buttonClearSelected
            // 
            this.buttonClearSelected.Location = new System.Drawing.Point(300, 132);
            this.buttonClearSelected.Name = "buttonClearSelected";
            this.buttonClearSelected.Size = new System.Drawing.Size(45, 23);
            this.buttonClearSelected.TabIndex = 10;
            this.buttonClearSelected.Text = "<<";
            this.buttonClearSelected.UseVisualStyleBackColor = true;
            this.buttonClearSelected.Click += new System.EventHandler(this.buttonClearSelected_Click);
            // 
            // FoodOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 324);
            this.Controls.Add(this.buttonClearSelected);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnFood);
            this.Controls.Add(this.comboBoxBeverages);
            this.Controls.Add(this.comboBoxFood);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnBeverage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FoodOrder";
            this.Text = "TheFoodApp(OrderDetails)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBeverage;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.ComboBox comboBoxFood;
        private System.Windows.Forms.ComboBox comboBoxBeverages;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ListBox listBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelItemNames;
        private System.Windows.Forms.ListBox listBoxNames;
        private System.Windows.Forms.Button buttonClearCart;
        private System.Windows.Forms.Button buttonClearSelected;
    }
}