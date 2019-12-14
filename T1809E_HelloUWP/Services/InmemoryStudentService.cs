using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1809E_HelloUWP.Models;

namespace T1809E_HelloUWP.Services
{
    class InmemoryStudentService: IStudentService
    {
        private static List<Student> _students = new List<Student>();
        public Student Create(Student student)
        {
            _students.Add(student);
            return student;
        }

        public List<Student> GetList()
        {
            return _students;
        }

        public Student GetDetail(string rollNumber)
        {
            throw new NotImplementedException();
        }

        public Student Update(Student student)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string rollNumber)
        {
            throw new NotImplementedException();
        }
    }
}
