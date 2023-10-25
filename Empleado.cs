using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioEmpleados
{
    internal class Empleado
    {
        public string Nombre;
        public string Apellido;
        public int DNI;
        public string Direccion;
        public int Antiguedad;
        public int Telefono;
        public double Salario;
        public string Supervisor;

        public Empleado(string nombre, string apellido, int dni, string direccion, int antiguedad, int telefono, double salario, string supervisor)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Direccion = direccion;
            Antiguedad = antiguedad;
            Telefono = telefono;
            Salario = salario;
            Supervisor = supervisor;
        }

        public virtual void Imprimir()
        {
            Console.WriteLine($"- Hola mi Nombre es {Nombre} {Apellido}, mi DNI es {DNI}, para contactarte conmigo mi numero telefonico es {Telefono}, " +
                $"mi dirrecion de residencia es {Direccion},tengo {Antiguedad} año(s) de antiguedad en la empresa, tengo un salario de {Salario} y mi Jefe inmediato es {Supervisor}");
        }

        public virtual void cambioSupervisor(string newSupervisor)
        {
            Console.WriteLine($"- Mi supervisor anterior era: {Supervisor}");
            Supervisor = newSupervisor;
            Console.WriteLine($"- Mi nuevo supervisor es: {Supervisor}");
        }
        public virtual void incrementoSalario()
        {
            double newSalario;
            double Porcentaje = 0;

            Console.WriteLine($"- Mi salario base es de: {Salario}");
            newSalario = Salario + (Salario * (Porcentaje / 100));

            Console.WriteLine($"- Mi nuevo salario con el aumento del {Porcentaje}%, es de {newSalario}");

        }
    }
}
