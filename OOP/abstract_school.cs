//Нека е дадено едно училище. В училището име класове от ученици. Всеки клас има множество от учители. 
//Всеки учител преподава множество от предмети. Учениците имат име и уникален номер в класа. 
//Класовете имат уникален текстов идентификатор. Учителите имат име. Предметите имат име, брой на часове и брой упражнения. 
//Както учителите, така и студентите са хора.  

//================ ПОЯСНЕНИЕ ==================//
// Програмата използва абстрактен клас Person
// Въвеждат се множеството от учитилите и техните предмети
// Въвеждат се дадените ученици с техните номера
// Въвеждат се имената, предметитие и броят часове

using System;
using System.Collections.Generic;

//================= АБСТРАКТЕН КЛАС ЧОВЕК =====================

abstract class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public abstract void Info();
}

//================= У Ч Е Н И К ===============================

class Student : Person
{
    public int StudentID { get; set; }

    public Student(string name, int id) : base(name)
    {
        StudentID = id;
    }

    public override void Info()
    {
        Console.WriteLine($"Ученик: {Name}, № {StudentID}");
    }
}

//================= П Р Е Д М Е Т ===============================

class Subject
{
    public string Name { get; set; }
    public int Hours { get; set; }
    public int Exercises { get; set; }

    public Subject(string name, int hours, int exercises)
    {
        Name = name;
        Hours = hours;
        Exercises = exercises;
    }

    public override string ToString()
    {
        return $"{Name} — часове: {Hours}, упражнения: {Exercises}";
    }
}

//================= У Ч И Т Е Л ================================

class Teacher : Person
{
    public List<Subject> Subjects { get; set; } = new List<Subject>();

    public Teacher(string name) : base(name) { }

    public void AddSubject(Subject subject) => Subjects.Add(subject);

    public override void Info()
    {
        Console.WriteLine($"Учител: {Name}");
        Console.WriteLine("  Преподава:");
        foreach (var subj in Subjects)
            Console.WriteLine("   → " + subj);
    }
}

//================= К Л А С  В  У Ч И Л И Щ Е ==================

class SchoolClass
{
    public string ClassID { get; set; }
    public List<Student> Students = new List<Student>();
    public List<Teacher> Teachers = new List<Teacher>();

    public SchoolClass(string id)
    {
        ClassID = id;
    }

    public void AddStudent(Student st) => Students.Add(st);
    public void AddTeacher(Teacher t) => Teachers.Add(t);

    public void Info()
    {
        Console.WriteLine($"\nКлас: {ClassID}");
        Console.WriteLine(" Ученици:");
        foreach (var s in Students)
            Console.WriteLine("  → " + s.Name + $" (№{s.StudentID})");

        Console.WriteLine(" Учители:");
        foreach (var t in Teachers)
        {
            Console.WriteLine(" ── " + t.Name);
            foreach (var subj in t.Subjects)
                Console.WriteLine("      * " + subj.ToString());
        }
    }
}

//================= У Ч И Л И Щ Е ==============================

class School
{
    public List<SchoolClass> Classes = new List<SchoolClass>();

    public void AddClass(SchoolClass sc) => Classes.Add(sc);

    public void ShowInfo()
    {
        Console.WriteLine("\n======= УЧИЛИЩЕТО =======");
        foreach (var c in Classes)
            c.Info();
    }
}

class Program
{
    static void Main()
    {
        School school = new School();

        SchoolClass classA = new SchoolClass("11A");
        classA.AddStudent(new Student("Иван Петров", 1));
        classA.AddStudent(new Student("Мария Иванова", 2));

        Teacher t1 = new Teacher("Георги Георгиев");
        t1.AddSubject(new Subject("Математика", 5, 3));
        t1.AddSubject(new Subject("Информатика", 4, 5));

        Teacher t2 = new Teacher("Елена Стоянова");
        t2.AddSubject(new Subject("Български език", 4, 2));

        classA.AddTeacher(t1);
        classA.AddTeacher(t2);

        school.AddClass(classA);

        // Показване на цялото училище
        school.ShowInfo();

        Console.ReadLine();
    }
}
