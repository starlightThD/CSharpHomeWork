using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace assignment6
{
    public partial class MsgForm : Form
    {
        private int FuncType = 0;
        public delegate void SendMsg(string ID, string Name, string Customer, string Amount);
        public event SendMsg handler;
        public MsgForm(int type)
        {
            InitializeComponent();
            FuncType = type;
            //type 1 is add order
            //type 2 is change order
            //type 3 is search order
            switch (FuncType)
            {
                case 1:
                    MessageBox.Show("You need input all the information to add an order", "Warning");
                    break;
                case 2:
                    MessageBox.Show("You can only change order by OrderID", "Warning");
                    break;
                case 3:
                    MessageBox.Show("You can search order by any information.\nAll the result will be show in list", "Warning");
                    break;
            }
        }

        private void MsgForm_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Ensure to exit？", "Warning", mess);
            if (dr == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if(FuncType == 3)
            {
                if (IDText.Text == "" && NameText.Text == "" && CustomerText.Text == "" && AmountText.Text == "")
                {
                    MessageBox.Show("Please give atleast one information", "Warning");
                    return;
                }
                else
                {
                    if (handler != null)
                    {
                        handler(IDText.Text, NameText.Text, CustomerText.Text, AmountText.Text);
                    }
                    this.Close();
                }
            }
                    if (IDText.Text == "" || NameText.Text == "" || CustomerText.Text == "" || AmountText.Text == "")
                    {
                        MessageBox.Show("Please fill in all the information", "Warning");
                        return;
                    }
                    if (!int.TryParse(IDText.Text, out int id))
                    {
                        MessageBox.Show("Please enter a number in OrderID", "Warning");
                        return;
                    }
                    if (!int.TryParse(AmountText.Text, out int amount))
                    {
                        MessageBox.Show("Please enter a number in OrderAmount", "Warning");
                        return;
                    }
                    MessageBoxButtons mess = MessageBoxButtons.OKCancel;
                    DialogResult dr = MessageBox.Show("Ensure the message？", "Warning", mess);
                    if (dr == DialogResult.OK)
                    {
                        if (handler != null)
                        {
                            handler(IDText.Text, NameText.Text, CustomerText.Text, AmountText.Text);
                        }
                        this.Close();
                    }
                    else
                    {
                        return;
                    }
        }

        private void OrderName_Click(object sender, EventArgs e)
        {

        }
    }
}
