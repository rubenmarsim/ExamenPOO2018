using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedConversorStandard
{
    public partial class frmSpeed : Form
    {
        Calculus CCalculusStandard = new Calculus();

        public frmSpeed()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                speedControl1.Valor = CCalculusStandard.SpeedConversion(int.Parse(txtBoxParsecs.Text));
                speedControl1.txtBoxSpeed.Text = speedControl1.Valor.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduce un valor");
            }
            
        }
    }
}
