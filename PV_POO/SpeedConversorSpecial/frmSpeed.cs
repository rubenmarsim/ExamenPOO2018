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
        #region Instancias y variables globales
        Calculus CCalculusSpecial = new Calculus();
        SpeedConversorStandard.frmSpeed frmStandar = new SpeedConversorStandard.frmSpeed();
        ControlsPOO.SpeedControl controlspeed = new ControlsPOO.SpeedControl();
        private const string MensajeError = "Introduce un valor";
        #endregion

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

        #region Eventos
        private void btnXWings_Click(object sender, EventArgs e)
        {
            try
            {
                Nave = "XW";
                speedControl1.Valor = CCalculusSpecial.SpeedConversion(int.Parse(txtBoxParsecs.Text), Nave);
                speedControl1.txtBoxSpeed.Text = speedControl1.Valor.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show(MensajeError);
            }
            
        }

        private void btnShuttle_Click(object sender, EventArgs e)
        {
            try
            {
                Nave = "CS";
                speedControl1.Valor = CCalculusSpecial.SpeedConversion(int.Parse(txtBoxParsecs.Text), Nave);
                speedControl1.txtBoxSpeed.Text = speedControl1.Valor.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show(MensajeError);
            }            
        }

        private void btnUnknown_Click(object sender, EventArgs e)
        {
            try
            {
                Nave = "UR";
                speedControl1.Valor = CCalculusSpecial.SpeedConversion(int.Parse(txtBoxParsecs.Text));
                speedControl1.txtBoxSpeed.Text = speedControl1.Valor.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show(MensajeError);
            }            
        }
        #endregion
    }
}
