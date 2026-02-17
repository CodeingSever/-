namespace EmployeeManagementSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(250, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(300, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "โปรแกรมบันทึกข้อมูลพนักงาน";
            // 
            // label1 (EmployeeID)
            // 
            this.label1.Location = new System.Drawing.Point(30, 80);
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.Text = "รหัสพนักงาน:";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(140, 77);
            this.txtEmployeeID.Size = new System.Drawing.Size(200, 23);
            this.txtEmployeeID.ReadOnly = true;
            // 
            // label2 (Name)
            // 
            this.label2.Location = new System.Drawing.Point(30, 110);
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.Text = "ชื่อพนักงาน:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(140, 107);
            this.txtEmployeeName.Size = new System.Drawing.Size(200, 23);
            // 
            // label3 (Position)
            // 
            this.label3.Location = new System.Drawing.Point(30, 140);
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.Text = "ตำแหน่งงาน:";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(140, 137);
            this.txtPosition.Size = new System.Drawing.Size(200, 23);
            // 
            // label4 (Department)
            // 
            this.label4.Location = new System.Drawing.Point(30, 170);
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.Text = "ฝ่าย/แผนก:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(140, 167);
            this.txtDepartment.Size = new System.Drawing.Size(200, 23);
            // 
            // label5 (Email)
            // 
            this.label5.Location = new System.Drawing.Point(30, 200);
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.Text = "อีเมล:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(140, 197);
            this.txtEmail.Size = new System.Drawing.Size(200, 23);
            // 
            // label6 (Phone)
            // 
            this.label6.Location = new System.Drawing.Point(30, 230);
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.Text = "เบอร์โทรศัพท์:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(140, 227);
            this.txtPhone.Size = new System.Drawing.Size(200, 23);
            // 
            // label7 (Status)
            // 
            this.label7.Location = new System.Drawing.Point(30, 260);
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.Text = "สถานะ:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(140, 257);
            this.txtStatus.Size = new System.Drawing.Size(200, 23);
            this.txtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtStatus.Items.AddRange(new object[] { "ทำงานปกติ", "ลาออก", "พักงาน" });
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(30, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "บันทึก (Save)";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(160, 310);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "แก้ไข (Update)";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(290, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "ลบ (Delete)";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(30, 370);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(740, 200);
            this.dgvEmployees.TabIndex = 10;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEmployees.AllowUserToAddRows = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "โปรแกรมบันทึกข้อมูลพนักงาน";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvEmployees;
    }
}
