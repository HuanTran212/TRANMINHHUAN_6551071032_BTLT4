namespace Bai18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tileHorizonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muaxuan f2 = new muaxuan();
            muahe f3 = new muahe();
            muathu f4 = new muathu();
            muadong  f5 = new muadong();

            f2.MdiParent = this;
            f3.MdiParent = this;
            f4.MdiParent = this;
            f5.MdiParent = this;

            f2.Show();
            f3.Show();
            f4.Show();
            f5.Show();
        }
    }
}
