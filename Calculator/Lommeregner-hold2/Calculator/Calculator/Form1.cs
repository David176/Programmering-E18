using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
  public partial class Form1 : Form
  {
    private double number1 = 0;
    private double number2 = 0;
    private BasicCalculator _basicCalculator = new BasicCalculator();
    private AcademicCalculator _academicCalculator = new AcademicCalculator();

    public Form1()
    {
      InitializeComponent();
    }

    private bool BothValuesAreValid()
    {
      number1 = 0;
      number2 = 0;

      bool number1Succes = double.TryParse(textBox_number1.Text, out number1);
      bool number2Succes = double.TryParse(textBox2_number2.Text, out number2);

      if (number1Succes == true && number2Succes == true)
      {
        return true;
      }
      else
      {
        textBox_result.Text = "Fejl i inputværdier";
        return false;
      }
    }

    private void button_clear_Click(object sender, EventArgs e)
    {
      textBox_result.Clear();
      textBox_number1.Text = "";
      textBox2_number2.Text = "";
    }

    private void button_add_Click(object sender, EventArgs e)
    {
      if (BothValuesAreValid() == true)
      {
        double result = _basicCalculator.Add(number1, number2);
        double result2 = _academicCalculator.Average(number1, number2);
        textBox_result.Text = result.ToString();
      }
    }

    private void button_divide_Click(object sender, EventArgs e)
    {
      if (BothValuesAreValid() == true)
      {
        double result = number1 / number2;
        textBox_result.Text = result.ToString();
      }
    }

    private void button_percentage_Click(object sender, EventArgs e)
    {
      if (BothValuesAreValid() == true && number2 != 0)
      {
        double result = (number1 / number2) * 100;
        textBox_result.Text = result + " %";
      }
    }

    private void button_minus_Click(object sender, EventArgs e)
    {
      if (BothValuesAreValid() == true && number2 != 0)
      {
        double result = number1 - number2;
        textBox_result.Text = result.ToString();
      }
    }

    private void button_multiply_Click(object sender, EventArgs e)
    {
      if (BothValuesAreValid() == true)
      {
        double result = number1 * number2;
        textBox_result.Text = result.ToString();
      }
    }
  }
}
