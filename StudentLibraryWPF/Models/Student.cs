using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentLibraryWPF.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public string GroupName { get; set; }

        public virtual ICollection<Loan> Loans { get; set; }
    }
}
