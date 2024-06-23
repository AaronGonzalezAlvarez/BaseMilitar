using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMilitar.models
{
    public class Vehiculo
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public string modelo { get; set; }
        [Column("numero_serie")]
        public string numeroSerie { get; set; }
        [Column("mecanico_id")]
        public int mecanicoId { get; set; }

        public Mecanico mecanico { get; set; }

        public List<SoldadoVehiculo> SoldadoVehiculo { get; } = new List<SoldadoVehiculo>(0);
    }
}
