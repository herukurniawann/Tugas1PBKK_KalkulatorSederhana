namespace WinFormsApp3
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
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(203, 39);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(203, 40);
            maskedTextBox1.TabIndex = 0;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox2.Location = new Point(203, 110);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(203, 40);
            maskedTextBox2.TabIndex = 1;
            maskedTextBox2.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox3.Location = new Point(203, 192);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(203, 40);
            maskedTextBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 48);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 3;
            label1.Text = "Nilai 1 :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 119);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 4;
            label2.Text = "Nilai 2 :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 207);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 5;
            label3.Text = "Hasil :";
            // 
            // button1
            // 
            button1.Location = new Point(74, 283);
            button1.Name = "button1";
            button1.Size = new Size(112, 111);
            button1.TabIndex = 6;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(209, 283);
            button2.Name = "button2";
            button2.Size = new Size(112, 111);
            button2.TabIndex = 7;
            button2.Text = "*";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(74, 412);
            button3.Name = "button3";
            button3.Size = new Size(112, 111);
            button3.TabIndex = 8;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(209, 412);
            button4.Name = "button4";
            button4.Size = new Size(112, 111);
            button4.TabIndex = 9;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(341, 283);
            button5.Name = "button5";
            button5.Size = new Size(112, 240);
            button5.TabIndex = 10;
            button5.Text = "C";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 564);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}