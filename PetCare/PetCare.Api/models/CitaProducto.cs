using PetCare.Api.Models;
using PetCare.Api.Models.PetCare.Models;
namespace PetCare.Models
{
    // Esta entidad representa la tabla intermedia para la relación muchos a muchos entre Cita y Producto,
    // con el campo adicional Cantidad.
    public class CitaProducto
    {
        // Claves foráneas compuestas
        public int IdCita { get; set; }
        public Cita Cita { get; set; }

        public int IdProducto { get; set; }
        public Producto Producto { get; set; }

        public int Cantidad { get; set; }

        // Métodos de acción (stubs)
        public void Agregar()
        {
            // Lógica para agregar producto a la cita.
        }

        public void Remover()
        {
            // Lógica para remover producto de la cita.
        }
    }
}
