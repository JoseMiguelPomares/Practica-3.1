using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textoTelegrama = txtTexto.Text;
            string[] palabra = textoTelegrama.Split(' ');
            int numPalabras = textoTelegrama.Split(' ').Length;
            double coste = 0;

            textoTelegrama = txtTexto.Text;
            //COMENTARIO
            if (rdUrgente.Checked)
            {
                coste = 2.5;
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 * 0.75 * (numPalabras - 10);
            }
            if (rdOrdinario.Checked) 
            { //cambiamos el checkbox button por 2 radio button
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 * 0.75 * (numPalabras - 10);
            }
            //PACO
            txtCoste.Text = coste.ToString() + " euros";
        }
    }
}
