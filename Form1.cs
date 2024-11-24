using Project09_MongoDbOrder.Entities;
using Project09_MongoDbOrder.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project09_MongoDbOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OrderOperation orderOperation = new OrderOperation();
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                City = txtCityName.Text,
                CustomerName = txtCustomerName.Text,
                District = txtDistrictName.Text,
                TotalPrice = decimal.Parse(txtTotalPrice.Text),
                //OrderId = txtOrderId.Text
            };

            orderOperation.AddOrder(order);
            MessageBox.Show("Kayıt başarıyla eklendi");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
           
               List<Order> orders = orderOperation.GetAllOrders();

            dataGridView1.DataSource = orders;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string orderId=txtOrderId.Text;
            orderOperation.DeleteOrder(orderId);
            MessageBox.Show("Başarıyla Silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string orderId = txtOrderId.Text;

            var updatedOrder = new Order
            {
                City = txtCityName.Text,
                CustomerName = txtCustomerName.Text,
                District = txtDistrictName.Text,
                TotalPrice = decimal.Parse(txtTotalPrice.Text)
            };
            orderOperation.UpdateOrder(updatedOrder);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            string id = txtOrderId.Text;
           Order order = orderOperation.GetOrderById(id);

            dataGridView1.DataSource = new List<Order> { order};
        }
    }
}
