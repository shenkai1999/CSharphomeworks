using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using program1;
namespace program2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            int c = int.Parse(b);
            string d = textBox3.Text;
            double f = double.Parse(d);
            OrderDetails newdetails = new OrderDetails(a, c, f);
            Form2.neworder.AddDetails(newdetails);
            this.Close();
        }
    }
}
