namespace PetCare.Api.Models;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

{

    public class Mascota
    {
        public int IdMascota { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }

        // Clave foránea: Cada mascota pertenece a un Cliente.
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }

        // Relación: Una Mascota puede tener muchas Citas.
        public ICollection<Cita> Citas { get; set; } = new List<Cita>();

        // Métodos de acción (stubs)
        public void Registrar()
        {
            // Lógica para registrar una mascota.
        }

        public void Actualizar()
        {
            // Lógica para actualizar datos de la mascota.
        }

        public void Eliminar()
        {
            // Lógica para eliminar una mascota.
        }
    }
}
