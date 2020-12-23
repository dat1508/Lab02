using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_03
{
    public partial class fTicketSale : Form
    {
        public fTicketSale()
        {
            InitializeComponent();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Thoát Chương Trình", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            this.Close();
        }

        private void btnChooseASeat(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.White)
                btn.BackColor = Color.Blue;
            else if (btn.BackColor == Color.Blue)
                btn.BackColor = Color.White;
            else if (btn.BackColor == Color.Yellow)
                MessageBox.Show("Ghế đã được bán!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int TinhTien()
        {
            int Total = 0;
            foreach (var control in gBox1.Controls)
            {
                if (control.GetType() == typeof(Button) && ((Button)control).BackColor == Color.Yellow)
                {
                    switch (((Button)control).Text)
                    {
                        case "1":
                        case "2":
                        case "3":
                        case "4":
                        case "5":
                            Total += 5000;
                            break;
                        case "6":
                        case "7":
                        case "8":
                        case "9":
                        case "10":
                            Total += 6500;
                            break;
                        case "11":
                        case "12":
                        case "13":
                        case "14":
                        case "15":
                            Total += 8000;
                            break;
                    }
                }
            }
            return Total;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            foreach (var control in gBox1.Controls)
            {
                if (control.GetType() == typeof(Button) && ((Button)control).BackColor == Color.Blue)
                {
                    ((Button)control).BackColor = Color.Yellow;
                }
            }
            txtBoxTotal.Text = TinhTien().ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (var control in gBox1.Controls)
            {
                if (control.GetType() == typeof(Button) && ((Button)control).BackColor == Color.Blue)
                {
                    ((Button)control).BackColor = Color.White;
                }
            }
            txtBoxTotal.Text = TinhTien().ToString();
        }
    }
}
