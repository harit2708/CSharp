namespace PetStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pet Store!");

            // Enter user's personal information
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your student number: ");
            string stnum = Console.ReadLine();

            Console.Write("Enter your email address: ");
            string email = Console.ReadLine();

            try
            {
                Console.Write("Enter the name of the pet item purchased: ");
                string itnm = Console.ReadLine();

                Console.Write("Enter the quan of the item purchased: ");
                int quan = Convert.ToInt32(Console.ReadLine());

                Console.Write("Do you have a loyalty card? (yes/no): ");
                string lytcrd = Console.ReadLine();

                bool hasLoyaltyCard = lytcrd.ToLower() == "yes";

                double basePrice = 0.0;
                double disc = 0.0;

                if (itnm.ToLower() == "fish")
                {
                    basePrice = 5.00;
                    if (quan >= 3)
                        disc = 0.10; // 10% disc on all fish purchased
                }
                else if (itnm.ToLower() == "cat food")
                {
                    basePrice = 10.00;
                    if (quan >= 5)
                    {
                        int fbags = quan / 5;
                        disc = fbags * basePrice; // 1 free bag for every 5 bags of cat food purchased
                    }
                }
                else if (itnm.ToLower() == "dog food")
                {
                    basePrice = 15.00;
                    if (quan >= 3)
                    {
                        int hob = quan / 3;
                        disc = (hob * basePrice) / 2; // 50% off 1 bag for every 3 bags of dog food purchased
                    }
                }
                else
                {
                    Console.Write("Enter the price for " + itnm + ": ");
                    basePrice = Convert.ToDouble(Console.ReadLine());

                    if (quan >= 2)
                        disc = basePrice * 0.05; // 5% additional disc on each item if 2 or more are purchased
                }

                double sbtotal = (basePrice * quan) - disc;
                double tax = sbtotal * 0.13; // 13% tax applied to the subtotal
                double total = sbtotal + tax;

                if (hasLoyaltyCard)
                    total -= total * 0.05; // 5% disc on the total if the user has a loyalty card

                Console.WriteLine();
                Console.WriteLine("Receipt:");
                Console.WriteLine("======================================");
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Student Number: " + stnum);
                Console.WriteLine("Email Address: " + email);
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Item: " + itnm);
                Console.WriteLine("Quantity: " + quan);
                Console.WriteLine("Base Price: $" + basePrice);
                Console.WriteLine("Discount: $" + disc);
                Console.WriteLine("Loyalty Card: " + (hasLoyaltyCard ? "Yes" : "No"));
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Sub Total: $" + sbtotal);
                Console.WriteLine("----");
                Console.WriteLine("Tax: $" + tax);
                Console.WriteLine("=======================================");
                Console.WriteLine("Total: $" + total);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for shopping at the Pet Store! Press any key to exit.");
            Console.ReadKey();
        }
    }
}
