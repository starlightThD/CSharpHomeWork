namespace assignment8
{
    partial class DetailEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddButton = new Button();
            DelButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            SaveButton = new Button();
            ExitButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            DetailList = new DataGridView();
            Index = new DataGridViewTextBoxColumn();
            _Name = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            tableLayoutPanel3 = new TableLayoutPanel();
            IndexText = new TextBox();
            NameText = new TextBox();
            NumberText = new TextBox();
            AmountText = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DetailList).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(192, 46);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DelButton
            // 
            DelButton.Dock = DockStyle.Fill;
            DelButton.Location = new Point(201, 3);
            DelButton.Name = "DelButton";
            DelButton.Size = new Size(192, 46);
            DelButton.TabIndex = 1;
            DelButton.Text = "Delete";
            DelButton.UseVisualStyleBackColor = true;
            DelButton.Click += DelButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(DelButton, 1, 0);
            tableLayoutPanel1.Controls.Add(AddButton, 0, 0);
            tableLayoutPanel1.Controls.Add(SaveButton, 2, 0);
            tableLayoutPanel1.Controls.Add(ExitButton, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 359);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(794, 52);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // SaveButton
            // 
            SaveButton.Dock = DockStyle.Fill;
            SaveButton.Location = new Point(399, 3);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(192, 46);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Dock = DockStyle.Fill;
            ExitButton.Location = new Point(597, 3);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(194, 46);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(DetailList, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 85.82888F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.1711226F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.Size = new Size(800, 450);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // DetailList
            // 
            DetailList.AllowUserToAddRows = false;
            DetailList.AllowUserToDeleteRows = false;
            DetailList.BackgroundColor = SystemColors.ButtonFace;
            DetailList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DetailList.Columns.AddRange(new DataGridViewColumn[] { Index, _Name, Number, Amount });
            DetailList.Dock = DockStyle.Fill;
            DetailList.Location = new Point(3, 3);
            DetailList.Name = "DetailList";
            DetailList.RowHeadersWidth = 51;
            DetailList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DetailList.Size = new Size(794, 350);
            DetailList.TabIndex = 2;
            DetailList.CellContentClick += DetailList_CellContentClick;
            // 
            // Index
            // 
            Index.HeaderText = "Index";
            Index.MinimumWidth = 6;
            Index.Name = "Index";
            Index.Width = 125;
            // 
            // _Name
            // 
            _Name.HeaderText = "Name";
            _Name.MinimumWidth = 6;
            _Name.Name = "_Name";
            _Name.Width = 125;
            // 
            // Number
            // 
            Number.HeaderText = "Number";
            Number.MinimumWidth = 6;
            Number.Name = "Number";
            Number.Width = 125;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.Width = 125;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(IndexText, 0, 0);
            tableLayoutPanel3.Controls.Add(NameText, 1, 0);
            tableLayoutPanel3.Controls.Add(NumberText, 2, 0);
            tableLayoutPanel3.Controls.Add(AmountText, 3, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 417);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(794, 30);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // IndexText
            // 
            IndexText.Dock = DockStyle.Fill;
            IndexText.Location = new Point(3, 3);
            IndexText.Name = "IndexText";
            IndexText.Size = new Size(192, 27);
            IndexText.TabIndex = 0;
            // 
            // NameText
            // 
            NameText.Dock = DockStyle.Fill;
            NameText.Location = new Point(201, 3);
            NameText.Name = "NameText";
            NameText.Size = new Size(192, 27);
            NameText.TabIndex = 1;
            // 
            // NumberText
            // 
            NumberText.Dock = DockStyle.Fill;
            NumberText.Location = new Point(399, 3);
            NumberText.Name = "NumberText";
            NumberText.Size = new Size(192, 27);
            NumberText.TabIndex = 2;
            // 
            // AmountText
            // 
            AmountText.Dock = DockStyle.Fill;
            AmountText.Location = new Point(597, 3);
            AmountText.Name = "AmountText";
            AmountText.Size = new Size(194, 27);
            AmountText.TabIndex = 3;
            // 
            // DetailEdit
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel2);
            Name = "DetailEdit";
            Text = "DetailEdit";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DetailList).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button AddButton;
        private Button DelButton;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView DetailList;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox IndexText;
        private TextBox NameText;
        private TextBox NumberText;
        private TextBox AmountText;
        private Button SaveButton;
        private Button ExitButton;
        private DataGridViewTextBoxColumn Index;
        private DataGridViewTextBoxColumn _Name;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Amount;
    }
}