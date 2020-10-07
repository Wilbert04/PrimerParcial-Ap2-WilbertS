using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial_Ap2_WIlbertSmith.Models
{
    public class Productos
    {
        [Key]
        [Range(0, 1000000, ErrorMessage = "ProductoId incorrecto!!!, El limite permitido es de 0 a 1000000")]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Descripcion { get; set; }

        [Range(minimum: 1, maximum: 200, ErrorMessage = " El maximo de existencia es de 200")]
        public int Existencia { get; set; }

        [Required(ErrorMessage = "El monto es obligatorio")]
        public decimal Costo { get; set; }
        public decimal ValorInventario { get; set; }

    }
}
