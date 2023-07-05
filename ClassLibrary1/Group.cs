using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace ClassLibrary1
{
    public class Group
    {
        public Group(string name, string college)
        {
            Name = name;
            College = college;
            Students = new List<Student>();
        }
        

        public string Name { get; set; }
        public string College { get; set; }

        public List<Student> Students { get; set; }

        public StringBuilder ShowAll()
        { 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Имя - {Name}");
            sb.AppendLine($"Колледж - {College}");
            foreach(Student student in Students)
                sb.AppendLine(student.Show());
        return sb;
        }

        public void AddStudent(Student student) 
        {
            Students.Add(student);
        }
        //Aбдурахимов Бек 31ИС
    }
}
