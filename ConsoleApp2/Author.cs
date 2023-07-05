using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp2
{
    internal class Author
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Person person = new Person("Сантурян Самвел", "Мурановская 5а");
            Student book = new Book("Исскуство войны", person);
            Student book2 = new Book("Война и мир", person);
            library.AddPerson(person);
            library.AddBooks(book);
            library.AddBooks(book2);
            Console.WriteLine(library.ShowAll());
            Console.WriteLine(book2.CompareTo(book));
            Console.ReadLine();
        }

    }
}
