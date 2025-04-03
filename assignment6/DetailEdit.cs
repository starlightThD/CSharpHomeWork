namespace assignment6
{

    public partial class DetailEdit : Form
    {
        private List<OrderDeatils> _orderDetailsList;
        public DetailEdit(List<OrderDeatils> orderDetailsList)
        {
            InitializeComponent();
            _orderDetailsList = new List<OrderDeatils>(orderDetailsList); // 创建副本
            UpdateDetailList();
        }

        private void UpdateDetailList()
        {
            DetailList.Rows.Clear();
            foreach (var detail in _orderDetailsList)
            {
                DetailList.Rows.Add(detail.getIndex(), detail.getItemName(), detail.getNumber(), detail.getAmount());
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (IndexText.Text == "" || NameText.Text == "" || NumberText.Text == "" || AmountText.Text == "")
            {
                MessageBox.Show("Please fill in all the information", "Warning");
                return;
            }
            if (!int.TryParse(IndexText.Text, out int Index))
            {
                MessageBox.Show("Please enter a number in Index", "Warning");
                return;
            }
            if (!int.TryParse(NumberText.Text, out int Number))
            {
                MessageBox.Show("Please enter a number in Number", "Warning");
                return;
            }
            if (!int.TryParse(AmountText.Text, out int Amount))
            {
                MessageBox.Show("Please enter a number in Amount", "Warning");
                return;
            }
            OrderDeatils orderDeatils = new OrderDeatils(Index, NameText.Text, Number, Amount);
            if (_orderDetailsList.Any(d => d.getIndex() == Index))
            {
                MessageBox.Show("Index already exists", "Error");
                return;
            }
            else
            {
                _orderDetailsList.Add(orderDeatils);
                MessageBox.Show("Add Order Successfully");
                UpdateDetailList();
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (DetailList.SelectedRows.Count > 0)
            {
                int selectedIndex = -1;
                for(int i = 0; i < _orderDetailsList.Count(); i++)
                {
                    if (DetailList.Rows[0].Cells[0].Value.ToString() == _orderDetailsList[i].getIndex().ToString())
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
                DialogResult = DialogResult.OK;
                Close();
            }

        }
        public List<OrderDeatils> GetUpdatedOrderDetailsList()
        {
            return _orderDetailsList;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Ensure to exit without save？", "Warning", mess);
            if (dr == DialogResult.OK)
            {
                this.Close();
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


