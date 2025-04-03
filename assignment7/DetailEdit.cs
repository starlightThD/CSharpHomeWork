using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace assignment7
{
    public partial class DetailEdit : Form
    {
        private List<OrderDetails> _orderDetailsList;
        private int _orderId;

        public DetailEdit(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
            LoadOrderDetails();
            UpdateDetailList();
        }

        private void LoadOrderDetails()
        {
            using (var context = new OrderContext())
            {
                var order = context.Orders.Include(o => o.OrderDetailsList).SingleOrDefault(o => o.OrderId == _orderId);
                if (order != null)
                {
                    _orderDetailsList = new List<OrderDetails>(order.OrderDetailsList);
                }
                else
                {
                    _orderDetailsList = new List<OrderDetails>();
                }
            }
        }

        private void UpdateDetailList()
        {
            DetailList.Rows.Clear();
            foreach (var detail in _orderDetailsList)
            {
                DetailList.Rows.Add(detail.Index, detail.ItemName, detail.Number, detail.Amount);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (IndexText.Text == "" || NameText.Text == "" || NumberText.Text == "" || AmountText.Text == "")
            {
                MessageBox.Show("Please fill in all the information", "Warning");
                return;
            }
            if (!int.TryParse(IndexText.Text, out int index))
            {
                MessageBox.Show("Please enter a number in Index", "Warning");
                return;
            }
            if (!int.TryParse(NumberText.Text, out int number))
            {
                MessageBox.Show("Please enter a number in Number", "Warning");
                return;
            }
            if (!int.TryParse(AmountText.Text, out int amount))
            {
                MessageBox.Show("Please enter a number in Amount", "Warning");
                return;
            }
            OrderDetails orderDetails = new OrderDetails(index, NameText.Text, number, amount);
            if (_orderDetailsList.Any(d => d.Index == index))
            {
                MessageBox.Show("Index already exists", "Error");
                return;
            }
            else
            {
                _orderDetailsList.Add(orderDetails);
                MessageBox.Show("Add Order Successfully");
                UpdateDetailList();
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (DetailList.SelectedRows.Count > 0)
            {
                int selectedIndex = -1;
                for (int i = 0; i < _orderDetailsList.Count(); i++)
                {
                    if (DetailList.SelectedRows[0].Cells[0].Value.ToString() == _orderDetailsList[i].Index.ToString())
                    {
                        selectedIndex = i;
                        break;
                    }
                }
                if (selectedIndex == -1)
                {
                    MessageBox.Show("Index not found", "Error");
                    return;
                }
                else
                {
                    MessageBoxButtons mess = MessageBoxButtons.OKCancel;
                    DialogResult dr = MessageBox.Show("Ensure to delete？", "Warning", mess);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("Delete Order Successfully");
                        _orderDetailsList.RemoveAt(selectedIndex);
                        UpdateDetailList();
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Ensure to save？", "Warning", mess);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                using (var context = new OrderContext())
                {
                    var order = context.Orders.Include(o => o.OrderDetailsList).SingleOrDefault(o => o.OrderId == _orderId);
                    if (order != null)
                    {
                        order.OrderDetailsList = _orderDetailsList;
                        order.SetOrderAmount();
                        context.SaveChanges();
                    }
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        public List<OrderDetails> GetUpdatedOrderDetailsList()
        {
            return _orderDetailsList;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Ensure to exit without save？", "Warning", mess);
            if (dr == DialogResult.OK)
            {
                Close();
            }
            else
            {
                return;
            }
        }

        private void DetailList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
