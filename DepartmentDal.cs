using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerdonelTakip
{
    public class DepartmentDal
    {
        public List<Department> GetAll()
        {
            using(DepartContext dc = new DepartContext())
            {
                return dc.Departments.ToList();
            }
        }
        public void Add(Department department)
        {
            using (DepartContext dcontext = new DepartContext())
            {
                dcontext.Departments.Add(department);
                dcontext.SaveChanges();
            }
        }
        public void Delete(Department department)
        {
            using (DepartContext dcontext = new DepartContext())
            {
                dcontext.Entry(department).State = System.Data.Entity.EntityState.Deleted;
                dcontext.SaveChanges();
            }
        }
        public void Update(Department department)
        {
            using (DepartContext dcontext = new DepartContext())
            {
                dcontext.Entry(department).State = System.Data.Entity.EntityState.Modified;
                dcontext.SaveChanges();
            }
        }
    }
}
