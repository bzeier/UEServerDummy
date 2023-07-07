using System.Runtime.InteropServices;

namespace UEServerDummy
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            label7 = new Label();
            label4 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(27, 25);
            label1.TabIndex = 0;
            label1.Text = "IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(45, 9);
            label2.MinimumSize = new Size(120, 6);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 1;
            label2.Text = "undefined";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 9);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 2;
            label3.Text = "PORT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(457, 9);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 4;
            label5.Text = "STATUS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlDark;
            label6.Location = new Point(535, 9);
            label6.Name = "label6";
            label6.Size = new Size(55, 25);
            label6.TabIndex = 5;
            label6.Text = "None";
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Location = new Point(25, 89);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(139, 34);
            button1.TabIndex = 6;
            button1.Text = "Shutdown";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Location = new Point(170, 89);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(169, 34);
            button2.TabIndex = 7;
            button2.Text = "Kick All Players";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 31);
            textBox1.TabIndex = 8;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Location = new Point(246, 154);
            button3.Name = "button3";
            button3.Size = new Size(79, 34);
            button3.TabIndex = 9;
            button3.Text = "Send";
            button3.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 128);
            label7.Name = "label7";
            label7.Size = new Size(169, 25);
            label7.TabIndex = 10;
            label7.Text = "Broadcast Message:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(258, 9);
            label4.MinimumSize = new Size(120, 6);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 11;
            label4.Text = "undefined";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 59);
            label8.Name = "label8";
            label8.Size = new Size(125, 25);
            label8.TabIndex = 12;
            label8.Text = "Server Control";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(693, 9);
            label9.Name = "label9";
            label9.Size = new Size(51, 25);
            label9.TabIndex = 13;
            label9.Text = "TIME";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Control;
            label10.Location = new Point(750, 9);
            label10.MinimumSize = new Size(40, 5);
            label10.Name = "label10";
            label10.Size = new Size(40, 25);
            label10.TabIndex = 14;
            label10.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DarkSlateGray;
            pictureBox2.Location = new Point(12, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(780, 1);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Wurms Online - Dedicated Server Instance";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private Label label7;
        private Label label4;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox2;
    }
}