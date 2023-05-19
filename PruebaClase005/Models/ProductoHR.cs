using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PruebaClase005.Models
{
    public class ProductoHR
    {
        public int IdProducto { get; set; }
        public string Sku { get; set; } = null!;
        public string Titulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Precio { get; set; }
        public int? DescuentoPorcentaje { get; set; }
        public int Existencia { get; set; }
        public int IdMarca { get; set; }
        public string? Imagen { get; set; }
    }
}
