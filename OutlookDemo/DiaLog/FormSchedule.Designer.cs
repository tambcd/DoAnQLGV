namespace OutlookDemo.DiaLog
{
    partial class FormSchedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.header = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.txtHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.class_section = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bxHP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bxGV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bxPH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_DS = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_DE = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_TS = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txt_TE = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txt_T = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txt_number = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txt_KN = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txt_QD = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txt_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.header.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_T)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_QD)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.White;
            this.header.Controls.Add(this.btnClose);
            this.header.Controls.Add(this.txtHeader);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(822, 36);
            this.header.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(781, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 20);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtHeader
            // 
            this.txtHeader.AutoSize = true;
            this.txtHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeader.ForeColor = System.Drawing.Color.Black;
            this.txtHeader.Location = new System.Drawing.Point(14, 7);
            this.txtHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(131, 19);
            this.txtHeader.TabIndex = 2;
            this.txtHeader.Text = "Thêm Lớp Tín Chỉ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 60);
            this.panel1.TabIndex = 57;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BorderRadius = 4;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(729, 14);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 35);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 4;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(624, 14);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 35);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BorderRadius = 4;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(11, 14);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 35);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.header;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // class_section
            // 
            this.class_section.BackColor = System.Drawing.Color.Transparent;
            this.class_section.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_section.Location = new System.Drawing.Point(18, 50);
            this.class_section.Name = "class_section";
            this.class_section.Size = new System.Drawing.Size(64, 17);
            this.class_section.TabIndex = 58;
            this.class_section.Text = "Học phần";
            // 
            // bxHP
            // 
            this.bxHP.BackColor = System.Drawing.Color.Transparent;
            this.bxHP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bxHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bxHP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bxHP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bxHP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bxHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.bxHP.ItemHeight = 30;
            this.bxHP.Location = new System.Drawing.Point(18, 82);
            this.bxHP.Name = "bxHP";
            this.bxHP.Size = new System.Drawing.Size(219, 36);
            this.bxHP.TabIndex = 59;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(301, 50);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(104, 17);
            this.guna2HtmlLabel1.TabIndex = 60;
            this.guna2HtmlLabel1.Text = "Tên Lớp Tín Chỉ";
            // 
            // bxGV
            // 
            this.bxGV.BackColor = System.Drawing.Color.Transparent;
            this.bxGV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bxGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bxGV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bxGV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bxGV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bxGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.bxGV.ItemHeight = 30;
            this.bxGV.Location = new System.Drawing.Point(572, 82);
            this.bxGV.Name = "bxGV";
            this.bxGV.Size = new System.Drawing.Size(219, 36);
            this.bxGV.TabIndex = 63;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(572, 50);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(73, 17);
            this.guna2HtmlLabel2.TabIndex = 62;
            this.guna2HtmlLabel2.Text = "Giảng Viên ";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(301, 138);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(104, 17);
            this.guna2HtmlLabel3.TabIndex = 64;
            this.guna2HtmlLabel3.Text = "Giờ kiêm nhiệm";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(572, 138);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(75, 17);
            this.guna2HtmlLabel4.TabIndex = 66;
            this.guna2HtmlLabel4.Text = "Giờ quy đổi";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(18, 138);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(37, 17);
            this.guna2HtmlLabel5.TabIndex = 68;
            this.guna2HtmlLabel5.Text = "Sỹ số";
            // 
            // bxPH
            // 
            this.bxPH.BackColor = System.Drawing.Color.Transparent;
            this.bxPH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bxPH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bxPH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bxPH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bxPH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bxPH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.bxPH.ItemHeight = 30;
            this.bxPH.Location = new System.Drawing.Point(18, 265);
            this.bxPH.Name = "bxPH";
            this.bxPH.Size = new System.Drawing.Size(219, 36);
            this.bxPH.TabIndex = 71;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(18, 233);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(71, 17);
            this.guna2HtmlLabel6.TabIndex = 70;
            this.guna2HtmlLabel6.Text = "Phòng học";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(301, 233);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(131, 17);
            this.guna2HtmlLabel7.TabIndex = 72;
            this.guna2HtmlLabel7.Text = "Ngày học trong tuần";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(572, 233);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(87, 17);
            this.guna2HtmlLabel8.TabIndex = 74;
            this.guna2HtmlLabel8.Text = "Ngày bắt đầu";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(18, 323);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(89, 17);
            this.guna2HtmlLabel9.TabIndex = 76;
            this.guna2HtmlLabel9.Text = "Ngày kết thúc";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(301, 323);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(79, 17);
            this.guna2HtmlLabel10.TabIndex = 78;
            this.guna2HtmlLabel10.Text = "Tiết bắt đầu";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(572, 323);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(81, 17);
            this.guna2HtmlLabel11.TabIndex = 80;
            this.guna2HtmlLabel11.Text = "Tiết kết thúc";
            // 
            // txt_DS
            // 
            this.txt_DS.Checked = true;
            this.txt_DS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DS.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_DS.Location = new System.Drawing.Point(572, 265);
            this.txt_DS.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_DS.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_DS.Name = "txt_DS";
            this.txt_DS.Size = new System.Drawing.Size(219, 36);
            this.txt_DS.TabIndex = 82;
            this.txt_DS.Value = new System.DateTime(2023, 12, 18, 0, 0, 0, 0);
            // 
            // txt_DE
            // 
            this.txt_DE.Checked = true;
            this.txt_DE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DE.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_DE.Location = new System.Drawing.Point(18, 355);
            this.txt_DE.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_DE.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_DE.Name = "txt_DE";
            this.txt_DE.Size = new System.Drawing.Size(219, 36);
            this.txt_DE.TabIndex = 83;
            this.txt_DE.Value = new System.DateTime(2023, 12, 18, 0, 0, 0, 0);
            // 
            // txt_TS
            // 
            this.txt_TS.BackColor = System.Drawing.Color.Transparent;
            this.txt_TS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TS.Location = new System.Drawing.Point(301, 355);
            this.txt_TS.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txt_TS.Name = "txt_TS";
            this.txt_TS.Size = new System.Drawing.Size(219, 36);
            this.txt_TS.TabIndex = 84;
            // 
            // txt_TE
            // 
            this.txt_TE.BackColor = System.Drawing.Color.Transparent;
            this.txt_TE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TE.Location = new System.Drawing.Point(572, 355);
            this.txt_TE.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txt_TE.Name = "txt_TE";
            this.txt_TE.Size = new System.Drawing.Size(219, 36);
            this.txt_TE.TabIndex = 85;
            // 
            // txt_T
            // 
            this.txt_T.BackColor = System.Drawing.Color.Transparent;
            this.txt_T.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_T.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_T.Location = new System.Drawing.Point(301, 265);
            this.txt_T.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.txt_T.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txt_T.Name = "txt_T";
            this.txt_T.Size = new System.Drawing.Size(219, 36);
            this.txt_T.TabIndex = 86;
            this.txt_T.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // txt_number
            // 
            this.txt_number.BackColor = System.Drawing.Color.Transparent;
            this.txt_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_number.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_number.Location = new System.Drawing.Point(18, 170);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(219, 36);
            this.txt_number.TabIndex = 87;
            // 
            // txt_KN
            // 
            this.txt_KN.BackColor = System.Drawing.Color.Transparent;
            this.txt_KN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_KN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_KN.Location = new System.Drawing.Point(301, 170);
            this.txt_KN.Name = "txt_KN";
            this.txt_KN.Size = new System.Drawing.Size(219, 36);
            this.txt_KN.TabIndex = 88;
            // 
            // txt_QD
            // 
            this.txt_QD.BackColor = System.Drawing.Color.Transparent;
            this.txt_QD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_QD.Location = new System.Drawing.Point(572, 170);
            this.txt_QD.Name = "txt_QD";
            this.txt_QD.Size = new System.Drawing.Size(219, 36);
            this.txt_QD.TabIndex = 89;
            // 
            // txt_name
            // 
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.DefaultText = "";
            this.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.Location = new System.Drawing.Point(301, 82);
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderText = "";
            this.txt_name.SelectedText = "";
            this.txt_name.Size = new System.Drawing.Size(219, 36);
            this.txt_name.TabIndex = 90;
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 581);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_QD);
            this.Controls.Add(this.txt_KN);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.txt_T);
            this.Controls.Add(this.txt_TE);
            this.Controls.Add(this.txt_TS);
            this.Controls.Add(this.txt_DE);
            this.Controls.Add(this.txt_DS);
            this.Controls.Add(this.guna2HtmlLabel11);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.bxPH);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.bxGV);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.bxHP);
            this.Controls.Add(this.class_section);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSchedule";
            this.Text = "FormSchedule";
            this.Load += new System.EventHandler(this.FormSchedule_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_T)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_QD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label txtHeader;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2HtmlLabel class_section;
        private Guna.UI2.WinForms.Guna2ComboBox bxHP;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox bxGV;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox bxPH;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2DateTimePicker txt_DS;
        private Guna.UI2.WinForms.Guna2DateTimePicker txt_DE;
        private Guna.UI2.WinForms.Guna2NumericUpDown txt_TS;
        private Guna.UI2.WinForms.Guna2NumericUpDown txt_TE;
        private Guna.UI2.WinForms.Guna2NumericUpDown txt_T;
        private Guna.UI2.WinForms.Guna2NumericUpDown txt_number;
        private Guna.UI2.WinForms.Guna2NumericUpDown txt_KN;
        private Guna.UI2.WinForms.Guna2NumericUpDown txt_QD;
        private Guna.UI2.WinForms.Guna2TextBox txt_name;
    }
}