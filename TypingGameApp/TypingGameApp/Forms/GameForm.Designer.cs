namespace TypingGameApp.Forms
{
    partial class GameForm
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
            panel2 = new Panel();
            richTextBox1 = new RichTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel2);
            panel1.Size = new Size(773, 395);
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(richTextBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(22, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(734, 279);
            panel2.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.Location = new Point(32, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(671, 205);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(655, 236);
            label5.Name = "label5";
            label5.Size = new Size(48, 18);
            label5.TabIndex = 4;
            label5.Text = "0 wpm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(582, 236);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 3;
            label4.Text = "Speed:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(509, 236);
            label3.Name = "label3";
            label3.Size = new Size(24, 18);
            label3.TabIndex = 2;
            label3.Text = "0s";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 236);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 1;
            label2.Text = "Time:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(27, 337);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(516, 25);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(549, 334);
            button1.Name = "button1";
            button1.Size = new Size(106, 31);
            button1.TabIndex = 3;
            button1.Text = "Restart";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(657, 334);
            button2.Name = "button2";
            button2.Size = new Size(104, 31);
            button2.TabIndex = 4;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(204, 117);
            label1.Name = "label1";
            label1.Size = new Size(329, 32);
            label1.TabIndex = 9;
            label1.Text = "Retrieving Data . . .";
            label1.Visible = false;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 395);
            Name = "GameForm";
            Load += GameForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox1;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}