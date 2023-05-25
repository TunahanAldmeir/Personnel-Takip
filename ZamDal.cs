using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerdonelTakip
{
    public class ZamDal
    {
        public void Add(Zam  zam)
        {
            using (DepartContext dcontext = new DepartContext())
            {
                dcontext.Zams.Add(zam);
                dcontext.SaveChanges();
            }
        }
    }
}
