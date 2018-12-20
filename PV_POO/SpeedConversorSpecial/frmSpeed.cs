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
            speedControl1.Valor = CCalculusSpecial.SpeedConversion(int.Parse(txtBoxParsecs.Text), Nave);
            speedControl1.txtBoxSpeed.Text = speedControl1.Valor.ToString();
        }

        private void btnShuttle_Click(object sender, EventArgs e)
        {
            Nave = "CS";
            speedControl1.Valor = CCalculusSpecial.SpeedConversion(int.Parse(txtBoxParsecs.Text), Nave);
            speedControl1.txtBoxSpeed.Text = speedControl1.Valor.ToString();
        }

        private void btnUnknown_Click(object sender, EventArgs e)
        {
            Nave = "UR";
            speedControl1.Valor = CCalculusSpecial.SpeedConversion(int.Parse(txtBoxParsecs.Text));
            speedControl1.txtBoxSpeed.Text = speedControl1.Valor.ToString();
        }
    }
}
