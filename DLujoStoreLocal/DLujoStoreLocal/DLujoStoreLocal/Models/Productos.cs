using System;
using System.Collections.Generic;
using System.Text;

namespace DLujoStoreLocal.Models
{
    public class Productos
    {
        public string nombre { get; set; }
        public double precio { get; set; }
        public string imagen { get; set; }
        public string historiaDescripcion;


        public string getHistoria() {


            return historiaDescripcion;


        }


        public virtual void calcularPrecio() { }

    }
}
