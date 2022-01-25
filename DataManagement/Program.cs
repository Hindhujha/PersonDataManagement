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
            Console.WriteLine("*************************************************");
            Console.WriteLine("RETRIEVING TOP 2 RECORDS LESS THAN AGE 60");
            Retrieve_Top2(listPerson);
        }
        //list of persons and their datas
        private static void AddRecords(List<Person> listPersons)
        {
            listPersons.Add(new Person("2034556787890", "JOHN", "NEW YORK", 35));
            listPersons.Add(new Person("2234570927890", "RONI", "WASHINGTON", 24));
            listPersons.Add(new Person("2034558891235", "SCANDAL", "CHICAGO", 45));
            listPersons.Add(new Person("2234570929864", "ANNIE", "CANADA", 21));
            listPersons.Add(new Person("2000570700001", "MINNIE", "NEW YORK", 40));
            listPersons.Add(new Person("2234570927890", "ROHAN", "LOS VEGAS", 60));
            listPersons.Add(new Person("2034558891235", "RITA", "LOS ANGELS", 68));
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
    }
}
