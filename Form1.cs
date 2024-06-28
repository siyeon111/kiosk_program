using prtojectfoam;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prtoject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static public int totalPrice = 0;
        static public int totalpriceform1 = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void ckbSpicyshr_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(ckbSpicyshr, lbSpicyshr);
        }

        private void ckbShrimp_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(ckbShrimp, lbShrimp);
        }

        private void ckbBbq_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(ckbBbq, lbBbq);
        }

        private void ckbFold_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(ckbFold, lbFold);
        }

        private void ckbItalinsal_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(ckbItalinsal, lbItalinsal);
        }

        private void ckbDeri_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(ckbDeri, lbDeri);
        }

        private void ckbLabshrimp_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(ckbLabshrimp, lbLabshrimp);
        }

        private void ckbLabcheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(ckbLabcheese, lbLabcheese);
        }

        private void ckbLabmini_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(ckbLabmini, lbLabmini);
        }

        private void ckbCornsoup_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(ckbCornsoup, lbCornsoup);
        }

        private void ckbMushroom_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(ckbMushroom, lbMushroom);
        }

        private void ckbSweetpotato_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(ckbSweetpotato, lbSweetpotato);
        }

        private void ckbPotato_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(ckbPotato, lbPotato);
        }

        private void ckbChsepotato_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(ckbChsepotato, lbChsepotato);
        }

        private void ckbCoke_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(ckbCoke, lbCoke);
        }

        private void ckbCoffee_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(ckbCoffee, lbCoffee);
        }

        private void ckbBLT_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePriceAndOpenForm2(ckbBLT, lbBLT);
        }

        private void ckbHam_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePriceAndOpenForm2(ckbHam, lbHam);
        }

        private void ckbTuna_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePriceAndOpenForm2(ckbTuna, lbTuna);
        }

        private void ckbEggmayo1_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePriceAndOpenForm2(ckbEggmayo1, lbEggmayo1);
        }

        private void ckbItalin_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePriceAndOpenForm2(ckbItalin, lbItalin);
        }

        private void ckbRobster_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePriceAndOpenForm2(ckbRobster, lbRobster);
        }

        private void ckbRobshr_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePriceAndOpenForm2(ckbRobshr, lbRobshr);
        }

        private void ckbChicken_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePriceAndOpenForm2(ckbChicken, lbChicken);
        }

        private void UpdatePrice(CheckBox checkBox, Label priceLabel)
        {
            int price = int.Parse(priceLabel.Text);

            if (checkBox.Checked)
            {
                richTextBox10.AppendText(checkBox.Text + "\n");
                totalPrice += price;
            }
            else
            {
                string[] lines = richTextBox10.Lines;
                List<string> newLines = new List<string>();

                foreach (string line in lines)
                {
                    if (!line.Trim().Equals(checkBox.Text))
                    {
                        newLines.Add(line);
                    }
                }
                richTextBox10.Lines = newLines.ToArray();
                totalPrice -= price;
            }

            // Ensure totalPrice does not go negative
            if (totalPrice < 0)
            {
                totalPrice = 0;
            }

            textBox3.Text = totalPrice.ToString();
        }

        private void UpdatePriceAndOpenForm2(CheckBox checkBox, Label priceLabel)
        {
            int price = int.Parse(priceLabel.Text);

            if (checkBox.Checked)
            {
                richTextBox10.AppendText(checkBox.Text + "\n");
                totalPrice += price;

                Form2 form2 = new Form2(ref textBox3, ref richTextBox10);
                form2.ShowDialog();
            }
            else
            {
                string[] lines = richTextBox10.Lines;
                List<string> newLines = new List<string>();

                foreach (string line in lines)
                {
                    if (!line.Trim().Equals(checkBox.Text))
                    {
                        newLines.Add(line);
                    }
                }
                richTextBox10.Lines = newLines.ToArray();
                totalPrice -= price;
            }

            // Ensure totalPrice does not go negative
            if (totalPrice < 0)
            {
                totalPrice = 0;
            }

            textBox3.Text = totalPrice.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //richTextBox10.Clear();
            //textBox3.Text = "0";
            //totalPrice = 0;

            //ClearAllControls(this);
            ResetAll();
        }
        private void ResetAll()
        {
            richTextBox10.Clear();
            textBox3.Text = "0";
            totalPrice = 0;
            ClearAllControls(this);
        }
        private void ClearAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                else if (control.HasChildren)
                {
                    ClearAllControls(control);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//주문결제
        {
            
            Form3 form3 = new Form3();
            form3.Form3Closing += Form3_Form3Closing;
            form3.ShowDialog();
            ResetAll();
        }
        private void Form3_Form3Closing(object sender, FormClosingEventArgs e)
        {
            ResetAll();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
