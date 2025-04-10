using PetCare.Api.Models;
using System.Collections.Generic;

namespace PetCare.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        // Relación: Un Cliente puede tener muchas Mascotas.
        public ICollection<Mascota> Mascotas { get; set; } = new List<Mascota>();

        // Métodos de acción (stubs)
        public void Registrar()
        {
            // Lógica para registrar un cliente.
        }

        public void Actualizar()
        {
            // Lógica para actualizar datos del cliente.
        }

        public void Eliminar()
        {
            // Lógica para eliminar un cliente.
        }
    }
}
