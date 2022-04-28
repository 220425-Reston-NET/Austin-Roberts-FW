// public class Conversions
// {
//     //Static keyword will make whatever class member belong to the class itself
//     //For us, it means we dont have to create an object out of this class to use it
//     public static void ConversionsMain()
//     {

//         //General coding terms
//         //Implicit - Just means something is done automatically(Usually the compiler)
//         //Explicit - Just means you have to write some syntax to do something, or to tell the compiler to do something

//         Console.WriteLine("===Conversion Demo===");
//         int number = 10;
//         double numberDecimal = 76.3;
//         string word = "Hello";

//         //Implicit Conversion
//         //The computer/compiler automatically converts one datatype to another without you needin to specify anything
//         //The general rule is if you are going from a datatype to another datatype without losing information it will be implicit conversion
//         Console.WriteLine("=Implicit+");
        
//         //Double datatyhpe can set its value using an int datatype
//         numberDecimal = number;
//         Console.WriteLine(numberDecimal);

//         //Explicit Conversion
//         //You have to write a syntax to tell the compiler/computer to do the conversion anyway regardless of the potential data loss
//         Console.WriteLine("=Explicit=");
//         numberDecimal = 76.3;

//         //A cast is required
//         //Syntax: (datatype)variableName;
//         number = (int)numberDecimal;
//         Console.WriteLine(number);

//         //More Explicit Conversion
//         string numberString = number.ToString();
//         Console.WriteLine(numberString);

//         //Converting string into numerical values
//         string doubleString = "438.1239";
//         double double2 = Convert.ToDouble(doubleString);
//         Console.WriteLine(double2/2);
//     }
// }