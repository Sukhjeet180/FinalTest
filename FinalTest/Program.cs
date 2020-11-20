using System;

namespace FinalTest
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Person[] persons=new Person[2];
            persons[0] = new Adult("Sukhjeet","Kaur");
            persons[1] = new Child("Moninder","Singh");

            foreach(Person p in persons)
            {
                Console.WriteLine(p.FirstName +" "+p.LastName);
            }

        }
   

    }

    public class Person
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        

    }

    public class Adult : Person
    {
        public override string FirstName { get; set; }
        public Adult(string fname,string lname)
        {
            FirstName = fname;
            LastName = lname;
        }
    }

    public class Child : Person
    {
        public override string FirstName { get; set; }
        public Child(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }

    }

}
