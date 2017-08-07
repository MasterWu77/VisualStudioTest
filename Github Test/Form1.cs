using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Github_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int var1; int var2; int total = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var1 = Convert.ToInt32(textBox1.Text);
                MessageBox.Show(Convert.ToString(var1));
            }
            catch
            {
                MessageBox.Show("Please enter only numbers!");
            }
           
        }
       

        private void button2_Click_1(object sender, EventArgs e)
        {
            var1 = Convert.ToInt32(textBox1.Text);
            var2 = Convert.ToInt32(textBox2.Text);
            total = var1 + var2;
            MessageBox.Show(Convert.ToString(total));
        }
    }
}
