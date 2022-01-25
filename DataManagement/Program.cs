using System;
namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PERSON DATA MANAGEMENT PROGRAMS");
            List<Person> listPerson=new List<Person>();
            AddRecords(listPerson);
        }
        //list of persons datas
        private static void AddRecords(List<Person> listPersons)
        {
            listPersons.Add(new Person("2034556787890", "JOHN", "NEW YORK", 25));
            listPersons.Add(new Person("2234570927890", "RONI", "WASHINGTON", 24));
            listPersons.Add(new Person("2034558891235", "SCANDAL", "CHICAGO", 23));
            listPersons.Add(new Person("2234570929864", "ANNIE", "CANADA", 21));
            listPersons.Add(new Person("2000570700001", "MINNIE", "NEW YORK", 26));
            Console.WriteLine("PERSON DETAILS ARE: ");
            foreach (Person person in listPersons)
            {
            
                Console.WriteLine("SSN: " + person.SSN + " NAME: " + person.Name + " Address: "+ person.Address
                +" AGE :"+person.Age);
            }
        }
    }
}
