using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMilitar.models
{
    public class SoldadoVehiculo
    {
        [Column("soldado_id")]
        public int soldadoId { get; set; }
        public Soldado Soldado { get; set; }
        [Column("vehiculo_id")]
        public int VehiculoId { get; set; }
        public Vehiculo Vehiculo { get; set; }
    }
}
