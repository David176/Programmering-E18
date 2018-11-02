using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrolstrukturer
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    // private int no1, no2, no3, no4;
    private int no1;
    private int no2;
    private int no3;
    private int no4;

    private void button_biggestNumber_Click(object sender, EventArgs e)
    {
      if (AllValuesAreValid() && AllValuesAreWithInScope())
      {
        int resultat = GetBiggestNumber();
        textBox_resultat.Text = resultat.ToString();
      }

      //  textBox_resultat.Text = GetBiggestNumber().ToString(); - Samme som ovenfor
    }

    private int GetBiggestNumber()
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

    private bool AllValuesAreWithInScope()
    {
      bool no1InScope = no1 > 0 && no1 < 13;
      bool no2InScope = no2 > 0 && no2 < 13;
      bool no3InScope = no3 > 0 && no3 < 13;
      bool no4InScope = no4 > 0 && no4 < 13;

      if (no1InScope && no2InScope && no3InScope && no4InScope)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    private bool AllValuesAreValid()
    {
      bool value1valid = int.TryParse(textBox_month1.Text, out no1);
      bool value2valid = int.TryParse(textbox_month2.Text, out no2);
      bool value3valid = int.TryParse(textBox_month3.Text, out no3);
      bool value4valid = int.TryParse(textBox_month4.Text, out no4);

      if (value1valid && value2valid && value3valid && value4valid)
      {
        return true;
      }

      return false;
    }
  }
}
