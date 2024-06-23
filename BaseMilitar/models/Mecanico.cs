using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMilitar.models
{
    public class Mecanico
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string especialidad { get; set; }
        public int experiencia { get; set; }
        //public List<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();
        public ICollection<Vehiculo> Vehiculos { get; } = new List<Vehiculo>();
    }
}
