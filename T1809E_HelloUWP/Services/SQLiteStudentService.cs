using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1809E_HelloUWP.Models;

namespace T1809E_HelloUWP.Services
{
    public class SQLiteStudentService: IStudentService
    {
        private MemberModel memberModel;

        public SQLiteStudentService()
        {
            memberModel = new MemberModel();
        }

        public void Create(Member member)
        {
            memberModel.Save(member);
        }

        public Task<Student> Create(Student student)
        {
            throw new NotImplementedException();
        }

        public Task<List<Student>> GetList()
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetDetail(string rollNumber)
        {
            throw new NotImplementedException();
        }

        public Task<Student> Update(Student student)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(string rollNumber)
        {
            throw new NotImplementedException();
        }
    }
}
