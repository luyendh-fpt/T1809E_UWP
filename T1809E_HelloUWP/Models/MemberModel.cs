using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;

namespace T1809E_HelloUWP.Models
{
    public class MemberModel
    {
        public bool Save(Member member)
        {
            var sqlConnection = SQLiteHelper.CreateInstance().SQLiteConnection;
            var sqlCommandString = "insert into Members (Name, Username, Password) values (?,?,?)";
            using (var stt = sqlConnection.Prepare(sqlCommandString))
            {
                stt.Bind(1, member.Name);
                stt.Bind(2, member.Username);
                stt.Bind(3, member.Password);
                var result = stt.Step();
                return result == SQLiteResult.OK;
            }
        }

        public List<Member> GetList()
        {
            List<Member> list = new List<Member>();
            var sqlConnection = SQLiteHelper.CreateInstance().SQLiteConnection;
            var sqlCommandString = "select * from Members";
            using (var stt = sqlConnection.Prepare(sqlCommandString))
            {
                while (SQLiteResult.ROW == stt.Step())
                {
                   var id = stt[0].ToString();
                   var name = (string) stt[1];
                   var username = (string) stt["Username"];
                   var password = (string) stt["Password"];
                   var member = new Member()
                   {
                       Id = Int32.Parse(id),
                       Name = name,
                       Username = username,
                       Password = password
                   };
                   list.Add(member);
                }
            }
            return list;
        }

        public Member GetDetail(int id)
        {
            return new Member();
        }

        public Member Update(Member member)
        {
            return new Member();
        }

        public bool Delete(int id)
        {
            return false;
        }
    }
}
