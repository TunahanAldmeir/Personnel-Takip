using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerdonelTakip
{
    public class DepartContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<User>  Users { get; set; }
        public DbSet<Zam>  Zams { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }
        public DbSet<PermissionMove> PermissionMoves { get; set; }

    }
}
