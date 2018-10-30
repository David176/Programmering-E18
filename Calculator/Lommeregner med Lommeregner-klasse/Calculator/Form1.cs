using System;
using System.Windows.Forms;

namespace Calculator
{
  public partial class Form1 : Form
  {
    private double _tal1;
    private double _tal2;
    private bool _numbersAreValid = false;
    private string invalidValuesMessage = "Invalid values";

    public Form1()
    {
      InitializeComponent();

      UpdateUIAccess(); //Automatisk tjek

      textBox_tal_1.TextChanged += (sender, args) => { _numbersAreValid = areValuesValid(); UpdateUIAccess(); }; //Automatisk tjek
      textBox_tal_2.TextChanged += (sender, args) => { _numbersAreValid = areValuesValid(); UpdateUIAccess(); }; //Automatisk tjek
    }

    public void UpdateUIAccess() //Automatisk tjek
    {
      button_plus.Enabled = _numbersAreValid;
      button_minus.Enabled = _numbersAreValid;
      button_multiply.Enabled = _numbersAreValid;
      button_divide.Enabled = _numbersAreValid && _tal2 != 0;
      button_percentage.Enabled = _numbersAreValid && _tal2 != 0;

      if (textBox_tal_1.Text != "" || textBox_tal_2.Text != "")
        button_clear.Enabled = true;
      else
        button_clear.Enabled = false;
    }

    private bool areValuesValid() //Metode til at tjekke at begge tal, jeg laver tjekket i en metode fordi det bruges flere steder
    {
      bool isTal1Valid = double.TryParse(textBox_tal_1.Text, out _tal1); //prøver at parse textBox_tal_1 tallet og sætter isTal1Valid til true hvis det lykkes og sætter _tal1 til tallet (hvis det lykkes)
      bool isTal2Valid = double.TryParse(textBox_tal_2.Text, out _tal2);//prøver at parse textBox_tal_2 tallet og sætter isTal1Valid til true hvis det lykkes og sætter _tal2 til tallet (hvis det lykkes)

      if (isTal2Valid == true && isTal1Valid == true) //Hvis begge tal er valide returneres true
      {
        textBox_result.Text = ""; //Fjerner evt. fejlbesked
        return true;
      }

      textBox_result.Text = invalidValuesMessage; //Sætter fejlbesked hvis data er ikke er korrekt
      return false; //Hvis ét eller begge tal ikke er valide returneres false
    }

    private void button_plus_Click(object sender, EventArgs e)
    {
      if (areValuesValid() == true) //Bruger "tjek"-metoden og hvis metoden returnerer true er begge tal valide og kan regnes med, derfor regner vi med den - Dette tjek er ikke nødvendigt her hvis værdierne tjekkes inden man kan trykke på knappen, altså Automatisk tjek
      {
        textBox_result.Text = BasicCalculator.Add(_tal1, _tal2).ToString(); //De to tal vi har parsed bruges til at regne med og resultatet sættes i textBox_result
      }
      else
        textBox_result.Text = invalidValuesMessage; //Hvis nogle af de to tal ikke er valide sættes en fejlbesked i textBox_result
    }

    private void button_minus_Click(object sender, EventArgs e)
    {
      if (areValuesValid() == true)
      {
        textBox_result.Text = BasicCalculator.Subtract(_tal1, _tal2).ToString();
      }
      else
        textBox_result.Text = invalidValuesMessage;
    }

    private void button_multiply_Click(object sender, EventArgs e)
    {
      if (areValuesValid() == true)
      {
        textBox_result.Text = BasicCalculator.Multiply(_tal1, _tal2).ToString();
      }
      else
        textBox_result.Text = invalidValuesMessage;
    }

    private void button_divide_Click(object sender, EventArgs e)
    {
      if (areValuesValid() == true && _tal2 != 0) // Samme tjek som de andre, plus tjek om _tal2 er 0, fordi hvis den er det kan vi ikke regne med det fordi man ikke må dividere med 0
      {
        textBox_result.Text = BasicCalculator.Divide(_tal1, _tal2).ToString();
      }
      else
        textBox_result.Text = invalidValuesMessage;
    }

    private void button_clear_Click(object sender, EventArgs e)
    {
      textBox_tal_1.Text = "";
      textBox_tal_2.Text = "";
      textBox_result.Text = "";
    }

    private void button_percentage_Click(object sender, EventArgs e)
    {
      if (areValuesValid() == true && _tal2 != 0) // Samme tjek som de andre, plus tjek om _tal2 er 0, fordi hvis den er det kan vi ikke regne med det fordi man ikke må dividere med 0
      {
        textBox_result.Text = BasicCalculator.Percentage(_tal1, _tal2).ToString();
      }
      else
        textBox_result.Text = invalidValuesMessage;
    }
  }
}
