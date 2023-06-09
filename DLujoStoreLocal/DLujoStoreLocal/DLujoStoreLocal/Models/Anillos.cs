using System;
using System.Collections.Generic;
using System.Text;

namespace DLujoStoreLocal.Models
{
    public class Anillos : Productos
    {

        public Anillos( string nombre, string imagen , string materiaPrima, double kgMateriaPima, string historia) {

            this.nombre = nombre;
            this.imagen = imagen;
            this.materiaPrima= materiaPrima;
            this.kgMateriaPima= kgMateriaPima;
            this.historiaDescripcion = historia;

            calcularPrecio();
        }

        public string materiaPrima { get; set; }
        public double kgMateriaPima { get; set; }

        public override void calcularPrecio()
        {
            switch (materiaPrima) {

                case "Oro":
                    precio = kgMateriaPima * 50;
                    break;
                case "Plata":
                    precio = kgMateriaPima * 20;
                    break;
                case "Cobre":
                    precio = kgMateriaPima * 10;
                    break;
                default:
                    precio = kgMateriaPima * 10;
                    break;

            }

        }

    }
}
