using Guna.UI2.WinForms;
using OutlookDemo.DiaLog;
using OutlookDemo.UserControls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;



namespace OutlookDemo
{
    public partial class Form1 : Form
    {
        private connectDB ketNoi;
        private UserControlGiangVien userControlGiangVien = new UserControlGiangVien();
        private SqlConnection connection;
        private DataGridView dataGridViewChiTietLop;
        private int isCheckUser = 0;
        public Form1()
        {
            InitializeComponent();
            ketNoi = new connectDB();
            // Khởi tạo dataGridViewChiTietLop
            dataGridViewChiTietLop = new DataGridView();

            // Thêm dataGridViewChiTietLop vào Controls của Form
            Controls.Add(dataGridViewChiTietLop);
            isCheckUser = 0;
        }

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 138, b.Location.Y - 30);
            imgSlide.SendToBack();
        }
        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uC_Inbox1_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }      

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            isCheckUser = 0;
            reloadData();
            headerRename();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            main.Controls.Clear();
            main.Controls.Add(userControlGiangVien);
            userControlGiangVien.gridGV.DataSource = loadDataGrid("select member_code,CONCAT(last_name,' ',first_name),(CASE gender WHEN 0 THEN 'Nam' WHEN 1 THEN N'Nữ' ELSE 'Khác' END),dateOfbirth,hometown,degree from member").Tables[0];
            userControlGiangVien.Dock = DockStyle.Fill;
            userControlGiangVien.btnAdd.Click += opentDialog;
            userControlGiangVien.gridGV.CellDoubleClick += ClickSelectGridView;
            headerRename();
            isCheckUser = 0;
        }
        private void opentDialog(object sender, EventArgs e)
        {
            memberCode = "";
            ShowDialog();
        }
        public string memberCode = "";

        private void ShowDialog()
        {
          
            switch(isCheckUser)
            {
                case 0 :
                    ActionUserForm addUser = new ActionUserForm();
                    addUser.memberCode = memberCode;
                    addUser.LoadDataGrid = new ActionUserForm.LoadData(reloadData);
                    addUser.ShowDialog();
                    break;
                case 1 :
                    FormClass formClass = new FormClass();
                    //addUser.LoadDataGrid = new ActionUserForm.LoadData(reloadData);
                    formClass.ShowDialog();
                    break;
                case 2:
                    FormClassSection formClassSection = new FormClassSection();
                    //addUser.memberCode = memberCode;
                    //addUser.LoadDataGrid = new ActionUserForm.LoadData(reloadData);
                    formClassSection.ShowDialog();
                    break;
                case 3:
                    Formbuilding room = new Formbuilding();
                    //addUser.memberCode = memberCode;
                    //addUser.LoadDataGrid = new ActionUserForm.LoadData(reloadData);
                    room.ShowDialog();
                    break;
                    // default :
                    //    addUser.memberCode = memberCode;
                    //    addUser.LoadDataGrid = new ActionUserForm.LoadData(reloadData);
                    //    addUser.ShowDialog();
            }

        }
        private void ClickSelectGridView(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = userControlGiangVien.gridGV.Rows[e.RowIndex];

            memberCode = row.Cells[0].Value.ToString();
            
            ShowDialog();
        }        
        private void reloadData()
        {
            txtSearch.Text = "";
            string queryUser = "";
            if (isCheckUser == 0)
            {
                queryUser = "select member_code,CONCAT(last_name,' ',first_name),(CASE gender WHEN 0 THEN 'Nam' WHEN 1 THEN N'Nữ' ELSE 'Khác'END),dateOfbirth,hometown,degree from member";
            }
            else if (isCheckUser == 1)
            {
                 queryUser = $"select class_code,class_name,number_students from class;";
            }
            else if (isCheckUser == 2)
            {
                 queryUser = $"select class_section_code,class_section_name,number_credits,number_students from class_section";
            }
            else if (isCheckUser == 3)
            {
                 queryUser = $"select class_room_number,class_room_number from class_room ";
            }

            userControlGiangVien.gridGV.DataSource = loadDataGrid(queryUser).Tables[0];

        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            isCheckUser = 1;
            reloadData();
            headerRename();
        }
        DataSet loadDataGrid(string sql)
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (connection = ketNoi.MoKetNoi())
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataSet);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ketNoi.DongKetNoi(connection);
            }
            return dataSet;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string queryUser = "";
            if (isCheckUser == 0)
            {
                 queryUser = $"select member_code,CONCAT(last_name,' ',first_name),(CASE gender WHEN 0 THEN 'Nam' WHEN 1 THEN N'Nữ' ELSE 'Khác'END) AS gender,dateOfbirth,hometown,degree from member where member_code like  '%{txtSearch.Text}%' or CONCAT(last_name,' ',first_name) like '%{txtSearch.Text}%'  ";
            }
            else if (isCheckUser == 1)
            {
                 queryUser = $"select class_code,class_name,number_students from class where class_code like '%{txtSearch.Text}%' or class_name like '%{txtSearch.Text}%'  ";
            }
            else if (isCheckUser == 2)
            {
                 queryUser = $"select class_section_code,class_section_name,number_credits,number_students from class_section where class_section_code like '%{txtSearch}%' or class_section_name like '%{txtSearch}%'  ";
            }
            else if (isCheckUser == 3)
            {
                 queryUser = $"select class_room_number,class_room_number from class_room where class_room_number like '%{txtSearch}%' or class_room_number like '%{txtSearch}%'  ";
            }
            userControlGiangVien.gridGV.DataSource = loadDataGrid(queryUser).Tables[0];

        }
        private void headerRename()
        {
            if(isCheckUser == 0)
            {
                userControlGiangVien.gridGV.Columns[0].HeaderText = "Mã Giảng Viên ";
                userControlGiangVien.gridGV.Columns[1].HeaderText = "Tên Giảng Viên";
                userControlGiangVien.gridGV.Columns[2].HeaderText = "Giới Tính";
                userControlGiangVien.gridGV.Columns[3].HeaderText = "Ngày Sinh";
                userControlGiangVien.gridGV.Columns[4].HeaderText = "Quê Quán";
                userControlGiangVien.gridGV.Columns[5].HeaderText = "Học Vị";

                userControlGiangVien.gridGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                userControlGiangVien.gridGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                userControlGiangVien.gridGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                userControlGiangVien.gridGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                userControlGiangVien.gridGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                userControlGiangVien.gridGV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else if (isCheckUser == 1)
            {
                userControlGiangVien.gridGV.Columns[0].HeaderText = "Mã Lớp";
                userControlGiangVien.gridGV.Columns[1].HeaderText = "Tên Lớp";
                userControlGiangVien.gridGV.Columns[2].HeaderText = "Si Số";
                userControlGiangVien.gridGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                userControlGiangVien.gridGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }else if (isCheckUser == 2)
            {
                userControlGiangVien.gridGV.Columns[0].HeaderText = "Mã Lớp Học Phần";
                userControlGiangVien.gridGV.Columns[1].HeaderText = "Tên Lớp Học Phần";
                userControlGiangVien.gridGV.Columns[2].HeaderText = "Số Tín Chỉ";
                userControlGiangVien.gridGV.Columns[3].HeaderText = "Si Số";
                userControlGiangVien.gridGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                userControlGiangVien.gridGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else if (isCheckUser == 3)
            {
                userControlGiangVien.gridGV.Columns[0].HeaderText = "Tên Phòng học";
                userControlGiangVien.gridGV.Columns[1].HeaderText = "Tòa";
                userControlGiangVien.gridGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                userControlGiangVien.gridGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            
            

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            isCheckUser = 2;
            reloadData();
            headerRename();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            isCheckUser = 3;
            reloadData();
            headerRename();
        }

    }
}
