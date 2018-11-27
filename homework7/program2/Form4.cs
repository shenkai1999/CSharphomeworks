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
    public partial class Form4 : Form
    {
        public static Order neworder ;
       
        public Order CurrentOrder { get; set; }
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(Order order) : this()
        {

            CurrentOrder = order;
            orderBindingSource.DataSource = order;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            int b = int.Parse(a);
          
           
            neworder=new Order(b,textBox2.Text);
            Form1.os.Update(CurrentOrder, neworder);
            Form1 frm1;
            frm1 = (Form1)this.Owner;
            frm1.update();
            this.Close();
        }
        
    }
}
