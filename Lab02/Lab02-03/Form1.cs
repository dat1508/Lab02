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

        private void KiemTraMau()
        {
            foreach (Control in this.gBox1)
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            
        }
    }
}
