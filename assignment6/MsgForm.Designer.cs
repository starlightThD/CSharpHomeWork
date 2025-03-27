namespace assignment6
{
    partial class MsgForm
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
            AmountText = new TextBox();
            OrderAmount = new Label();
            CustomerText = new TextBox();
            OrderCustomer = new Label();
            NameText = new TextBox();
            OrderName = new Label();
            IDText = new TextBox();
            OrderID = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            OKButton = new Button();
            Cancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // AmountText
            // 
            AmountText.Dock = DockStyle.Fill;
            AmountText.Location = new Point(143, 263);
            AmountText.Multiline = true;
            AmountText.Name = "AmountText";
            AmountText.Size = new Size(654, 62);
            AmountText.TabIndex = 7;
            // 
            // OrderAmount
            // 
            OrderAmount.AutoSize = true;
            OrderAmount.Dock = DockStyle.Fill;
            OrderAmount.FlatStyle = FlatStyle.Flat;
            OrderAmount.Location = new Point(3, 260);
            OrderAmount.Name = "OrderAmount";
            OrderAmount.Size = new Size(134, 68);
            OrderAmount.TabIndex = 3;
            OrderAmount.Text = "OrderAmount";
            OrderAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerText
            // 
            CustomerText.Dock = DockStyle.Fill;
            CustomerText.Location = new Point(143, 170);
            CustomerText.Multiline = true;
            CustomerText.Name = "CustomerText";
            CustomerText.Size = new Size(654, 87);
            CustomerText.TabIndex = 6;
            // 
            // OrderCustomer
            // 
            OrderCustomer.AutoSize = true;
            OrderCustomer.Dock = DockStyle.Fill;
            OrderCustomer.FlatStyle = FlatStyle.Flat;
            OrderCustomer.Location = new Point(3, 167);
            OrderCustomer.Name = "OrderCustomer";
            OrderCustomer.Size = new Size(134, 93);
            OrderCustomer.TabIndex = 2;
            OrderCustomer.Text = "OrderCustomer";
            OrderCustomer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameText
            // 
            NameText.Dock = DockStyle.Fill;
            NameText.Location = new Point(143, 83);
            NameText.Multiline = true;
            NameText.Name = "NameText";
            NameText.Size = new Size(654, 81);
            NameText.TabIndex = 5;
            // 
            // OrderName
            // 
            OrderName.AutoSize = true;
            OrderName.Dock = DockStyle.Fill;
            OrderName.FlatStyle = FlatStyle.Flat;
            OrderName.Location = new Point(3, 80);
            OrderName.Name = "OrderName";
            OrderName.Size = new Size(134, 87);
            OrderName.TabIndex = 1;
            OrderName.Text = "OrderName";
            OrderName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IDText
            // 
            IDText.Dock = DockStyle.Fill;
            IDText.Location = new Point(143, 3);
            IDText.Multiline = true;
            IDText.Name = "IDText";
            IDText.Size = new Size(654, 74);
            IDText.TabIndex = 4;
            // 
            // OrderID
            // 
            OrderID.AutoSize = true;
            OrderID.Dock = DockStyle.Fill;
            OrderID.FlatStyle = FlatStyle.Flat;
            OrderID.Location = new Point(3, 0);
            OrderID.Name = "OrderID";
            OrderID.Size = new Size(134, 80);
            OrderID.TabIndex = 0;
            OrderID.Text = "OrderID";
            OrderID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.5F));
            tableLayoutPanel1.Controls.Add(OrderID, 0, 0);
            tableLayoutPanel1.Controls.Add(OrderName, 0, 1);
            tableLayoutPanel1.Controls.Add(OrderCustomer, 0, 2);
            tableLayoutPanel1.Controls.Add(AmountText, 1, 3);
            tableLayoutPanel1.Controls.Add(OrderAmount, 0, 3);
            tableLayoutPanel1.Controls.Add(CustomerText, 1, 2);
            tableLayoutPanel1.Controls.Add(IDText, 1, 0);
            tableLayoutPanel1.Controls.Add(NameText, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.66355F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.33645F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.Size = new Size(800, 328);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(OKButton);
            flowLayoutPanel1.Controls.Add(Cancel);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 404);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 46);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // OKButton
            // 
            OKButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OKButton.AutoSize = true;
            OKButton.Location = new Point(3, 3);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(394, 40);
            OKButton.TabIndex = 8;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // Cancel
            // 
            Cancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Cancel.AutoSize = true;
            Cancel.Location = new Point(403, 3);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(394, 40);
            Cancel.TabIndex = 9;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // MsgForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            Name = "MsgForm";
            Text = "MsgForm";
            Load += MsgForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox AmountText;
        private Label OrderAmount;
        private TextBox CustomerText;
        private Label OrderCustomer;
        private TextBox NameText;
        private Label OrderName;
        private TextBox IDText;
        private Label OrderID;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button OKButton;
        private Button Cancel;
    }
}