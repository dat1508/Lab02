using System;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class fMayTinh : Form
    {
        public fMayTinh()
        {
            InitializeComponent();
        }
        
        public static float Cong(float a, float b)
        {
            return a + b;
        }

        public static float Tru(float a, float b)
        {
            return a - b;
        }

        public static float Nhan(float a, float b)
        {
            return a * b;
        }

        public static float Chia(float a, float b)
        {
            return a/b;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            string s = ((Button)sender).Text;
            if (string.IsNullOrEmpty(txtBoxNumber1.Text) ||
                string.IsNullOrEmpty(txtBoxNumber2.Text))
            {
                MessageBox.Show("Vui lòng nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                float v = float.Parse(txtBoxNumber1.Text);
                float v1 = float.Parse(txtBoxNumber2.Text);
                if (s == "+")
                {
                    txtBoxDapAn.Text = Cong(v, v1).ToString();
                }

                if (s == "-")
                {
                    txtBoxDapAn.Text = Tru(v, v1).ToString();
                }

                if (s == "*")
                {
                    txtBoxDapAn.Text = Nhan(v, v1).ToString();
                }

                if (s == "/")
                {
                    txtBoxDapAn.Text = Chia(v, v1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtBoxNumber1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
