namespace TypingGameApp.Forms
{
    partial class CompleteTypeForm
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Size = new Size(499, 375);
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(478, 311);
            panel2.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(98, 271);
            label7.Name = "label7";
            label7.Size = new Size(0, 18);
            label7.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(98, 217);
            label6.Name = "label6";
            label6.Size = new Size(0, 18);
            label6.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 271);
            label5.Name = "label5";
            label5.Size = new Size(48, 18);
            label5.TabIndex = 4;
            label5.Text = "Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 217);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 3;
            label4.Text = "Speed:";
            // 
            // label3
            // 
            label3.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 138);
            label3.Name = "label3";
            label3.Size = new Size(441, 63);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.Location = new Point(19, 52);
            label2.Name = "label2";
            label2.Size = new Size(431, 57);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 20);
            label1.Name = "label1";
            label1.Size = new Size(232, 18);
            label1.TabIndex = 0;
            label1.Text = "You Just Typed the Article: ";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(386, 332);
            button2.Name = "button2";
            button2.Size = new Size(104, 31);
            button2.TabIndex = 8;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(278, 332);
            button1.Name = "button1";
            button1.Size = new Size(106, 31);
            button1.TabIndex = 7;
            button1.Text = "Retry";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CompleteTypeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 375);
            Name = "CompleteTypeForm";
            Load += CompleteTypeForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Button button2;
        private Button button1;
    }
}