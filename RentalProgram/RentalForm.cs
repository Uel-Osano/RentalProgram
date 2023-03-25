using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalProgram
{
    public partial class RentalForm : Form
    {
         //Declare module-level variables and constants.
            const decimal PRICE_OF_ONE_Decimal= 25.8m;
            const decimal DISCOUNT_RATE_Decimal = 0.1m;
            private decimal TotalRentalsDecimal;
            private int TotalCustomersInteger;
        public RentalForm()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
           int QuantityInteger = int.Parse(QuantityTextBox.Text);
            calculate(QuantityInteger);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            clearControls();
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            //End the program
            Close();
        }

        private void clearControls()
        {
            //Clear the entries on the form.
            QuantityTextBox.Clear();
            RentalTextBox.Clear();
            DiscountTextBox.Clear();
            AmountDueTextBox.Clear();
            NumberTextBox.Clear();
            NumberTextBox.Focus();
        }

        private void calculate (int quantity)
        {
            decimal RentalAmountDecimal, DiscountAmountDecimal, AmountDueDecimal;
            //Calculate the rental amount, the discount, and the amount due
            RentalAmountDecimal = quantity * PRICE_OF_ONE_Decimal;
            DiscountAmountDecimal = RentalAmountDecimal * DISCOUNT_RATE_Decimal;
            AmountDueDecimal = RentalAmountDecimal - DiscountAmountDecimal;

            //Calculate totals for all customers
            TotalRentalsDecimal += AmountDueDecimal;
            TotalCustomersInteger += 1;

            //Display the results
            RentalTextBox.Text = RentalAmountDecimal.ToString("C");
            DiscountTextBox.Text = DiscountAmountDecimal.ToString("C");
            AmountDueTextBox.Text = AmountDueDecimal.ToString("C");
            CustomersTextBox.Text = TotalCustomersInteger.ToString();
            TotalRentalsTextBox.Text = TotalRentalsDecimal.ToString("C");
            if (TotalRentalsDecimal > 500)
            {
                QuantityTextBox.Enabled = false;
                NumberTextBox.Enabled = false;
            }
        }
    }
}
