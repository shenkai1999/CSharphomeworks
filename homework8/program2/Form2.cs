﻿using System;
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
    public partial class Form2 : Form
    {
        public static Order neworder;
        public Form2()
        {
            InitializeComponent();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int a = int.Parse(s);
            string q = textBox2.Text;
            string w = textBox3.Text;
            neworder = new Order(a, q,w);
            Form1.os.AddOrder(neworder);
            Form1 frm1;
            frm1 = (Form1)this.Owner;
            frm1.update();
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int a = int.Parse(s);
            string q = textBox2.Text;
            string w = textBox3.Text;
            neworder = new Order(a, q, w);
            Form1.os.AddOrder(neworder);
            Form1 frm1;
            frm1 = (Form1)this.Owner;
            frm1.update();
            this.Close();
        }
    }
}
