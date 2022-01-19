using CompositionEx.Entities;
using CompositionEx.Entities.Enums;

Console.Write("Enter department's name: ");
string departmentName = Console.ReadLine();
Console.WriteLine("Enter worker data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Level (Junior/Midlevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.Write("Base salary: ");
double bSalary = double.Parse(Console.ReadLine());

Department department = new Department(departmentName);   

Worker worker = new Worker(name, level, bSalary, department);

Console.Write("How many contractst to this worker? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Enter #" + (n + 1) + " contract data:");
    Console.Write("Date (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double value = double.Parse(Console.ReadLine());
    Console.Write("Duration (hours): ");
    int duration = int.Parse(Console.ReadLine());

    HourContract newContract = new HourContract(date, value, duration);

    worker.AddContract(newContract);
}
