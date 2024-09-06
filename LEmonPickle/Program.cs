using System;

namespace LEmonPickle
{
    class Program
    {
        static void Main(string[] args)
        {
            int sweetQuantity = 0, spicyQuantity = 0, sweetAndSpicyQuantity = 0;
            string repeatOrder;

            Console.WriteLine("Welcome to the Lemon Pickle Store!");
            Console.WriteLine("1. Sweet Lemon Pickle");
            Console.WriteLine("2. Spicy Lemon Pickle");
            Console.WriteLine("3. Sweet and Spicy Lemon Pickle");
            Console.WriteLine("Please enter the corresponding number to place your order (or press 0 to exit):");

            do
            {
                int pickleChoice;
                if (int.TryParse(Console.ReadLine(), out pickleChoice) && (pickleChoice >= 0 && pickleChoice <= 3))
                {
                    if (pickleChoice == 0)
                    {
                        Console.WriteLine("Thank you for visiting! Have a great day!");
                        break;
                    }

                    HandlePickleOrder(ref sweetQuantity, ref spicyQuantity, ref sweetAndSpicyQuantity, pickleChoice);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a valid number (1, 2, 3, or 0 to exit):");
                }

                Console.WriteLine("Would you like to order again? (Y/N):");
                repeatOrder = Console.ReadLine().ToUpper();
            } while (repeatOrder == "Y" || repeatOrder == "YES");

            // Display total quantities at the end
            Console.WriteLine("\n--- Final Order Summary ---");
            Console.WriteLine($"Sweet Lemon Pickle Quantity: {sweetQuantity}");
            Console.WriteLine($"Spicy Lemon Pickle Quantity: {spicyQuantity}");
            Console.WriteLine($"Sweet and Spicy Lemon Pickle Quantity: {sweetAndSpicyQuantity}");
            Console.WriteLine("\nThank you for your order!");
        }

        static void HandlePickleOrder(ref int sweetQuantity, ref int spicyQuantity, ref int sweetAndSpicyQuantity, int pickleChoice)
        {
            int size, quantity;

            Console.WriteLine("Please choose the size of the pickle in grams (200, 500, 1000):");

            if (int.TryParse(Console.ReadLine(), out size) && (size == 200 || size == 500 || size == 1000))
            {
                Console.WriteLine("Please enter the quantity:");
                if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
                {
                    switch (pickleChoice)
                    {
                        case 1:
                            sweetQuantity += quantity;
                            Console.WriteLine($"Added {quantity} x {size}g of Sweet Lemon Pickle to your order.");
                            break;
                        case 2:
                            spicyQuantity += quantity;
                            Console.WriteLine($"Added {quantity} x {size}g of Spicy Lemon Pickle to your order.");
                            break;
                        case 3:
                            sweetAndSpicyQuantity += quantity;
                            Console.WriteLine($"Added {quantity} x {size}g of Sweet and Spicy Lemon Pickle to your order.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid quantity. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid size. Please enter 200, 500, or 1000 grams.");
            }
        }
    }
}
