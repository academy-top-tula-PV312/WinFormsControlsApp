namespace WinFormsControlsApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnOk = new Button();
            txtName = new TextBox();
            lblExample = new Label();
            btnUp = new Button();
            btnDown = new Button();
            btnLeft = new Button();
            btnRight = new Button();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 24F);
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(217, 68);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(261, 134);
            btnOk.TabIndex = 0;
            btnOk.Text = "Hello";
            btnOk.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 24F);
            txtName.Location = new Point(151, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(401, 50);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // lblExample
            // 
            lblExample.AutoSize = true;
            lblExample.BackColor = Color.Maroon;
            lblExample.Font = new Font("Segoe UI", 20F);
            lblExample.ForeColor = Color.White;
            lblExample.Location = new Point(280, 391);
            lblExample.Name = "lblExample";
            lblExample.Size = new Size(117, 37);
            lblExample.TabIndex = 2;
            lblExample.Text = "Example";
            // 
            // btnUp
            // 
            btnUp.Location = new Point(68, 336);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(50, 43);
            btnUp.TabIndex = 3;
            btnUp.Text = "&Up";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // btnDown
            // 
            btnDown.Location = new Point(68, 385);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(50, 43);
            btnDown.TabIndex = 3;
            btnDown.Text = "&Down";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(12, 385);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(50, 43);
            btnLeft.TabIndex = 3;
            btnLeft.Text = "&Left";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(124, 385);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(50, 43);
            btnRight.TabIndex = 3;
            btnRight.Text = "&Right";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(696, 457);
            Controls.Add(btnRight);
            Controls.Add(btnLeft);
            Controls.Add(btnDown);
            Controls.Add(btnUp);
            Controls.Add(lblExample);
            Controls.Add(txtName);
            Controls.Add(btnOk);
            DoubleBuffered = true;
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private TextBox txtName;
        private Label lblExample;
        private Button btnUp;
        private Button btnDown;
        private Button btnLeft;
        private Button btnRight;
    }
}
