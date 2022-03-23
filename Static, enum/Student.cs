using System;
using System.Collections.Generic;
using System.Text;

namespace Static__enum.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Point { get; set; }

        public Student(string FulName, int Point)
        {
            this.FullName = FulName;
            this.Point = Point;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"id =>{Id}");
            Console.WriteLine($"FullName =>{FullName}");
            Console.WriteLine($"Point =>{Point}");
        }
    }
}
