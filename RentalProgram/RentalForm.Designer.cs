namespace RentalProgram
{
    partial class RentalForm
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CalcButton = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.TotalRentalsTextBox = new System.Windows.Forms.TextBox();
            this.CustomersTextBox = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.AmountDueTextBox = new System.Windows.Forms.TextBox();
            this.DiscountTextBox = new System.Windows.Forms.TextBox();
            this.RentalTextBox = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(286, 256);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 18;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ClearButton.Location = new System.Drawing.Point(286, 222);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 17;
            this.ClearButton.Text = "C&lear";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CalcButton
            // 
            this.CalcButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CalcButton.Location = new System.Drawing.Point(286, 193);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 16;
            this.CalcButton.Text = "&Calculate";
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.TotalRentalsTextBox);
            this.GroupBox2.Controls.Add(this.CustomersTextBox);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Location = new System.Drawing.Point(35, 207);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(219, 90);
            this.GroupBox2.TabIndex = 15;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Summary";
            // 
            // TotalRentalsTextBox
            // 
            this.TotalRentalsTextBox.Location = new System.Drawing.Point(103, 54);
            this.TotalRentalsTextBox.Name = "TotalRentalsTextBox";
            this.TotalRentalsTextBox.ReadOnly = true;
            this.TotalRentalsTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalRentalsTextBox.TabIndex = 3;
            this.TotalRentalsTextBox.TabStop = false;
            this.TotalRentalsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CustomersTextBox
            // 
            this.CustomersTextBox.Location = new System.Drawing.Point(103, 28);
            this.CustomersTextBox.Name = "CustomersTextBox";
            this.CustomersTextBox.ReadOnly = true;
            this.CustomersTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomersTextBox.TabIndex = 1;
            this.CustomersTextBox.TabStop = false;
            this.CustomersTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(15, 54);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(70, 13);
            this.Label7.TabIndex = 2;
            this.Label7.Text = "Total Rentals";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(15, 25);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(83, 13);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Total Customers";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.AmountDueTextBox);
            this.GroupBox1.Controls.Add(this.DiscountTextBox);
            this.GroupBox1.Controls.Add(this.RentalTextBox);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Location = new System.Drawing.Point(34, 82);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(220, 106);
            this.GroupBox1.TabIndex = 14;
            this.GroupBox1.TabStop = false;
            // 
            // AmountDueTextBox
            // 
            this.AmountDueTextBox.Location = new System.Drawing.Point(104, 71);
            this.AmountDueTextBox.Name = "AmountDueTextBox";
            this.AmountDueTextBox.ReadOnly = true;
            this.AmountDueTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmountDueTextBox.TabIndex = 5;
            this.AmountDueTextBox.TabStop = false;
            this.AmountDueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DiscountTextBox
            // 
            this.DiscountTextBox.Location = new System.Drawing.Point(104, 45);
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.ReadOnly = true;
            this.DiscountTextBox.Size = new System.Drawing.Size(100, 20);
            this.DiscountTextBox.TabIndex = 3;
            this.DiscountTextBox.TabStop = false;
            this.DiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RentalTextBox
            // 
            this.RentalTextBox.Location = new System.Drawing.Point(104, 19);
            this.RentalTextBox.Name = "RentalTextBox";
            this.RentalTextBox.ReadOnly = true;
            this.RentalTextBox.Size = new System.Drawing.Size(100, 20);
            this.RentalTextBox.TabIndex = 1;
            this.RentalTextBox.TabStop = false;
            this.RentalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(8, 71);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(66, 13);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Amount Due";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(8, 45);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(72, 13);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "10% Discount";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(8, 19);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(77, 13);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Rental Amount";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(137, 47);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.QuantityTextBox.TabIndex = 13;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(137, 21);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberTextBox.TabIndex = 11;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(33, 47);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(49, 13);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "&Quantity:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(33, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 13);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "&Member Number:";
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 324);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "RentalForm";
            this.Text = "Rental Form";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ExitButton;
        internal System.Windows.Forms.Button ClearButton;
        internal System.Windows.Forms.Button CalcButton;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox TotalRentalsTextBox;
        internal System.Windows.Forms.TextBox CustomersTextBox;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox AmountDueTextBox;
        internal System.Windows.Forms.TextBox DiscountTextBox;
        internal System.Windows.Forms.TextBox RentalTextBox;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox QuantityTextBox;
        internal System.Windows.Forms.TextBox NumberTextBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

