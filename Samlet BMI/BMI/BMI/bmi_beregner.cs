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
      text_error.Text = ""; //Nulstil fejlbesked - Det giver mening hvis programmet køres igen
      ideal_vaegt.Text = ""; //Nulstil ideal vægt tekst - Det giver mening hvis programmet køres igen

      string _vaegt = vaegt.Text.Replace(',', '.'); //Sætter vægt som en lokal string og tager højde for indtastet , i stedet for .
      string _hoejde = hoejde.Text.Replace(',', '.'); //Sætter højde som en lokal string og tager højde for indtastet , i stedet for .

      bool vaegtParsedKorrekt = double.TryParse(_vaegt, out double d_vaegt); //Prøver at parse _vaegt (string) til en double
      bool hoejdeParsedKorrekt = double.TryParse(_hoejde, out double d_hoejde); //Prøvr at parse _hoejde (string) til en double

      if (vaegtParsedKorrekt == false && hoejdeParsedKorrekt == false) //Tjekker om begge værdier er forkerte
      {
        text_error.Text = "Fejl: Vægt og højde-værdierne er ikke valide"; //Hvis begge værdier er forkerte sættes fejlkoden til dette
      }
      else if (vaegtParsedKorrekt == true && hoejdeParsedKorrekt == false) //Tjekker om vægt er korrekt og højde forkert
      {
        text_error.Text = "Fejl: Højde-værdien er ikke valid"; //Hvis vægt er korrekt og højde er forkert sættes fejlkoden til dette
      }
      else if (vaegtParsedKorrekt == false && hoejdeParsedKorrekt == true) //Tjekker om højde er korrekt og vægt forkert
      {
        text_error.Text = "Fejl: Vægt-værdien er ikke valid"; //Hvis højde er korrekt og vægt er forkert sættes fejlkoden til dette
      }
      //else if gør at hvis en af de tidligere er "true" tjekkes de resterende ikke

      if (text_error.Text != "") //Tjekker om fejlteksten er tom
        return; //Hvis fejlteksten ikke er tom, så stopper "programmet" her

      if (d_hoejde == 0 || d_vaegt == 0) //Tjekker om nogen af værdierne er 0 - "||" betyder "eller", det vil sige at hvis nogen af dem er 0 er denne statement "true"
      {
        bmi_result.Text = "0"; //Hvis nogen af værdierne er 0 sættes resultatet til 0, fordi man ikke kan dividere med 0
        return; //Programmet stopper her
      }

      bmi_result.Text = Math.Round(d_vaegt / Math.Pow(d_hoejde / 100, 2), 2).ToString(); //Udregner BMI og sætter det i vores User Interface (det vi ser)
      //Math.Round afrunder til x decimaler (I dette tilfælde 2) - Math.Pow opløfter i x (I dette tilfælde 2)

      ideal_vaegt.Text = Math.Round(Math.Pow(d_hoejde / 100, 2) * 18.5, 2) + "-" + Math.Round(Math.Pow(d_hoejde / 100, 2) * 24.9, 2) + " kg"; //Udregner idealvægten for en given person og sætter det i vores User Interface
      //Eksempel på resultatet: 56,15 - 78,52 kg - 18.5 og 24.9 er konstanter taget fra BMI's anbefaling om idealvægten
    }
  }
}
