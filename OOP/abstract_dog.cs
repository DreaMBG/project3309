//Имплементирайте следните обекти: куче (Dog), жаба (Frog), котка (Cat), котенце (Kitten), котарак (Tomcat). 
//Всички те са животни (Animal). Животните се характеризират с възраст (age), име (name) и пол (gender). 
//Всяко животно издава звук (виртуален метод на Animal). 
//Направете масив от различни животни и за всяко изписвайте на конзолата името, възрастта и звука, който издава. 

// ================== ПОЯСНЕНИЕ ===================//
// Има добавен масив за изчисляване на различните животни
// Добавена е име, възраст и звука, който издава съответното животно.
// Имплементирани са всички животни.

using System;

abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public Animal(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public abstract void MakeSound();

    public override string ToString()
    {
        return $"{Name}, {Age} години, {Gender}";
    }
}

//================= Куче =================
class Dog : Animal
{
    public Dog(string name, int age, string gender) : base(name, age, gender) { }

    public override void MakeSound()
    {
        Console.WriteLine("Bau-bau!");
    }
}

//================= Жаба =================
class Frog : Animal
{
    public Frog(string name, int age, string gender) : base(name, age, gender) { }

    public override void MakeSound()
    {
        Console.WriteLine("Kva-kva!");
    }
}

//================= Котка ================
class Cat : Animal
{
    public Cat(string name, int age, string gender) : base(name, age, gender) { }

    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

//================= Котенце =============
class Kitten : Cat
{
    public Kitten(string name, int age) : base(name, age, "Женска") { } // котенцата по условие често са женски

    public override void MakeSound()
    {
        Console.WriteLine("Mew-mew!");
    }
}

//================= Котарак =============
class Tomcat : Cat
{
    public Tomcat(string name, int age) : base(name, age, "Мъжки") { } // котарак → мъжки

    public override void MakeSound()
    {
        Console.WriteLine("Mrrr-meow!");
    }
}

class Program
{
    static void Main()
    {
        Animal[] animals =
        {
            new Dog("Рекс", 4, "Mъжки"),
            new Frog("Зелчо", 1, "Мъжки"),
            new Cat("Мая", 3, "Женска"),
            new Kitten("Пухчо", 1),
            new Tomcat("Борис", 5)
        };

        foreach (var a in animals)
        {
            Console.WriteLine(a.ToString());
            a.MakeSound();
            Console.WriteLine();
        }
    }
}
