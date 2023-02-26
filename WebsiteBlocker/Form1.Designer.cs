namespace WebsiteBlocker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Control;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Hmmm", "Ok", "No Problem" });
            listBox1.Location = new Point(13, 55);
            listBox1.Margin = new Padding(4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(663, 560);
            listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(5, 5);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(651, 20);
            textBox1.TabIndex = 1;
            textBox1.Text = "Ola";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(697, 13);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(129, 41);
            button1.TabIndex = 2;
            button1.Text = "Block";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(697, 62);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(129, 41);
            button2.TabIndex = 3;
            button2.Text = "Unblock";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(663, 32);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(661, 30);
            panel2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 657);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Website Blocker";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
    }
}