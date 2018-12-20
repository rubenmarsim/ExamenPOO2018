using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsPOO
{
    public partial class SpeedControl: UserControl
    {
        public SpeedControl()
        {
            InitializeComponent();
        }

        #region Propiedades y variables
        private string _Valor;

        public string Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }

        double val=0;
        #endregion

        #region Eventos
        private void txtBoxSpeed_TextChanged(object sender, EventArgs e)
        {
            txtBoxSpeed.Text = Valor;
            val = double.Parse(Valor);
            if (val< 100000)
            {
                pctBoxSpeed.Image = Image.FromFile(@"\images\slow.png");
            }
            else
            {
                pctBoxSpeed.Image = Image.FromFile(@"\images\fast.png");
            }
        }
        #endregion

        private void SpeedControl_Load(object sender, EventArgs e)
        {
            pctBoxSpeed.Image = Image.FromFile(@"\images\unknown.png");
        }
    }
}
