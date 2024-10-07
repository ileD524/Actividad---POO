using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Vehiculo
    {
        public string Nombre { get; set; }
        public int AnioMarca { get; set; }
        public decimal Precio { get; set; }

        public virtual string Descripcion()
        {
            return $"El vehículo de {Nombre} (año {AnioMarca}) se vende por {Precio:C}";
        }
    }

    public class Auto : Vehiculo
    {
        public string Modelo { get; set; }
        public override string Descripcion()
        {
            return $"El auto de {Nombre} (Modelo {Modelo} - año {AnioMarca}) se vende por {Precio:C}";
        }
    }

    public class Moto : Vehiculo
    {
        public string Modelo { get; set; }
        public override string Descripcion()
        {
            return $"La moto de {Nombre} (Modelo {Modelo} - año {AnioMarca}) se vende por {Precio:C}";
        }
    }
}
