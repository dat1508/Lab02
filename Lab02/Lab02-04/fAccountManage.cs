using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_04
{
    public partial class fAccountManage : Form
    {
        static int stt = 0;
        public fAccountManage()
        {
            InitializeComponent();
        }

        private bool ValidateItem()
        {
            if (string.IsNullOrEmpty(txtBoxNumber.Text) ||
               string.IsNullOrEmpty(txtBoxFullname.Text) ||
               string.IsNullOrEmpty(txtBoxAdress.Text) ||
               string.IsNullOrEmpty(txtBoxMoney.Text) ||
               int.Parse(txtBoxMoney.Text) < 0)
                return false;
            return true;
        }

        private int KiemTraTrung(string name)
        {
            if (listVInfor.Items.Count == 0)
                return - 1;
            for(int i = 0; i < listVInfor.Items.Count; i++)
            {
                if (name == listVInfor.Items[i].SubItems[1].Text)
                    return i;
            }
            return -1;
        }

        private void InsertUpdate(int stt)
        {
            
            ListViewItem item = new ListViewItem();
            item.Text = stt.ToString();
            item.SubItems.Add(txtBoxNumber.Text);
            item.SubItems.Add(txtBoxFullname.Text);
            item.SubItems.Add(txtBoxAdress.Text);
            item.SubItems.Add(txtBoxMoney.Text);
            listVInfor.Items.Add(item);
        }

        private int TinhTien()
        {
            int total = 0;
            foreach(ListViewItem item in listVInfor.Items)
            {
                total += int.Parse(item.SubItems[4].Text.ToString());
            }
            return total;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateItem())
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int selectedRow = KiemTraTrung(txtBoxNumber.Text);
            if (selectedRow == -1)
            {

                stt++;
                InsertUpdate(stt);
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxTotal.Text = TinhTien().ToString();
            }
            else
            {
                ListViewItem.ListViewSubItem num = new ListViewItem.ListViewSubItem();
                num.Text = txtBoxNumber.Text;
                ListViewItem.ListViewSubItem name = new ListViewItem.ListViewSubItem();
                name.Text = txtBoxFullname.Text;
                ListViewItem.ListViewSubItem adress = new ListViewItem.ListViewSubItem();
                adress.Text = txtBoxAdress.Text;
                ListViewItem.ListViewSubItem money = new ListViewItem.ListViewSubItem();
                money.Text = txtBoxMoney.Text;
                listVInfor.Items[selectedRow].SubItems[1] = num;
                listVInfor.Items[selectedRow].SubItems[2] = name;
                listVInfor.Items[selectedRow].SubItems[3] = adress;
                listVInfor.Items[selectedRow].SubItems[4] = money;
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxTotal.Text = TinhTien().ToString();
            }
        }
        private void btnEnd_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Thoát Chương Trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listVInfor.Items.Count == 0)
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (ListViewItem i in listVInfor.SelectedItems)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    listVInfor.Items.Remove(i);
                    MessageBox.Show("Xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBoxTotal.Text = TinhTien().ToString();
                }
            }
        }

        private void HienThiNguocLai()
        {
            foreach(ListViewItem item in listVInfor.SelectedItems)
            {
                txtBoxNumber.Text = item.SubItems[1].Text.ToString();
                txtBoxFullname.Text = item.SubItems[2].Text.ToString();
                txtBoxAdress.Text = item.SubItems[3].Text.ToString();
                txtBoxMoney.Text = item.SubItems[4].Text.ToString();
            }
        }

        private void listVInfor_Click(object sender, EventArgs e)
        {
            HienThiNguocLai();
        }
    }
}
