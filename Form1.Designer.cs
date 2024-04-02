namespace Project_File_Manager
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
            Movbtn = new Button();
            Renamebtn = new Button();
            createbtn = new Button();
            Delbtn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            accbtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // Movbtn
            // 
            Movbtn.BackColor = Color.WhiteSmoke;
            Movbtn.Location = new Point(39, 341);
            Movbtn.Margin = new Padding(4, 2, 4, 2);
            Movbtn.Name = "Movbtn";
            Movbtn.Size = new Size(208, 55);
            Movbtn.TabIndex = 0;
            Movbtn.Text = "Move Folder";
            Movbtn.UseVisualStyleBackColor = false;
            Movbtn.Click += button1_Click;
            // 
            // Renamebtn
            // 
            Renamebtn.BackColor = Color.WhiteSmoke;
            Renamebtn.Location = new Point(39, 131);
            Renamebtn.Margin = new Padding(4, 2, 4, 2);
            Renamebtn.Name = "Renamebtn";
            Renamebtn.Size = new Size(208, 55);
            Renamebtn.TabIndex = 1;
            Renamebtn.Text = "Rename Folder";
            Renamebtn.UseVisualStyleBackColor = false;
            Renamebtn.Click += button2_Click;
            // 
            // createbtn
            // 
            createbtn.BackColor = Color.WhiteSmoke;
            createbtn.Location = new Point(39, 26);
            createbtn.Margin = new Padding(4, 2, 4, 2);
            createbtn.Name = "createbtn";
            createbtn.Size = new Size(208, 55);
            createbtn.TabIndex = 3;
            createbtn.Text = "Create Folder";
            createbtn.UseVisualStyleBackColor = false;
            createbtn.Click += button4_Click;
            // 
            // Delbtn
            // 
            Delbtn.BackColor = Color.WhiteSmoke;
            Delbtn.Location = new Point(39, 236);
            Delbtn.Margin = new Padding(4, 2, 4, 2);
            Delbtn.Name = "Delbtn";
            Delbtn.Size = new Size(208, 55);
            Delbtn.TabIndex = 4;
            Delbtn.Text = "Delete Folder";
            Delbtn.UseVisualStyleBackColor = false;
            Delbtn.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(419, 131);
            textBox1.Margin = new Padding(4, 2, 4, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.AllowDrop = true;
            textBox2.Location = new Point(419, 62);
            textBox2.Margin = new Padding(4, 2, 4, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.DragDrop += textBox2_DragDrop;
            textBox2.DragEnter += textBox2_DragEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(331, 62);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 7;
            label1.Text = "Path :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 134);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // accbtn
            // 
            accbtn.Location = new Point(705, 62);
            accbtn.Margin = new Padding(4, 2, 4, 2);
            accbtn.Name = "accbtn";
            accbtn.Size = new Size(64, 28);
            accbtn.TabIndex = 9;
            accbtn.Text = "....";
            accbtn.UseVisualStyleBackColor = true;
            accbtn.Click += accbtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(875, 422);
            Controls.Add(accbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Delbtn);
            Controls.Add(createbtn);
            Controls.Add(Renamebtn);
            Controls.Add(Movbtn);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "File Access";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Movbtn;
        private Button Renamebtn;
        private Button createbtn;
        private Button Delbtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button accbtn;
        private OpenFileDialog openFileDialog1;
    }
}