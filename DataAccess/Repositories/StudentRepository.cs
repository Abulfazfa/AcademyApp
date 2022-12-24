using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        public bool Create(Student entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Student entity)
        {
            throw new NotImplementedException();
        }

        public Student Get(Predicate<Student> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll(Predicate<Student> filter = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
