using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Büfe_Stış_Paneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int vault = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            int water, tea, pancake, ticket, total;
            water = Convert.ToInt16(textBox1.Text);
            tea = Convert.ToInt16(textBox2.Text);
            pancake = Convert.ToInt16(textBox3.Text);
            ticket = Convert.ToInt16(textBox4.Text);
            total = water * 1 + tea * 2 + pancake * 5 + ticket * 10;
            label10.Text = total.ToString() + " $ ";
            vault = vault + total;
            label11.Text = vault.ToString() + " $";
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox1.Focus();
        }
    }
    
}
