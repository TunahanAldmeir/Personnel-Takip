using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerdonelTakip
{
    public class PermissionTypeDal
    {
        DepartContext dcontext = new DepartContext();
        public List<PermissionType> GetAll()
        {
            return dcontext.PermissionTypes.ToList();
        }

        public void Add(PermissionType  permissionType)
        {
            using (DepartContext dcontext = new DepartContext())
            {
                dcontext.PermissionTypes.Add(permissionType);
                dcontext.SaveChanges();
            }
        }
        public void Delete(PermissionType permissionType)
        {
            using (DepartContext dcontext = new DepartContext())
            {
                dcontext.Entry(permissionType).State = System.Data.Entity.EntityState.Deleted;
                dcontext.SaveChanges();
            }
        }
        public void Update(PermissionType permissionType)
        {
            using (DepartContext dcontext = new DepartContext())
            {
                dcontext.Entry(permissionType).State = System.Data.Entity.EntityState.Modified;
                dcontext.SaveChanges();
            }
        }
    }
}
