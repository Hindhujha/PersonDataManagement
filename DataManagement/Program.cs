using System;
using System.Collections.Generic;
using System.Linq;
namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PERSON DATA MANAGEMENT PROGRAMS");
            List<Person> listPerson=new List<Person>();
            AddRecords(listPerson);
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("RETRIEVING TOP 2 RECORDS LESS THAN AGE 60");
            Retrieve_Top2(listPerson);
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("RETRIEVING AGE BETWEEN 13 TO 18");
            Retrieve_Age13btwn18(listPerson);
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("AVERAGE AGE");
            AverageAge(listPerson);
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("CHECKING PERSON IN THE LIST OR NOT");
            CheckPerson(listPerson);
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("SKIP PERSON LESS THAN 60");
            SkipRecord(listPerson);
        }
        //list of persons and their datas
        private static void AddRecords(List<Person> listPersons)
        {
            listPersons.Add(new Person("2034556787890", "JOHN", "NEW YORK", 35));
            listPersons.Add(new Person("2234570927890", "RONI", "WASHINGTON", 24));
            listPersons.Add(new Person("2034558891235", "SCANDAL", "CHICAGO", 45));
            listPersons.Add(new Person("2234570929864", "ANNIE", "CANADA", 13));
            listPersons.Add(new Person("2000570700001", "MINNIE", "NEW YORK", 40));
            listPersons.Add(new Person("2234570927890", "ROHAN", "LOS VEGAS", 16));
            listPersons.Add(new Person("2034558891235", "RITA", "LOS ANGELS", 18));
            listPersons.Add(new Person("2234570929864", "JENNIE", "DUBAI", 60));
            listPersons.Add(new Person("2000570700001", "LISA", "NEW YORK", 72));
            Console.WriteLine("PERSON DETAILS ARE: ");
            foreach (Person person in listPersons)
            {
            
                Console.WriteLine("SSN: " + person.SSN + " NAME: " + person.Name + " Address: "+ person.Address
                +" AGE :"+person.Age);
            }
        }

        //retrieve top 2 records age less than 60
        private static void Retrieve_Top2(List<Person> listPersons)
        {
            foreach (Person person in listPersons.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("NAME :" + person.Name + " \t AGE : " + person.Age);
            }
        }

         //retrieve  age between 13-18
        private static void Retrieve_Age13btwn18(List<Person> listPersons)
        {
            foreach (Person person in listPersons.FindAll(e => (e.Age >= 13 && e.Age <=18)))
            {
                Console.WriteLine("NAME :" + person.Name + " \t AGE : " + person.Age);
            }
        }

        //Average  age 
        private static void AverageAge(List<Person> listPersons)
        {
        var average=listPersons.Average(e => e.Age);
            Console.WriteLine("AVERAGE AGE IS : " + Math.Round(average));
        }

        //checking for particular person

        private static void CheckPerson(List<Person>listPersons)
        {
         if(listPersons.Exists(e=>e.Name=="LISA"))
            {
                Console.WriteLine("LISA EXISTS IN OUR LIST");
            }
            else
            {
                Console.WriteLine("LISA IS NOT IN THE LIST");
            }
        }
        //skip record

        private static void SkipRecord(List<Person>listPersons)
        {
            foreach(Person person in listPersons.SkipWhile(e=>e.Age <60))
            {
                Console.WriteLine("NAME :" + person.Name + " \t AGE : " + person.Age);
            }
        }
    }
}
