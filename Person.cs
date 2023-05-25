using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerdonelTakip
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public string PersonAd { get; set; }
        public string PersonSoyad { get; set; }
        public string PersonTel { get; set; }
        public string PersonAdres { get; set; }
        public string PersonEmail { get; set; }
        public int PersonDepartId { get; set; }
        public string PersonDurum { get; set; }
        public int PersonMaas { get; set; }
        public string PersonGTarihi { get; set; }
        public string PersonCTarihi { get; set; }
        public string PersonAcıklama { get; set; }
        public string DepartmanAdı { get; set; }

    }
}
