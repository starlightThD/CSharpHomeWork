


namespace assignment7
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tableLayoutPanel3 = new TableLayoutPanel();
            OrderList = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            DetailList = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            AddOrderButton = new Button();
            DeleteOrderButton = new Button();
            ChangeOrderButton = new Button();
            SearchOrderButton = new Button();
            SortButton = new Button();
            IDSort = new RadioButton();
            NameSort = new RadioButton();
            CustomerSort = new RadioButton();
            AmountSort = new RadioButton();
            Title = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            Index = new DataGridViewTextBoxColumn();
            _Name = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DetailList).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(OrderList, 0, 0);
            tableLayoutPanel3.Controls.Add(DetailList, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 119);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1134, 458);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // OrderList
            // 
            OrderList.BackgroundColor = SystemColors.ButtonFace;
            OrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderList.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            OrderList.Dock = DockStyle.Fill;
            OrderList.GridColor = SystemColors.InactiveBorder;
            OrderList.Location = new Point(3, 3);
            OrderList.Name = "OrderList";
            OrderList.ReadOnly = true;
            OrderList.RowHeadersWidth = 51;
            OrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrderList.Size = new Size(561, 452);
            OrderList.TabIndex = 8;
            OrderList.CellContentClick += OrderList_CellContentClick;
            OrderList.CellMouseDoubleClick += OrderList_CellMouseDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Customer";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Amount";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // DetailList
            // 
            DetailList.AllowUserToDeleteRows = false;
            DetailList.BackgroundColor = SystemColors.ButtonHighlight;
            DetailList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DetailList.Columns.AddRange(new DataGridViewColumn[] { Index, _Name, Number, Amount });
            DetailList.Dock = DockStyle.Fill;
            DetailList.Location = new Point(570, 3);
            DetailList.Name = "DetailList";
            DetailList.ReadOnly = true;
            DetailList.RowHeadersWidth = 51;
            DetailList.Size = new Size(561, 452);
            DetailList.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 9;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel2.Controls.Add(AddOrderButton, 0, 0);
            tableLayoutPanel2.Controls.Add(DeleteOrderButton, 1, 0);
            tableLayoutPanel2.Controls.Add(ChangeOrderButton, 2, 0);
            tableLayoutPanel2.Controls.Add(SearchOrderButton, 3, 0);
            tableLayoutPanel2.Controls.Add(SortButton, 4, 0);
            tableLayoutPanel2.Controls.Add(IDSort, 5, 0);
            tableLayoutPanel2.Controls.Add(NameSort, 6, 0);
            tableLayoutPanel2.Controls.Add(CustomerSort, 7, 0);
            tableLayoutPanel2.Controls.Add(AmountSort, 8, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 56);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1134, 57);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // AddOrderButton
            // 
            AddOrderButton.Dock = DockStyle.Fill;
            AddOrderButton.Location = new Point(3, 3);
            AddOrderButton.Name = "AddOrderButton";
            AddOrderButton.Size = new Size(119, 51);
            AddOrderButton.TabIndex = 1;
            AddOrderButton.Text = "AddOrder";
            AddOrderButton.UseVisualStyleBackColor = true;
            AddOrderButton.Click += AddOrderButton_Click;
            // 
            // DeleteOrderButton
            // 
            DeleteOrderButton.Dock = DockStyle.Fill;
            DeleteOrderButton.Location = new Point(128, 3);
            DeleteOrderButton.Name = "DeleteOrderButton";
            DeleteOrderButton.Size = new Size(119, 51);
            DeleteOrderButton.TabIndex = 2;
            DeleteOrderButton.Text = "DeleteOrder";
            DeleteOrderButton.UseVisualStyleBackColor = true;
            DeleteOrderButton.Click += DeleteOrderButton_Click;
            // 
            // ChangeOrderButton
            // 
            ChangeOrderButton.Dock = DockStyle.Fill;
            ChangeOrderButton.Location = new Point(253, 3);
            ChangeOrderButton.Name = "ChangeOrderButton";
            ChangeOrderButton.Size = new Size(119, 51);
            ChangeOrderButton.TabIndex = 3;
            ChangeOrderButton.Text = "ChangeOrder";
            ChangeOrderButton.UseVisualStyleBackColor = true;
            ChangeOrderButton.Click += ChangeOrderButton_Click;
            // 
            // SearchOrderButton
            // 
            SearchOrderButton.Dock = DockStyle.Fill;
            SearchOrderButton.Location = new Point(378, 3);
            SearchOrderButton.Name = "SearchOrderButton";
            SearchOrderButton.Size = new Size(119, 51);
            SearchOrderButton.TabIndex = 5;
            SearchOrderButton.Text = "SearchOrder";
            SearchOrderButton.UseVisualStyleBackColor = true;
            SearchOrderButton.Click += SearchOrderButton_Click;
            // 
            // SortButton
            // 
            SortButton.Dock = DockStyle.Fill;
            SortButton.Location = new Point(503, 3);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(119, 51);
            SortButton.TabIndex = 4;
            SortButton.Text = "Sort";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // IDSort
            // 
            IDSort.AutoSize = true;
            IDSort.Dock = DockStyle.Fill;
            IDSort.Location = new Point(628, 3);
            IDSort.Name = "IDSort";
            IDSort.Size = new Size(119, 51);
            IDSort.TabIndex = 6;
            IDSort.TabStop = true;
            IDSort.Text = "ID";
            IDSort.UseVisualStyleBackColor = true;
            // 
            // NameSort
            // 
            NameSort.AutoSize = true;
            NameSort.Dock = DockStyle.Fill;
            NameSort.Location = new Point(753, 3);
            NameSort.Name = "NameSort";
            NameSort.Size = new Size(119, 51);
            NameSort.TabIndex = 7;
            NameSort.TabStop = true;
            NameSort.Text = "Name";
            NameSort.UseVisualStyleBackColor = true;
            // 
            // CustomerSort
            // 
            CustomerSort.AutoSize = true;
            CustomerSort.Dock = DockStyle.Fill;
            CustomerSort.Location = new Point(878, 3);
            CustomerSort.Name = "CustomerSort";
            CustomerSort.Size = new Size(119, 51);
            CustomerSort.TabIndex = 8;
            CustomerSort.TabStop = true;
            CustomerSort.Text = "Customer";
            CustomerSort.UseVisualStyleBackColor = true;
            // 
            // AmountSort
            // 
            AmountSort.AutoSize = true;
            AmountSort.Dock = DockStyle.Fill;
            AmountSort.Location = new Point(1003, 3);
            AmountSort.Name = "AmountSort";
            AmountSort.Size = new Size(128, 51);
            AmountSort.TabIndex = 9;
            AmountSort.TabStop = true;
            AmountSort.Text = "Amount";
            AmountSort.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Dock = DockStyle.Fill;
            Title.Font = new Font("OPPOSans B", 24F, FontStyle.Bold, GraphicsUnit.Point, 134);
            Title.Location = new Point(3, 0);
            Title.Name = "Title";
            Title.Size = new Size(1134, 53);
            Title.TabIndex = 0;
            Title.Text = "Welcome to Order Manager";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(Title, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1140, 580);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // Index
            // 
            Index.HeaderText = "Index";
            Index.MinimumWidth = 6;
            Index.Name = "Index";
            Index.ReadOnly = true;
            Index.Width = 125;
            // 
            // _Name
            // 
            _Name.HeaderText = "Name";
            _Name.MinimumWidth = 6;
            _Name.Name = "_Name";
            _Name.ReadOnly = true;
            _Name.Width = 125;
            // 
            // Number
            // 
            Number.HeaderText = "Number";
            Number.MinimumWidth = 6;
            Number.Name = "Number";
            Number.ReadOnly = true;
            Number.Width = 125;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 580);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrderList).EndInit();
            ((System.ComponentModel.ISupportInitialize)DetailList).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private int selectedRowIndex = -1;
        private int selectedTimes = 0;
        private void OrderList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (selectedRowIndex != e.RowIndex)
                {
                    selectedTimes = 1;
                    selectedRowIndex = e.RowIndex;
                    DetailList.Rows.Clear();
                    int orderId = Convert.ToInt32(OrderList.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value);
                    Order selectedOrder = _orderService.GetOrderList().FirstOrDefault(o => o.OrderId == orderId);
                    if (selectedOrder != null)
                    {
                        foreach (var detail in selectedOrder.OrderDetailsList)
                        {
                            DetailList.Rows.Add(detail.Index, detail.ItemName, detail.Number, detail.Amount);
                        }
                    }
                }
                else
                {
                    selectedTimes++;
                    if (selectedTimes >= 2)
                    {
                        selectedTimes = 0;
                        int orderId = Convert.ToInt32(OrderList.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value);
                        Order selectedOrder = _orderService.GetOrderList().FirstOrDefault(o => o.OrderId == orderId);
                        if (selectedOrder != null)
                        {
                            DetailEdit detailEdit = new DetailEdit(orderId);
                            if (detailEdit.ShowDialog() == DialogResult.OK)
                            {
                                UpdateOrderList();
                            }
                        }
                    }
                    else
                    {
                        DetailList.Rows.Clear();
                        int orderId = Convert.ToInt32(OrderList.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value);
                        Order selectedOrder = _orderService.GetOrderList().FirstOrDefault(o => o.OrderId == orderId);
                        if (selectedOrder != null)
                        {
                            foreach (var detail in selectedOrder.OrderDetailsList)
                            {
                                DetailList.Rows.Add(detail.Index, detail.ItemName, detail.Number, detail.Amount);
                            }
                        }
                    }
                }
            }
        }



        #endregion
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Button AddOrderButton;
        private Button DeleteOrderButton;
        private Button ChangeOrderButton;
        private Button SearchOrderButton;
        private Button SortButton;
        private RadioButton IDSort;
        private RadioButton NameSort;
        private RadioButton CustomerSort;
        private RadioButton AmountSort;
        private Label Title;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView OrderList;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridView DetailList;
        private DataGridViewTextBoxColumn Index;
        private DataGridViewTextBoxColumn _Name;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Amount;
    }
}