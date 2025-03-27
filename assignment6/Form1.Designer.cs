namespace assignment6
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
            Title = new Label();
            AddOrderButton = new Button();
            DeleteOrderButton = new Button();
            ChangeOrderButton = new Button();
            SortButton = new Button();
            SearchOrderButton = new Button();
            OrderList = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            IDSort = new RadioButton();
            NameSort = new RadioButton();
            CustomerSort = new RadioButton();
            AmountSort = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)OrderList).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
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
            // OrderList
            // 
            OrderList.BackgroundColor = SystemColors.ButtonFace;
            OrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderList.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            OrderList.Dock = DockStyle.Fill;
            OrderList.GridColor = SystemColors.InactiveBorder;
            OrderList.Location = new Point(3, 119);
            OrderList.Name = "OrderList";
            OrderList.ReadOnly = true;
            OrderList.RowHeadersWidth = 51;
            OrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrderList.Size = new Size(1134, 458);
            OrderList.TabIndex = 7;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Title, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(OrderList, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1140, 580);
            tableLayoutPanel1.TabIndex = 8;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 580);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)OrderList).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Title;
        private Button AddOrderButton;
        private Button DeleteOrderButton;
        private Button ChangeOrderButton;
        private Button SortButton;
        private Button SearchOrderButton;
        private DataGridView OrderList;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private RadioButton IDSort;
        private RadioButton NameSort;
        private RadioButton CustomerSort;
        private RadioButton AmountSort;
    }
}