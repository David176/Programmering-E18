using System;

namespace Test
{
  class Program
  {
    static void Main(string[] args)
    {
      //Testkode - Bruges til at teste vores klasse
      Person Anders = new Person(false, 15, "Anders", "anders@anders.dk", 15000); //Opretter instans af vores klasse - altså et objekt
      Person Nanna = new Person(true, 23, "Nanna", "Nanna@nanna.dk", -12000); //Opretter instans af vores klasse - altså et objekt
      Person LillePer = new Person(5, "LillePer"); //Opretter instans af vores klasse - altså et objekt

      Console.WriteLine("Hello, world!"); //Skriver noget ud i vores Console
      Console.WriteLine("Hello my name is " + Anders.Name); //Skriver noget ud i vores Console
      Console.WriteLine("I am " + Anders.Age + " years old"); //Skriver noget ud i vores Console
      Anders.HaveABirthday(); //Kalder metode
      Console.WriteLine("I am " + Anders.Age + " years old"); //Skriver noget ud i vores Console

      Console.WriteLine("I have this much money " + Anders.BankAccount); //Skriver noget ud i vores Console
      Anders.DepositCash(150000); //Kalder metode
      Console.WriteLine("Now I have this much money " + Anders.BankAccount); //Skriver noget ud i vores Console

      bool answer = Anders.IsPersonFemale(); // Kalder metode og sætter svaret (dvs. det der returneres i en lokal variable 'answer')
      Console.WriteLine(Anders.Name + " is a female: " + answer); // Bruges det svar vi fik fra IsPersonFemale metoden

      Console.WriteLine("Hi my name is " + Nanna.Name + " I am " + Nanna.Age + " years old"); //Skriver noget ud i vores Console

      Console.WriteLine();

    }
  }

  public class Person
  {
    //Properties
    public bool IsFemale { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public double BankAccount { get; set; }
    private double _secretAccount { get; set; }

    //Constructors
    public Person(bool isFemale, int age, string name, string email, double bankAccount)
    {
      IsFemale = isFemale;
      Age = age;
      Name = name;
      Email = email;
      BankAccount = bankAccount;
    }

    public Person(int age, string name)
    {
      Age = age;
      Name = name;
    }

    //Metoder
    public void HaveABirthday() //void er retur-type, dvs. ingenting
    {
      Age++;
      Console.WriteLine("Yay, I had a birthday");
    }

    public void DepositCash(double amount) //amount er noget vi får når metoden kaldes
    {
      BankAccount += amount;
      _secretAccount += amount * 0.1;
    }


    public bool IsPersonFemale() //bool er retur-type, dvs. den returnerer true eller false
    {
      return IsFemale;
    }
  }
}
