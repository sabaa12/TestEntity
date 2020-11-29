using System;
using System.Collections.Generic;
using System.Text;

namespace Domain {
  public class Book {
    public int ID { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public DateTime? PublishDate { get; set; }
    public int? CategoryID { get; set; }
    public Category Category { get; set; }
    public Annotation Annotation { get; set; }
    public ICollection<Author> Authors { get; set; }
  }
}
