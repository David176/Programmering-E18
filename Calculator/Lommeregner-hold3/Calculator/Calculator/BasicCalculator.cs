using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
  public class BasicCalculator
  {
    public BasicCalculator()
    {
    }

    public double Add(double _number1, double _number2)
    {
      double result = _number1 + _number2;
      return result;
    }

    public double Divide(double _number1, double _number2)
    {
      double result = _number1 / _number2;
      return result;
    }

    public double Multiply(double _number1, double _number2)
    {
      double result = _number1 * _number2;
      return result;
    }

    public double Subtract(double _number1, double _number2)
    {
      double result = _number1 - _number2;
      return result;
    }

    public double Percentage(double _number1, double _number2)
    {
      double result = (_number1 / _number2) * 100;
      return result;
    }
  }
}
