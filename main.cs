using System;
//added System.Linq
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    
    //int[] day; 
    double[] cel;
    double far=0; 

    for(int pos=0; pos <= 6; pos++ )
    {
      Console.WriteLine("Enter temperature in Celsius");
      double ctemp = Convert.ToDouble(Console.ReadLine());
      far=(cTemp * 9/5) + 32; 
    }

    Console.WriteLine("Temperature in Fahrenheit " + fTemp);

  }
}