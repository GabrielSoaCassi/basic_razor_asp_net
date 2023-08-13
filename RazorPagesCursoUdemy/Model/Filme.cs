using System.ComponentModel.DataAnnotations;

namespace RazorPagesCursoUdemy.Model
{
    public class Filme:Base
    {
        public string Title { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime LaunchDate { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public int Points { get; set; } = 0;
    }
}
