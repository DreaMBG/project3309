// 2.Да се създаде абстрактен клас Vehicle, описващ превозно средство. 
//Класът да съдържа полета за обем на двигател и максимална скорост. В 
//класа да е включен конструктор, който инициализира стойностите на 
//полетата и абстрактен метод Info(), който да дава информация за 
//превозното средство. Да се декларират производни класове Car, Truck, 
//Bus, описващи лек автомобил, камион и автобус. Класове Car и Bus да 
//съдържат полета за броя на местата, клас Truck – полета за размери и 
//тегло. Всеки един от класовете да има необходимите конструктори. Да се 
//създаде демонстрационна програма, с която се имитира работа с 
//автомобилен парк от различни превозни средства. 

// =============== ПОЯСНЕНИЕ ================ //
// Програмата може да създава и управлява един автопарк.
// Може да добавя автомобили, автобуси и камиони
// Може да показва информация за всички видове превозни средства през метода Info()

using System;
using System.Collections.Generic;

//====================== АБСТРАКТЕН КЛАС ======================

abstract class Vehicle
{
    protected double engineVolume;   // Метод за обема на двигателя (кубатура)
    protected int maxSpeed;          // Метод за максималната скорост на даденият автомобил

    public Vehicle(double engineVolume, int maxSpeed)
    {
        this.engineVolume = engineVolume;
        this.maxSpeed = maxSpeed;
    }

    public abstract void Info();  // метод за информация на автопарка
}

//====================== ЛЕК АВТОМОБИЛ =========================

class Car : Vehicle
{
    private int seats; // добавяне на метод за броят места в автомобила

    public Car(double engineVolume, int maxSpeed, int seats)
        : base(engineVolume, maxSpeed)
    {
        this.seats = seats;
    }

    public override void Info()
    {
        Console.WriteLine($"Лек автомобил: двигател {engineVolume} L, " +
                          $"макс. скорост {maxSpeed} km/h, места {seats}");
    }
}

//====================== АВТОБУС ===============================

class Bus : Vehicle
{
    private int seats; // добавяне на метод за броят места в автобуса

    public Bus(double engineVolume, int maxSpeed, int seats)
        : base(engineVolume, maxSpeed)
    {
        this.seats = seats;
    }

    public override void Info()
    {
        Console.WriteLine($"Автобус: двигател {engineVolume} L, " +
                          $"макс. скорост {maxSpeed} km/h, места {seats}");
    }
}

//====================== КАМИОН ================================

class Truck : Vehicle
{
    private double length, width, height;  // размерите на камионът
    private double weight;                 // колко е товароносимостта на камиона

    public Truck(double engineVolume, int maxSpeed,
                 double length, double width, double height, double weight)
        : base(engineVolume, maxSpeed)
    {
        this.length = length;
        this.width = width;
        this.height = height;
        this.weight = weight;
    }

    public override void Info()
    {
        Console.WriteLine($"Камион: двигател {engineVolume} L, " +
                          $"макс. скорост {maxSpeed} km/h,\n" +
                          $"Размери: {length} x {width} x {height} m, товар {weight} t");
    }
}

// Тук отново се използва SWITCH CASE функцията за добавянето на различните автомобили в автопарка

class Program
{
    static void Main()
    {
        List<Vehicle> park = new List<Vehicle>();

        // Добавяме няколко превозни средства
        park.Add(new Car(1.6, 210, 5));
        park.Add(new Bus(4.0, 140, 50));
        park.Add(new Truck(5.5, 120, 6, 2.5, 3, 18));

        int choice;

        while (true)
        {
            Console.WriteLine("\n=== Автомобилен парк ===");
            Console.WriteLine("1. Добави Лек автомобил");
            Console.WriteLine("2. Добави Автобус");
            Console.WriteLine("3. Добави Камион");
            Console.WriteLine("4. Покажи всички превозни средства");
            Console.WriteLine("0. Изход");
            Console.Write("Избор: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 0) break;

            switch (choice)
            {
                case 1:
                    {
                        Console.Write("Обем двигател: ");
                        double ev = double.Parse(Console.ReadLine());
                        Console.Write("Макс. скорост: ");
                        int sp = int.Parse(Console.ReadLine());
                        Console.Write("Места: ");
                        int st = int.Parse(Console.ReadLine());
                        park.Add(new Car(ev, sp, st));
                        Console.WriteLine("Добавен е лек автомобил.");
                        break;
                    }
                case 2:
                    {
                        Console.Write("Обем двигател: ");
                        double ev = double.Parse(Console.ReadLine());
                        Console.Write("Макс. скорост: ");
                        int sp = int.Parse(Console.ReadLine());
                        Console.Write("Места: ");
                        int st = int.Parse(Console.ReadLine());
                        park.Add(new Bus(ev, sp, st));
                        Console.WriteLine("Добавен е автобус.");
                        break;
                    }
                case 3:
                    {
                        Console.Write("Обем двигател: ");
                        double ev = double.Parse(Console.ReadLine());
                        Console.Write("Макс. скорост: ");
                        int sp = int.Parse(Console.ReadLine());
                        Console.Write("Дължина: ");
                        double l = double.Parse(Console.ReadLine());
                        Console.Write("Ширина: ");
                        double w = double.Parse(Console.ReadLine());
                        Console.Write("Височина: ");
                        double h = double.Parse(Console.ReadLine());
                        Console.Write("Товар (тон): ");
                        double wt = double.Parse(Console.ReadLine());
                        park.Add(new Truck(ev, sp, l, w, h, wt));
                        Console.WriteLine("Добавен е камион.");
                        break;
                    }
                case 4:
                    Console.WriteLine("\n--- Автопарк ---");
                    foreach (var v in park) v.Info();
                    break;

                default:
                    Console.WriteLine("Невалиден избор!");
                    break;
            }
        }
    }
}
