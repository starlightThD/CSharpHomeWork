namespace Assignment1_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            input1 = new TextBox();
            input2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            subButton = new Button();
            multButton = new Button();
            divButton = new Button();
            remButton = new Button();
            label3 = new Label();
            output = new TextBox();
            addButton = new Button();
            SuspendLayout();
            // 
            // input1
            // 
            input1.Location = new Point(53, 119);
            input1.Multiline = true;
            input1.Name = "input1";
            input1.Size = new Size(236, 93);
            input1.TabIndex = 0;
            input1.Tag = "";
            // 
            // input2
            // 
            input2.Location = new Point(53, 238);
            input2.Multiline = true;
            input2.Name = "input2";
            input2.Size = new Size(236, 91);
            input2.TabIndex = 1;
            input2.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 96);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "number1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 215);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "number2";
            label2.Click += label2_Click;
            // 
            // subButton
            // 
            subButton.Font = new Font("Microsoft YaHei UI", 18F);
            subButton.Location = new Point(295, 112);
            subButton.Name = "subButton";
            subButton.Size = new Size(51, 49);
            subButton.TabIndex = 5;
            subButton.Text = "-";
            subButton.UseVisualStyleBackColor = true;
            subButton.Click += subButton_Click;
            // 
            // multButton
            // 
            multButton.Font = new Font("Microsoft YaHei UI", 18F);
            multButton.Location = new Point(295, 195);
            multButton.Name = "multButton";
            multButton.Size = new Size(51, 49);
            multButton.TabIndex = 6;
            multButton.Text = "*";
            multButton.UseVisualStyleBackColor = true;
            multButton.Click += multButton_Click;
            // 
            // divButton
            // 
            divButton.Font = new Font("Microsoft YaHei UI", 18F);
            divButton.Location = new Point(295, 280);
            divButton.Name = "divButton";
            divButton.Size = new Size(51, 49);
            divButton.TabIndex = 7;
            divButton.Text = "/";
            divButton.UseVisualStyleBackColor = true;
            divButton.Click += divButton_Click;
            // 
            // remButton
            // 
            remButton.Font = new Font("Microsoft YaHei UI", 18F);
            remButton.Location = new Point(295, 361);
            remButton.Name = "remButton";
            remButton.Size = new Size(51, 49);
            remButton.TabIndex = 8;
            remButton.Text = "%";
            remButton.UseVisualStyleBackColor = true;
            remButton.Click += remButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(466, 141);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 9;
            label3.Text = "output";
            // 
            // output
            // 
            output.Location = new Point(466, 165);
            output.Multiline = true;
            output.Name = "output";
            output.ReadOnly = true;
            output.Size = new Size(260, 100);
            output.TabIndex = 10;
            // 
            // addButton
            // 
            addButton.Font = new Font("Microsoft YaHei UI", 18F);
            addButton.Location = new Point(295, 33);
            addButton.Name = "addButton";
            addButton.Size = new Size(51, 49);
            addButton.TabIndex = 11;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addButton);
            Controls.Add(output);
            Controls.Add(label3);
            Controls.Add(remButton);
            Controls.Add(divButton);
            Controls.Add(multButton);
            Controls.Add(subButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(input2);
            Controls.Add(input1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input1;
        private TextBox input2;
        private Label label1;
        private Label label2;
        private Button subButton;
        private Button multButton;
        private Button divButton;
        private Button remButton;
        private Label label3;
        private TextBox output;
        private Button addButton;
    }
}
