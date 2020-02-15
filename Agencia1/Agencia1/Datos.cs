using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia1
{
    public partial class Datos : Form
    {
        //a es la entrada a los elementos del formulario Reservas
        Reservas a;
        public Datos(Reservas Reserva)
        {
            this.a = Reserva;
            InitializeComponent();
        }

        String ViajeroMasFrecuente()
        {
            int Frecuente = 0;
            String cedula = "", nombre = "", apellido = "";
            if (a.Repetidas.ToList().Count() != 0)
            {
                foreach (Reserva r in a.Repetidas.ToList())
                {
                    int cont = 0;
                    foreach (Reserva t in a.Repetidas.ToList())
                    {
                        if (r.cedula == t.cedula)
                        {
                            cont++;
                        }
                    }
                    if (cont > Frecuente)
                    {
                        Frecuente = cont;
                        cedula = r.cedula;
                        nombre = r.nombre;
                        apellido = r.apellido;
                    }
                }
                return "El viajero más frecuente es " + nombre + " " + apellido + " cedula: " + cedula + " Con " + (Frecuente + 1) + " Reservas";
            }
            else
            {
                return "Nadie ha hecho más de una reserva";
            }
            
        }
        private void btnReservasACiudad_Click(object sender, EventArgs e)
        {
            btnConsultar.Visible = true;
            cbxCiudades.Visible = true;
        }

        String DestinoMasSolicitado()
        {
            int contM = 0;
            int contC = 0;
            int contB = 0;
            foreach (Reserva reservas in a.reservas.ToList())
            {
                if (reservas.llegada == "Medellin")
                {
                    contM++;
                }
                else if (reservas.llegada == "Bogota")
                {
                    contB++;
                }
                else
                {
                    contC++;
                }
            }
            foreach (Reserva reservas in a.Repetidas.ToList())
            {
                if (reservas.llegada == "Medellin")
                {
                    contM++;
                }
                else if (reservas.llegada == "Bogota")
                {
                    contB++;
                }
                else
                {
                    contC++;
                }
            }
            if (contB > contC)
            {
                if (contB > contM)
                {
                    return "El destino más solicitado es: Bogota";
                }
                else if (contM > contC)
                {
                    return "El destino más solicitado es: Medellin";
                }
            }
            else if (contC > contM)
            {
                return "El destino más solicitado es: cali";
            }
            else if (contB == contC && contB == contM)
            {
                return "Son iguales";
            }
            else
            {
                return "El destino más solicitado es: Medellin";
            }
            return "";
        }

        Double Prom()
        {
            double acum = 0;
            foreach (Reserva r in a.reservas.ToList())
            {
                acum += r.costo;
            }
            try
            {
                return Math.Round(acum / (a.reservas.ToList().Count()+a.Repetidas.ToList().Count()), 3); ;

            }
            catch (System.DivideByZeroException)
            {
                MessageBox.Show("No hay ventas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
        }

        private void btnDMS_Click(object sender, EventArgs e)
        {
            cbxCiudades.Visible = false;
            btnConsultar.Visible = false;
            txtResultados.Text = DestinoMasSolicitado();
        }

        private void btnPromVentas_Click(object sender, EventArgs e)
        {
            cbxCiudades.Visible = false;
            btnConsultar.Visible = false;
            txtResultados.Text = "El promedio de ventas es: " + Prom();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int cont = 0;
            foreach (Reserva r in a.reservas.ToList())
            {
                if (r.llegada == cbxCiudades.Text)
                {
                    cont++;
                }
            }
            foreach (Reserva r in a.Repetidas.ToList())
            {
                if (r.llegada == cbxCiudades.Text)
                {
                    cont++;
                }
            }
            txtResultados.Text = "En la ciudad de " + cbxCiudades.Text + " hubieron " + cont + " reservas";
        }

        private void btnMejorCliente_Click(object sender, EventArgs e)
        {
            cbxCiudades.Visible = false;
            btnConsultar.Visible = false;
            double mayor = 0;
            string mejorCliente = "";
            foreach (Reserva r in a.reservas.ToList())
            {
                if (r.km > mayor)
                {
                    mayor = r.km;
                    mejorCliente = r.nombre + " " + r.apellido;
                }
            }
            txtResultados.Text = "El mejor cliente fue " + mejorCliente + " con " + mayor + " Km";
        }
        string CiudadDeMasIngresos()
        {
            double contM = 0;
            double contC = 0;
            double contB = 0;
            foreach (Reserva reservas in a.reservas.ToList())
            {
                if (reservas.llegada == "Medellin")
                {
                    contM += reservas.ValorViaje(reservas.salida, reservas.llegada);
                }
                else if (reservas.llegada == "Bogota")
                {
                    contB += reservas.ValorViaje(reservas.salida, reservas.llegada);
                }
                else
                {
                    contC += reservas.ValorViaje(reservas.salida, reservas.llegada);
                }
            }
            foreach (Reserva reservas in a.Repetidas.ToList())
            {
                if (reservas.llegada == "Medellin")
                {
                    contM += reservas.ValorViaje(reservas.salida, reservas.llegada);
                }
                else if (reservas.llegada == "Bogota")
                {
                    contB += reservas.ValorViaje(reservas.salida, reservas.llegada);
                }
                else
                {
                    contC += reservas.ValorViaje(reservas.salida, reservas.llegada);
                }
            }
            if (contB > contC)
            {
                if (contB > contM)
                {
                    return "La ciudad de más ingresos es: Bogota";
                }
                else if (contM > contC)
                {
                    return "La ciudad de más ingresos es: Medellin";
                }
            }
            else if (contC > contM)
            {
                return "La ciudad de más ingresos es: cali";
            }
            else if (contB == contC && contB == contM)
            {
                return "Son iguales";
            }
            else
            {
                return "La ciudad de más ingresos es: Medellin";
            }
            return "";
        }
        private void btnCiudadDeMasIngresos_Click(object sender, EventArgs e)
        {
            cbxCiudades.Visible = false;
            btnConsultar.Visible = false;
            txtResultados.Text = CiudadDeMasIngresos();
        }

        private void btnCedulaMejoresClientes_Click(object sender, EventArgs e)
        {
            cbxCiudades.Visible = false;
            btnConsultar.Visible = false;
            StringBuilder sb = new StringBuilder();
            foreach (Reserva r in a.reservas.ToList())
            {
                if (r.costo > Prom())
                {
                    sb.AppendLine(r.cedula);
                }
            }
            txtResultados.Text = "Las cedulas de los mejores clientes son: \n" + sb;
        }

        private void btnViajeroFrecuente_Click(object sender, EventArgs e)
        {
            cbxCiudades.Visible = false;
            btnConsultar.Visible = false;
            txtResultados.Text = ViajeroMasFrecuente();
        }
    }
}
