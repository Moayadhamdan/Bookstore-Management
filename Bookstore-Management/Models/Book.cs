using System.ComponentModel.DataAnnotations;

namespace Bookstore_Management.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Title length can't be more than 100.")]
        public string Title { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Author name can't be more than 50.")]
        public string Author { get; set; }

        [Range(0.01, 1000.00, ErrorMessage = "Price must be between 0.01 and 1000.")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Genre can't be more than 30.")]
        public string Genre { get; set; }
    }
}
