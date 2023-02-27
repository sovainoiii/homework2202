using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Bai lam cua Pham Duc Minh
namespace baitapcollection3
{
    internal class Student : IComparable<Student>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Student() { }
        public Student(int id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }
        public void Show()
        {
            Console.WriteLine($"ID: {ID}, Ten: {Name}, tuoi: {Age}");
        }

        public int CompareTo(Student? other)
        {
            if (ID > other.ID) return 1;
            else if(ID < other.ID) return -1;
            return 0;
        }
    }
}
