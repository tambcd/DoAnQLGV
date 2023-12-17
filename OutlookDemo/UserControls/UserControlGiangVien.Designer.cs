namespace OutlookDemo.UserControls
{
    partial class UserControlGiangVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMoney = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelMoney = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_price = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.price = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSumtime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LabelSumTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.laberGv = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bxGV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMoney);
            this.panel1.Controls.Add(this.labelMoney);
            this.panel1.Controls.Add(this.txt_price);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.txtSumtime);
            this.panel1.Controls.Add(this.LabelSumTime);
            this.panel1.Controls.Add(this.laberGv);
            this.panel1.Controls.Add(this.bxGV);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 46);
            this.panel1.TabIndex = 7;
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.Color.Transparent;
            this.txtMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(772, 11);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(2);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(93, 19);
            this.txtMoney.TabIndex = 22;
            this.txtMoney.Text = "1000000000";
            this.txtMoney.Visible = false;
            // 
            // labelMoney
            // 
            this.labelMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoney.Location = new System.Drawing.Point(691, 11);
            this.labelMoney.Margin = new System.Windows.Forms.Padding(2);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(77, 19);
            this.labelMoney.TabIndex = 21;
            this.labelMoney.Text = "Tổng tiền:";
            this.labelMoney.Visible = false;
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.Color.Transparent;
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(594, 11);
            this.txt_price.Margin = new System.Windows.Forms.Padding(2);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(57, 19);
            this.txt_price.TabIndex = 20;
            this.txt_price.Text = "100000";
            this.txt_price.Visible = false;
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.Transparent;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(526, 12);
            this.price.Margin = new System.Windows.Forms.Padding(2);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(64, 19);
            this.price.TabIndex = 19;
            this.price.Text = "Đơn giá:";
            this.price.Visible = false;
            // 
            // txtSumtime
            // 
            this.txtSumtime.BackColor = System.Drawing.Color.Transparent;
            this.txtSumtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumtime.Location = new System.Drawing.Point(425, 12);
            this.txtSumtime.Margin = new System.Windows.Forms.Padding(2);
            this.txtSumtime.Name = "txtSumtime";
            this.txtSumtime.Size = new System.Drawing.Size(48, 19);
            this.txtSumtime.TabIndex = 18;
            this.txtSumtime.Text = "10000";
            this.txtSumtime.Visible = false;
            // 
            // LabelSumTime
            // 
            this.LabelSumTime.BackColor = System.Drawing.Color.Transparent;
            this.LabelSumTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSumTime.Location = new System.Drawing.Point(327, 11);
            this.LabelSumTime.Margin = new System.Windows.Forms.Padding(2);
            this.LabelSumTime.Name = "LabelSumTime";
            this.LabelSumTime.Size = new System.Drawing.Size(94, 19);
            this.LabelSumTime.TabIndex = 17;
            this.LabelSumTime.Text = "Tổng số giờ:";
            this.LabelSumTime.Visible = false;
            // 
            // laberGv
            // 
            this.laberGv.BackColor = System.Drawing.Color.Transparent;
            this.laberGv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laberGv.Location = new System.Drawing.Point(4, 11);
            this.laberGv.Margin = new System.Windows.Forms.Padding(2);
            this.laberGv.Name = "laberGv";
            this.laberGv.Size = new System.Drawing.Size(81, 19);
            this.laberGv.TabIndex = 16;
            this.laberGv.Text = "Giảng viên";
            this.laberGv.Visible = false;
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
            this.bxGV.Location = new System.Drawing.Point(89, 5);
            this.bxGV.Margin = new System.Windows.Forms.Padding(2);
            this.bxGV.Name = "bxGV";
            this.bxGV.Size = new System.Drawing.Size(220, 36);
            this.bxGV.TabIndex = 15;
            this.bxGV.Visible = false;
            this.bxGV.SelectedIndexChanged += new System.EventHandler(this.bxGV_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(992, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridGV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1096, 594);
            this.panel2.TabIndex = 8;
            // 
            // gridGV
            // 
            this.gridGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridGV.EnableHeadersVisualStyles = false;
            this.gridGV.Location = new System.Drawing.Point(0, 0);
            this.gridGV.Name = "gridGV";
            this.gridGV.RowHeadersWidth = 30;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gridGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridGV.Size = new System.Drawing.Size(1096, 594);
            this.gridGV.TabIndex = 0;
            // 
            // UserControlGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "UserControlGiangVien";
            this.Size = new System.Drawing.Size(1096, 640);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView gridGV;
        public Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelMoney;
        private Guna.UI2.WinForms.Guna2HtmlLabel price;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelSumTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel laberGv;
        public Guna.UI2.WinForms.Guna2ComboBox bxGV;
        public Guna.UI2.WinForms.Guna2HtmlLabel txtSumtime;
        public Guna.UI2.WinForms.Guna2HtmlLabel txt_price;
        public Guna.UI2.WinForms.Guna2HtmlLabel txtMoney;
    }
}
