namespace a
{
    public class Person
    {
        public string name {  get; set; }   
        public DateTime dob { get; set; }
        public double wieght { get; set; }
        public Person() { } // empty constructor function
        public Person (string name, DateTime dob, double wieght) 
        { 
            this.name = name;
            this.dob = dob;
            this.wieght = wieght;
        }

    }
}