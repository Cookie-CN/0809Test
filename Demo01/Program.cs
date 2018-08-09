using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Student> list = new List<Student>();
            //var result = list.Find(stu => stu.Name == "");
            //Console.WriteLine(result==null);

            double b = 82.0 / 98598;
            Console.WriteLine(b);
            var r = Math.Round(Convert.ToDecimal(b), 2);
            Console.WriteLine(r);
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
