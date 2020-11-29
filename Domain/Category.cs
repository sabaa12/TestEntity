using System;
using System.Collections.Generic;
using System.Text;

namespace Domain {
  public class Category {
    public int ID { get; set; }
    public string Name { get; set; }
    public ICollection<Book> Books { get; set; }
  }
}
