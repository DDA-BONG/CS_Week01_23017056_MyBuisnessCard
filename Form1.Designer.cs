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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            splitter1 = new Splitter();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._333513745_723309442538120_4664664086457855711_n_1_1;
            pictureBox1.Location = new Point(71, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(339, 351);
            button1.Name = "button1";
            button1.Size = new Size(159, 38);
            button1.TabIndex = 2;
            button1.Text = "배경색 랜덤 변경";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(517, 77);
            label1.Name = "label1";
            label1.Size = new Size(116, 45);
            label1.TabIndex = 3;
            label1.Text = "윤형규";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(517, 152);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 4;
            label2.Text = "컴퓨터SW학과";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.DarkViolet;
            label3.Location = new Point(409, 192);
            label3.Name = "label3";
            label3.Size = new Size(321, 21);
            label3.TabIndex = 5;
            label3.Text = "010-8835-9796 / yhk1071206@gmail.com";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(8, 480);
            splitter1.TabIndex = 6;
            splitter1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(501, 243);
            button2.Name = "button2";
            button2.Size = new Size(130, 30);
            button2.TabIndex = 7;
            button2.Text = "GitHub";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuBar;
            button3.Location = new Point(134, 279);
            button3.Name = "button3";
            button3.Size = new Size(130, 30);
            button3.TabIndex = 8;
            button3.Text = "사진 변경";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(839, 480);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(splitter1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Splitter splitter1;
        private Button button2;
        private Button button3;
    }
}
