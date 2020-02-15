using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia1
{
    public class Reserva
    {
        public int id { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string salida { get; set; }
        public string llegada { get; set; }
        public double costo { get; set; }
        public double km { get; set; }

        public Reserva(int ID, string Cedula, string Nombre, string Apellid, string Salida, string Llegada)
        {
            this.id = ID;
            this.cedula = Cedula;
            this.nombre = Nombre;
            this.apellido = Apellid;
            this.salida = Salida;
            this.llegada = Llegada;
            this.costo = ValorViaje(salida, llegada);
            this.km = KilometrajeViaje(salida, llegada);
        }

        public double KilometrajeViaje(string salida, string llegada)
        {

            {
                if (salida == "Bogota")
                {
                    if (llegada == "Cali")
                    {
                        return 462;
                    }
                    else if (llegada == "Medellin")
                    {
                        return 417.3;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else if (salida == "Cali")
                {
                    if (llegada == "Bogota")
                    {
                        return 462;
                    }
                    else if (llegada == "Medellin")
                    {
                        return 418.1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else if (salida == "Medellin")
                {
                    if (llegada == "Cali")
                    {
                        return 418.1;
                    }
                    else if (llegada == "Bogota")
                    {
                        return 417.3;
                    }
                    else
                    {
                        return 0;
                    }
                }
                return 0;
            }
        }

        public double ValorViaje(string salida, string llegada)
        {
            if (salida == "Bogota")
            {
                if (llegada == "Cali")
                {
                    return 267000;
                }
                else if (llegada == "Medellin")
                {
                    return 208000;
                }
                else
                {
                    return 0;
                }
            }
            else if (salida == "Cali")
            {
                if (llegada == "Bogota")
                {
                    return 280000;
                }
                else if (llegada == "Medellin")
                {
                    return 200000;
                }
                else
                {
                    return 0;
                }
            }
            else if (salida == "Medellin")
            {
                if (llegada == "Cali")
                {
                    return 180000;
                }
                else if (llegada == "Bogota")
                {
                    return 210000;
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }
    }
}
