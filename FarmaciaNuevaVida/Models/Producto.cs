using System.ComponentModel.DataAnnotations;

namespace FarmaciaNuevaVida.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un tipo de producto.")]
        [RegularExpression("^(Natural|Químico|Líquido)$",
            ErrorMessage = "El tipo debe ser Natural, Químico o Líquido.")]
        public string Tipo { get; set; }

        [Range(1, int.MaxValue,
            ErrorMessage = "La cantidad debe ser mayor que 0.")]
        public int Cantidad { get; set; }

        [Range(0.01, double.MaxValue,
            ErrorMessage = "El precio debe ser mayor que 0.")]
        public decimal PrecioUnitario { get; set; }
    }
}