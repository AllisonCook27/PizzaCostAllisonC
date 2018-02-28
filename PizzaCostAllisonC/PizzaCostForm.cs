/*
 * Created by: Allison Cook
 * Created on: 26 february, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - Pizza Cost
 * This program calculates the cost of a pizza for a given diameter
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCostAllisonC
{
    public partial class frmPizzaCost : Form
    {
        //setting variables
        double subtotal, cost, numberOfPizzas, diameter;

        //Setting constants
        const double TAX = 1.13, ALL = (0.75 + 0.99);

        public frmPizzaCost()
        {
            InitializeComponent();
            lblCost.Hide();
            lblsubtotal.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            diameter = 0;
            numberOfPizzas = 0;
            subtotal = 0;
            cost = 0;
            try
            {
                //set the diameter
                diameter = double.Parse(txtSize.Text);

                //set the number of pizza
                numberOfPizzas = double.Parse(txtSize.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number.");
            }
            if (diameter >= 0)
            {
                //calculate the subtotal
                subtotal = (ALL + (0.50 * diameter) * numberOfPizzas);
                subtotal = Math.Round(subtotal, 2); 

                //calculate the total
                cost = subtotal * TAX;
                cost = Math.Round(cost, 2);

                //set to text
                lblcostsubtotal.Text = Convert.ToString(subtotal) + "$";
                lblcosttotal.Text = Convert.ToString(cost) + "$";

                //show text
                lblCost.Show();
                lblsubtotal.Show();

            }
            else
            {
                MessageBox.Show("Please enter a positive number.");
            }


        }


        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
