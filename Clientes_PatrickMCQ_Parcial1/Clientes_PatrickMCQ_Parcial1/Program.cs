using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes_PatrickMCQ_Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {

            Clientes cliente1 = new Clientes(1212, "Juan Aroldo", "López Zuñiga", 1223242, "2av Col.Independencia", 32456788, "Antonio Guamuch", 700);
            cliente1.mostrarDatos();
            Console.WriteLine();

            Clientes cliente2 = new Clientes(2343, "Esteban Rodolfo", "Casanova Ruiz", 4545454, "7av Col. Laa Flores", 7877778, "René Descartes", 1500);
            cliente2.mostrarDatos();
            Console.WriteLine();

            Clientes cliente3 = new Clientes(7640, "Julian Toy", "Everest Dogo", 1092882, "5av Col.Israel", 7884040, "Estebean Duarte", 7000);
            cliente3.mostrarDatos();
            Console.WriteLine();

            Console.ReadKey();
        }

    class Clientes
        {
            private string _TipoCliente;

            public int codigoCliente { get; set; }
            public string nombreCliente { get; set; }
            public string apellidoCliente { get; set; }
            public int nitCliente { get; set; }
            public string direccionCliente { get; set; }
            public int telefonoCliente { get; set; }
            public string nombreVendedor { get; set; }
            public string tipoCliente { get { return _TipoCliente; } }
            public int totalCompras { get; set; } 

            public Clientes(int codigoCliente, string nombreCliente, string apellidoCliente, int nitCliente, string direccionCliente, int telefonoCliente, string nombreVendedor, int totalCompras)
            {
                this.codigoCliente = codigoCliente;
                this.nombreCliente = nombreCliente;
                this.apellidoCliente = apellidoCliente;
                this.nitCliente = nitCliente;
                this.direccionCliente = direccionCliente;
                this.telefonoCliente = telefonoCliente;
                this.nombreVendedor = nombreVendedor;
                this.totalCompras = totalCompras;

                if(totalCompras < 1500)
                {
                    _TipoCliente = "Cliente Normal";
                } else if(totalCompras>=1500 && totalCompras < 5000)
                {
                    _TipoCliente = "Cliente Especial";
                } else if (totalCompras >= 5000)
                {
                    _TipoCliente = "Mayorista";
                }
            }

            public void mostrarDatos()
            {
                Console.WriteLine("Código del cliente: " + codigoCliente);
                Console.WriteLine("Nombre del Cliente: " + nombreCliente);
                Console.WriteLine("Apellidos del Cliente: " + apellidoCliente);
                Console.WriteLine("Nit del Cliente: " + nitCliente);
                Console.WriteLine("Dirección del cliente: " + direccionCliente);
                Console.WriteLine("Teléfono del cliente: " + telefonoCliente);
                Console.WriteLine("Nombre del vendedor: " + nombreVendedor);
                Console.WriteLine("Total de Compras: " + totalCompras);
                Console.WriteLine("Tipo de cliente: " + tipoCliente);
            }
        }
    }
}
