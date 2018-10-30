namespace Calculator
{
  public static class BasicCalculator
  {
    public static double Add(double no1, double no2)
    {
      return no1 + no2;
    }

    public static double Subtract(double no1, double no2)
    {
      return no1 - no2;
    }

    public static double Divide(double no1, double no2)
    {
      return no1 / no2;
    }

    public static double Multiply(double no1, double no2)
    {
      return no1 * no2;
    }

    public static double Percentage(double no1, double no2)
    {
      return no1 * (no2 / 100);
    }
  }
}