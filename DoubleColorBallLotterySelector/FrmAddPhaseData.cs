using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace DoubleColorBallLotterySelector
{
    public partial class FrmAddPhaseData : Form
    {
        SinglePhaseDataManager singlePhaseDataManager = new SinglePhaseDataManager();
        public FrmAddPhaseData()
        {
            InitializeComponent();
        }

        private void btnAddPhaseData_Click(object sender, EventArgs e)
        {
            DoubleColorBall objdoubleColerBall = new DoubleColorBall()
            {
                
            };
        }
    }
}
