using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentLibraryWPF.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public int Year { get; set; }

        public bool IsAvailable { get; set; } = true;

        public virtual ICollection<Loan> Loans { get; set; }
    }
}
