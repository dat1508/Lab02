using System;
using System.Windows.Forms;

namespace Lab02_02
{
    public partial class fQuanLySinhVien : Form
    {
        public fQuanLySinhVien()
        {
            InitializeComponent();
        }

        private void fQuanLySinhVien_Load(object sender, EventArgs e)
        {
            cBoxFaculty.Text = "QTKD";
            txtBnumberFemale.Text = 0.ToString();
            txtBnumberMale.Text = 0.ToString();
            rBtnFemale.Checked = true;
        }

        private void InsertUpdate(int selectedRow)
        {
            dgvStudent.Rows[selectedRow].Cells[0].Value = txtBoxNumber.Text;
            dgvStudent.Rows[selectedRow].Cells[1].Value = txtBoxName.Text;
            dgvStudent.Rows[selectedRow].Cells[2].Value = rBtnFemale.Checked ? "Nữ" : "Nam";
            dgvStudent.Rows[selectedRow].Cells[3].Value = float.Parse(txtBoxAverage.Text.ToString());
            dgvStudent.Rows[selectedRow].Cells[4].Value = cBoxFaculty.Text;
        }

        private bool ValidateItem()
        {
            if (string.IsNullOrEmpty(txtBoxNumber.Text) || 
                string.IsNullOrEmpty(txtBoxName.Text) || 
                string.IsNullOrEmpty(txtBoxAverage.Text))
            {
                return false;
            }
            if (int.Parse(txtBoxAverage.Text) > 10)
                return false;
            return true;
        }

        private int ValidateAvaiable(string studentID)
        {

            
                for (int i = 0; i < dgvStudent.Rows.Count; i++)
                {
                    if (dgvStudent.Rows[i].Cells[0].Value.ToString() == studentID)
                    {
                        return i;
                    }
                }
                return -1;

        }
        private void CapNhatNumber()
        {
            int num = 0;
            int num1 = 0;

            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[2].Value.ToString() == "Nữ")
                {
                    num += 1;
                }
                else
                {
                    num1 += 1;
                }
            }
            txtBnumberMale.Text = num1.ToString();
            txtBnumberFemale.Text = num.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(!ValidateItem())
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int selectedRow = ValidateAvaiable(txtBoxNumber.Text);

                if(selectedRow == -1)
                {
                    selectedRow = dgvStudent.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CapNhatNumber();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = ValidateAvaiable(txtBoxNumber.Text);
                if(selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy MSSV cần xóa!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", " YES/NO", MessageBoxButtons.YesNo);
                    if(dr == DialogResult.Yes)
                    {
                        dgvStudent.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xóa sinh viên thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                CapNhatNumber();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rows = this.dgvStudent.Rows[e.RowIndex];
            txtBoxNumber.Text = rows.Cells[0].Value.ToString();
            txtBoxName.Text = rows.Cells[1].Value.ToString();
            if (rows.Cells[2].Value.ToString() == "Nữ")
            {
                rBtnFemale.Checked = true;
            }
            else
            {
                rBtnMale.Checked = true;
            }
            txtBoxAverage.Text = rows.Cells[3].Value.ToString();
            cBoxFaculty.Text = rows.Cells[4].Value.ToString();
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
