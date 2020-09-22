using Billetes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_23
{
    public partial class FrmMonedas : Form
    {
        public FrmMonedas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BtnLockCotizacion_Click(object sender, EventArgs e)
        {
            if (txtCotizacionEuro.Enabled == true)
            {
                txtCotizacionEuro.Enabled = false;
                txtCotizacionDolar.Enabled = false;
                txtCotizacionPeso.Enabled = false;
            }
            else
            {
                txtCotizacionEuro.Enabled = true;
                txtCotizacionDolar.Enabled = true;
                txtCotizacionPeso.Enabled = true;
            }
        }

        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            double cotiz;
            if(double.TryParse(txtCotizacionEuro.Text,out cotiz))
            {
                Euro.SetCotizacion(cotiz);
            }
            else
            {
                txtCotizacionEuro.Text = Euro.GetCotizacion().ToString();
            }
        }

        private void txtCotizacionDolar_Leave(object sender, EventArgs e)
        {
            double cotiz;
            if (double.TryParse(txtCotizacionDolar.Text, out cotiz))
            {
                Dolar.SetCotizacion(cotiz);
            }
            else
            {
                txtCotizacionDolar.Text = Dolar.GetCotizacion().ToString();
            }
        }

        private void txtCotizacionPeso_Leave(object sender, EventArgs e)
        {
            double cotiz;
            if (double.TryParse(txtCotizacionPeso.Text, out cotiz))
            {
                Pesos.SetCotizacion(cotiz);
            }
            else
            {
                txtCotizacionPeso.Text = Pesos.GetCotizacion().ToString();
            }
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double valor;
            if(double.TryParse(txtEuroA.Text,out valor))
            {
                txtEuroADolar.Text = ((Dolar) new Euro(valor)).GetCantidad().ToString();
                txtEuroAPeso.Text = ((Pesos)new Euro(valor)).GetCantidad().ToString();
                txtEuroAEuro.Text = txtEuroA.Text;
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double valor;
            if (double.TryParse(txtDolarA.Text, out valor))
            {
                txtDolarADolar.Text = txtDolarA.Text;
                txtDolarAPeso.Text = ((Pesos)new Dolar(valor)).GetCantidad().ToString();
                txtDolarAEuro.Text = ((Euro)new Dolar(valor)).GetCantidad().ToString();
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            double valor;
            if (double.TryParse(txtPesoA.Text, out valor))
            {
                txtPesoAPeso.Text = txtPesoA.Text;
                txtPesoADolar.Text = ((Dolar)new Pesos(valor)).GetCantidad().ToString();
                txtPesoAEuro.Text = ((Euro)new Pesos(valor)).GetCantidad().ToString();
            }
        }
    }
}
