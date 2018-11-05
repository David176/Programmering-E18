using System;
using System.Windows.Forms;

namespace Kontrolstrukturer
{
  public partial class Form1 : Form
  {
    private int no1, no2, no3, no4;
    private string errorText = "Month values invalid";

    public Form1()
    {
      InitializeComponent();
    }

    //HJÆLPEMETODER

    private bool AllValuesAreWithInScope() //Tjekker om de parsed/konverterede tal er mellem 1 og 12 - Returnerer true hvis alle er
    {
      bool no1InScope = no1 > 0 && no1 < 13;
      bool no2InScope = no2 > 0 && no2 < 13;
      bool no3InScope = no3 > 0 && no3 < 13;
      bool no4InScope = no4 > 0 && no4 < 13;

      if (no1InScope && no2InScope && no3InScope && no4InScope)
      {
        return true;
      }

      return false;
    }

    private bool AllValuesAreValid() //Prøver at parse/konvertere de fire talværdier indtastet og gemmer talværdierne i no1, no2, no3 og no4 hvis det lykkes og returnerer true
    {
      bool value1valid = int.TryParse(textBox_no1.Text, out no1);
      bool value2valid = int.TryParse(textBox_no2.Text, out no2);
      bool value3valid = int.TryParse(textBox_no3.Text, out no3);
      bool value4valid = int.TryParse(textBox_no4.Text, out no4);

      if (value1valid && value2valid && value3valid && value4valid)
      {
        return true;
      }

      return false;
    }
    
    private int GetBiggestValue() //Finder og returnerer den største værdi af de fire talværdier
    {
      int biggest = 1;

      if (no1 > biggest)
        biggest = no1;

      if (no2 > biggest)
        biggest = no2;

      if (no3 > biggest)
        biggest = no3;

      if (no4 > biggest)
        biggest = no4;

      return biggest;
    }

    private int GetSmallestValue()  //Finder og returnerer den mindste værdi af de fire talværdier
    {
      int smallest = 12;

      if (no1 < smallest)
        smallest = no1;

      if (no2 < smallest)
        smallest = no2;

      if (no3 < smallest)
        smallest = no3;

      if (no4 < smallest)
        smallest = no4;

      return smallest;
    }

    private string NumberToName(string monthNumber) //Konverterer indtastede tal mellem 1 og 12 til måneder og returnerer tilsvarende månedsnavn
    {
      switch (monthNumber)
      {
        case "1":
          return "January";
        case "2":
          return "February";
        case "3":
          return "March";
        case "4":
          return "April";
        case "5":
          return "May";
        case "6":
          return "June";
        case "7":
          return "July";
        case "8":
          return "August";
        case "9":
          return "September";
        case "10":
          return "October";
        case "11":
          return "November";
        case "12":
          return "December";
        default:
          return "Invalid value"; //Metoden håndterer fejlindtastninger ved at returnere denne ved forkert indtastet værdi
      }
    }

    private string MonthToNumber(string monthName) //Konverterer indtastede måned til tilsvarende månedsnummer mellem 1 og 12 og returnerer dette
    {
      switch (monthName)
      {
        case "January":
          return "1";
        case "February":
          return "2";
        case "March":
          return "3";
        case "April":
          return "4";
        case "May":
          return "5";
        case "June":
          return "6";
        case "July":
          return "7";
        case "August":
          return "8";
        case "September":
          return "9";
        case "October":
          return "10";
        case "November":
          return "11";
        case "December":
          return "12";
        default:
          return "Invalid value"; //Metoden håndterer fejlindtastninger ved at returnere denne ved forkert indtastet værdi
      }
    }

    //KNAPPER

    private void button_number_to_month_Click(object sender, EventArgs e)
    {
      textBox_no1.Text = NumberToName(textBox_no1.Text); //Kalder metoden NumberToName med indtastede månedsnummer og returnerer tilsvarende månedsnavn og sætter textbox'en i GUI'en med resultatet - Tager højde for fejlindtastning
      textBox_no2.Text = NumberToName(textBox_no2.Text);
      textBox_no3.Text = NumberToName(textBox_no3.Text);
      textBox_no4.Text = NumberToName(textBox_no4.Text);
    }

    private void button_month_to_number_Click(object sender, EventArgs e)
    {
      textBox_no1.Text = MonthToNumber(textBox_no1.Text);  //Kalder metoden MonthToNumber med indtastede månedsnavn og returnerer tilsvarende månedsnummer og sætter textbox'en i GUI'en med resultatet - Tager højde for fejlindtastning
      textBox_no2.Text = MonthToNumber(textBox_no2.Text);
      textBox_no3.Text = MonthToNumber(textBox_no3.Text);
      textBox_no4.Text = MonthToNumber(textBox_no4.Text);
    }

    private void button_previous_months_Click(object sender, EventArgs e)
    {
      label_prevouis_months.Text = ""; //Fjerner evt. tidligere resultat
      int biggestNumber; //Erklærer lokal variabel

      if (AllValuesAreValid() && AllValuesAreWithInScope()) //Tjekker at indtastede værdier er tal og mellem 1 og 12
        biggestNumber = GetBiggestValue(); //Hvis ovenstående tjek er "true" hentes største tal
      else
      {
        label_prevouis_months.Text = errorText; //Hvis ovenstående tjek er "false" sættes fejlbesked
        return; //Stopper her
      }

      for (int i = biggestNumber-1; i >= 1; i--) //Starter ved største indtastede måned og tæller ned til 1 (January)
      {
        if (label_prevouis_months.Text != "") //Tjekker om label ikke er tomt
          label_prevouis_months.Text += " - "; //Hvis den ikke er tom indsættes en seperator så resultatet ser sådan uden: 'December - November' og ikke: ' - December - November'

        label_prevouis_months.Text += NumberToName(i.ToString()); //Indsætter månedsnavn på baggrund af månedsnummer (i)
      }
    }

    private void button_remaining_months_Click(object sender, EventArgs e)
    {
      label_remaining_months.Text = ""; //Fjerner evt. tidligere resultat
      int smallestNumber; //Erklærer lokal variabel

      if (AllValuesAreValid() && AllValuesAreWithInScope()) //Tjekker at indtastede værdier er tal og mellem 1 og 12
        smallestNumber = GetSmallestValue(); //Hvis ovenstående tjek er "true" hentes mindste tal
      else
      {
        label_remaining_months.Text = errorText;//Hvis ovenstående tjek er "false" sættes fejlbesked
        return; //Stopper her
      }

      for (int i = smallestNumber+1; i <= 12; i++) //Starter ved mindste indtastede måned og tæller op til 12 (december)
      {
        if (label_remaining_months.Text != "") //Tjekker om label ikke er tomt
          label_remaining_months.Text += " - ";//Hvis den ikke er tom indsættes en seperator så resultatet ser sådan uden: 'January - February' og ikke: ' - January - February'

        label_remaining_months.Text += NumberToName(i.ToString());  //Indsætter månedsnavn på baggrund af månedsnummer (i)
      }
    }

    private void button_biggest_Click(object sender, EventArgs e)
    {
      if (AllValuesAreValid() && AllValuesAreWithInScope()) //Tjekker at indtastede værdier er tal og mellem 1 og 12
        textBox_biggest.Text = GetBiggestValue().ToString(); //Skriver største tal
      else
        textBox_biggest.Text = errorText; //Skriver fejlbesked
    }

    private void button_smallest_Click(object sender, EventArgs e)
    {
      if (AllValuesAreValid() && AllValuesAreWithInScope()) //Tjekker at indtastede værdier er tal og mellem 1 og 12
        textBox_smallest.Text = GetSmallestValue().ToString(); //Skriver mindste tal
      else
        textBox_smallest.Text = errorText; //Skriver fejlbesked
    }
  }
}
