using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1_cs
{
    public partial class frmCalculadora : Form
    {
        Calculadora ob;

       //constructor
        public frmCalculadora()
        {
            InitializeComponent();
            ob = new Calculadora(); //creamos el objeto
        }
        //ob.getResultado().ToString();  otra laternativa 
        //("Solo numeros,", "error", MessageBoxButtons.OK,MessageBoxIcon.Error); //se crea el boton de erros y se personaliza
        //MessageBox.Show(ex.message) otra alternativa
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbOpcion.SelectedIndex >= 0)
                {
                    ob.setNumero1(double.Parse(txtNumero1.Text));
                    ob.setNumero2(double.Parse(txtNumero2.Text));
                    ob.Operaciones(cbOpcion.Text);
                    txtResultado.Text = Convert.ToString(ob.getResultado());
                }
                else
                {
                    MessageBox.Show("Seleccione una opcion");
                    cbOpcion.Focus();
                }

            }catch(Exception ex)
            {
                txtNumero1.Clear();
                txtNumero2.Clear();
                txtResultado.Clear();
                MessageBox.Show(ex.Message);
                txtNumero1.Focus(); 
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
            txtNumero1.Focus(); //manda cursor a caja 1
        }
    }
}
