using System.ComponentModel.DataAnnotations.Schema;

namespace tp2.Models
{
    public class Movie
    {
        public  int Id { get; set; }
        public string Name { get; set; } = "";
        public int GenreId { get; set; }
        public virtual Genres? Genre { get; set; }
        public ICollection<Customer>? Customers { get; set; }


        public DateTime? MovieAdded { get; set; }
        public string? Photo { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
    }
}
