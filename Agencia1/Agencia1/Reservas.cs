using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Agencia1
{
    public partial class Reservas : Form
    {
        public Reservas()
        {
            InitializeComponent();
        }
        public List<Reserva> reservas = new List<Reserva>();
        public List<Reserva> Repetidas = new List<Reserva>();
        public StreamWriter archivo = new StreamWriter("archivo.txt");
        void limpiar()
        {
            txtApellido.Text = "";
            txtCC.Text = "";
            txtCosto.Text = "";
            txtKilometraje.Text = "";
            txtNombre.Text = "";
            listboxLlegada.Text = " ";
            listboxSalida.Text = " ";
        }
        Boolean vacio()
        {
            if (txtApellido.Text == "" || txtCC.Text == "" || txtNombre.Text == "" || listboxLlegada.Text == "" || listboxSalida.Text == "" || (listboxSalida.Text == listboxLlegada.Text))
            {
                MessageBox.Show("Revise los campos","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        Boolean SeRepiteLaCedula(String ced)
        {
            foreach (Reserva r in reservas)
            {
                if (r.cedula == ced)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnReserva_Click(object sender, EventArgs e)
        {
            if (!vacio())
            {
                richTextBox1.Visible = false;
                int id = reservas.Count() + Repetidas.Count();
                string cedula = txtCC.Text, nombre = txtNombre.Text, apellido = txtApellido.Text, salida = listboxSalida.Text, llegada = listboxLlegada.Text;
                Reserva r = new Reserva(id, cedula, nombre, apellido, salida, llegada);
                double costo = r.ValorViaje(salida, llegada), km = r.KilometrajeViaje(salida, llegada);
                /** Si la cedula ya existe en la lista reservas entonces ese elemento nuevo llamado r se agrega a la lista Repetidas
                 * y a su vez se le suma el costo y los kilometros de este nuevo viaje al primer elemento registrado con esa cedula*/
                if (SeRepiteLaCedula(cedula))
                {
                    foreach (Reserva a in reservas)
                    {
                        if (r.cedula == cedula)
                        {
                            a.costo += costo;
                            a.km += km;
                        }
                    }
                    Repetidas.Add(r);
                }
                else
                {
                    reservas.Add(r);
                }
                archivo.WriteLine(reserva(id, nombre, apellido, cedula, salida, llegada, costo, km));
            }
            limpiar();
        }
        StringBuilder reserva(int id, string nombre,string apellido,string cedula,string salida, string llegada, double costo, double km)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("RESERVA");
            sb.AppendLine("ID " + id);
            sb.AppendLine("Nombre completo: " + nombre + " " + apellido);
            sb.AppendLine("Cédula: " + cedula);
            sb.AppendLine("De " + salida + " a " + llegada);
            sb.AppendLine("Costo: " + costo);
            sb.AppendLine("Kilometros de viaje: " + km);
            return sb;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!vacio())
            {
                richTextBox1.Visible = true;
                int id = reservas.Count() + Repetidas.Count();
                string cedula = txtCC.Text, nombre = txtNombre.Text, apellido = txtApellido.Text, salida = listboxSalida.Text, llegada = listboxLlegada.Text;
                Reserva r = new Reserva(id, cedula, nombre, apellido, salida, llegada);
                double costo = r.ValorViaje(salida, llegada), km = r.KilometrajeViaje(salida, llegada);
                txtCosto.Text = Convert.ToString(costo);
                txtKilometraje.Text = Convert.ToString(km);
                richTextBox1.Text = Convert.ToString(reserva(id,nombre,apellido,cedula,salida,llegada,costo,km));
            }
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            /**Se valida el evento de presionar tecla en el teclado para verificar si se están oprimiendo numeros o simbolos
             * en vez de letras, entonces si se están oprimiendo numeros o simbolos el teclado se desactiva con el .Handled
             * pero si se estám escribiendo algo diferente a letras y simbolos éste se vuelve a activar poniendolo en false**/
            if (Char.IsDigit(e.KeyChar)||Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Misma validacion que en txtNombre_KeyPress
            if (Char.IsDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Reservas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hecho para que el formulario que me contiene la lista (this) no se cierre y se pierdan los datos
            e.Cancel = true;
            this.Hide();
        }
    }
}
