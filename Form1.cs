using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace EmployeeManagementSystem
{
    public partial class Form1 : Form
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                _dbHelper.InitializeDatabase();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                var employees = _dbHelper.GetAllEmployees();
                // Demonstration of LINQ: Sorting by Name
                var sortedEmployees = employees.OrderBy(e => e.EmployeeName).ToList();
                dgvEmployees.DataSource = sortedEmployees;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeName.Text))
            {
                MessageBox.Show("กรุณากรอกชื่อพนักงาน");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("กรุณากรอกอีเมลให้ถูกต้อง");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text) || !Regex.IsMatch(txtPhone.Text, @"^[0-9+]+$"))
            {
                MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์ให้ถูกต้อง");
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtEmployeeID.Clear();
            txtEmployeeName.Clear();
            txtPosition.Clear();
            txtDepartment.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtStatus.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                Employee emp = new Employee
                {
                    EmployeeName = txtEmployeeName.Text,
                    Position = txtPosition.Text,
                    Department = txtDepartment.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Status = txtStatus.Text
                };

                _dbHelper.AddEmployee(emp);
                MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว");
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                MessageBox.Show("กรุณาเลือกพนักงานที่ต้องการแก้ไขจากตาราง");
                return;
            }

            if (!ValidateInput()) return;

            try
            {
                Employee emp = new Employee
                {
                    EmployeeID = int.Parse(txtEmployeeID.Text),
                    EmployeeName = txtEmployeeName.Text,
                    Position = txtPosition.Text,
                    Department = txtDepartment.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Status = txtStatus.Text
                };

                _dbHelper.UpdateEmployee(emp);
                MessageBox.Show("แก้ไขข้อมูลเรียบร้อยแล้ว");
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                MessageBox.Show("กรุณาเลือกพนักงานที่ต้องการลบจากตาราง");
                return;
            }

            var confirmResult = MessageBox.Show("คุณแน่ใจหรือไม่ว่าต้องการลบข้อมูลนี้?", "ยืนยันการลบ", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    _dbHelper.DeleteEmployee(int.Parse(txtEmployeeID.Text));
                    MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว");
                    LoadData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting data: " + ex.Message);
                }
            }
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];
                txtEmployeeID.Text = row.Cells["EmployeeID"].Value.ToString();
                txtEmployeeName.Text = row.Cells["EmployeeName"].Value.ToString();
                txtPosition.Text = row.Cells["Position"].Value.ToString();
                txtDepartment.Text = row.Cells["Department"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtStatus.Text = row.Cells["Status"].Value.ToString();
            }
        }
    }
}
