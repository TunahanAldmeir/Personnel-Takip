using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerdonelTakip
{
    public class PermissionMove
    {
        [Key]
        public int İzinId { get; set; }
        public int PersonelId { get; set; }
        public int KullanıcıId { get; set; }
        public int İzinTürId { get; set; }
        public  DateTime İzinBasla { get; set; }
        public DateTime İzinBitis { get; set; }
        public string Aciklama { get; set; }
        public string İzinTürü { get; set; }
    }
}
