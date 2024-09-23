namespace WinFormsControlsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //btnOk.BackColor = Color.Magenta;
            //btnOk.ForeColor = Color.White;

            //btnOk.Enabled = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //if(sender is TextBox txt)
            //{
            //    txt = sender as TextBox;
            //    if (txt?.Text.Trim().Length > 0)
            //        btnOk.Enabled = true;
            //}
            //if (txtName.Text.Trim().Length > 0)
            //    btnOk.Enabled = true;
            //else
            //    btnOk.Enabled = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Hello {txtName.Text}");
            SecondForm secondForm = new SecondForm();
            secondForm.Show();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            lblExample.Top -= 5;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            lblExample.Top += 5;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            lblExample.Location = new Point(lblExample.Location.X - 5, lblExample.Location.Y);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            lblExample.Left += 5;
        }
    }
}
