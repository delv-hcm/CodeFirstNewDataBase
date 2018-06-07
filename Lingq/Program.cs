using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lingq
{
    public class student
    {
        public string name { get; set; }
        public int id { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[5] { 1, 2, 3, 4, 5 };

            List<student> Students = new List<student>()
            {
                new student { name = "xyz", id = 111 },
                new student {name="abc",id=112},
                 new student {name="abc",id=110}
            };
            var student_ = from stu in Students
                           
                           select stu.name;
            var number = from num in list
                         where num % 2 == 0
                         select num;
            foreach (var item in student_)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
