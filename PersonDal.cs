using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerdonelTakip
{
    public class PersonDal
    {
        DepartContext dcontext = new DepartContext();
        public List<Person> GetAll()
        {
            return dcontext.People.ToList();
        }
        public void Add(Person person)
        {
            using (DepartContext dcontext = new DepartContext())
            {
                dcontext.People.Add(person);
                dcontext.SaveChanges();
            }
        }
        public void Delete(Person person)
        {
            using (DepartContext dcontext = new DepartContext())
            {
                dcontext.Entry(person).State = System.Data.Entity.EntityState.Deleted;
                dcontext.SaveChanges();
            }
        }
        public void Update(Person person)
        {
            using (DepartContext dcontext = new DepartContext())
            {
                dcontext.Entry(person).State = System.Data.Entity.EntityState.Modified;
                dcontext.SaveChanges();
            }
        }
        public List<Person> GetByName(string search)
        {
           return dcontext.People.Where(p => p.PersonAd.Contains(search)).ToList();
        }

        public void ZamYap(int PersonId, int PersonMaas)
        {
            var maas = new Person() { PersonId = PersonId, PersonMaas = PersonMaas };
            using (DepartContext dcontext = new DepartContext())
            {
                dcontext.People.Attach(maas);
                dcontext.Entry(maas).Property(p => p.PersonMaas).IsModified = true;
                dcontext.SaveChanges();
            }
        }
        public void GetByName2(string name)
        {
            using (DepartContext dcontext = new DepartContext())
            {
                dcontext.People.SingleOrDefault(p => p.PersonAd == name);
            }
        }
    }
}
