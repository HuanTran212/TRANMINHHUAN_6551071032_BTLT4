using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai15_Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            trackBar1.Minimum = 1;
            trackBar1.Maximum = 10;
            trackBar1.Value = 5;

            timer1.Interval = 200;


            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;

                lblComplete.Text = "Percentage Complete: " + progressBar1.Value + "%";
            }
            else
            {
                timer1.Stop();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = 1000 / trackBar1.Value;
        }
    }
}
