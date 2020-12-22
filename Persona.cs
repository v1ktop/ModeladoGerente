using System;
using System.Collections.Generic;
using System.Text;


namespace ModeladoGerente
{
    /*
     * Esta clase define las propiedades que puede tener una persona.
     */
    class Persona
    {
        // Atributos simples, se requiere implementar una validación.
        public string id { get; set; }
        public string nombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public DateTime fechaNacimiento { get; set; }

        public Int16 sexo { get; set; }
        public float altura { get; set; }
        public float peso { get; set; }

        public List<Vestimenta> vestuario { get; set; }
        

        public Persona(string id, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento)
        {
            this.id = id;
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.fechaNacimiento = fechaNacimiento;
        }

        public void agregarVestuario(Vestimenta vestido)
        {
            this.vestuario.Add(vestido);
        }

    }
}
