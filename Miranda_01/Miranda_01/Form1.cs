// Programmer: Bryan Miranda
//Project: Miranda_1
//Due Date: 02/12/2021
//Description: Individual Assignment #1




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miranda_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear button with format for clearing all the information        
            // Clearing all fields that are typable
            dateMaskedTextBox.Text = "";
            firstnameTextBox.Text = "";
            lastnameTextBox.Text = "";
            roomnumberTextBox.Text = "";
            nightsTextBox.Text = "";
            rateTextBox.Text = "";
            barTextBox.Text = "";
            teleTextBox.Text = "";
            miscTextBox.Text = "";
            rchargeTextBox.Text = "";
            achargeTextBox.Text = "";
            subtotalTextBox.Text = "";
            taxTextBox.Text = "";
            grandtotalTextBox.Text = "";
            // sending focus to first data entry control form
            dateMaskedTextBox.Focus();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            // Help button with information when clicked
            {
                MessageBox.Show("In regards to Help Fill out the Fields above" +
                    "---2.First Name" +

                    "---3.Last Name" +

                    "---4.Move onto Room information by providing" +

                    "---5.Room Number" +

                    "---6.Number of Nights the clients are staying" +

                    "---7.Followed by the Rate " +

                    "---8.Then move to Additional Charges" +

                    "---9.BAR is mini bar service at the hotel" +
                    "---10.Telephone charge if they used the motel phone or not" +

                    "---11.MISC is miscellaneous items like extra towels");
            }
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            //Creating a try and catch for punching in calculations           
            {
                int numberOfNights;
                double rate, bar, telephone, misc, roomCharge, additionalCharge, subtotal, tax, total;
                try
                {
                    numberOfNights = int.Parse(nightsTextBox.Text);
                    rate = double.Parse(rateTextBox.Text);
                    if (string.IsNullOrEmpty(barTextBox.Text))
                    {
                        barTextBox.Text = "0";
                    }
                    if (string.IsNullOrEmpty(teleTextBox.Text))
                    {
                        teleTextBox.Text = "0";
                    }
                    if (string.IsNullOrEmpty(miscTextBox.Text))
                    {
                        miscTextBox.Text = "0";
                    }
                    bar = double.Parse(barTextBox.Text);
                    telephone = double.Parse(teleTextBox.Text);
                    misc = double.Parse(miscTextBox.Text);

                    
                    roomCharge = numberOfNights * rate;
                    additionalCharge = (bar + telephone + misc);
                    subtotal = roomCharge + additionalCharge;
                    tax = 0.07 * subtotal;
                    total = tax + subtotal;

                    rchargeTextBox.Text = "" + roomCharge;
                    achargeTextBox.Text = "" + additionalCharge;
                    subtotalTextBox.Text = "" + subtotal;
                    taxTextBox.Text = "" + total;
                    grandtotalTextBox.Text = "" + total;
                }
                catch (Exception err)
                {
                    MessageBox.Show("Some Information was inputted incorrectly" + err.Message);
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closing the program entirely
            {
                this.Close();
            }
        }
    }
}
