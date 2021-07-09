using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stuObj = new Student();
            stuObj.Name = "Fardin Osman";
            stuObj.roll_No = 111222;
            stuObj.Class = 12;

            Address addObj = new Address();
            addObj.City = "Kolding";
            addObj.Pincode = "6000";
            addObj.State = "Sydjyland";
            stuObj.Get_Student_Info(addObj);

        }
    }
    class Student
    {
        public Student()
        {


        }
        public string Name { get; set; }
        public int roll_No { get; set; }
        public int Class { get; set; }

        public void Get_Student_Info(Address Obj)
        {
            Console.WriteLine($"Student Name={this.Name} \n Roll_No={this.roll_No} \n Class={this.Class}\n");
            Obj.GetAddress();
        }
    }
}
