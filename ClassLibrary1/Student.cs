using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student:IComparable<Student>
    {
        public Student(string name, int ocenka)
        {
            Name = name;
            Ocenka = ocenka;
        }

        public string Name { get; set; }
        public int Ocenka { get; set; }

        public int CompareTo(Student other)
        {
            return string.Compare(Name, other.Name);
        }

        public string Show() 
        {
            return $"Имя - {Name}\n Оценка - {Ocenka}";
        }
        //Aбдурахимов Бек 31ИС
    }
}
