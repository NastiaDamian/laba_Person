using System;

class Person
{
    private string name;
    private DateTime birthYear;

    public string Name
    {
        get { return name; }
    }

    
    public DateTime BirthYear
    {
        get { return birthYear; }
    }

   
    public Person()
    {
    }

    public Person(string name, DateTime birthYear)
    {
        this.name = name;
        this.birthYear = birthYear;
    }

    
    public int Age()
    {
        DateTime currentDate = DateTime.Now;
        int age = currentDate.Year - birthYear.Year;

        
        if (currentDate < birthYear.AddYears(age))
        {
            age--;
        }

        return age;
    }

    
    public void Input()
    {
        Console.Write("Введіть ім'я: ");
        name = Console.ReadLine();

        Console.Write("Введіть рік народження: ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime year))
        {
            birthYear = year;
        }
        else
        {
            Console.WriteLine("Некоректний формат року.");
        }
    }

    
    public void ChangeName(string newName)
    {
        name = newName;
    }

    
    public override string ToString()
    {
        return $"Ім'я: {name}, Рік народження: {birthYear.Year}";
    }

    
    public void Output()
    {
        Console.WriteLine(ToString());
    }

   
    public static bool operator ==(Person person1, Person person2)
    {
        return person1.name == person2.name;
    }

   
    public static bool operator !=(Person person1, Person person2)
    {
        return !(person1 == person2);
    }
}

class Program
{
    static void Main()
    {
        
        Person person1 = new Person();
        Person person2 = new Person("Ім'я2", new DateTime(1990, 5, 15));
        Person person3 = new Person();

        
        person1.Input();
        person2.Input();
        person3.Input();

       
        Console.WriteLine($"Ім'я: {person1.Name}, Вік: {person1.Age()}");
        Console.WriteLine($"Ім'я: {person2.Name}, Вік: {person2.Age()}");
        Console.WriteLine($"Ім'я: {person3.Name}, Вік: {person3.Age()}");

       
        if (person1.Age() < 16)
        {
            person1.ChangeName("Very Young");
        }

        if (person2.Age() < 16)
        {
            person2.ChangeName("Very Young");
        }

        if (person3.Age() < 16)
        {
            person3.ChangeName("Very Young");
        }

        
        Console.WriteLine("Інформація про особи:");
        person1.Output();
        person2.Output();
        person3.Output();

        
        if (person1 == person2)
        {
            Console.WriteLine($"Особа 1 і Особа 2 мають однакові імена: {person1.Name}");
        }

        if (person1 == person3)
        {
            Console.WriteLine($"Особа 1 і Особа 3 мають однакові імена: {person1.Name}");
        }
    }
}




