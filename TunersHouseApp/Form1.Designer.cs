namespace TunersHouseApp
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
            checkedListBox1 = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            textBox1 = new TextBox();
            add = new Button();
            reverse = new Button();
            clear = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            save = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.Black;
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.ForeColor = Color.Red;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(13, 169);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(115, 54);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // checkedListBox2
            // 
            checkedListBox2.BackColor = Color.Black;
            checkedListBox2.BorderStyle = BorderStyle.None;
            checkedListBox2.ForeColor = Color.Red;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Tydzień 1", "Tydzień 2", "Tydzień 3", "Tydzień 4" });
            checkedListBox2.Location = new Point(134, 169);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(115, 54);
            checkedListBox2.TabIndex = 7;
            checkedListBox2.SelectedIndexChanged += checkedListBox2_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(12, 233);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 46);
            textBox1.TabIndex = 0;
            textBox1.Text = "Wybierz frakcje oraz tydzień aby zacząć.";
            // 
            // add
            // 
            add.BackColor = Color.Black;
            add.FlatStyle = FlatStyle.Flat;
            add.ForeColor = Color.Red;
            add.Location = new Point(12, 285);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 8;
            add.Text = "ADD";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // reverse
            // 
            reverse.BackColor = Color.Black;
            reverse.FlatStyle = FlatStyle.Flat;
            reverse.ForeColor = Color.Red;
            reverse.Location = new Point(93, 285);
            reverse.Name = "reverse";
            reverse.Size = new Size(75, 23);
            reverse.TabIndex = 9;
            reverse.Text = "RESTORE";
            reverse.UseVisualStyleBackColor = false;
            reverse.Click += reverse_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.Black;
            clear.FlatStyle = FlatStyle.Flat;
            clear.ForeColor = Color.Red;
            clear.Location = new Point(174, 285);
            clear.Name = "clear";
            clear.Size = new Size(75, 23);
            clear.TabIndex = 10;
            clear.Text = "CLEAR";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(289, 233);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 11;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(290, 264);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 12;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(255, 233);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 13;
            label3.Text = "x1.7";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(255, 264);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 14;
            label4.Text = "30%";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(492, 205);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 74);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // save
            // 
            save.BackColor = Color.Black;
            save.FlatStyle = FlatStyle.Flat;
            save.ForeColor = Color.Red;
            save.Location = new Point(492, 285);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 16;
            save.Text = "SAVE";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(579, 320);
            Controls.Add(save);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(clear);
            Controls.Add(reverse);
            Controls.Add(add);
            Controls.Add(textBox1);
            Controls.Add(checkedListBox2);
            Controls.Add(checkedListBox1);
            DoubleBuffered = true;
            MaximumSize = new Size(595, 359);
            MinimumSize = new Size(595, 359);
            Name = "Form1";
            Text = "Tunre's House";
            UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
        private TextBox textBox1;
        private Button add;
        private Button reverse;
        private Button clear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button save;
    }
}