using System;
// 20230914_AndrewHorton_Exercise2.1
class Program {
  public static void Main (string[] args) {
    double conversionRate = 2.54;
    int inchValue = 5;
    
    double centiValue = inchValue * conversionRate;
    
    Console.WriteLine("{0} Inches", inchValue );
    Console.WriteLine("{0} Centimeters", centiValue );
  }
}