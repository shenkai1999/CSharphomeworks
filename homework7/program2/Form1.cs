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
    public partial class Form1 : Form
    {
        OrderDetails orderDetails1 = new OrderDetails("可乐", 1, 3.0);
        OrderDetails orderDetails2 = new OrderDetails("手机", 1, 2999.0);
        OrderDetails orderDetails3 = new OrderDetails(" 薯片", 2, 10.0);

        Order order1 = new Order(1, "李米");
        Order order2 = new Order(2, "天恩");
        Order order3 = new Order(3, "小莫");
        public static List<Order> orders = new List<Order>();
        public static OrderService os = new OrderService();
        

        public Form1()
        {
            InitializeComponent();
            order1.AddDetails(orderDetails2);
            order1.AddDetails(orderDetails3);
            order2.AddDetails(orderDetails1);
            order2.AddDetails(orderDetails2);
            order3.AddDetails(orderDetails1);
            order1.jisuan();//计算订单总金额
            order2.jisuan();
            order3.jisuan();                    
            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);
            
            orders = os.QueryAllOrders();
            orderBindingSource.DataSource = orders;
        }
          public void update()
        {
            orders = os.QueryAllOrders();
            orderBindingSource.DataSource = orders;
        }
             
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Order o = (Order)orderBindingSource.Current;
            if (o != null)
            {
                orderDetailsBindingSource.DataSource = o.Details;
                
            }
           

        }       
                
        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Form2 frm = new Form2();
            frm.Owner = this;
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Order od in os.QueryByCustomerName(textBox1.Text))
            {
                orderDetailsBindingSource.DataSource = od.Details;
                orderBindingSource.DataSource = od;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order o = (Order)orderBindingSource.Current;
           
            if (o != null)
            {
                os.RemoveOrder(o.Id);
                orderBindingSource.DataSource = os.QueryAllOrders();
            }
           
        }

       

        private void button4_Click_1(object sender, EventArgs e)
        {

            Order o = (Order)orderBindingSource.Current;
            Form4 form4 = new Form4((Order)orderBindingSource.Current);
            form4.Owner = this;
            form4.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Order o = (Order)orderBindingSource.Current;
            if (o != null)
            {
                os.Export(o);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            orders = os.QueryAllOrders();
            orderBindingSource.DataSource = orders;
        }
    }
}
