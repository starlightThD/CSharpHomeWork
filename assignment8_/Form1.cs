using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace assignment8
{
    public partial class Form1 : Form
    {
        private OrderService _orderService = new OrderService();

        public Form1()
        {
            InitializeComponent();
            this.Text = "OrderManager";
            UpdateOrderList();
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            MsgForm msgForm = new MsgForm(1);
            msgForm.handler += new MsgForm.SendMsg(AddOrder);
            msgForm.ShowDialog();
            UpdateOrderList();
        }

        private void ChangeOrderButton_Click(object sender, EventArgs e)
        {
            MsgForm msgForm = new MsgForm(1);
            msgForm.handler += new MsgForm.SendMsg(ChangeOrder);
            msgForm.ShowDialog();
            UpdateOrderList();
        }

        private void AddOrder(string id, string name, string customer, string amount)
        {
            int intId = int.Parse(id);
            int intAmount = int.Parse(amount);
            if (_orderService.SearchOrderLINQ(1, id) != null)
            {
                MessageBox.Show("OrderID already exists", "Error");
                return;
            }
            _orderService.AddOrder(intId, name, customer, intAmount);
            MessageBox.Show("Add Order Successfully");
        }

        private void ChangeOrder(string id, string name, string customer, string amount)
        {
            int intId = int.Parse(id);
            int intAmount = int.Parse(amount);
            if (_orderService.SearchOrderLINQ(1, id) == null)
            {
                MessageBoxButtons mess = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("Order doesn't exist, do you want to add a new one?", "Warning", mess);
                if (dr == DialogResult.OK)
                {
                    AddOrder(id, name, customer, amount);
                }
                else
                {
                    return;
                }
            }
            else
            {
                _orderService.DeleteOrder(intId);
                _orderService.AddOrder(intId, name, customer, intAmount);
                MessageBox.Show("Change Order Successfully");
            }
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            if (OrderList.SelectedRows.Count > 0)
            {
                int orderId = 0;
                foreach (DataGridViewRow row in OrderList.SelectedRows)
                {
                    orderId = Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn1"].Value);
                }
                MessageBoxButtons mess = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("Select in table,\nDo you want to delete it?\n£¨A long time!)", "Warning", mess);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        _orderService.DeleteOrder(orderId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    MessageBox.Show("Order(s) Deleted Successfully");
                    UpdateOrderList();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select an order to delete", "Warning");
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            string sortType = "OrderId"; // Ä¬ÈÏ°´ OrderId ÅÅÐò
            if (IDSort.Checked)
            {
                sortType = "OrderId";
            }
            else if (NameSort.Checked)
            {
                sortType = "OrderName";
            }
            else if (CustomerSort.Checked)
            {
                sortType = "OrderCustomer";
            }
            else if (AmountSort.Checked)
            {
                sortType = "OrderAmount";
            }

            _orderService.SortOrderList(_orderService.GetOrderList(), sortType);
            UpdateOrderList();
        }

        private void UpdateOrderList()
        {
            OrderList.Rows.Clear();
            foreach (var order in _orderService.GetOrderList())
            {
                OrderList.Rows.Add(order.OrderId, order.OrderName, order.OrderCustomer, order.OrderAmount);
            }
        }

        private void SearchOrderButton_Click(object sender, EventArgs e)
        {
            MsgForm msgForm = new MsgForm(3);
            msgForm.handler += new MsgForm.SendMsg(SearchOrder);
            msgForm.ShowDialog();
        }

        private void SearchOrder(string id, string name, string customer, string amount)
        {
            List<Order> result = new List<Order>();
            if (id != "")
            {
                result.AddRange(_orderService.SearchOrderLINQ(1, id));
            }
            if (name != "")
            {
                result.AddRange(_orderService.SearchOrderLINQ(2, name));
            }
            if (customer != "")
            {
                result.AddRange(_orderService.SearchOrderLINQ(3, customer));
            }
            if (amount != "")
            {
                result.AddRange(_orderService.SearchOrderLINQ(4, amount));
            }
            if (result.Count == 0)
            {
                MessageBox.Show("No order found", "Warning");
                return;
            }
            else
            {
                OrderList.Rows.Clear();
                foreach (var order in result)
                {
                    OrderList.Rows.Add(order.OrderId, order.OrderName, order.OrderCustomer, order.OrderAmount);
                }
            }
        }

        private void OrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int orderId = Convert.ToInt32(OrderList.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value);
                Order selectedOrder = _orderService.GetOrderList().FirstOrDefault(o => o.OrderId == orderId);
                if (selectedOrder != null)
                {
                    DetailList.Rows.Clear();
                    foreach (var detail in selectedOrder.OrderDetailsList)
                    {
                        DetailList.Rows.Add(detail.Index, detail.ItemName, detail.Number, detail.Amount);
                    }
                }
            }
        }
    }
}
