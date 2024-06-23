using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaseMilitar.models
{
    public class Soldado
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string rango { get; set; }
        [Column("fecha_ingreso")]
        public DateTime fechaIngreso { get; set; }
        public List<SoldadoVehiculo> SoldadoVehiculo { get; } = new List<SoldadoVehiculo>(0);
    }
}
