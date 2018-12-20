using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedConversorSpecial
{
    public partial class frmSpeed : SpeedConversorStandard.frmSpeed
    {
        Calculus CCalculusSpecial = new Calculus();
        SpeedConversorStandard.frmSpeed frmStandar = new SpeedConversorStandard.frmSpeed();
        ControlsPOO.SpeedControl controlspeed = new ControlsPOO.SpeedControl();
        private string _Nave;

        public string Nave
        {
            get { return _Nave; }
            set { _Nave = value; }
        }

        public frmSpeed()
        {
            InitializeComponent();
        }

        private void btnXWings_Click(object sender, EventArgs e)
        {
            Nave = "XW";
           CCalculusSpecial.SpeedConversion(int.Parse(txtBoxParsecs.Text), Nave);
        }

        private void btnShuttle_Click(object sender, EventArgs e)
        {
            Nave = "CS";
            CCalculusSpecial.SpeedConversion(int.Parse(txtBoxParsecs.Text), Nave);
        }

        private void btnUnknown_Click(object sender, EventArgs e)
        {
            Nave = "UR";
            CCalculusSpecial.SpeedConversion(int.Parse(txtBoxParsecs.Text));
        }
    }
}
