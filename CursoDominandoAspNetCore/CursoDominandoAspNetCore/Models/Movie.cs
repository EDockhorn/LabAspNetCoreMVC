using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoDominandoAspNetCore.Models
{
    public class Movie
    {
        //public Movie()
        //{
        //    Title = "TITULO";
        //    ReleaseDate = DateTime.Now;
        //    Genre = "COMEDIA";
        //    Rating = 10;
        //    Price = 20000;
        //}


        [Key]
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3), Required(ErrorMessage = "O campo Título é requerido")]
        public string Title { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de Lançamento")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Por favor informe o preço")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public double Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Gênero em formato inválido")]
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Máximo de 30 caracteres")]
        public string Genre { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        public int Rating { get; set; }
    }
}
