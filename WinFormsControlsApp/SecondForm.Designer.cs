namespace WinFormsControlsApp
{
    partial class SecondForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnExit = new Button();
            btnIgnore = new Button();
            btnOk = new Button();
            lblTablo = new Label();
            linkLabel1 = new LinkLabel();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AutoCompleteCustomSource.AddRange(new string[] { "Москва", "Тула", "Калуга", "Туапсе", "Орел" });
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.Font = new Font("Segoe UI", 24F);
            textBox1.Location = new Point(53, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 50);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.AcceptsReturn = true;
            textBox2.AcceptsTab = true;
            textBox2.Font = new Font("Segoe UI", 24F);
            textBox2.Location = new Point(420, 61);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Size = new Size(336, 253);
            textBox2.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 24F);
            btnExit.Location = new Point(53, 330);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(165, 85);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnIgnore
            // 
            btnIgnore.Font = new Font("Segoe UI", 24F);
            btnIgnore.Location = new Point(315, 330);
            btnIgnore.Name = "btnIgnore";
            btnIgnore.Size = new Size(165, 85);
            btnIgnore.TabIndex = 3;
            btnIgnore.Text = "Ignore";
            btnIgnore.UseVisualStyleBackColor = true;
            btnIgnore.Click += btnIgnore_Click;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 24F);
            btnOk.Location = new Point(591, 330);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(165, 85);
            btnOk.TabIndex = 3;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lblTablo
            // 
            lblTablo.AutoSize = true;
            lblTablo.Font = new Font("Segoe UI", 24F);
            lblTablo.Location = new Point(53, 13);
            lblTablo.Name = "lblTablo";
            lblTablo.Size = new Size(105, 45);
            lblTablo.TabIndex = 4;
            lblTablo.Text = "label1";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 24F);
            linkLabel1.Location = new Point(53, 252);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(191, 45);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://ya.ru";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 24F);
            textBox3.Location = new Point(53, 143);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(316, 50);
            textBox3.TabIndex = 0;
            // 
            // SecondForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 566);
            Controls.Add(linkLabel1);
            Controls.Add(lblTablo);
            Controls.Add(btnOk);
            Controls.Add(btnIgnore);
            Controls.Add(btnExit);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Name = "SecondForm";
            Text = "SecondForm";
            Load += SecondForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnExit;
        private Button btnIgnore;
        private Button btnOk;
        private Label lblTablo;
        private LinkLabel linkLabel1;
        private TextBox textBox3;
    }
}