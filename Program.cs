using System;

/*Programa Principal, este programa modela las acciones y atributos de un gerente en una determinada empresa.
 *Inicia con un test case interactivo y faltan agregar funcionalidades.
 *Se siguio el estilo CamelCase en lugar de PascalCase
 * */


/*POR HACER:
 * Recibir el nombre del gerente por consola
 * Agregar acciones en las diferentes entidades
 */
namespace ModeladoGerente
{ 
    class Program
    {
        
        static void Main(string[] args)
        {

        //Prueba en terminal
        string nombreEmpleado = args[0];

        //Prueba local
        //string nombreEmpleado = "Alberto";

        int opcion=1;
        
        Empresa empresa = new Empresa("TR Network", "TRN000000MX1");

        Console.WriteLine("Hola " + nombreEmpleado);
        Console.WriteLine("Bienvenido a" + empresa.denominacion);

            // Creacion de un nuevo Gerente
        
        Gerente gerente = new Gerente("02A", nombreEmpleado, "", "", DateTime.Today, 0, "Gerente", DateTime.Today);

        Console.WriteLine("Selecciona una acción");
        Console.WriteLine("0) Salir");
        Console.WriteLine("1) Realizar entrevista");
        Console.WriteLine("2) Registrar candidato");
        Console.WriteLine("3) Dar de alta un nuevo empleado");

            opcion = 1;
            do
            {

                
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    // POR HACER: Implementar acciones
                    case 1:
                        {

                            Console.WriteLine("Realizando entrevista...");
                            gerente.entrevistar(new Persona("id", "nombre", "ap1", "ap2", DateTime.Today));
                            break;
                        }

                    case 2: Console.WriteLine("Registrando nuevo candidato..."); break;
                    case 3:Console.WriteLine("Agregando un nuevo empleado..."); break;
                }


            } while (opcion > 0);

        }
    }
}
