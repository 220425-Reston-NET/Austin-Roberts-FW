// //This is how you create a class by using the class keyword
// //Public is just there to make the class available for everyone
// public class Car
// {
//     //This is a field
//     //It is used to store information or define the current state of the object
//     // By default, fields should be private
//     private string _color;
//     private string _owner;
//     private int _fuel; 
//     private int _gallonPerMile;

//     //This is a method
//     //A way to represent behabior/function and it will run multiple lines of code
//     //Void means that the method will not return anything
//     //Any other datatype the method will exect to return that data type

//     public int TotalDistancePerFuel()
//     {
//         Console.WriteLine("Current Fuel: " + _fuel);
//         Console.WriteLine($"Gallon Per Mile:  {_gallonPerMile} This is the owner:{_owner}");

//         Console.WriteLine(_fuel/_gallonPerMile + " This is how many miles");

//         //Return keyword is what the method will give back
//         return _fuel/_gallonPerMile;
//     }

//     //Methods can also have parameters
//     // Paramaters are implemented by adding in datatypes inside of the parenthesis
//     //A coma is used if your method needs more then one parameter
//     public void Sum(int num1, int num2)
//     {
//         Console.WriteLine(num1+num2);
//     }

//     //This is a constructor
//     //It is a special mehtod that will run whenever you create an object
//     public Car()
//     {
//         _color = "Blue";
//         _fuel = 100;
//         _gallonPerMile = 5;
//         _owner = "Austin";
//     }

//     public Car(string p_owner)
//     {
//         _owner = p_owner;
//     }
    
//     // This is Property
//     //Gives us the flexibility to check that the data being stored is correct, let only certain things access data, make things read or write only
//     public string Owner 
//     {
//         //Get keyword is how the data is getting shared
//         get {return _owner + " is the owner of this car.";}
        
//         //set keyword is how you change the data that is being stored
//         set {_owner=value+" Owner";}

//     }

//     //Fuel can only hold numbers from 0 to 100
//     public int Fuel
//     {
//         get {return _fuel;}
//         set 
//         {
//             if (value <=100 && value >=0)
//             {
//             _fuel = value;
//             }
//             else
//             {
//                 _fuel = 100;
//                 Console.WriteLine("Fuel can only hold from 0 to 100");
                
//             }
           
//         }
//     }
// }