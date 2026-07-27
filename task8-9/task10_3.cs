using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1. Initialize a list to store Employee object structures
        List<Employee> tyontekijat = new List<Employee>();
        int currentId = 1;

        // 2. Loop continuously to ingest data until '0' is processed
        while (true)
        {
            // Note: No trailing space after the last colon to respect the strict tester rule
            Console.Write("Anna työntekijän nimi: (0 lopetus):");
            string nimiInput = Console.ReadLine();

            // Exit rule condition check
            if (nimiInput == "0")
            {
                break;
            }

            // Instantiating the object and passing the incrementing identifier 
            Employee uusiTyontekija = new Employee(currentId, nimiInput);
            tyontekijat.Add(uusiTyontekija);

            currentId++; // Safe tracking incrementation logic
        }

        // 3. Final display list generation iteration logic
        foreach (var emp in tyontekijat)
        {
            Console.WriteLine($"Id: {emp.Id} Nimi: {emp.Name}");
        }
    }
}

// 4. Custom Class Model implementation 
public class Employee
{
    // Auto-implemented public properties requested by the task framework
    public int Id { get; set; }
    public string Name { get; set; }

    // Initialization Constructor Method setup
    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
