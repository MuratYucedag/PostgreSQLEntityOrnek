using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQLEntityOrnek
{
   public class Birim
    {
        [Key]
        public int birimid { get; set; }
        public string birimad { get; set; }
    }
}
