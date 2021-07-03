using System;
//added System.Linq
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    
    double[] cel = new double[7];    
    double[] far = new double[7];
    double ave = 0.00;    
    

   for(int pos=0; pos < 7; pos++)
    {
      Console.WriteLine("Enter temperature in Celsius");
      cel[pos] = Convert.ToDouble(Console.ReadLine());
      far[pos] = (cel[pos] * 9/5) + 32;
    }

    Console.WriteLine("Temperature in Fahrenheit ");
    
    Array.Reverse(far);
    foreach (double x in far)
    {
      Console.WriteLine(x);
    }

    double sum = far.Sum();
    ave = (sum / 7);
    Console.WriteLine("Average weekly temperature is " + ave + "degrees Fahrenheit");


  }
}