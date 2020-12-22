using System;
using System.Collections.Generic;
using System.Text;

namespace ModeladoGerente
{
    /*
     * Clase empresa. Define las propiedades del entorno de trabajo de la empresa.
     */
    class Empresa
    {
        public string denominacion { get; set; }
        public string impuestosId { get; set; }

        public Empresa(string denominacion, string impuestosId)
        {
            this.denominacion = denominacion;
            this.impuestosId = impuestosId;
        }
    }
}
