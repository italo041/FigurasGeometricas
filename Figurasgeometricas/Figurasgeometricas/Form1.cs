using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figurasgeometricas.Clases;
using System.Globalization;
namespace Figurasgeometricas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcRomb_Click(object sender, EventArgs e)
        {
            Romboide romboide = new Romboide();
            romboide.Base = Convert.ToDouble(txtBaseRomb.Text);
            romboide.Altura = Convert.ToDouble(txtAltRomb.Text);

            romboide.CalcularArea();

            txtResultRomb.Text = Convert.ToString(romboide.Area);


        }

        private void txtBaseRomb_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back
                            ||  (e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator))
                        || ((e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
                            && txt.Text.Contains('.'));
        }

        private void txtAltRomb_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back
                            || (e.KeyChar == 'm' || e.KeyChar == 'M')
                            || (e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator))
                        || ((e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
                            && txt.Text.Contains('.'))
                        || ((e.KeyChar == 'm' || e.KeyChar == 'M')
                            && txt.Text.ToUpper().Contains('M'));
        }

        private void btnCalcOcto_Click(object sender, EventArgs e)
        {
            Octogono objOcto = new Octogono();
            objOcto.Lado = Convert.ToDouble(txtLadoOcto.Text);

            objOcto.CalcularArea();

            txtResultOcto.Text = Convert.ToString(objOcto.Area);
        }

        private void txtLadoOcto_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back
                            || (e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator))
                        || ((e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
                            && txt.Text.Contains('.'));
        }

        private void BtnCalcTra_Click(object sender, EventArgs e)
        {
            Trapecio objTra = new Trapecio();

            objTra.Altura = Convert.ToDouble(txtAltTra.Text);
            objTra.Bmayor = Convert.ToDouble(txtBMayor.Text);
            objTra.Bmenor = Convert.ToDouble(txtBMenor.Text);

            objTra.CalcularArea();

            txtResultTra.Text = Convert.ToString(objTra.Area);
        }
    }
}
