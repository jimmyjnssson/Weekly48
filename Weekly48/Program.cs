namespace Weekly48
{
    class Program
    {
        static void Main(string[] args)
        {
            StartApp();
        }
        private static void StartApp()
        {
            Cart cart = new Cart(); //Creates the cart class which contains the different List operation methods
            
            //Declaring variables for ReadLine() input and the variables to set the constructor in Product class
            string input;
            string category = "";
            string name = "";
            double price = 0;
            


            while (true)
            {
                Console.WriteLine("Enter product category - or q to quit: ");
                input = Console.ReadLine();
                if (input.ToLower() == "q")
                {
                    break;
                }
                category = input; //Assigns the input to new variable


                Console.WriteLine("Enter product name - or q to quit: ");
                input = Console.ReadLine();
                if (input.ToLower() == "q")
                {
                    break;
                }
                name = input; //Assigns the input to new variable

                //This while checks if input is a number. TryParse return false if not and user gets a new prompt to enter a number instead of negative number or chars
                while (true)
                {
                    Console.WriteLine("Enter product price - or q to quit: ");
                    input = Console.ReadLine();
                    if (input.ToLower() == "q")
                    {
                        break;
                    }

                    if (double.TryParse(input, out price) && price >= 0) //Assigns the input to a double variable if the TryParse is true
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Input needs to be a number in the range 1 to N");
                    }
                }

                // Create a new product and calls AddProduct method in the Car class (where the List is simulating a ShoppingCart)
                Product newProduct = new Product(category, name, price);
                cart.AddProduct(newProduct);

                // Question for adding more products into the list (If yes it return to the top of While and iterates throgh again
                Console.WriteLine("Do you want to add another product? - yes or no: ");
                string continueInput = Console.ReadLine().ToLower();
                if (continueInput == "no")
                {
                    break;
                }
            }

            // Display all products from the List sorted by price and total
            cart.GetAllProducts();

            // Display the total amount by calling the LINQ method in Cart class
            Console.WriteLine($"\nTotal Price: {cart.GetTotalPrice()} kr");

            // Question to add more products after displaying the List
            Console.WriteLine("\nDo you want to add more products? - yes or no: ");
            string addMoreProducts = Console.ReadLine().ToLower();
            if (addMoreProducts == "yes")
            {
                StartApp(); // Calling the method once again to add more products
            }
            else
            {
                
                Console.WriteLine("Thanks for shopping");
            }
        }

    }

}
