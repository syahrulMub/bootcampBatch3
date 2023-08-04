using JSONSerialize;
using System.Text.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.DataContracts;

class Program
{
    static void Main()
    {
        List<Person> myList = new List<Person>()
        {
            new Person("syahrul", 20, Gender.male, Job.chef),
            new Person("mubarok", 19, Gender.female)
        };

        var user = new DataContractJsonSerializer(typeof(List<Person>));
        // using (FileStream stream = new FileStream("Person.json", FileMode.OpenOrCreate))
        // {
        //     user.WriteObject(stream, myList);
        // }

        List<Person> inputPerson;
        using (FileStream stream2 = new FileStream("Person.json", FileMode.OpenOrCreate))
        {
            inputPerson = (List<Person>)user?.ReadObject(stream2);
        }

        foreach (var person in inputPerson)
        {
            Console.WriteLine($"Name:\t{person.name}\nAge:\t{person.age}\nGender:\t{person.gender}\nJob:\t{person.job}");
        }

    }
} 