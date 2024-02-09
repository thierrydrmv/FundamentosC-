using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    public class Person
    {
        public string name;
        public int age;
        public double height;

        public Person(string name, int age, double height) {
            this.name = name;
            this.age = age;
            this.height = height;
        }
        public void talk()
        {
            Console.WriteLine("Me chamo " + name + " e tenho " + age + " de idade e " + height + "m de altura.");
        }
    }
}
