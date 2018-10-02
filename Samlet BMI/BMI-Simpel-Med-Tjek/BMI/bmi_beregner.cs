using System;
using System.Windows.Forms;

namespace BMI
{
  public partial class bmi_beregner : Form
  {
    public bmi_beregner()
    {
      InitializeComponent();
    }

    private void udregn_Click(object sender, EventArgs e)
    {
      label_fejlbesked.Text = ""; //Fjern evt. tidligere fejlbesked
      double d_vaegt = 0; //Opretter lokal variable af typen string
      double d_hoejde = 0; //Opretter lokal variable af typen string

      bool vaegtParsedKorrekt = double.TryParse(vaegt.Text, out d_vaegt); //Prøver at parse _vaegt (string) til en lokal variable d_vaegt
      bool hoejdeParsedKorrekt = double.TryParse(hoejde.Text, out d_hoejde); //Prøvr at parse _hoejde (string) til en lokal variable d_hoejde

      if (vaegtParsedKorrekt == false || hoejdeParsedKorrekt == false) //Tjekker der er fejl i input værdierne
      {
        label_fejlbesked.Text = "Der er fejl i input-værdierne"; //Sætter fejltekst
        return; //Hvis den ikke er, stopper "programmet" her
      } 

      double mathResult = d_vaegt / Math.Pow(d_hoejde / 100, 2); //Udregner BMI pga. af formel vægt/(højde I meter)^2 - Math.Pow opløfter i x (I dette tilfælde 2)

      bmi_result.Text = Math.Round(mathResult, 2).ToString(); //Tager udregnede BMI og sætter det i vores User Interface (det vi ser)
                                                              //Math.Round afrunder til x decimaler (I dette tilfælde 2)
    }
  }
}
