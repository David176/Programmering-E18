using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
  public class BasicCalculator
  {
    public double Add(double number1, double number2)
    {
      double result = number1 + number2;
      return result;
    }
    
    public double Multiply(double number1, double number2)
    {
      double result = number1 * number2;
      return result;
    }

    public double Subtract(double number1, double number2)
    {
      double result = number1 - number2;
      return result;
    }
    public double Divide(double number1, double number2)
    {
      double result = number1 / number2;
      return result;
    }

    public double Percentage(double number1, double number2)
    {
      double result = (number1 / number2)*100;
      return result;
    }
  }
}
