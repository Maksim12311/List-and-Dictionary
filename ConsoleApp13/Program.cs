using System.Xml.Linq;
using System;

namespace ListAndDictionary
{
    internal class Program
    {
        // List variable containing names of persons
        public static List<string> personList = new List<string>();

        // Dictionary containing person name and age where the string TKey is for name and the int TValue is for age
        public static Dictionary<string, int> personAgeDictionary = new Dictionary<string, int>();

        public static void Main()
        {
            Console.WriteLine("Welcome to the Person Manager!");
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Add New Person");
                Console.WriteLine("2. Remove Person");
                Console.WriteLine("3. Find Person");
                Console.WriteLine("4. List All Persons");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        RemovePerson();
                        break;
                    case "3":
                        FindPerson();
                        break;
                    case "4":
                        DisplayAllPersons();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        public static void AddPerson()
        {
            // TODO 1: Request user input for the person's name.
            Console.WriteLine("Write the name");
            string s = Console.ReadLine();
            // TODO 2: Validate if the person already exists in the personList.
            bool personexist = personList.Contains(s);
            if (personexist)
            {
                Console.WriteLine("This person exists");
            }
            else
            {
                // TODO 3: Add the person to the personList if they don't already exist.
                personList.Add(s);
                // TODO 4: Provide user feedback for successful addition or if the person already exists in personList.
                Console.WriteLine("The person seccessfully added");
            }
            // TODO 5: Validate if the person already exists in the personAgeDictionary.
            bool ageexist = personAgeDictionary.ContainsKey(s);
            if (ageexist)
            {
                Console.WriteLine("This person exsts");
            }
            else
            {


                // TODO 6: If they don't exist, request age input and add the person to the personAgeDictionary.
                //         NOTE!: Remember to add both TKey and TValue
                Console.WriteLine("Write the age");
                string s1 = Console.ReadLine();
                int age = int.Parse(s1);
                personAgeDictionary.Add(s, age);
                Console.WriteLine("Person added successfully");
            }
            // TODO 7: Provide user feedback for successful addition or if the person already exists in personAgeDictionary.
            Console.WriteLine("The person added in list");
        }


        public static void RemovePerson()
        {
            // TODO 8: Request user input for the name of the person to remove.
            Console.WriteLine("Write the name of person which you would like to remove");
            string s2 = Console.ReadLine();
            // TODO 9: Remove the person from personList if they exist.
            bool existpersoninl = personList.Contains(s2);
            if (existpersoninl) 
            {   
                personList.Remove(s2);
                Console.WriteLine("The person was deleted");
            }
            // TODO 10: Provide user feedback for successful removal or if the person doesn't exist in personList.
            else
            {
                Console.WriteLine("The person isn't on the List");
            }
            // TODO 11: Remove the person from personAgeDictionary if they exist.
            bool ageremove = personAgeDictionary.ContainsKey(s2);
            if (ageremove)
            {
                personAgeDictionary.Remove(s2);
                Console.WriteLine("The age was deleted");
            }
            // TODO 12: Provide user feedback for successful removal or if the person doesn't exist in personAgeDictionary.
            else
            {
                Console.WriteLine("The age of person isn't in List");
            }
        }


        public static void FindPerson()
        {
            // TODO 13: Request user input for the name of the person to find.
            Console.WriteLine("Write the name");
            string s3 = Console.ReadLine();
            // TODO 14: Check if the person is in personList and provide appropriate feedback.
            bool personinlist = personList.Contains(s3);
            if (personinlist) 
            { 
                Console.WriteLine($"The person exists in List {s3}");
            }
            else
            {
                Console.WriteLine($"Person with name {s3} not found");      
            }
            // TODO 15: Check if the person is in personAgeDictionary and provide appropriate feedback.
            bool personage = personAgeDictionary.ContainsKey(s3);
            if (personage) 
            { 
                 Console.WriteLine($"Person with name {s3} has age");
            }
            else
            { 
                Console.WriteLine($"Person with name {s3} does not exist in age list");
            }
        }


        public static void DisplayAllPersons()
        {
            // TODO 16: Iterate over personList and display each person's name.
            if (personAgeDictionary.Count > 0)
            { foreach (var person in personList)
                {
                    Console.WriteLine(person);
                }
                // TODO 17: Iterate over personAgeDictionary and display each person's name and age.
                foreach (var age in personAgeDictionary)
                {
                    Console.WriteLine(age);
                }
            }
            // TODO 18: Consider handling the case where the lists are empty by providing feedback to the user.
            else
            {
                Console.WriteLine("The list is empty");
            }
        }
    }
}