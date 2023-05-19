using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace PruebaClase005.Models.dbModels
{
    public class ApplicationUser : IdentityUser<int>
    {
        public ApplicationUser()
        {
            Carritos = new HashSet<Carrito>();
            Deseados = new HashSet<Deseado>();
            Resenas = new HashSet<Resena>();
            Venta = new HashSet<Ventum>();
        }

        public int Edad { get; set; }
        [StringLength(50)]
        public string? Direccion { get; set; }
        


        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<Carrito> Carritos { get; set; }
        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<Deseado> Deseados { get; set; }
        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<Resena> Resenas { get; set; }
        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
