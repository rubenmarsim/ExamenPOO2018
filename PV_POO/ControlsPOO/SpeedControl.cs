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
        private int _Valor;

        public int Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }

        int val = 0;
        
        #endregion

        #region Eventos
        private void txtBoxSpeed_TextChanged(object sender, EventArgs e)
        {
            txtBoxSpeed.Text = Valor.ToString();
            
            if (Valor<100000)
            {
                pctBoxSpeed.ImageLocation = Application.StartupPath + @"\\images\slow.png";
            }
            else
            {
                pctBoxSpeed.ImageLocation = Application.StartupPath + @"\\images\fast.png";
            }
        }
        

        private void SpeedControl_Load(object sender, EventArgs e)
        {
            if(Valor == null) Valor = 0;   
        }
        #endregion
    }
}
