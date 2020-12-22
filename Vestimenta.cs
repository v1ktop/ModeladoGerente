using System;
using System.Collections.Generic;
using System.Text;

namespace ModeladoGerente
{

    /*
     * Clase Vestimenta, representa el tipo de vestimenta que una persona puede tener.
     * Atributos:
     *  TipoVestido tipo: Toma un valor constante FORMAL o CASUAL
     *  string nombre: Descripción del vestido (pantalon, camisa, etc)
     *  string color: Codigo de color del vestido
     *  Int16 numeroBotones: Valor entero si el vestido tiene botones
     */
    class Vestimenta
    {
        public enum TipoVestido { FORMAL, CASUAL };

        public TipoVestido tipo { get; set; }
        public string color { get; set; }
        public string nombre { get; set; }

        public Int16 numeroBotones { get; set; }

        public Vestimenta(string color, string nombre, TipoVestido tipo)
        {
            this.color = color;
            this.nombre = nombre;
            this.tipo = tipo;
        }
    }
  



}
