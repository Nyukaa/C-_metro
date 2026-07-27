using System;
using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
 public static class Kuukausipalkat
{
    public static void Run(string[] args)
    
    {
        // Создаем список именно базового типа Employee (или SalaryEmployee, 
        // но по условию PayrollSystem принимает список сотрудников)
        List<Employee> tyontekijat = new List<Employee>();
        int currentId = 1;

        while (true)
        {
            // Обратите внимание на пробел после двоеточия
            Console.Write("Anna työntekijän nimi (0 lopetus): ");
            string nimiInput = Console.ReadLine();

            if (nimiInput == "0")
            {
                break;
            }

            Console.Write("Anna kuukausipalkka: ");
            int palkkaInput = int.Parse(Console.ReadLine());

            // Создаем объект дочернего класса и добавляем его в общий список сотрудников
            SalaryEmployee uusiTyontekija = new SalaryEmployee(currentId, nimiInput, palkkaInput);
            tyontekijat.Add(uusiTyontekija);

            currentId++;
        }

        // Передаем список сотрудников в систему расчета зарплат
        PayrollSystem payroll = new PayrollSystem();
        payroll.CalculatePayroll(tyontekijat);
    }
}

// 1. Базовый класс сотрудников (из предыдущих заданий)
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

// 2. Дочерний класс (наследуется от Employee)
public class SalaryEmployee : Employee
{
    public int MonthlySalary { get; set; }

    // Конструктор использует базовый конструктор через ': base'
    public SalaryEmployee(int id, string name, int monthlySalary) : base(id, name)
    {
        MonthlySalary = monthlySalary;
    }

    // Метод возвращает зарплату сотрудника
    public int CalculateSalary()
    {
        return MonthlySalary;
    }
}

// 3. Класс PayrollSystem для обработки ведомостей
public class PayrollSystem
{
    public void CalculatePayroll(List<Employee> lista)
    {
        foreach (var emp in lista)
        {
            // Приводим базовый объект Employee к типу SalaryEmployee, чтобы вызвать метод рассчета зарплаты
            if (emp is SalaryEmployee salaryEmp)
            {
                // Принудительно выводим пустую строку перед каждым расчетным листком для строгого теста
                Console.WriteLine();
                Console.WriteLine("Palkkalaskelma");
                Console.WriteLine("==============");
                Console.WriteLine($"Henkilölle: {salaryEmp.Id} - {salaryEmp.Name}");
                Console.WriteLine($"- Maksetaan: {salaryEmp.CalculateSalary()}");
            }
        }
    }
}
