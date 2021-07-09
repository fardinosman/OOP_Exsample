using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionInOOP
{
    class Program
    {
        //this rel in OOP is Called Composition Part of Engine is Part of a Car
        static void Main(string[] args)
        {
            Suzuki Obj = new Suzuki();
            Obj.Color = "Black";
            Obj.Max_Speed = "300Km";
            Obj.Model_No = "Sitra";
            Obj.Total_Seats = 6;//
            Obj.CarInfo();
        }
    }
    class Car
    {
        public Car()
        {

        }
        public string Color { get; set; }
        public string Max_Speed { get; set; }
    }
    class Suzuki : Car //Suzuki inhert from Car
    {
        public Suzuki()
        {

        }
        public int Total_Seats { get; set; }
        public string Model_No { get; set; }
        public void CarInfo()
        {
            string Info = $"Color of Car is  {this.Color} \n Maximum Speed is {this.Max_Speed} \n Numbers of Seets is \n {this.Total_Seats} \n Model_No is {this.Model_No} \n";
            Console.WriteLine(Info);
            Engine Obj = new Engine(); // Suzuki has a Engine is called Composition Rel ship in OOP
            Obj.Engine_Info();

        }
    }
    class Engine 
    {
        public void Engine_Info()
        {
            Console.WriteLine("Engine is 4 stroke and fuel efficiency is good");
        }
    }
}
