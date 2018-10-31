namespace Calculator
{
  public class AcademicCalculator : BasicCalculator
  {
    public double Avg(double _number1, double _number2)
    {
      double result = (_number1 + _number2) / 2;
      return result;
    }
  }
}