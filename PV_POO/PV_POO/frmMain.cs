using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV_POO
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        #region Instancias
        SpeedConversorStandard.frmSpeed frmSCStandard = new SpeedConversorStandard.frmSpeed();
        SpeedConversorSpecial.frmSpeed frmSCSpecial = new SpeedConversorSpecial.frmSpeed();
        #endregion

        #region Eventos
        private void btnSCStandard_Click(object sender, EventArgs e)
        {
            frmSCStandard.Show();
        }

        private void btnSCSpecial_Click(object sender, EventArgs e)
        {
            frmSCSpecial.Show();
        }
        #endregion
    }
}
