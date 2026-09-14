namespace Bai15_ex4
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
            tabControl1 = new TabControl();
            Message = new TabPage();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            Buttons = new TabPage();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton10 = new RadioButton();
            Icon = new TabPage();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            radBottom = new RadioButton();
            radRight = new RadioButton();
            rdoTop = new RadioButton();
            rdoLeft = new RadioButton();
            btnShow = new Button();
            label3 = new Label();
            tabControl1.SuspendLayout();
            Message.SuspendLayout();
            Buttons.SuspendLayout();
            Icon.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Message);
            tabControl1.Controls.Add(Buttons);
            tabControl1.Controls.Add(Icon);
            tabControl1.Location = new Point(69, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(393, 230);
            tabControl1.TabIndex = 0;
            // 
            // Message
            // 
            Message.Controls.Add(textBox2);
            Message.Controls.Add(label2);
            Message.Controls.Add(textBox1);
            Message.Controls.Add(label1);
            Message.Location = new Point(4, 29);
            Message.Name = "Message";
            Message.Padding = new Padding(3);
            Message.Size = new Size(385, 197);
            Message.TabIndex = 0;
            Message.Text = "Message";
            Message.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(344, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 137);
            label2.Name = "label2";
            label2.Size = new Size(224, 20);
            label2.TabIndex = 2;
            label2.Text = "Enter a Caption for MessageBox:";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter the message to display:";
            // 
            // Buttons
            // 
            Buttons.Controls.Add(radioButton6);
            Buttons.Controls.Add(radioButton7);
            Buttons.Controls.Add(radioButton8);
            Buttons.Controls.Add(radioButton9);
            Buttons.Controls.Add(radioButton10);
            Buttons.Location = new Point(4, 29);
            Buttons.Name = "Buttons";
            Buttons.Padding = new Padding(3);
            Buttons.Size = new Size(385, 197);
            Buttons.TabIndex = 1;
            Buttons.Text = "Buttons";
            Buttons.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(6, 126);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(155, 24);
            radioButton6.TabIndex = 9;
            radioButton6.TabStop = true;
            radioButton6.Text = "Yes, No and Cancel";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(6, 96);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(104, 24);
            radioButton7.TabIndex = 8;
            radioButton7.TabStop = true;
            radioButton7.Text = "Yes and No";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(6, 66);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(141, 24);
            radioButton8.TabIndex = 7;
            radioButton8.TabStop = true;
            radioButton8.Text = "Retry and Cancel";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(6, 36);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(127, 24);
            radioButton9.TabIndex = 6;
            radioButton9.TabStop = true;
            radioButton9.Text = "OK and Cancel";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(6, 6);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(50, 24);
            radioButton10.TabIndex = 5;
            radioButton10.TabStop = true;
            radioButton10.Text = "OK";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // Icon
            // 
            Icon.Controls.Add(radioButton5);
            Icon.Controls.Add(radioButton4);
            Icon.Controls.Add(radioButton3);
            Icon.Controls.Add(radioButton2);
            Icon.Controls.Add(radioButton1);
            Icon.Location = new Point(4, 29);
            Icon.Name = "Icon";
            Icon.Padding = new Padding(3);
            Icon.Size = new Size(385, 197);
            Icon.TabIndex = 2;
            Icon.Text = "Icon";
            Icon.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(6, 126);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(85, 24);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "Warning";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 96);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(89, 24);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Question";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 66);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(66, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "None";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 36);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(108, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Information";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 6);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Error";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(radBottom, 1, 1);
            tableLayoutPanel1.Controls.Add(radRight, 1, 0);
            tableLayoutPanel1.Controls.Add(rdoTop, 0, 1);
            tableLayoutPanel1.Controls.Add(rdoLeft, 0, 0);
            tableLayoutPanel1.Location = new Point(73, 293);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5, 10, 10, 10);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(385, 125);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // radBottom
            // 
            radBottom.AutoSize = true;
            radBottom.Location = new Point(193, 65);
            radBottom.Name = "radBottom";
            radBottom.Padding = new Padding(5, 10, 10, 10);
            radBottom.Size = new Size(95, 44);
            radBottom.TabIndex = 3;
            radBottom.TabStop = true;
            radBottom.Text = "Bottom";
            radBottom.UseVisualStyleBackColor = true;
            radBottom.CheckedChanged += radBottom_CheckedChanged;
            // 
            // radRight
            // 
            radRight.AutoSize = true;
            radRight.Location = new Point(193, 13);
            radRight.Name = "radRight";
            radRight.Padding = new Padding(5, 10, 10, 10);
            radRight.Size = new Size(80, 44);
            radRight.TabIndex = 2;
            radRight.TabStop = true;
            radRight.Text = "Right";
            radRight.UseVisualStyleBackColor = true;
            radRight.CheckedChanged += radRight_CheckedChanged;
            // 
            // rdoTop
            // 
            rdoTop.AutoSize = true;
            rdoTop.Location = new Point(8, 65);
            rdoTop.Name = "rdoTop";
            rdoTop.Padding = new Padding(5, 10, 10, 10);
            rdoTop.Size = new Size(70, 44);
            rdoTop.TabIndex = 0;
            rdoTop.TabStop = true;
            rdoTop.Text = "Top";
            rdoTop.UseVisualStyleBackColor = true;
            rdoTop.CheckedChanged += rdoTop_CheckedChanged_1;
            // 
            // rdoLeft
            // 
            rdoLeft.AutoSize = true;
            rdoLeft.Location = new Point(8, 13);
            rdoLeft.Name = "rdoLeft";
            rdoLeft.Padding = new Padding(5, 10, 10, 10);
            rdoLeft.Size = new Size(70, 44);
            rdoLeft.TabIndex = 1;
            rdoLeft.TabStop = true;
            rdoLeft.Text = "Left";
            rdoLeft.UseVisualStyleBackColor = true;
            rdoLeft.CheckedChanged += rdoLeft_CheckedChanged;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(214, 248);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 2;
            btnShow.Text = "Show!";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 282);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 3;
            label3.Text = "Tab layout";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btnShow);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            Message.ResumeLayout(false);
            Message.PerformLayout();
            Buttons.ResumeLayout(false);
            Buttons.PerformLayout();
            Icon.ResumeLayout(false);
            Icon.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Message;
        private TabPage Buttons;
        private TabPage Icon;
        private RadioButton radioButton1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnShow;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private RadioButton radioButton10;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton14;
        private RadioButton radioButton13;
        private RadioButton rdoTop;
        private RadioButton rdoLeft;
        private Label label3;
        private RadioButton radBottom;
        private RadioButton radRight;
    }
}
