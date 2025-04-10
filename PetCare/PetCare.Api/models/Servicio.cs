using PetCare.Api.Models;
using PetCare.Api.Models.PetCare.Models;
using System.Collections.Generic;

namespace PetCare.Models
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        // Relación: Un Servicio puede estar asociado a muchas Citas.
        public ICollection<Cita> Citas { get; set; } = new List<Cita>();

        // Métodos de acción (stubs)
        public void Crear()
        {
            // Lógica para crear un servicio.
        }

        public void Modificar()
        {
            // Lógica para modificar el servicio.
        }

        public void Eliminar()
        {
            // Lógica para eliminar un servicio.
        }
    }
}
