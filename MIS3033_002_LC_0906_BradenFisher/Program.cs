// MIS 3033 002
// September 6, 2023
// Braden Fisher 113492081

using a;

Console.WriteLine("Interface");// class, interface

Person p1;

p1 = new Person();
p1.name = "Braden Fisher";
p1.dob = new DateTime(2001, 12, 21);
p1.wieght = 189.4;// in lbs
// this is on branch 1
Console.WriteLine(p1.dob.ToString("MMMM dd, yyyy"));
