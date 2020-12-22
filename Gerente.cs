using System;
using System.Collections.Generic;
using System.Text;

namespace ModeladoGerente
{
    /*
     * Clase Gerente, deriva de Empleado. 
     * Esta clase define las acciones que un gerente puede realizar
     */
    class Gerente: Empleado
    {

        public Gerente(string id, string nombre, string primerApellido, string segundoApellido,
            DateTime fechaNacimiento, decimal salario, string puesto, DateTime fechaContrato) :
            base(id, nombre, primerApellido, segundoApellido, fechaNacimiento, salario, puesto, fechaContrato)
        {
            ;
        }

        public void entrevistar(Persona candidato)
        {
            //realizar entrevista de trabajo
            //registrar hora de inicio y hora de fin, 
        }

    }
}
