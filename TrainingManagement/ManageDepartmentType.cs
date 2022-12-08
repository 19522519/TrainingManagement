using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingManagement.Controller;

namespace TrainingManagement
{
    public partial class ManageDepartmentType : Form
    {
        DepartmentTypeController departmentTypeController = new DepartmentTypeController();
        public ManageDepartmentType()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            dgvDepartmentType.DataSource = departmentTypeController.getAll();
            addBinding();
        }

        void addBinding()
        {
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dgvDepartmentType.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("Text", dgvDepartmentType.DataSource, "Name", true, DataSourceUpdateMode.Never);
            txtPhone.DataBindings.Clear();
            txtPhone.DataBindings.Add("Text", dgvDepartmentType.DataSource, "Phone", true, DataSourceUpdateMode.Never);
            txtAddress.DataBindings.Clear();
            txtAddress.DataBindings.Add("Text", dgvDepartmentType.DataSource, "Address", true, DataSourceUpdateMode.Never);

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!checkEmpty())
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            department department = new department()
            {
                name = txtName.Text,
                phone = txtPhone.Text,
                address = txtAddress.Text,
            };
            departmentTypeController.AddDepartment(department);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                departmentTypeController.DeleteDepartment(Int32.Parse(txtID.Text));
                LoadData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!checkEmpty())
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            department department = new department()
            {
                id = Int32.Parse(txtID.Text),
                name = txtName.Text,
                phone = txtPhone.Text,
                address = txtAddress.Text
            };
            departmentTypeController.UpdateDepartment(department);
            LoadData();
        }

        private bool checkEmpty()
        {
            foreach (Control item in groupBoxDepartment.Controls)
            {
                if (item is TextBox && item.Text == "")
                {
                    return false;
                }
            }

            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDepartmentType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDepartmentType.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtPhone.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
