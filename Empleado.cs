using System;
using System.Collections.Generic;
using System.Text;

namespace ModeladoGerente
{
    /*
     * Clase Empleado, deriva de Persona. 
     * Esta clase define las propiedades generales de un Empleado y las acciones que puede realizar.
     */
    
    class Empleado: Persona
    {
        
        public decimal salario { get; set; }
        public string puesto { get; set; }
        public DateTime fechaContrato { get; set;  }

        public string areaTrabajo { get; set; }
        public Empleado(string id, string nombre, string primerApellido, string segundoApellido, 
            DateTime fechaNacimiento, decimal salario, string puesto, DateTime fechaContrato): 
            base( id, nombre, primerApellido, segundoApellido, fechaNacimiento)
        {
            this.salario = salario;
            this.puesto = puesto;
            this.fechaContrato = fechaContrato;
        }

        public void trabajar()
        {
            //Trabajo realizado
        }

        public void registrarEntrada(DateTime horaEntrada)
        {
            // Registrar entrada del empleado
        }

        public void registrarSalida(DateTime horaEntrada)
        {
            //Registrar salida del empleado
        }

    }
}
