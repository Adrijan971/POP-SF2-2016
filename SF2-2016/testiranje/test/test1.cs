using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2_2016.TEST
{
    class Test1
    {
        private string name { get; set; }
        public double weight { get; set; }

        public Test1(string name , double weight)
        { 
            this.name = name;
            this.weight = weight;
        }


        static void Main(string[] args)
        {
            var obj1 = new Test1("ime", 12);

            Console.WriteLine(obj1.name+ obj1.weight);
            obj1.weight = 15;
            Console.WriteLine(obj1.name + obj1.weight);
            Console.WriteLine(obj1.GetType());

            Console.ReadLine();

        }
    }
}
