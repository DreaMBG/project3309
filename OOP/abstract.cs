// 1. Да се създаде абстрактен базов клас Figure, описващ фигура в 
//равнината. Класът да съдържа абстрактни методи за въвеждане и 
//извеждане стойностите на полетата и абстрактен метод за намиране 
//площта на фигурата. Да се създадат производни класове, описващи 
//квадрат, окръжност, ромб,  правоъгълник и триъгълник. Да се създаде 
//демонстрационна програма за работа с тези класове. 

//Упътване: Да се създаде програма, която пресмята лице на фигура, която е 
//изградена от множество различни фигури.

// ====================== ПОЯСНЕНИЕ ============================ //

// Програмата е направена да създава 5 различни произволни класа
// Позволява да се извеждат и други фируги без прекъсване
// Изчислява общата площ на всичките дадени фигури, които са регистрирани в програмата.
// Може да покаже всяка въведена фигура
// И най-вече програмата е направена да използва клас Figure

using System;
using System.Collections.Generic;

abstract class Figure
{
    public abstract void Input();        // Абстрактен метод за вход
    public abstract void Print();        // Абстрактен метод за принтиране
    public abstract double Area();       // Абстрактен метод за пресмятане на площта
}

//====================== К В А Д Р А Т ======================

class Square : Figure
{
    private double a;

    public override void Input()
    {
        Console.Write("Въведете страна на квадрата: ");
        a = double.Parse(Console.ReadLine());
    }

    public override void Print()
    {
        Console.WriteLine($"Квадрат със страна {a}, площ = {Area():F2}");
    }

    public override double Area() => a * a;
}

//====================== О К Р Ъ Ж Н О С Т ===================

class Circle : Figure
{
    private double r;

    public override void Input()
    {
        Console.Write("Въведете радиус на окръжността: ");
        r = double.Parse(Console.ReadLine());
    }

    public override void Print()
    {
        Console.WriteLine($"Окръжност с радиус {r}, площ = {Area():F2}");
    }

    public override double Area() => Math.PI * r * r;
}

//====================== Р О М Б =============================

class Rhombus : Figure
{
    private double d1, d2;

    public override void Input()
    {
        Console.Write("Въведете диагонал 1 на ромба: ");
        d1 = double.Parse(Console.ReadLine());
        Console.Write("Въведете диагонал 2 на ромба: ");
        d2 = double.Parse(Console.ReadLine());
    }

    public override void Print()
    {
        Console.WriteLine($"Ромб с диагонали {d1} и {d2}, площ = {Area():F2}");
    }

    public override double Area() => (d1 * d2) / 2.0;
}

//====================== П Р А В О Ъ Г Ъ Л Н И К ===============

class Rectangle : Figure
{
    private double a, b;

    public override void Input()
    {
        Console.Write("Въведете страна a на правоъгълника: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Въведете страна b на правоъгълника: ");
        b = double.Parse(Console.ReadLine());
    }

    public override void Print()
    {
        Console.WriteLine($"Правоъгълник {a} x {b}, площ = {Area():F2}");
    }

    public override double Area() => a * b;
}

//====================== Т Р И Ъ Г Ъ Л Н И К ==================

class Triangle : Figure
{
    private double a, h;

    public override void Input()
    {
        Console.Write("Въведете основа на триъгълника: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Въведете височина към основата: ");
        h = double.Parse(Console.ReadLine());
    }

    public override void Print()
    {
        Console.WriteLine($"Триъгълник с основа {a} и височина {h}, площ = {Area():F2}");
    }

    public override double Area() => (a * h) / 2.0;
}

// в класът Program се използва и SWITCH CASE функцията, която позволява да се
// разглеждат различни видове фигури. 


class Program
{
    static void Main()
    {
        List<Figure> figures = new List<Figure>();
        double totalArea = 0;

        while (true)
        {
            Console.WriteLine("\n=== Меню ===");
            Console.WriteLine("1. Квадрат");
            Console.WriteLine("2. Окръжност");
            Console.WriteLine("3. Ромб");
            Console.WriteLine("4. Правоъгълник");
            Console.WriteLine("5. Триъгълник");
            Console.WriteLine("6. Извеждане на всички фигури");
            Console.WriteLine("7. Обща площ");
            Console.WriteLine("0. Изход");
            Console.Write("Избор: ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 0) break;

            Figure f = null;

            switch (choice)
            {
                case 1: f = new Square(); break;
                case 2: f = new Circle(); break;
                case 3: f = new Rhombus(); break;
                case 4: f = new Rectangle(); break;
                case 5: f = new Triangle(); break;
                case 6:
                    foreach (var fig in figures) fig.Print();
                    continue;
                case 7:
                    totalArea = 0;
                    foreach (var fig in figures) totalArea += fig.Area(); // формула за пресмятане на площта на всички записани фигури в програмата.
                    Console.WriteLine($"Обща площ на всички фигури = {totalArea:F2}");
                    continue;
                default:
                    Console.WriteLine("Невалиден избор!");
                    continue;
            }

            f.Input();
            figures.Add(f);
            Console.WriteLine("Фигурата е добавена!"); // След като се дадът съотвените параметри се добавя фигурата към програмата и остава запаметена.
        }
    }
}
