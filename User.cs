using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerdonelTakip
{
    public class User
    {
        [Key]
        public int KullanıcıId { get; set; }
        public string KullanıcıAdı { get; set; }
        public string KullanıcıSifre { get; set; }
    }
}
