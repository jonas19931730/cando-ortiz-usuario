using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace DeberDaw.Model
{
    public class Usuario
    {
        public int Id { set; get; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public String? NombreUsuario { set; get; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public String? Clave { set; get; }

        [Required]
        public Boolean Estado { set; get; }

        public int GeneroId { set; get; }

        public Genero? Genero { set; get; }

    }
}
