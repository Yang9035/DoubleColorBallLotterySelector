using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleColorBallLotterySelector
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        //添加数据
        private void tsAddData_Click(object sender, EventArgs e)
        {
            FrmAddPhaseData frmAddPhaseData = new FrmAddPhaseData();
            frmAddPhaseData.ShowDialog();
        }
    }
}
