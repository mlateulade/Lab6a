using System;
//added System.Linq
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    
    //int[] day;
    double ftemp=0;
    double ctemp=0; 
    double[] cel = ctemp;
    double[] far = ftemp;
     

    for(int pos=0; pos <= 1; pos++ )
    {
      Console.WriteLine("Enter temperature in Celsius");
      ctemp = Convert.ToDouble(Console.ReadLine());       
      ftemp=(ctemp * 9/5) + 32; 
    }

    
    Console.WriteLine("Temperature in Fahrenheit " + ftemp);

  }
}