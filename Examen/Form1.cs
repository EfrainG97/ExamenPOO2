using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen.Controller;



namespace Examen
{
    public partial class Form1 : Form
    {
        ControllerPersona cp = new ControllerPersona();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar(this);
        }

        void Limpiar(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DGVPersona.DataSource = null;
            DGVPersona.DataSource = cp.ObtenerDatos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBNombre.Text) || TBNombre.Text.Length < 3)
            {
                MessageBox.Show("El nombre es obligatorio y debe tener al menos 3 caracteres."); 
                return;
            }

            int edadv = Convert.ToInt32(TBEdad.Text);

            if(edadv<0 && edadv > 99)
            {
                MessageBox.Show("Por favor, introduce una edad valida");
                return;
            }

            else if (!System.Text.RegularExpressions.Regex.IsMatch(TBCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Por favor, introduce un correo electrónico válido.");
                return;
            }
            else
            {
                DateTime fechaSeleccionada = DTPFecha.Value;
                string fechaMysql = fechaSeleccionada.ToString("yyyy-MM-dd");

                cp.AgregarPersona(TBNombre.Text, Convert.ToInt32(TBEdad.Text), fechaSeleccionada, TBCorreo.Text);
                MessageBox.Show("Persona agregada con exito");
            }
        }

        private void BTNMostrar_Click(object sender, EventArgs e)
        {
            DGVPersona.DataSource = null;
            DGVPersona.DataSource = cp.ObtenerDatos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            cp.EliminarPersona(Convert.ToInt32(TbElimID.Text));
            MessageBox.Show("Alumno eliminado con exito");
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = DTPFecha.Value;
            cp.ActualizarPersona(Convert.ToInt32(TBId.Text), TBNombre.Text, Convert.ToInt32(TBEdad.Text), fechaSeleccionada, TBCorreo.Text);
            MessageBox.Show("Alumno Actualizado con exito");
        }
    }
}
