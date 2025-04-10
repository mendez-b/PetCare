using PetCare.Api.Models;
using System.Collections.Generic;

namespace PetCare.Models
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        // Relación: Un proveedor puede tener muchos productos.
        public ICollection<Producto> Productos { get; set; } = new List<Producto>();

        // Métodos de acción (stubs)
        public void Registrar()
        {
            // Lógica para registrar un proveedor.
        }

        public void Actualizar()
        {
            // Lógica para actualizar datos del proveedor.
        }

        public void Eliminar()
        {
            // Lógica para eliminar un proveedor.
        }
    }
}
