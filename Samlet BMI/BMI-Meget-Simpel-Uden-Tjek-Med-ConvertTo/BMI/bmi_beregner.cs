using System;
using System.Text;
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
      //Meget simpel one-liner - Her laves ingen tjek og ingen feedback gives til brugeren
      bmi_result.Text = Math.Round(Convert.ToDouble(vaegt.Text) / Math.Pow(Convert.ToDouble(hoejde.Text) / 100, 2), 2).ToString();
    }
  }
}
