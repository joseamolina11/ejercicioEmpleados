using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioEmpleados
{
    internal class JefeZona : Empleado
    {
        public string Despacho;
        public string Secretario;
        public string marcaCarro;
        public string modeloCarro;
        public string placaCarro;
        public string Puestotrabajo;

        public List<string> Vendedores = new List<string>();

        public JefeZona(string nombre, string apellido, int dni, string direccion, int antiguedad, int telefono, double salario,
            string supervisor, string marcacarro, string modelocarro, string placacarro, string puestotrabajo, string despacho, string secretario)
            : base(nombre, apellido, dni, direccion, antiguedad, telefono, salario, supervisor)
        {
            Despacho = despacho;
            Secretario = secretario;
            Puestotrabajo = puestotrabajo;
            marcaCarro = marcacarro;
            modeloCarro = modelocarro;
            placaCarro = placacarro;


            Vendedores.Add("Cristian");
            Vendedores.Add("Samuel");
            Vendedores.Add("Alex");

        }

        public override void Imprimir()
        {
            base.Imprimir();

            Console.WriteLine($"-Trabajo de {Puestotrabajo}, la empresa me proporciona un auto es un {marcaCarro} {modeloCarro} con placas" +
                $" {placaCarro}. Mi secretaria {Secretario} los llevara a mi {Despacho}");

            Console.WriteLine("-Estoy encargado de los siguientes Vendedores: ");

            foreach (var item in Vendedores) { Console.WriteLine("-" + item); }

        }

        public void cambioSecretario(string newSecretario)
        {
            Console.WriteLine($"- Mi Secretario anterior era: {Secretario}");
            Secretario = newSecretario;
            Console.WriteLine($"- Mi nuevo Secretario es: {Secretario}");
        }

        public void cambioAuto(string newMarcaCarro, string newModeloCarro, string newPlaca)
        {

            marcaCarro = newMarcaCarro;
            modeloCarro = newModeloCarro;
            placaCarro = newPlaca;

            Console.WriteLine($"El nuevo carro que me dio la empresa es un {marcaCarro} {modeloCarro} con placa {placaCarro}");

        }
        public void agregarVendedor(string newVendedor)
        {
            Vendedores.Add(newVendedor);
            Console.WriteLine($"Un nuevo cliente ha sido agregado de nombre, {newVendedor}");
            foreach (string V in Vendedores)
            {
                Console.WriteLine("-" + V);
            }
        }

        public void eliminarVendedor(string vendedor)
        {
            Vendedores.Remove(vendedor);
            Console.WriteLine($"Un nuevo cliente ha sido eliminado de nombre, {vendedor}");
            foreach (string V in Vendedores)
            {
                Console.WriteLine("-", V);
            }
        }

        public override void incrementoSalario()
        {
            double newSalario;
            double Porcentaje = 20;

            Console.WriteLine($"- Mi salario base es de: {Salario}");
            newSalario = Salario + (Salario * (Porcentaje / 100));

            Console.WriteLine($"- Mi nuevo salario con el aumento del {Porcentaje}%, es de {newSalario}");
        }
    }
}
