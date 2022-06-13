
namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAlternate = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAlternate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelName.Location = new System.Drawing.Point(69, 60);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 33);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelAge.Location = new System.Drawing.Point(69, 113);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(33, 13);
            this.labelAge.TabIndex = 1;
            this.labelAge.Text = "Age:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelPhone.Location = new System.Drawing.Point(69, 160);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(94, 13);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Phone Number:";
            // 
            // labelAlternate
            // 
            this.labelAlternate.AutoSize = true;
            this.labelAlternate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlternate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelAlternate.Location = new System.Drawing.Point(69, 207);
            this.labelAlternate.Name = "labelAlternate";
            this.labelAlternate.Size = new System.Drawing.Size(109, 13);
            this.labelAlternate.TabIndex = 3;
            this.labelAlternate.Text = "Alternate Number:";
            this.labelAlternate.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.Transparent;
            this.btnSignup.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSignup.Location = new System.Drawing.Point(72, 241);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(115, 43);
            this.btnSignup.TabIndex = 4;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Transparent;
            this.btnContinue.Location = new System.Drawing.Point(248, 241);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(125, 34);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "Sign in";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxName.Location = new System.Drawing.Point(209, 49);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(164, 29);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxAge
            // 
            this.textBoxAge.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAge.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxAge.Location = new System.Drawing.Point(209, 102);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(164, 29);
            this.textBoxAge.TabIndex = 7;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxPhone.Location = new System.Drawing.Point(209, 149);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(164, 29);
            this.textBoxPhone.TabIndex = 8;
            // 
            // textBoxAlternate
            // 
            this.textBoxAlternate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAlternate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlternate.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxAlternate.Location = new System.Drawing.Point(209, 196);
            this.textBoxAlternate.Name = "textBoxAlternate";
            this.textBoxAlternate.Size = new System.Drawing.Size(164, 29);
            this.textBoxAlternate.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Already a User?";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAlternate);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.labelAlternate);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = "TheFoodApp(User Details)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAlternate;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAlternate;
        private System.Windows.Forms.Label label1;
    }
}

