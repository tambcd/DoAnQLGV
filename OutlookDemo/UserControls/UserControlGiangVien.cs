using OutlookDemo.DiaLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookDemo.UserControls
{
    public partial class UserControlGiangVien : UserControl
    {
        public UserControlGiangVien()
        {
            InitializeComponent();
        }

        public void showHideItem(bool ischeck)
        {
            bxGV.Visible = ischeck;
            laberGv.Visible = ischeck;
            txtMoney.Visible = ischeck;
            labelMoney.Visible = ischeck;
            txt_price.Visible = ischeck;
            price.Visible = ischeck;
            txtSumtime.Visible = ischeck;
            LabelSumTime.Visible = ischeck;
            btnAdd.Visible = !ischeck;

        }

        private void bxGV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
