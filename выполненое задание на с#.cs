using System;

interface IInput
{
    void InputData();
}

interface IOutput
{
    void ShowData();
}

class Project
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
   // public string Manager { get; set; }
}

class Task : Project, IInput, IOutput
{
    public int Duration { get; set; }
    public string Status { get; set; }

    public void InputData()
    {
        Console.WriteLine("Напиши имя задачи: ");
        Name = Console.ReadLine();
        Console.WriteLine("Напиши дату начала задачи (yyyy-mm-dd): ");
        StartDate = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        Console.WriteLine("Напиши дату окончания задачи (yyyy-mm-dd): ");
        EndDate = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        Console.WriteLine("Напиши продолжительность задачи в днях: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("напиши статус задачи: ");
        Status = Console.ReadLine();
    }

    public void ShowData()
    {
        Console.WriteLine("Имя задачи: " + Name);
        Console.WriteLine("Дата старта задачи: " + StartDate.ToString("yyyy-MM-dd"));
        Console.WriteLine("Дата окончания задачи: " + EndDate.ToString("yyyy-MM-dd"));
        Console.WriteLine("Продолжительность задачи: " + Duration + " дней");
        Console.WriteLine("Статус задачи: " + Status);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Task task = new Task();
        task.InputData();
        task.ShowData();

        Console.ReadKey();
    }
}