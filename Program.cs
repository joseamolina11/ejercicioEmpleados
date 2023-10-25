using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioEmpleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado("jose", "andres", 1143169, "santuario", 1, 304561, 2500, "antony");
            //empleado1.Imprimir();
            //empleado1.cambioSupervisor("Andres");
            //empleado1.incrementoSalario();


            Empleado secretario = new Secretario("Juan", "Galindo", 1553, "carrizal", 5, 300552, 1500, "rAul", "ingenieria", 452161, "Secretario");
            secretario.Imprimir();
            //secretario.incrementoSalario();

            Vendedor vendedor1 = new Vendedor("jose", "andres", 1143169, "santuario", 1, 304561, 2500, "antony", "Renult", "Sandero", "AAA458", 32544441, "Tecnologia", 1.5, "Vendedor");
            //vendedor1.Imprimir();
            //vendedor1.agregarCliente("Maria");
            //vendedor1.eliminarCliente("Sofia");
            //vendedor1.incrementoSalario();
            //vendedor1.cambioCarro("Mazda", "CX5", "JUL223");

            JefeZona jefeZona1 = new JefeZona("Andres", "Molina", 1143169, "Cali", 5, 30456661, 4500, "Antonella", "Renult", "Logan", "ARW458", "Jefe de zona", "Despacho", "Cristina");
            //jefeZona1.Imprimir();
            //jefeZona1.cambioSecretario("Silvia");
            //jefeZona1.cambioAuto("Mercedes", "AMG", "HIW342");
            //jefeZona1.agregarVendedor("Camilo");
            //jefeZona1.eliminarVendedor("Alex");
            //  jefeZona1.incrementoSalario();
        }
    }

}
