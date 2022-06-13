
namespace WindowsFormsApp1
{
    partial class Summary
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
            this.labelSuccess = new System.Windows.Forms.Label();
            this.labelSummary = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelInputTotal = new System.Windows.Forms.Label();
            this.labelInputPhone = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInputName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDetailedSummary = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.Font = new System.Drawing.Font("Niagara Engraved", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuccess.Location = new System.Drawing.Point(129, 19);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(303, 68);
            this.labelSuccess.TabIndex = 0;
            this.labelSuccess.Text = "Payment Success!";
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSummary.Location = new System.Drawing.Point(168, 87);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(217, 36);
            this.labelSummary.TabIndex = 1;
            this.labelSummary.Text = "Order Summary";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.57547F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.42453F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel1.Controls.Add(this.labelInputTotal, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelInputPhone, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTotal, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPhone, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelInputName, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 145);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(563, 87);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // labelInputTotal
            // 
            this.labelInputTotal.AutoSize = true;
            this.labelInputTotal.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputTotal.Location = new System.Drawing.Point(403, 43);
            this.labelInputTotal.Name = "labelInputTotal";
            this.labelInputTotal.Size = new System.Drawing.Size(0, 28);
            this.labelInputTotal.TabIndex = 5;
            // 
            // labelInputPhone
            // 
            this.labelInputPhone.AutoSize = true;
            this.labelInputPhone.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputPhone.Location = new System.Drawing.Point(181, 43);
            this.labelInputPhone.Name = "labelInputPhone";
            this.labelInputPhone.Size = new System.Drawing.Size(0, 28);
            this.labelInputPhone.TabIndex = 4;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(403, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(142, 29);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "Order Total";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(181, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(180, 29);
            this.labelPhone.TabIndex = 1;
            this.labelPhone.Text = "Phone Number";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(77, 29);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelInputName
            // 
            this.labelInputName.AutoSize = true;
            this.labelInputName.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputName.Location = new System.Drawing.Point(3, 43);
            this.labelInputName.Name = "labelInputName";
            this.labelInputName.Size = new System.Drawing.Size(0, 28);
            this.labelInputName.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 87);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonDetailedSummary
            // 
            this.buttonDetailedSummary.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetailedSummary.Location = new System.Drawing.Point(190, 258);
            this.buttonDetailedSummary.Name = "buttonDetailedSummary";
            this.buttonDetailedSummary.Size = new System.Drawing.Size(226, 34);
            this.buttonDetailedSummary.TabIndex = 7;
            this.buttonDetailedSummary.Text = "View Detailed Summary";
            this.buttonDetailedSummary.UseVisualStyleBackColor = true;
            this.buttonDetailedSummary.Click += new System.EventHandler(this.buttonDetailedSummary_Click);
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 304);
            this.Controls.Add(this.buttonDetailedSummary);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelSummary);
            this.Controls.Add(this.labelSuccess);
            this.Controls.Add(this.groupBox1);
            this.Name = "Summary";
            this.Text = "Summary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Summary_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSuccess;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInputTotal;
        private System.Windows.Forms.Label labelInputPhone;
        private System.Windows.Forms.Label labelInputName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDetailedSummary;
    }
}