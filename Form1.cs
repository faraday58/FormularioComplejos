using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioComplejos
{
    public partial class Form1 : Form
    {
        private bool agregaComLb;
        public Form1()
        {
            InitializeComponent();
            agregaComLb = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (agregaComLb)
            {
                try
                {
                    string variable = txtbComplejo.Text;
                    leerCadena(variable);
                   

                    if(  !variable.Contains("j") )
                    {
                        string errorContenidoJ = "Falta identificar la parte imaginaria con \"j\"";
                        throw new ApplicationException(errorContenidoJ);
                    }

                    string[] realImag = variable.Split('+');
                    float real =float.Parse( realImag[0]);
                    string[] imag = realImag[1].Split('j');
                    float imagn =float.Parse( imag[0]);


                    lbComplejo1.Text = txtbComplejo.Text;

                    txtbComplejo.Clear();
                    agregaComLb = false;
                }
                catch(ApplicationException error)
                {
                    MessageBox.Show(error.Message);
                }
                catch(FormatException error)
                {
                    MessageBox.Show("Parte real o imaginaria incorrecta ");
                }
                
            }
            else
            {
               lbComplejo2.Text = txtbComplejo.Text;
                txtbComplejo.Clear();
                agregaComLb = true;
            }

        }

        private void leerCadena(string variable)
        { 
            if( variable.Contains("-"))
            {
                string[] realImag = variable.Split('-');
                float real = float.Parse(realImag[0]);
                string[] imag = realImag[1].Split('j');
                float imagn = float.Parse(imag[0]);
            }
            

        }


        private void btnSumar_Click(object sender, EventArgs e)
        {
            // float real = lbComplejo1.Text.Split('+');
            try
            {
                #region Conversión de cadena a número complejo
                string[] cadReal = lbComplejo1.Text.Split('+');
                float real = Convert.ToSingle(cadReal[0]);
                //float imaginaria = cadComplejo[1].Split('j');
                string[] cadImaginaria = cadReal[1].Split('j');
                float imaginaria = Convert.ToSingle(cadImaginaria[0]);

                Complejo c1 = new Complejo(real, imaginaria);

                // Segundo Complejo

                cadReal = lbComplejo2.Text.Split('+');
                real = Convert.ToSingle(cadReal[0]);
                cadImaginaria = cadReal[1].Split('j');
                imaginaria = Convert.ToSingle(cadImaginaria[0]);

                Complejo c2 = new Complejo(real, imaginaria);

                Complejo c3 = c1 + c2;
                lbResultado.Text = c3.ToString();
                #endregion
            }
            catch(FormatException error)
            {
                MessageBox.Show("Ingresa un número en la parte real y en la parte imaginaria");
            }


            catch
            {
                MessageBox.Show("Hubo un error");
            }

        }
    }
}
