using Day4;
// // See https://aka.ms/new-console-template for more information
// Console.Clear(); //Will clear console
// Console.WriteLine("Hello, World!");

// Console.WriteLine("Making a car object!");
// //[Class name] [NameOfObject] = new [Class name];
// Car carObj1 = new Car();





// //Referenceing Class members within an object
// int mile = carObj1.TotalDistancePerFuel();

// carObj1.Sum(5, 10);

// Console.WriteLine(mile);

// Console.WriteLine("End of Method");
// string owner = "Chadel";

// Car carObj2 = new Car(owner);
// Console.WriteLine(carObj2.Owner);
// carObj2.Owner = "Maaz";
// Console.WriteLine(carObj2.Owner);

// //Checking if our property constraints are working
// carObj2.Fuel = -100;
// Console.WriteLine(carObj2.Fuel);

//Menu Demo
// Menu menuObj = new Menu();
// bool repeat = true;

// Console.WriteLine("Hello! What is your name?");
// menuObj.Name = Console.ReadLine();

// while (repeat)
// {
//     menuObj.GreetUser();
//     string answer = Console.ReadLine();
//     if (answer == "1")
//     {
//         menuObj.BuyItem();
//     }
//     else if (answer == "2")
//     {
//         Console.WriteLine("Your total price is " + menuObj.TotalPrice);
//         repeat = false;
//     }
// }


Data dataObj = new Data();
dataObj.DataMain();

// Collections collectObj = new Collections();
// collectObj.CollectionMain();
//Data2.DataMain();

// Conversions.ConversionsMain();

