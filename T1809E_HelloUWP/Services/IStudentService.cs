using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1809E_HelloUWP.Models;

namespace T1809E_HelloUWP.Services
{
    interface IStudentService
    {
        Student Create(Student student);
        List<Student> GetList();
        Student GetDetail(string rollNumber);
        Student Update(Student student);
        bool Delete(string rollNumber);
    }
}
