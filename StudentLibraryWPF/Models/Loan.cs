using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentLibraryWPF.Models
{
    public class Loan
    {
        public int Id { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public virtual Book Book { get; set; }

        public virtual Student Student { get; set; }
    }
}
