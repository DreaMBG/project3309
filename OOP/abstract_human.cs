//Дефинирайте клас Human със свойства "собствено име" и "фамилно име". 
//Дефинирайте клас Student, наследяващ Human, който има свойство "оценка". Дефинирайте клас Worker, наследяващ Human, 
//със свойства "надница" и "изработени часове". Имплементирайте и метод "изчисли надница за 1 час", 
//който смята колко получава работникът за 1 час работа, на базата на надницата и изработените часове.  

//=================== ПОЯСНЕНИЕ ===================//
// Програмата използва функцията "наследяване".
// Има добавени свойства за Student и Worker
// Има добавен метод за изчисляване на заплащането на час

using System;

class Human
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Human(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

// ====================== Student ======================

class Student : Human
{
    public double Grade { get; set; }

    public Student(string firstName, string lastName, double grade)
        : base(firstName, lastName)
    {
        Grade = grade;
    }
}

// ====================== Worker =======================

class Worker : Human
{
    public double Salary { get; set; }         // надница (обща)
    public int WorkedHours { get; set; }       // изработени часове

    public Worker(string firstName, string lastName, double salary, int hours)
        : base(firstName, lastName)
    {
        Salary = salary;
        WorkedHours = hours;
    }

    public double SalaryPerHour()
    {
        return Salary / WorkedHours;
    }
}

class Program
{
    static void Main()
    {
    
        // Добавени са примерни студенти и работници  
        Student st = new Student("Иван", "Тодоров", 5.50);
        Console.WriteLine($"Студент: {st.FirstName} {st.LastName}, Оценка: {st.Grade}");

        Worker w = new Worker("Мария", "Георгиева", 1200, 160);
        Console.WriteLine($"Работник: {w.FirstName} {w.LastName}");
        Console.WriteLine($"Надница общо: {w.Salary} лв");
        Console.WriteLine($"Пари за час: {w.SalaryPerHour():F2} лв/ч");
    }
}
