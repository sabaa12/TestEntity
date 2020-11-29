using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain {
  public class Author {
    [Key]
    public int ID { get; set; }

    [Required, MaxLength(20)]
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string PhoneNumber { get; set; }

    [NotMapped]
    public string FullName => $"{FirstName} {LastName}";

    public IComparable<Book> Books { get; set; }
  }
}
