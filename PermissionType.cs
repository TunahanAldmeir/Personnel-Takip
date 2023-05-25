using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerdonelTakip
{
    public class PermissionType
    {
        [Key]
        public int İzinTürId { get; set; }
        public string İzinTürü { get; set; }
    }
}
