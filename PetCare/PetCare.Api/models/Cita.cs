namespace PetCare.Api.Models
{
    using System;
    using System.Collections.Generic;

    namespace PetCare.Models
    {
        public class Cita
        {
            public int IdCita { get; set; }
            public DateTime FechaHora { get; set; }

            // Clave foránea: La cita está asociada a una Mascota.
            public int IdMascota { get; set; }
            public Mascota Mascota { get; set; }

            // Clave foránea: La cita está asociada a un Servicio.
            public int IdServicio { get; set; }
            public Servicio Servicio { get; set; }

            // Relación Muchos a Muchos (con información adicional) a través de CitaProducto.
            public ICollection<CitaProducto> CitaProductos { get; set; } = new List<CitaProducto>();

            // Métodos de acción (stubs)
            public void Agendar()
            {
                // Lógica para agendar la cita.
            }

            public void Cancelar()
            {
                // Lógica para cancelar la cita.
            }
        }
    }

}
