using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgra2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        controlador con = new controlador();
        public bool validarForm(string texto)
        {
            if (String.IsNullOrEmpty(texto))
            {
                string message = "Llena todo los campos";
                string caption = "Error detectado";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Muestra el mensaje
                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }

        }
        private void btnCaracteres_Click(object sender, EventArgs e)
        {
            String palabra = txtPalabra.Text;
            if (validarForm(palabra))
            {

            }
            else if (validarForm(palabra) == false)
            {
                txtCaracteres.Text = Convert.ToString(con.cantidad(palabra, 1));
            }
            else 
            {
                MessageBox.Show("Dios sabra como has llegado aca", "Erro raro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVocales_Click(object sender, EventArgs e)
        {
            String palabra = txtPalabra.Text;
            if (validarForm(palabra))
            {

            }
            else if (validarForm(palabra) == false)
            {
                txtVocales.Text = Convert.ToString(con.cantidad(palabra, 2));
            }
            else
            {
                MessageBox.Show("Dios sabra como has llegado aca", "Erro raro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsonantes_Click(object sender, EventArgs e)
        {
            String palabra = txtPalabra.Text;
            if (validarForm(palabra))
            {

            }
            else if (validarForm(palabra) == false)
            {
                txtConsonantes.Text = Convert.ToString(con.cantidad(palabra, 3));
            }
            else
            {
                MessageBox.Show("Dios sabra como has llegado aca", "Erro raro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPalabras_Click(object sender, EventArgs e)
        {
            String palabra = txtPalabra.Text;
            if (validarForm(palabra))
            {

            }
            else if (validarForm(palabra) == false)
            {
                txtPalabras.Text = Convert.ToString(con.cantidad(palabra, 4));
            }
            else
            {
                MessageBox.Show("Dios sabra como has llegado aca", "Erro raro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
