using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerdonelTakip
{
    public class Zam
    {
        [Key]
        public int ZamId { get; set; }
        public string PersonelName { get; set; }
        public string Donem { get; set; }   
        public decimal Yuzde { get; set; }
        public decimal Fiyat { get; set; }
        public string Açıklama { get; set; }
        public string Tarih { get; set; }
    }
}
