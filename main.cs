using System;
// 20230914_AndrewHorton_Exercise2.1
class Program {
  public static void Main (string[] args) {
    double conversionRate = 2.54;
    int inchValue;
    double centiValue;
    
    inchValue= 5;
    centiValue = inchValue * conversionRate; 
    Console.WriteLine("{0} Inches is {1} Centimeters", inchValue, centiValue );
 
    inchValue= 5;
    centiValue = inchValue * conversionRate; 
    Console.WriteLine("{0} Inches is {1} Centimeters", inchValue, centiValue );
  
    inchValue= -15;
    centiValue = inchValue * conversionRate; 
    Console.WriteLine("{0} Inches is {1} Centimeters", inchValue, centiValue );
  
    inchValue= 15994;
    centiValue = inchValue * conversionRate; 
    Console.WriteLine("{0} Inches is {1} Centimeters", inchValue, centiValue );
  }
}