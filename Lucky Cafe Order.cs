using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tests
{
    public partial class Lucky_Cafe_Order : Form
    {
        public Lucky_Cafe_Order()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            String customerName = txtCustomerName.Text;
            int quantity;
            double price = 0;
            String drink = "";

            if (customerName == "")
            {
                MessageBox.Show("Please enter customer name.");
                return;
            }
            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity < 1)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            if (rbTea.Checked)
            {
                price = 1;
                drink = "Tea";
            }
            else if (rbCoffee.Checked)
            {
                price = 2;
                drink = "Coffee";
            }
            else if (rbJuice.Checked)
            {
                price = 3;
                drink = "Juice";
            }
            else
            {
                MessageBox.Show("Please Select a drink.");
                return;
            }

            listBox1.Items.Clear();
            Random random = new Random();

            bool gotPrize = false;

            for (int i = 1; i <= quantity; i++)
            {
                int luckyNumber = random.Next(1, 51);

                listBox1.Items.Add(i + ")" + customerName + " - "
                    + drink + "- Lucky:" + luckyNumber + "-$" + price.ToString("0.00"));
                if (luckyNumber == 7 || luckyNumber == 17)
                {
                    gotPrize = true;
                }
            }

            // calculate total...
            double total = price * quantity;
            if (checkStudent.Checked)
            {
                total = total - (total * 0.01);
            }

            lbltotal.Text = "Total Price: $ " + total.ToString("0.00");

            if (gotPrize)
            {
                lblMessegeLucky.Text = "Lucky Message: You got a free cookie! ";
            }
            else
                lblMessegeLucky.Text = "Lucky Message: No prize this time.";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("No order to save.");
                return;
            }
            StreamWriter writer = File.AppendText("orders.txt");

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                writer.WriteLine(listBox1.Items[i].ToString());
            }

            writer.WriteLine(lbltotal.Text);
            writer.WriteLine(lblMessegeLucky.Text);

            writer.WriteLine("--------------");
            writer.Close();

            MessageBox.Show("Order saved");

        }

        // Load form file button.
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!File.Exists("orders.txt"))
            {
                MessageBox.Show("No file found.");
                return;
            }

            listBox1.Items.Clear();

            StreamReader reader = File.OpenText("orders.txt");

            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine();

                listBox1.Items.Add(line);
            }
            reader.Close();
        }



        // Clear button.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtQuantity.Clear();

            listBox1.Items.Clear();

            lbltotal.Text = "Total Price: ";
            lblMessegeLucky.Text = "Lucky Message:";

            checkStudent.Checked = false;

            rbTea.Checked = false;
            rbCoffee.Checked = false;
            rbJuice.Checked = false;

        }


    }
}
