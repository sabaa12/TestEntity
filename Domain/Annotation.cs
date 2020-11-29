using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Domain {
  public class Annotation {
    [ForeignKey("Book")]
    public int ID { get; set; }
    public string Text { get; set; }
    public Book Book { get; set; }
  }
}