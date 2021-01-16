using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    //Static tanımlandığı zaman new lemeye gerek kalmaz. Ortak nesnelerdir ve herkes kullanabilirler.
    static class StaticConstructor
    {
        public static void Static()
        {
            Teacher.Add();
            Teacher.Delete();

            Student.Add(); // static ise bu şekilde ulaşıyoruz
            Student student = new Student(); // static değilse bu şekilde ulaşıyoruz
            student.Delete(); // static değil
        }
    }

    static class Teacher//class static ise içindekilerde static olmak zorunda.
    {
        public static void Add()
        {
            Console.WriteLine("Teacher Added");
        }
        public static void Delete()
        {
            Console.WriteLine("Teacher Deleted");
        }
    }
    class Student//classı static yapmayıp içindekilerden bazılarının static olmasını isteyebiliriz.
    {
        public static void Add() //! Static
        {
            Console.WriteLine("Student Added");
        }
        public void Delete()  // ! Static Değil !!
        {
            Console.WriteLine("Student Deleted");
        }
    }

}
