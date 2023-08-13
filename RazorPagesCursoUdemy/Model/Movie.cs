using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesCursoUdemy.Model
{
    public class Movie:Base
    {
        [StringLength(100,MinimumLength = 2,ErrorMessage = "Title isn't on the minimum length")]
        public string Title { get; set; } = string.Empty;

        [StringLength(20,MinimumLength = 2 )]
        public string Gender { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [Display(Name ="Date Launch")]
        public DateTime LaunchDate { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }

        [Range(0,5)]
        public int Points { get; set; } = 0;
    }
}
