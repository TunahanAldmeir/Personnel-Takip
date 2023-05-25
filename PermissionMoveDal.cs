using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerdonelTakip
{
    public class PermissionMoveDal
    {
        DepartContext dcontext = new DepartContext();
        public List<PermissionMove> GetAll()
        {
            return dcontext.PermissionMoves.ToList();
        }
        public void Add(PermissionMove permissionMove)
        {
            using (DepartContext dcontext = new DepartContext())
            {
                dcontext.PermissionMoves.Add(permissionMove);
                dcontext.SaveChanges();
            }
        }
        public void Delete(PermissionMove permissionMove)
        {
            using (DepartContext dcontext = new DepartContext())
            {
                dcontext.Entry(permissionMove).State = System.Data.Entity.EntityState.Deleted;
                dcontext.SaveChanges();
            }
        }
        public void Update(PermissionMove permissionMove)
        {
            using (DepartContext dcontext = new DepartContext())
            {
                dcontext.Entry(permissionMove).State = System.Data.Entity.EntityState.Modified;
                dcontext.SaveChanges();
            }
        }
    }
}
