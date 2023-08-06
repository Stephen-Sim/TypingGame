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
            label1 = new Label();
            textBox1 = new TextBox();
            panel3 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel2);
            panel1.Size = new Size(773, 388);
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(22, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(734, 216);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(17, 19);
            label1.Name = "label1";
            label1.Size = new Size(700, 184);
            label1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 342);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(516, 25);
            textBox1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(progressBar1);
            panel3.Location = new Point(22, 261);
            panel3.Name = "panel3";
            panel3.Size = new Size(734, 62);
            panel3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(618, 25);
            label5.Name = "label5";
            label5.Size = new Size(48, 18);
            label5.TabIndex = 4;
            label5.Text = "0 wpm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(545, 25);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 3;
            label4.Text = "Speed:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 25);
            label3.Name = "label3";
            label3.Size = new Size(24, 18);
            label3.TabIndex = 2;
            label3.Text = "0s";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(402, 25);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 1;
            label2.Text = "Time:";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(17, 23);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(344, 23);
            progressBar1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(544, 339);
            button1.Name = "button1";
            button1.Size = new Size(106, 31);
            button1.TabIndex = 3;
            button1.Text = "Restart";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(652, 339);
            button2.Name = "button2";
            button2.Size = new Size(104, 31);
            button2.TabIndex = 4;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 388);
            Name = "GameForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private TextBox textBox1;
        private Panel panel2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ProgressBar progressBar1;
    }
}