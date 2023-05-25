using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerdonelTakip
{
    public class Department
    {
        [Key]
        public int DepartId { get; set; }
        public string DepartName { get; set; }
        public string DepartDescription { get; set; }
    }
}
