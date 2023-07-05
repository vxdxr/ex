using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("31ИС", "1-й МОК");
            Student student = new Student("Марцинкевич Павел Алексеевич", 3);
            Student student2 = new Student("Залевский Артем Сергеевич", 4);
            Student student3 = new Student("Тиханов Ангелус Владимирович", 5);
            group.AddStudent(student);
            group.AddStudent(student2);
            group.AddStudent(student3);
            Console.WriteLine(group.ShowAll());
            Console.WriteLine(student.CompareTo(student2));
            Console.ReadLine();
            //Aбдурахимов Бек 31ИС
        }
    }
}
