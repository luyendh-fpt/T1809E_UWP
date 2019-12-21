﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using T1809E_HelloUWP.Models;

namespace T1809E_HelloUWP.Services
{
    class ApiStudentService: IStudentService
    {
        private static string REGISTER_API_URL = "https://2-dot-backup-server-002.appspot.com/_api/v2/members";
        private static string CONTENT_TYPE = "application/json";

        public Student Create(Student member)
        {
            return PostStudent(member).GetAwaiter().GetResult();
        }

        private async Task<Student> PostStudent(Student member)
        {
            // chuyển đối tượng member thành định dạng json.
            var studentJson = JsonConvert.SerializeObject(member);
            // quá trình đóng gói dữ liệu trước khi gửi đi.
            HttpContent contentToSend = new StringContent(studentJson,
                Encoding.UTF8, CONTENT_TYPE);
            // gọi shipper
            HttpClient httpClient = new HttpClient();
            // gửi đến đây (link), món quà này (contentToSend), chờ quá trình gửi thành công, thì lấy xác nhận từ người nhận.
            var response = await httpClient.PostAsync(REGISTER_API_URL,contentToSend);
            // đọc dữ liệu response từ người nhận.
            var stringContent = await response.Content.ReadAsStringAsync();
            // chuyển định dạng dữ liệu về đối tượng của C#
            var returnStudent = JsonConvert.DeserializeObject<Student>(stringContent);
            // in ra một thuộc tính của đối tượng đó.
            Debug.WriteLine(returnStudent.id);
            return returnStudent;
        }

        public List<Student> GetList()
        {
            throw new NotImplementedException();
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