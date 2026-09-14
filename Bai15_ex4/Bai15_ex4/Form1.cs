namespace Bai15_ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            rdoTop.Checked = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void rdoLeft_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.Alignment = TabAlignment.Left;
        }

        private void rdoTop_CheckedChanged_1(object sender, EventArgs e)
        {
            tabControl1.Alignment = TabAlignment.Top;
        }

        private void radRight_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.Alignment = TabAlignment.Right;
        }

        private void radBottom_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.Alignment = TabAlignment.Bottom;
        }
    }
}
