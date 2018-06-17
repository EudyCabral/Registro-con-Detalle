using Registro_con_Detalles.ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Registro_con_Detalles.UI.REGISTROS
{
    public partial class Registro_Persona : Form
    {
        public Registro_Persona()
        {
            InitializeComponent();
        }

        private void Registro_Persona_Load(object sender, EventArgs e)
        {

        }

        private Personas LlenaClase()
        {
            Personas personas = new Personas();
            personas.PersonaId = Convert.ToInt32(personaIdNumericUpDown.Value);
            personas.Nombres = nombresTextBox.Text; 
            personas.Fecha = fechaDateTimePicker.Value;
            personas.Cedula = cedulaTextBox.Text;
            personas.Direccion = direccionTextBox.Text;
            personas.Telefono = telefonoTextBox.Text;
          

            return personas;
        }

        public bool validar(int error)
        {
            bool paso = false;

            if (error == 1 && personaIdNumericUpDown.Value == 0)
            {
                GeneralerrorProvider.SetError(personaIdNumericUpDown, "Llenar Persona ID");
                paso = true;
            }


            if (error == 2 && string.IsNullOrEmpty(nombresTextBox.Text))
            {
                GeneralerrorProvider.SetError(nombresTextBox, "Llenar Nombre");
                paso = false;
            }

            if (error == 2 &&  string.IsNullOrEmpty(cedulaTextBox.Text))
            {
                GeneralerrorProvider.SetError(cedulaTextBox, "Llenar Cedula");
                paso = true;
            }
            if (error == 2 &&  string.IsNullOrEmpty(direccionTextBox.Text))
            {
                GeneralerrorProvider.SetError(direccionTextBox, "Llenar Direccion");
                paso = true;
            }

            return paso;
        }



    

        private void Limpiar()
        {
           


            personaIdNumericUpDown.Value = 0;
            nombresTextBox.Clear();
            fechaDateTimePicker.Value =DateTime.Now;
            cedulaTextBox.Clear();
            direccionTextBox.Clear();
            telefonoTextBox.Clear();
            GeneralerrorProvider.Clear();
        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Llene la Casilla Grupo ID", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(personaIdNumericUpDown.Value);
                Personas personas = BLL.PersonasBLL.Buscar(id);

                if (personas != null)
                {

                    personaIdNumericUpDown.Value = personas.PersonaId;
                    nombresTextBox.Text = personas.Nombres;
                    fechaDateTimePicker.Value = personas.Fecha;
                    cedulaTextBox.Text = personas.Cedula;
                    direccionTextBox.Text = personas.Direccion;
                    telefonoTextBox.Text = personas.Telefono;

                }
                else
                {
                    MessageBox.Show("No Encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(personaIdNumericUpDown.Value);

            if (validar(1))
            {
                MessageBox.Show("Llene la Casilla Grupo ID", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else

            if (BLL.PersonasBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No Pudo Eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            GeneralerrorProvider.Clear();
        }

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            bool paso = false;
            Personas persona = LlenaClase();

            if (validar(2))
            {
                MessageBox.Show("Llene las Casilla  Correspondiente", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (personaIdNumericUpDown.Value == 0)
                {
                    paso = BLL.PersonasBLL.Guardar(LlenaClase());
                }
                else
                {
                    paso = BLL.PersonasBLL.Guardar(LlenaClase());
                }

                if (paso)
                {
                    MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No Pudo Guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }
    }
}
