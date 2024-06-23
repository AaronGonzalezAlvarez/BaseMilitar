using BaseMilitar.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BaseMilitar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBaseContext Context = new DataBaseContext();

            var db = new DataBaseContext();
            var mecanicos = db.Mecanico.Include(m => m.Vehiculos).ToList();
               /* foreach (var mecanico in mecanicos)
                {
                    Console.WriteLine($"Mecánico: {mecanico.nombre}");
                    foreach (var vehiculo in mecanico.Vehiculos)
                    {
                        Console.WriteLine($"\tVehículo: {vehiculo.tipo}, {vehiculo.modelo}, {vehiculo.numeroSerie}");
                    }
                }*/

            var soldados = db.Soldado.Include(s => s.SoldadoVehiculo).ToList();
            var vehiculos = db.Vehiculo.ToList();

            Console.WriteLine("");
        }
    }
}
