using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQLEntityOrnek
{
    public class Personel
    {
        [Key]
        public int personelid { get; set; }
        public string adsoyad { get; set; }
        public string birim { get; set; }
    }
}
