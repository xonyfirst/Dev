namespace BankSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.iban_det = new System.Windows.Forms.TextBox();
            this.show_name = new System.Windows.Forms.Label();
            this.show_money = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Deposite";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 85);
            this.button2.TabIndex = 0;
            this.button2.Text = "Create Account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 85);
            this.button3.TabIndex = 0;
            this.button3.Text = "Transfer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(424, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 45);
            this.button4.TabIndex = 1;
            this.button4.Text = "Show Detail";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // iban_det
            // 
            this.iban_det.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iban_det.Location = new System.Drawing.Point(389, 105);
            this.iban_det.Name = "iban_det";
            this.iban_det.Size = new System.Drawing.Size(218, 33);
            this.iban_det.TabIndex = 2;
            // 
            // show_name
            // 
            this.show_name.AutoSize = true;
            this.show_name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.show_name.Location = new System.Drawing.Point(404, 164);
            this.show_name.Name = "show_name";
            this.show_name.Size = new System.Drawing.Size(20, 25);
            this.show_name.TabIndex = 3;
            this.show_name.Text = "-";
            // 
            // show_money
            // 
            this.show_money.AutoSize = true;
            this.show_money.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.show_money.Location = new System.Drawing.Point(404, 213);
            this.show_money.Name = "show_money";
            this.show_money.Size = new System.Drawing.Size(20, 25);
            this.show_money.TabIndex = 4;
            this.show_money.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(465, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "IBAN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 365);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.show_money);
            this.Controls.Add(this.show_name);
            this.Controls.Add(this.iban_det);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "Bank System";
            this.Load += new System.EventHandler(this.Form1_Load);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox iban_det;
        private System.Windows.Forms.Label show_name;
        private System.Windows.Forms.Label show_money;
        private System.Windows.Forms.Label label3;
    }
}

