using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalTubeTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true ){
                this.pin_value = 0;
                this.pin_value_n = 1;

                this.codevalue.Text = "0xff";
                this.segvalue1.Text = "1";
                this.segvalue2.Text = "1";
                this.segvalue3.Text = "1";
                this.segvalue4.Text = "1";
                this.segvalue5.Text = "1";
                this.segvalue6.Text = "1";
                this.segvalue7.Text = "1";
                this.segvalue8.Text = "1";

            }
            else
            {
                this.pin_value = 1;
                this.pin_value_n = 0;

                this.codevalue.Text = "0x00";
                this.segvalue1.Text = "0";
                this.segvalue2.Text = "0";
                this.segvalue3.Text = "0";
                this.segvalue4.Text = "0";
                this.segvalue5.Text = "0";
                this.segvalue6.Text = "0";
                this.segvalue7.Text = "0";
                this.segvalue8.Text = "0";

            }
            for(int i = 0; i < 8; i++)
            {
                pin_value_arr[i] = pin_value_n;
            }

            this.button1.BackColor = SystemColors.Control;
            this.button2.BackColor = SystemColors.Control;
            this.button3.BackColor = SystemColors.Control;
            this.button4.BackColor = SystemColors.Control;
            this.button5.BackColor = SystemColors.Control;
            this.button6.BackColor = SystemColors.Control;
            this.button7.BackColor = SystemColors.Control;
            this.button8.BackColor = SystemColors.Control;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.BackColor == Color.Red)
            {
                this.button1.BackColor = SystemColors.Control;
                this.pin_value_arr[0] = this.pin_value_n;
            }
            else
            {
                this.button1.BackColor = Color.Red;
                this.pin_value_arr[0] = this.pin_value;
            }
            
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.Red)
            {
                this.button5.BackColor = SystemColors.Control;
                this.pin_value_arr[4] = this.pin_value_n;
            }
            else
            {
                this.button5.BackColor = Color.Red;
                this.pin_value_arr[4] = this.pin_value;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Red)
            {
                this.button2.BackColor = SystemColors.Control;
                this.pin_value_arr[1] = this.pin_value_n;
            }
            else
            {
                this.button2.BackColor = Color.Red;
                this.pin_value_arr[1] = pin_value;
            }
        }




        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Red)
            {
                this.button3.BackColor = SystemColors.Control;
                this.pin_value_arr[2] = this.pin_value_n;

            }
            else
            {
                this.button3.BackColor = Color.Red;
                this.pin_value_arr[2] = pin_value;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.Red)
            {
                this.button4.BackColor = SystemColors.Control;
                this.pin_value_arr[3] = this.pin_value_n;
            }
            else
            {
                this.button4.BackColor = Color.Red;
                this.pin_value_arr[3] = this.pin_value;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.Red)
            {
                this.button6.BackColor = SystemColors.Control;
                this.pin_value_arr[5] = this.pin_value_n;
            }
            else
            {
                this.button6.BackColor = Color.Red;
                this.pin_value_arr[5] = this.pin_value;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.Red)
            {
                this.button7.BackColor = SystemColors.Control;
                this.pin_value_arr[6] = this.pin_value_n;
            }
            else
            {
                this.button7.BackColor = Color.Red;
                this.pin_value_arr[6] = this.pin_value;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.Red)
            {
                this.button8.BackColor = SystemColors.Control;
                this.pin_value_arr[7] = this.pin_value_n;
            }
            else
            {
                this.button8.BackColor = Color.Red;
                this.pin_value_arr[7] = this.pin_value;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string segname = "";
            int index = -1;
            segname = this.segname1.Text.ToLower();
            if (segname == "dp") segname = "h";
            index = (int)segname[0] - 97;
            this.segvalue1.Text = this.pin_value_arr[index].ToString();

            segname = this.segname2.Text.ToLower();
            if (segname == "dp") segname = "h";
            index = (int)segname[0] - 97;
            this.segvalue2.Text = this.pin_value_arr[index].ToString();

            segname = this.segname3.Text.ToLower();
            if (segname == "dp") segname = "h";
            index = (int)segname[0] - 97;
            this.segvalue3.Text = this.pin_value_arr[index].ToString();

            segname = this.segname4.Text.ToLower();
            if (segname == "dp") segname = "h";
            index = (int)segname[0] - 97;
            this.segvalue4.Text = this.pin_value_arr[index].ToString();

            segname = this.segname5.Text.ToLower();
            if (segname == "dp") segname = "h";
            index = (int)segname[0] - 97;
            this.segvalue5.Text = this.pin_value_arr[index].ToString();

            segname = this.segname6.Text.ToLower();
            if (segname == "dp") segname = "h";
            index = (int)segname[0] - 97;
            this.segvalue6.Text = this.pin_value_arr[index].ToString();

            segname = this.segname7.Text.ToLower();
            if (segname == "dp") segname = "h";
            index = (int)segname[0] - 97;
            this.segvalue7.Text = this.pin_value_arr[index].ToString();

            segname = this.segname8.Text.ToLower();
            if (segname == "dp") segname = "h";
            index = (int)segname[0] - 97;
            this.segvalue8.Text = this.pin_value_arr[index].ToString();
        }
    }
}
