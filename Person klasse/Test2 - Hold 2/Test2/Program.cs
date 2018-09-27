using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
  class Program
  {
    static void Main(string[] args)
    { //Testkode - Bruges til at teste vores klasse
      Person David = new Person("David", 25, false, 1500, true); //Opretter instans af vores klasse - altså et objekt
      Person Sara = new Person("Sara", 27, true, 2000000, true); //Opretter instans af vores klasse - altså et objekt
      David.DepositMoney(15000000); //Kalder metode
      David.Kill(); //Kalder metode
      Person BabyAnders = new Person("Baby Anders", 0, false, true);  //Opretter instans af vores klasse - altså et objekt

      Console.WriteLine("My name is " + David.Name); //Skriver noget ud i vores Console
      David.Name = "JohnJohn"; //Sætter Name på David objektet
      Console.WriteLine("My name is " + David.Name);  //Skriver noget ud i vores Console
      Console.WriteLine("Age: " + David.Age);  //Skriver noget ud i vores Console
      David.Age++; //Increaser Age med 1
      Console.WriteLine("Age: " + David.Age);  //Skriver noget ud i vores Console

      bool answer = David.IsPersonAlive(); // Kalder metode og sætter svaret (dvs. det der returneres i en lokal variable 'answer')
      Console.WriteLine(David.Name + " is a alive: " + answer); // Bruges det svar vi fik fra IsPersonAlive metoden

      Console.WriteLine();

    }
  }

  public class Person
  {
    //Properties
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsFemale { get; set; }
    public double Account { get; set; }
    public bool IsAlive { get; set; }
    public bool IsBaby { get; set; }
    private string _secretName { get; set; }

    //Construtor
    public Person(string name, int age, bool isFemale, double account, bool isAlive)
    {
      Name = name;
      Age = age;
      IsFemale = isFemale;
      Account = account;
      IsAlive = isAlive;
    }

    public Person(string name, int age, bool isFemale, bool isAlive) //If no account given it is a baby
    {
      Name = name;
      Age = age;
      IsFemale = isFemale;
      IsAlive = isAlive;
      IsBaby = true;
    }

    //Metoder
    public void Kill() //void er retur-type, dvs. ingenting
    {
      IsAlive = false;
    }

    public bool IsPersonAlive() //bool er retur-type, dvs. den returnerer true eller false
    {
      return IsAlive;
    }

    public void DepositMoney(double amount) //amount er noget vi får når metoden kaldes
    {
      Account += amount;
    }
  }


}
