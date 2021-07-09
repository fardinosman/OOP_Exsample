using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfRelationShipsInOOP
{
    class Program
    {
        //https://www.linkedin.com/pulse/types-relationships-object-oriented-programming-oop-sarah-el-dawody/
        static void Main(string[] args)
        {
            HOD Obj_Hod = new HOD();
            Obj_Hod.MemberID = 10;
            Obj_Hod.MemberName = "Fardin Osman";
            Obj_Hod.Department = "CSE";
            Obj_Hod.Course_Completed = 85;

            Teacher Obj_Teacher = new Teacher();
            Obj_Teacher.Hod_Id = 10;
            Obj_Teacher.MemberName = "Osman";
            Obj_Teacher.Department = "CSE";
            Obj_Teacher.MemberID = 15;

            Obj_Teacher.Teacher_Info();
            Obj_Hod.Hod_Info();

        }
    }
    public class StaffMember
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string Department { get; set; }

        public StaffMember()
        {


        }
    }
    public class HOD :StaffMember
    {
        public HOD()
        {

        }

        public int Course_Completed { get; set; }
        public void Hod_Info()
        {
            string Info = $"Member Id {this.MemberID} \n Member Name={this.MemberName} \n Department Name ={ this.Department} \n Total Course Completed = {this.Course_Completed} %";
            Console.WriteLine(Info);
                
        }

    }
    public class Teacher:StaffMember
    {
        public Teacher()
        {

        }
        public int Hod_Id { get; set; }
        public void Teacher_Info()
        {
            string Info = $"Member ID = {this.MemberID} \n Member Name={this.MemberName} \n Department Name={this.Department} \n Id of HOD={this.Hod_Id} ";
            Console.WriteLine(Info);
        }
    }
}
