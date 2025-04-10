using PetCare.Api.Models;
using System.Collections.Generic;

namespace PetCare.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        // Clave foránea: Cada producto está asociado a un Proveedor.
        public int IdProveedor { get; set; }
        public Proveedor Proveedor { get; set; }

        // Relación: Un producto puede estar asociado a muchas Citas a través de CitaProducto.
        public ICollection<CitaProducto> CitaProductos { get; set; } = new List<CitaProducto>();

        // Métodos de acción (stubs)
        public void Registrar()
        {
            // Lógica para registrar un producto.
        }

        public void Modificar()
        {
            // Lógica para modificar un producto.
        }

        public void Eliminar()
        {
            // Lógica para eliminar un producto.
        }
    }
}
