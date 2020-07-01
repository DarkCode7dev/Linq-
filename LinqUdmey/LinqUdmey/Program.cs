using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqUdmey
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {

                new Person("Tod", 180, 70, Gender.Male),
                new Person("John", 170, 88, Gender.Male),
                new Person("Anna", 150, 48, Gender.Female),
                new Person("Kyle", 164, 77, Gender.Male),
                new Person("Anna", 164, 77, Gender.Male),
                new Person("Maria", 160, 55, Gender.Female),
                new Person("John", 160, 55, Gender.Female)



            };


            var fourCharPeople = from p in people
                                 where (p.Name.Length == 4)
                                 orderby p.Weight
                                 select p;

            foreach (var item in fourCharPeople)
            {
                Console.WriteLine($" Name: {item.Name} , Weight : {item.Weight}");
            }

        }
    }
}

internal class Person
{
    private string name;
    private int height;
    private int weight;

    private Gender gender;

    public string Name
    {
        get
        {
            return this.name;
        }


        set
        {
            this.name = value;
        }
    }


   

    public int Height
    {
        get
        {
            return this.height;
        }


        set
        {
            this.height = value;
        }
    }


   
    public int Weight
    {
        get
        {
            return this.weight;
        }


        set
        {
            this.weight = value;
        }
    }



    public Gender Gender { get; set; }


    public Person(string name , int height , int weight , Gender gender)
    {
        this.Name = name;
        this.Height = height;
        this.Weight = weight;
        this.Gender = gender;

    }

}

internal enum Gender
{
    Male,
    Female
}
