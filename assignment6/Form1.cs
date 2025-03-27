using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static assignment6.MsgForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace assignment6
{
    public partial class Form1 : Form
    {
        private OrderService _orderService = new OrderService();
        public Form1()
        {
            InitializeComponent();
            this.Text = "OrderManager";
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            MsgForm msgForm = new MsgForm(1);
            msgForm.handler += new MsgForm.SendMsg(AdderOrder);
            msgForm.ShowDialog();
            OrderList.Rows.Clear();
            foreach (var order in _orderService.getOrderList())
            {
                OrderList.Rows.Add(order.getOrderId(), order.getOrderName(), order.getOrderCustomer(), order.getOrderAmount());
            }
        }
        private void ChangeOrderButton_Click(object sender, EventArgs e)
        {
            MsgForm msgForm = new MsgForm(1);
            msgForm.handler += new MsgForm.SendMsg(ChangeOrder);
            msgForm.ShowDialog();
            OrderList.Rows.Clear();
            foreach (var order in _orderService.getOrderList())
            {
                OrderList.Rows.Add(order.getOrderId(), order.getOrderName(), order.getOrderCustomer(), order.getOrderAmount());
            }
        }

        private void AdderOrder(string ID, string Name, string Customer, string Amount)
        {
            int intID = int.Parse(ID);
            int intAmount = int.Parse(Amount);
            if (_orderService.SearchOrderLINQ(1, ID) != null)
            {
                MessageBox.Show("OrderID already exists", "Error");
                return;
            }
            _orderService.AddOrder(intID, Name, Customer, intAmount);
            MessageBox.Show("Add Order Successfully");
        }
        private void ChangeOrder(string ID, string Name, string Customer, string Amount)
        {
            int intID = int.Parse(ID);
            int intAmount = int.Parse(Amount);
            if (_orderService.SearchOrderLINQ(1, ID) == null)
            {
                MessageBoxButtons mess = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("Order doesn't exit,do you want to add a new one£¿", "Warning", mess);
                if (dr == DialogResult.OK)
                {
                    AdderOrder(ID, Name, Customer, Amount);
                }
                else
                {
                    return;
                }
            }
            else
            {
                _orderService.DeleteOrder(intID);
                _orderService.AddOrder(intID, Name, Customer, intAmount);
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
                DialogResult dr = MessageBox.Show("Select in table,\nDo you want to delete it£¿\n£¨A long time!)", "Warning", mess);
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
                    OrderList.Rows.Clear();
                    foreach (var order in _orderService.getOrderList())
                    {
                        OrderList.Rows.Add(order.getOrderId(), order.getOrderName(), order.getOrderCustomer(), order.getOrderAmount());
                    }
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

            _orderService.sortOrderList(_orderService.getOrderList(), sortType);
            UpdateOrderList();
        }
        private void UpdateOrderList()
        {
            OrderList.Rows.Clear();
            foreach (var order in _orderService.getOrderList())
            {
                OrderList.Rows.Add(order.getOrderId(), order.getOrderName(), order.getOrderCustomer(), order.getOrderAmount());
            }
        }

        private void SearchOrderButton_Click(object sender, EventArgs e)
        {
            MsgForm msgForm = new MsgForm(3);
            msgForm.handler += new MsgForm.SendMsg(SearchOrder);
            msgForm.ShowDialog();
        }
        private void SearchOrder(string ID, string Name, string Customer, string Amount)
        {
            List<Order> result = new List<Order>();
            if (ID != "")
            {
                result.AddRange(_orderService.SearchOrderLINQ(1, ID));
            }
            if (Name != "")
            {
                result.AddRange(_orderService.SearchOrderLINQ(2, Name));
            }
            if (Customer != "")
            {
                result.AddRange(_orderService.SearchOrderLINQ(3, Customer));
            }
            if (Amount != "")
            {
                result.AddRange(_orderService.SearchOrderLINQ(4, Amount));
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
                    OrderList.Rows.Add(order.getOrderId(), order.getOrderName(), order.getOrderCustomer(), order.getOrderAmount());
                }
            }
        }
    }
}
