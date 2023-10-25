using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioEmpleados
{
    internal class Vendedor : Empleado
    {
        protected string marcaCarro;
        protected string modeloCarro;
        protected string placaCarro;
        public int telefonoMovil;
        public string areaVentas;
        public double Comision;
        protected string PuestoTrabajo;


        public List<string> Clientes = new List<string>();
        public Vendedor(string nombre, string apellido, int dni, string direccion, int antiguedad, int telefono, double salario,
         string supervisor, string marcacarro, string modelocarro, string placacarro, int telefonomovil, string areaventas, double comision, string puestotrabajo) : base(nombre, apellido, dni, direccion, antiguedad, telefono, salario, supervisor)
        {
            marcaCarro = marcacarro;
            modeloCarro = modelocarro;
            placaCarro = placacarro;
            telefonoMovil = telefonomovil;
            areaVentas = areaventas;
            Comision = comision;
            PuestoTrabajo = puestotrabajo;


            Clientes.Add("Juan");
            Clientes.Add("Leo");
            Clientes.Add("Sofia");
            Clientes.Add("Camila");
        }



        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine($"Trabajo de {PuestoTrabajo}, Cuento con auto empresarial, es un {marcaCarro} {modeloCarro}, de placas {placaCarro}, soy el encargado del area de {areaVentas} para una asesoria" +
                $" llamae a mi telefono celular {telefonoMovil}, por ventas gano una comision del {Comision}%");

            Console.WriteLine("Mi lista de clientes es la siguiente: ");
            foreach (string s in Clientes)
            {
                Console.WriteLine("-" + s);
            }

        }

        public void agregarCliente(string newCliente)
        {
            Clientes.Add(newCliente);
            Console.WriteLine($"Un nuevo cliente ha sido agregado de nombre, {newCliente}");
            foreach (string s in Clientes)
            {
                Console.WriteLine("-" + s);
            }
        }

        public void eliminarCliente(string cliente)
        {
            Clientes.Remove(cliente);
            Console.WriteLine($"Un nuevo cliente ha sido eliminado de nombre, {cliente}");
            foreach (string s in Clientes)
            {
                Console.WriteLine(s);
            }
        }

        public void cambioCarro(string newMarcaCarro, string newModeloCarro, string newPlaca)
        {

            marcaCarro = newMarcaCarro;
            modeloCarro = newModeloCarro;
            placaCarro = newPlaca;

            Console.WriteLine($"El nuevo carro es un {marcaCarro} {modeloCarro} con placa {placaCarro}");

        }

        public override void incrementoSalario()
        {
            double newSalario;
            double Porcentaje = 10;

            Console.WriteLine($"- Mi salario base es de: {Salario}");
            newSalario = Salario + (Salario * (Porcentaje / 100));

            Console.WriteLine($"- Mi nuevo salario con el aumento del {Porcentaje}%, es de {newSalario}");
        }
    }
}
