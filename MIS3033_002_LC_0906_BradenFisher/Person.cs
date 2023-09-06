namespace a
{
    public class Person// Object
    {
        public double grade { get; set; }// C# Syntax// you need to know
        public string name {  get; set; }// member field   
        public DateTime dob { get; set; }
        public double wieght { get; set; }
        public virtual string CoffeeMaker() // virtual, replaceable
        {

            return "This is the coffee from person";
        } 

        public Person() { } // empty constructor function 1

        // local variable
        public Person (string name, DateTime dob, double wieght)// constructor function 2
        {
            Console.WriteLine(name);// local has priority
            this.name = name;// this self 
            this.dob = dob;
            this.wieght = wieght;
        }
        // two functions have exactly the same name but different parameters. (Function overload)

    }
}