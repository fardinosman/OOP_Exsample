using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelOOPAssociation
{
    //Association is a “has-a” type relationship.
    //Association establish the relationship b/w two classes 
    //using through their objects. Association relationship can be one to one, One to many,
    //many to one and many to many. For example suppose we have two classes then these two
    //classes are said to be “has-a” relationship if both of these entities share each other’s 
    //object for some work and at the same time they can exists without each others dependency 
    //or both have their own life time.
    
    /*Below example showing an association relationship because both Employee and 
     * Manager class using the object of 
     * each other and both a their own independent life cycle.*/
    class Program//
    {
        static void Main(string[] args)
        {
            Manager Man_Obj = new Manager();
            Man_Obj.Manager_Name = "Fardin Osman";

            Employee Emp_Obj = new Employee();
            Emp_Obj.Emp_Name = "Mastoora";
            Emp_Obj.Manager_Name(Man_Obj);

        }
    }
    class Employee
    {
        public Employee()
        {

        }
        public string Emp_Name { get; set; }
        public void Manager_Name(Manager Obj)
        {
            Obj.manager_Info(this);
        }
    }
    class Manager
    {
        public Manager()
        {

        }
        public string Manager_Name { get; set; }
        public void manager_Info(Employee Obj)
        {
            Console.WriteLine($"Manager of Employee {Obj.Emp_Name} is {this.Manager_Name}");
        }
    }
}
