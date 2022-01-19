using CompositionEx.Entities;
using CompositionEx.Entities.Enums;
using System.Globalization;

Console.Write("Enter department's name: ");
string departmentName = Console.ReadLine();
Console.WriteLine("Enter worker data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Level (Junior/Midlevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.Write("Base salary: ");
double bSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Department department = new Department(departmentName);   

Worker worker = new Worker(name, level, bSalary, department);
Console.WriteLine();
Console.Write("How many contracts to this worker? ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Enter #" + (i + 1) + " contract data:");
    Console.Write("Date (DD/MM/YYYY): ");
    DateTime localDate = DateTime.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Duration (hours): ");
    int duration = int.Parse(Console.ReadLine());

    HourContract newContract = new HourContract(localDate, value, duration);

    worker.AddContract(newContract);
    Console.WriteLine();
}

Console.WriteLine();
Console.Write("Enter month and year to calculate income (MM/YYYY): ");
DateTime date = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Name: " + worker.Name);
Console.WriteLine("Department: " + worker.Department.Name);
Console.WriteLine("Income for " + date.Month + "/" + date.Year + ": " + worker.Income(date.Year, date.Month).ToString("F2", CultureInfo.InvariantCulture));
