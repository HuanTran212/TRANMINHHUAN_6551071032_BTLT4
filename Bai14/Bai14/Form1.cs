namespace Bai14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn không được phép nhập dữ liệu rỗng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
                return;
            }
            else
            {
                string strDulieu = txtTen.Text;
                lstLopA.Items.Add(strDulieu);
                txtTen.Clear();
                txtTen.Focus();
            }
        }

        void chuyenDuLieu(ListBox lst1, ListBox lst2)
        {
            int i = 0;
            while (i < lst1.Items.Count)
                if (lst1.GetSelected(i))
                {
                    string stDuLieu = lst1.Items[i].ToString();
                    lst2.Items.Add(stDuLieu);
                    lst1.Items.RemoveAt(i);
                }
                else
                    i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần chuyển!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult hoiChuyen = MessageBox.Show(
                "Bạn có chắc chuyển những dữ liệu đang chọn không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (hoiChuyen == DialogResult.Yes)
                chuyenDuLieu(lstLopA, lstLopB);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lstLopB.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần chuyển!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult hoiChuyen = MessageBox.Show(
                "Bạn có chắc chuyển những dữ liệu đang chọn không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (hoiChuyen == DialogResult.Yes)
                chuyenDuLieu(lstLopB, lstLopA);
        }
        void chuyenToanBo(ListBox lst1, ListBox lst2)
        {
            while (lst1.Items.Count != 0)
            {
                string stDuLieu = lst1.Items[0].ToString();
                lst2.Items.Add(stDuLieu);
                lst1.Items.RemoveAt(0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lstLopA.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển to{n bộ dữ liệu đang chọn ko ? ", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    chuyenToanBo(lstLopA, lstLopB);
            }
            else
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lstLopB.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển to{n bộ dữ liệu đang chọn ko ? ", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    chuyenToanBo(lstLopB, lstLopA);
            }
            else
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lstLopA.Items.Count > 0)
            {
                DialogResult hoiXoa = MessageBox.Show(
                    "Bạn có chắc muốn xóa tất cả dữ liệu không?",
                    "Chú ý",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                if (hoiXoa == DialogResult.Yes)
                    lstLopA.Items.Clear();
            }
            else
            {
                MessageBox.Show("Hiện danh sách đang rỗng!", "Chú ý");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (lstLopB.Items.Count > 0)
            {
                DialogResult hoiXoa = MessageBox.Show(
                    "Bạn có chắc muốn xóa tất cả dữ liệu không?",
                    "Chú ý",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                if (hoiXoa == DialogResult.Yes)
                    lstLopB.Items.Clear();
            }
            else
            {
                MessageBox.Show("Hiện danh sách đang rỗng!", "Chú ý");
            }
        }
    }
}
