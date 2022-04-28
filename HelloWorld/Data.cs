using System.Collections;

public class Data
{
    private string _milk;
    private string _water;
    private string _bread;
    private string _candy;
    private string _juice;
    private int _milkPrice;
    private int _waterPrice;
    private int _breadPrice;
    private int _candyPrice;
    private int _juicePrice;
    private int _total;
    private string _totalCart;

    public Data()
    {
        _milk = "Milk";
        _water = "Water";
        _bread = "Bread";
        _candy = "Candy";
        _juice = "Juice";
        _totalCart = "Nothing";
        _milkPrice = 2;
        _waterPrice = 1;
        _breadPrice = 3;
        _candyPrice = 2;
        _juicePrice = 4;
        _total = 0;
        
    }
   

    List<string> _cartList = new List<string>();
    
    public void DataMain()
    {
        bool repeat = true;
        while (repeat)
        {
                Console.WriteLine("Welcome to our store, what would you like to buy?");
            Console.WriteLine("1 to add, 2 to remove: Milk $2");
            Console.WriteLine("3 to add, 4 to remove: Water $1");
            Console.WriteLine("5 to add, 6 to remove: Bread $3");
            Console.WriteLine("7 to add 8 to remove: Candy $2");
            Console.WriteLine("9 to add, 10 to remove: Juice $4");
            Console.WriteLine("11 Veiw Full Cart");
            Console.WriteLine("12 to Checkout");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                _total += _milkPrice;
                Console.WriteLine("Your total is now $" + _total);
                _cartList.Add(_milk);
            }
            
            else if (answer == "3")
            {
                _total += _waterPrice;
                Console.WriteLine("Your total is now $" + _total);
                _cartList.Add(_water);
            }
            else if (answer == "5")
            {
                _total += _breadPrice;
                Console.WriteLine("Your total is now $" + _total);
                _cartList.Add(_bread);
            }
            else if (answer == "7")
            {
                _total += _candyPrice;
                Console.WriteLine("Your total is now $" + _total);
                _cartList.Add(_candy);
            }
            else if (answer == "9")
            {
                _total += _juicePrice;
                Console.WriteLine("Your total is now $" + _total);
                _cartList.Add(_juice);
            }
            else if (answer == "2")
            {
                _total -= _milkPrice;
                Console.WriteLine("Your total is now $" + _total);
                _cartList.Remove(_milk);
            }
             else if (answer == "4")
            {
                _total -= _waterPrice;
                Console.WriteLine("Your total is now $" + _total);
                _cartList.Remove(_water);
            }
             else if (answer == "6")
            {
                _total -= _breadPrice;
                Console.WriteLine("Your total is now $" + _total);
                _cartList.Remove(_bread);
            }
             else if (answer == "8")
            {
                _total -= _candyPrice;
                Console.WriteLine("Your total is now $" + _total);
                _cartList.Remove(_candy);
            }
             else if (answer == "10")
            {
                _total -= _juicePrice;
                Console.WriteLine("Your total is now $" + _total);
                _cartList.Remove(_juice);
            }
            else if (answer == "11")
            {
                Console.WriteLine("This is the total and contents of your cart");
                foreach(string element in _cartList)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine("This is your current total $" + _total);
            
            
            }
            else if (answer == "12")
            {
                repeat = false;
                Console.WriteLine("Thank you for shopping, have a nice day!");
            }
           

        }




        




    }







}

