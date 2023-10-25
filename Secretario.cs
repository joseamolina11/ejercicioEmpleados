using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioEmpleados
{
    internal class Secretario : Empleado
    {

        public string Despacho;
        public int NumeroFax;
        public string Puesto;

        public Secretario(string nombre, string apellido, int dni, string direccion, int antiguedad, int telefono, double salario, string supervisor, string despacho, int numeroFax, string puesto) : base(nombre, apellido, dni, direccion, antiguedad, telefono, salario, supervisor)
        {
            Despacho = despacho;
            NumeroFax = numeroFax;
            Puesto = puesto;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"- Hola mi Nombre es {Nombre} {Apellido}, mi DNI es {DNI}, para contactarte conmigo mi numero telefonico es {Telefono}, " +
               $"mi dirrecion de residencia es {Direccion},tengo {Antiguedad} año(s) de antiguedad en la empresa, mi puesto de trabajo es {Puesto}, en el despacho de {Despacho} con numero de Fax {NumeroFax}" +
               $" tengo un salario de {Salario} y mi Jefe inmediato es {Supervisor}");

        }
        public override void incrementoSalario()
        {
            double newSalario;
            double Porcentaje = 5;

            Console.WriteLine($"- Mi salario base es de: {Salario}");
            newSalario = Salario + (Salario * (Porcentaje / 100));

            Console.WriteLine($"- Mi nuevo salario con el aumento del {Porcentaje}%, es de {newSalario}");
        }
    }
}
