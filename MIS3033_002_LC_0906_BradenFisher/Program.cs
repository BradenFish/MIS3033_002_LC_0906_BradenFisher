// MIS 3033 002
// September 6, 2023
// Braden Fisher 113492081

using a;
using f1;

Console.WriteLine("Interface");// class, interface

a.Person p1;// Person, blueprint, complex

p1 = new Person();// function call, constructor function

Person p2 = new Person("Braden", new DateTime(2000,6,29), 136);
p1.grade = 96.6;// simple// write the value
Console.WriteLine(p1.grade);// read the value
//

p1.name = "Braden Fisher";
p1.dob = new DateTime(2001, 12, 21);
p1.wieght = 189.4;// in lbs
// this is on branch 1
Console.WriteLine(p1.dob.ToString("MMMM dd, yyyy"));

Student stu1;// student, complex
stu1 = new Student();

Console.WriteLine(stu1.CoffeeMaker());
Console.WriteLine(stu1);
Console.WriteLine(stu1.ToString());

// simple: int double bool char
// complex: string, student
int age2; // int
string str2;// string
// var
var age3 = 19;// var here is int
//var age4; //
var stu3 = new Student();// student datatype
var stu4 = new Person();// 

// namespace
// folder concept
namespace f1 // 2folder concept, 
{
    public class Student : Person // none. Student, complex
    {
        public string id { get; set; }
        public Student() { }

        public override string ToString()
        {
            return "This is a student";
        }
        public override string CoffeeMaker()
        {
            return "This is the coffee from Student";
        }
    }
}
