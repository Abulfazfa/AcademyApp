using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AppDBAccess
    {
        public static List<Student>Students = new List<Student>();
        public static List<Group> Groups = new List<Group>();

        static AppDBAccess()
        {
            Students = new List<Student>();
        }
    }
}
