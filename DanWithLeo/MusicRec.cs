using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanWithLeo
{
  public  class MusicRec
    {
      [Required]
      public int Id {get; set;}
      public string Name {get; set;}
      public double Leanth {get; set;}
      public string Author { get; set; }
    }
}
