using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachineCode
{
    class Program
    {
        static double credit = 0; // starting credit value
        static double InputCredit; // amount of money to be inserted
        static double totalcredit; // amount after the money was inserted
        static double ItemCost = 0; // cost of the product
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Jar's Vending Machine!");
            Console.WriteLine("------------------------------------");
            DisplayMenu();
            Console.WriteLine("-------------------------");

            
            Console.ReadLine();
        }

        static void DisplayMenu() //Main Menu
        {
            int user;
            Console.WriteLine("1. Buy a Drink or Snack");
            Console.WriteLine("2. Insert Money");
            Console.WriteLine("3. Get Refund or Change");
            Console.WriteLine("4. Exit");
            Console.Write("Select Number: ");
            user = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            

            switch (user) //Main Menu Selection
            {
                case 1: BuyDrinkOrSnack();
                    break;
                case 2: InsertMoneyMenu();
                    break;
                case 3: RefundOrChange();
                    break;
                case 4: Exit();
                    break;
                default:
                    Console.WriteLine("Invalid Input! Please Try Again!");
                    Console.WriteLine("----------------------------------");
                    DisplayMenu();
                    break;
            }
        }

        static void BuyDrinkOrSnack() //Category Selection
        {
            int user;
            Console.WriteLine("Select a Category");
            Console.WriteLine("1. Buy a Drink");
            Console.WriteLine("2. Buy a Snack");
            Console.WriteLine("3. Go Back");
            Console.WriteLine("4. Exit");
            Console.Write("Select Number: ");
            user = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            

            switch (user) //Category Selection
            {
                case 1: DrinksMenu();
                    break;
                case 2: SnacksMenu();
                    break;
                case 3: DisplayMenu();
                    break;
                case 4: Exit();
                    break;
                default:
                    Console.WriteLine("Invalid Input! Please Try Again!");
                    Console.WriteLine("----------------------------------");
                    BuyDrinkOrSnack();
                    break;
            }
        }

        static void DrinksMenu() //Drinks Menu
        {
            int user;
            Console.WriteLine("1. Water 500ml       =       1 AED");
            Console.WriteLine("2. Coca-Cola 330ml   =       3 AED");
            Console.WriteLine("3. 7-Up 330ml        =       3 AED");
            Console.WriteLine("4. Mirinda 330ml     =       3 AED");
            Console.WriteLine("5. Mountain Dew 330ml=       3 AED");
            Console.WriteLine("6. Orange Juice 500ml=       2 AED");
            Console.WriteLine("7. Mango Juice 500ml =       2 AED");
            Console.WriteLine("8. Apple Juice 500ml =       2 AED");
            Console.WriteLine("--------------------------");
            Console.Write("Enter number of Item to Buy: ");
            user = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            

            switch (user) // Drinks Selection
            {
                case 1: BuyWater();
                    break;
                case 2: BuyCola();
                    break;
                case 3: Buy7Up();
                    break;
                case 4: BuyMirinda();
                    break;
                case 5: BuyMountainDew();
                    break;
                case 6: BuyOrangeJuice();
                    break;
                case 7: BuyMangoJuice();
                    break;
                case 8: BuyAppleJuice();
                    break;
                default:
                    Console.WriteLine("Invalid Input! Please Try Again!");
                    Console.WriteLine("--------------------------");
                    DrinksMenu();
                    break;
            }
        }

        static void SnacksMenu() //Snacks Menu
        {
            int user;
            Console.WriteLine("1. Kit-Kat       =           3AED");
            Console.WriteLine("2. Snickers      =           3AED");
            Console.WriteLine("3. Doritos       =           2AED");
            Console.WriteLine("4. Lays          =           2AED");
            Console.WriteLine("5. Cheetos       =           2AED");
            Console.WriteLine("----------------------------------");
            Console.Write("Enter the number of the Item to Buy: ");
            user = Convert.ToInt32(Console.ReadLine());
            

            switch (user) //Snacks Selection
            {
                case 1: BuyKitKat();
                    break;
                case 2: BuySnickers();
                    break;
                case 3: BuyDoritos();
                    break;
                case 4: BuyLays();
                    break;
                case 5: BuyCheetos();
                    break;
                default:
                    Console.WriteLine("Invalid Input! Please Try Again!");
                    Console.WriteLine("--------------------------");
                    SnacksMenu();
                    break;
            }
        }

        static void Exit() //Exit Program
        {
            if (totalcredit > 0)
            {
                RefundOrChange();
            }
            Console.WriteLine("Thank you for using Jar's Vending Machine!");
            Console.WriteLine("Exiting Program... Press Any key to continue");
        }


        static void InsertMoney(double money) //Insert Money Function
        {
            Console.Write("Insert Money: ");
            money = Convert.ToDouble(Console.ReadLine());
            InputCredit = money;
            totalcredit += money;
            credit = totalcredit;
            Console.WriteLine("----------------------------------");
            

            if (totalcredit <= 0)
            {
                Console.WriteLine("Invalid Input! Please Try Again!");
                Console.WriteLine("----------------------------------");
            }
        }
        static void InsertMoneyMenu() //insert Money Selection (Main Menu)
        {
            InsertMoney(totalcredit);
            BuyDrinkOrSnack();
        }


        public static void RefundOrChange() //Refund or Change Function
        {
            if (totalcredit >= 1)
            {
                Console.WriteLine("Current Balance: {0}", totalcredit);
                Console.WriteLine("Amount Extracted: {0}", totalcredit);
                totalcredit = totalcredit - totalcredit;
                credit = totalcredit;
                Console.WriteLine("Current Balance: {0}", credit);
                Console.WriteLine("Take Money");
                Exit();
            }
            else if (totalcredit == 0)
            {
                Console.WriteLine("Current Balance Is {0}", totalcredit);
                Exit();
            }
        }

        public static void BuyWater()
        {
            ItemCost = 1;
            Console.WriteLine("You have selected Water");
            Console.WriteLine("----------------------------------");
            if (totalcredit == 0)
            {
                Console.WriteLine("Insert 1 AED");
                InsertMoney(totalcredit);

                if (totalcredit >= ItemCost)
                {
                    Console.WriteLine("You have bought a water!");
                    totalcredit = totalcredit - ItemCost;
                    Console.WriteLine("Current Balance: {0}", totalcredit);
                    Console.WriteLine("Take Your Item");
                    Console.WriteLine("----------------------------------");
                    Console.Write("Would You like to buy more? \nPress 1 for yes, 2 for no: ");
                    int option;
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------------------------------");

                    switch (option)
                    {
                        case 1: BuyDrinkOrSnack();
                            break;
                        case 2: Exit();
                            break;
                        default:
                            Console.WriteLine("Invalid Input! Please Try Again!");
                            Console.WriteLine("----------------------------------");
                            BuyWater();
                            break;
                    }
                }
                
                else if (totalcredit < ItemCost)
                {
                    Console.WriteLine("Insufficient Funds!");
                    Console.WriteLine("Insert at least {0} to buy the product.", ItemCost - totalcredit);
                    InsertMoney(totalcredit);
                    BuyWater();
                }
                else if (totalcredit <= 0)
                {
                    Console.WriteLine("Invalid Input! Enter Again!");
                    Console.WriteLine("----------------------------------");
                    BuyWater();
                }
            }
            else if (totalcredit < ItemCost)
            {
                Console.WriteLine("Insufficient Funds!");
                Console.WriteLine("Insert at least {0} to buy the product.", ItemCost - totalcredit);
                InsertMoney(totalcredit);
                BuyWater();
            }

            else if (totalcredit >= ItemCost)
            {
                totalcredit = totalcredit - ItemCost;
                Console.WriteLine("Current Balance: {0}", totalcredit);
                Console.WriteLine("You have bought a water!");
                Console.WriteLine("Take Your Item");
                Console.WriteLine("----------------------------------");
                Console.Write("Would you like to buy more? \nPress 1 for yes 2 for no: ");
                int option;
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------");
                
                switch (option)
                {
                    case 1: BuyDrinkOrSnack();
                        break;
                    case 2: RefundOrChange();
                        break;
                    default:
                        Console.WriteLine("Invalid Input! Please Try Again!");
                        Console.WriteLine("----------------------------------");
                        BuyWater();
                        break;
                }
            }

        }
            
        static void BuyCola()
        {
            ItemCost = 3;
            Console.WriteLine("You have selected Coca-Cola");
            Console.WriteLine("----------------------------------");
            if (totalcredit == 0)
            {
                Console.WriteLine("Insert 3 AED");
                InsertMoney(totalcredit);

                if (totalcredit >= ItemCost)
                {
                    Console.WriteLine("You have bought a Coca-Cola!");
                    totalcredit = totalcredit - ItemCost;
                    Console.WriteLine("Current Balance: {0}", totalcredit);
                    Console.WriteLine("Take Your Item");
                    Console.WriteLine("----------------------------------");
                    Console.Write("Would You like to buy more? \nPress 1 for yes, 2 for no: ");
                    int option;
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------------------------------");
                    
                    switch (option)
                    {
                        case 1: BuyDrinkOrSnack();
                            break;
                        case 2: Exit();
                            break;
                        default:
                            Console.WriteLine("Invalid Input! Please Try Again!");
                            Console.WriteLine("----------------------------------");
                            BuyCola();
                            break;
                    }
                }
                else if (totalcredit < ItemCost)
                {
                    Console.WriteLine("Insufficient Funds!");
                    Console.WriteLine("Insert at least {0} to buy the product.", ItemCost - totalcredit);
                    InsertMoney(totalcredit);
                    BuyCola();
                }
                else if (totalcredit <= 0)
                {
                    Console.WriteLine("Invalid Input! Enter Again!");
                    Console.WriteLine("----------------------------------");
                    BuyCola();
                }
            }
            else if (totalcredit >= ItemCost)
            {
                totalcredit = totalcredit - ItemCost;
                Console.WriteLine("Current Balance: {0}", totalcredit);
                Console.WriteLine("You have bought a Coca-Cola!");
                Console.WriteLine("Take Your Item");
                Console.WriteLine("----------------------------------");
                Console.Write("Would you like to buy more? \nPress 1 for yes 2 for no: ");
                int option;
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------");
                
                switch (option)
                {
                    case 1: BuyDrinkOrSnack();
                        break;
                    case 2: RefundOrChange();
                        break;
                    default:
                        Console.WriteLine("Invalid Input! Please Try Again!");
                        Console.WriteLine("----------------------------------");
                        BuyCola();
                        break;
                }
            }

        }

        static void Buy7Up()
        {
            ItemCost = 3;
            Console.WriteLine("You have selected 7-Up");
            Console.WriteLine("----------------------------------");
            if (totalcredit == 0)
            {
                Console.WriteLine("Insert 3 AED");
                InsertMoney(totalcredit);

                if (totalcredit >= ItemCost)
                {
                    Console.WriteLine("You have bought a 7-Up!");
                    totalcredit = totalcredit - ItemCost;
                    Console.WriteLine("Current Balance: {0}", totalcredit);
                    Console.WriteLine("Take Your Item");
                    Console.WriteLine("----------------------------------");
                    Console.Write("Would You like to buy more? \nPress 1 for yes, 2 for no: ");
                    int option;
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------------------------------");
                    
                    switch (option)
                    {
                        case 1: BuyDrinkOrSnack();
                            break;
                        case 2: Exit();
                            break;
                        default:
                            Console.WriteLine("Invalid Input! Please Try Again!");
                            Console.WriteLine("----------------------------------");
                            Buy7Up();
                            break;
                    }
                }

                else if (totalcredit < ItemCost)
                {
                    Console.WriteLine("Insufficient Funds!");
                    Console.WriteLine("Insert at least {0} to buy the product.", ItemCost - totalcredit);
                    InsertMoney(totalcredit);
                    Buy7Up();
                }
                else if (totalcredit <= 0)
                {
                    Console.WriteLine("Invalid Input! Enter Again!");
                    Console.WriteLine("----------------------------------");
                    Buy7Up();
                }
            }
            else if (totalcredit >= ItemCost)
            {
                totalcredit = totalcredit - ItemCost;
                Console.WriteLine("Current Balance: {0}", totalcredit);
                Console.WriteLine("You have bought a 7-Up!");
                Console.WriteLine("Take Your Item");
                Console.WriteLine("----------------------------------");
                Console.Write("Would you like to buy more? \nPress 1 for yes 2 for no: ");
                int option;
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------");
                
                switch (option)
                {
                    case 1: BuyDrinkOrSnack();
                        break;
                    case 2: RefundOrChange();
                        break;
                    default:
                        Console.WriteLine("Invalid Input! Please Try Again!");
                        Console.WriteLine("----------------------------------");
                        Buy7Up();
                        break;
                }
            }
        }
        
        static void BuyMirinda()
        {
            ItemCost = 3;
            Console.WriteLine("You have selected Mirinda");
            Console.WriteLine("----------------------------------");
            if (totalcredit == 0)
            {
                Console.WriteLine("Insert 3 AED");
                InsertMoney(totalcredit);

                if (totalcredit >= ItemCost)
                {
                    Console.WriteLine("You have bought a Mirinda!");
                    totalcredit = totalcredit - ItemCost;
                    Console.WriteLine("Current Balance: {0}", totalcredit);
                    Console.WriteLine("Take Your Item");
                    Console.WriteLine("----------------------------------");
                    Console.Write("Would You like to buy more? \nPress 1 for yes, 2 for no: ");
                    int option;
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------------------------------");
                    
                    switch (option)
                    {
                        case 1: BuyDrinkOrSnack();
                            break;
                        case 2: Exit();
                            break;
                        default:
                            Console.WriteLine("Invalid Input! Please Try Again!");
                            Console.WriteLine("----------------------------------");
                            Buy7Up();
                            break;
                    }
                }

                else if (totalcredit < ItemCost)
                {
                    Console.WriteLine("Insufficient Funds!");
                    Console.WriteLine("Insert at least {0} to buy the product.", ItemCost - totalcredit);
                    InsertMoney(totalcredit);
                    BuyMirinda();
                }
                else if (totalcredit <= 0)
                {
                    Console.WriteLine("Invalid Input! Enter Again!");
                    Console.WriteLine("----------------------------------");
                    Buy7Up();
                }
            }
            else if (totalcredit >= ItemCost)
            {
                totalcredit = totalcredit - ItemCost;
                Console.WriteLine("Current Balance: {0}", totalcredit);
                Console.WriteLine("You have bought a Mirinda!");
                Console.WriteLine("Take Your Item");
                Console.WriteLine("----------------------------------");
                Console.Write("Would you like to buy more? \nPress 1 for yes 2 for no: ");
                int option;
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------");
                
                switch (option)
                {
                    case 1: BuyDrinkOrSnack();
                        break;
                    case 2: RefundOrChange();
                        break;
                    default:
                        Console.WriteLine("Invalid Input! Please Try Again!");
                        Console.WriteLine("----------------------------------");
                        Buy7Up();
                        break;
                }
            }
        }

        static void BuyMountainDew()
        {
            ItemCost = 3;
            Console.WriteLine("You have selected Mountain Dew");
            Console.WriteLine("----------------------------------");
            if (totalcredit == 0)
            {
                Console.WriteLine("Insert 3 AED");
                InsertMoney(totalcredit);

                if (totalcredit >= ItemCost)
                {
                    Console.WriteLine("You have bought a Mountain Dew!");
                    totalcredit = totalcredit - ItemCost;
                    Console.WriteLine("Current Balance: {0}", totalcredit);
                    Console.WriteLine("Take Your Item");
                    Console.WriteLine("----------------------------------");
                    Console.Write("Would You like to buy more? \nPress 1 for yes, 2 for no: ");
                    int option;
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------------------------------");
                    
                    switch (option)
                    {
                        case 1: BuyDrinkOrSnack();
                            break;
                        case 2: Exit();
                            break;
                        default:
                            Console.WriteLine("Invalid Input! Please Try Again!");
                            Console.WriteLine("----------------------------------");
                            BuyMountainDew();
                            break;
                    }
                }

                else if (totalcredit < ItemCost)
                {
                    Console.WriteLine("Insufficient Funds!");
                    Console.WriteLine("Insert at least {0} to buy the product.", ItemCost - totalcredit);
                    InsertMoney(totalcredit);
                    BuyMountainDew();
                }
                else if (totalcredit <= 0)
                {
                    Console.WriteLine("Invalid Input! Enter Again!");
                    Console.WriteLine("----------------------------------");
                    BuyMountainDew();
                }
            }
            else if (totalcredit >= ItemCost)
            {
                totalcredit = totalcredit - ItemCost;
                Console.WriteLine("Current Balance: {0}", totalcredit);
                Console.WriteLine("You have bought a Mountain Dew!");
                Console.WriteLine("Take Your Item");
                Console.WriteLine("----------------------------------");
                Console.Write("Would you like to buy more? \nPress 1 for yes 2 for no: ");
                int option;
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------");
                
                switch (option)
                {
                    case 1: BuyDrinkOrSnack();
                        break;
                    case 2: RefundOrChange();
                        break;
                    default:
                        Console.WriteLine("Invalid Input! Please Try Again!");
                        Console.WriteLine("----------------------------------");
                        BuyMountainDew();
                        break;
                }
            }
        }

        static void BuyOrangeJuice()
        {
            ItemCost = 2;
            Console.WriteLine("You have selected Orange Juice");
            Console.WriteLine("----------------------------------");
            if (totalcredit == 0)
            {
                Console.WriteLine("Insert 2 AED");
                InsertMoney(totalcredit);

                if (totalcredit >= ItemCost)
                {
                    Console.WriteLine("You have bought a Orange Juice!");
                    totalcredit = totalcredit - ItemCost;
                    Console.WriteLine("Current Balance: {0}", totalcredit);
                    Console.WriteLine("Take Your Item");
                    Console.WriteLine("----------------------------------");
                    Console.Write("Would You like to buy more? \nPress 1 for yes, 2 for no: ");
                    int option;
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------------------------------");
                    
                    switch (option)
                    {
                        case 1: BuyDrinkOrSnack();
                            break;
                        case 2: Exit();
                            break;
                        default:
                            Console.WriteLine("Invalid Input! Please Try Again!");
                            Console.WriteLine("----------------------------------");
                            BuyOrangeJuice();
                            break;
                    }
                }

                else if (totalcredit < ItemCost)
                {
                    Console.WriteLine("Insufficient Funds!");
                    Console.WriteLine("Insert at least {0} to buy the product.", ItemCost - totalcredit);
                    InsertMoney(totalcredit);
                    BuyOrangeJuice();
                }
                else if (totalcredit <= 0)
                {
                    Console.WriteLine("Invalid Input! Enter Again!");
                    Console.WriteLine("----------------------------------");
                    BuyOrangeJuice();
                }
            }
            else if (totalcredit >= ItemCost)
            {
                totalcredit = totalcredit - ItemCost;
                Console.WriteLine("Current Balance: {0}", totalcredit);
                Console.WriteLine("You have bought a Orange Juice!");
                Console.WriteLine("Take Your Item");
                Console.WriteLine("----------------------------------");
                Console.Write("Would you like to buy more? \nPress 1 for yes 2 for no: ");
                int option;
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------");
                
                switch (option)
                {
                    case 1: BuyDrinkOrSnack();
                        break;
                    case 2: RefundOrChange();
                        break;
                    default:
                        Console.WriteLine("Invalid Input! Please Try Again!");
                        Console.WriteLine("----------------------------------");
                        BuyOrangeJuice();
                        break;
                }
            }
        }

        static void BuyMangoJuice()
        {
            ItemCost = 2;
            Console.WriteLine("You have selected Mango Juice");
            Console.WriteLine("----------------------------------");
            if (totalcredit == 0)
            {
                Console.WriteLine("Insert 2 AED");
                InsertMoney(totalcredit);

                if (totalcredit >= ItemCost)
                {
                    Console.WriteLine("You have bought a Mango Juice!");
                    totalcredit = totalcredit - ItemCost;
                    Console.WriteLine("Current Balance: {0}", totalcredit);
                    Console.WriteLine("Take Your Item");
                    Console.WriteLine("----------------------------------");
                    Console.Write("Would You like to buy more? \nPress 1 for yes, 2 for no: ");
                    int option;
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------------------------------");
                    
                    switch (option)
                    {
                        case 1: BuyDrinkOrSnack();
                            break;
                        case 2: Exit();
                            break;
                        default:
                            Console.WriteLine("Invalid Input! Please Try Again!");
                            Console.WriteLine("----------------------------------");
                            BuyMangoJuice();
                            break;
                    }
                }

                else if (totalcredit < ItemCost)
                {
                    Console.WriteLine("Insufficient Funds!");
                    Console.WriteLine("Insert at least {0} to buy the product.", ItemCost - totalcredit);
                    InsertMoney(totalcredit);
                    BuyMangoJuice();
                }
                else if (totalcredit <= 0)
                {
                    Console.WriteLine("Invalid Input! Enter Again!");
                    Console.WriteLine("----------------------------------");
                    BuyMangoJuice();
                }
            }
            else if (totalcredit >= ItemCost)
            {
                totalcredit = totalcredit - ItemCost;
                Console.WriteLine("Current Balance: {0}", totalcredit);
                Console.WriteLine("You have bought a Mango Juice!");
                Console.WriteLine("Take Your Item");
                Console.WriteLine("----------------------------------");
                Console.Write("Would you like to buy more? \nPress 1 for yes 2 for no: ");
                int option;
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------");
                
                switch (option)
                {
                    case 1: BuyDrinkOrSnack();
                        break;
                    case 2: RefundOrChange();
                        break;
                    default:
                        Console.WriteLine("Invalid Input! Please Try Again!");
                        Console.WriteLine("----------------------------------");
                        BuyMangoJuice();
                        break;
                }
            }
        }

        static void BuyAppleJuice()
        {
            ItemCost = 2;
            Console.WriteLine("You have selected Apple Juice");
            if (totalcredit == 0)
            {
                Console.WriteLine("Insert 2 AED");
                InsertMoney(totalcredit);

                if (totalcredit >= ItemCost)
                {
                    Console.WriteLine("You have bought a Apple Juice!");
                    totalcredit = totalcredit - ItemCost;
                    Console.WriteLine("Current Balance: {0}", totalcredit);
                    Console.WriteLine("Take Your Item");
                    Console.WriteLine("----------------------------------");
                    Console.Write("Would You like to buy more? \nPress 1 for yes, 2 for no: ");
                    int option;
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------------------------------");
                    
                    switch (option)
                    {
                        case 1: BuyDrinkOrSnack();
                            break;
                        case 2: Exit();
                            break;
                        default:
                            Console.WriteLine("Invalid Input! Please Try Again!");
                            Console.WriteLine("----------------------------------");
                            BuyAppleJuice();
                            break;
                    }
                }

                else if (totalcredit < ItemCost)
                {
                    Console.WriteLine("Insufficient Funds!");
                    Console.WriteLine("Insert at least {0} to buy the product.", ItemCost - totalcredit);
                    InsertMoney(totalcredit);
                    BuyAppleJuice();
                }
                else if (totalcredit <= 0)
                {
                    Console.WriteLine("Invalid Input! Enter Again!");
                    Console.WriteLine("----------------------------------");
                    BuyAppleJuice();
                }
            }
            else if (totalcredit >= ItemCost)
            {
                totalcredit = totalcredit - ItemCost;
                Console.WriteLine("Current Balance: {0}", totalcredit);
                Console.WriteLine("You have bought a Apple Juice!");
                Console.WriteLine("Take Your Item");
                Console.WriteLine("----------------------------------");
                Console.Write("Would you like to buy more? \nPress 1 for yes 2 for no: ");
                int option;
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------");
                
                switch (option)
                {
                    case 1: BuyDrinkOrSnack();
                        break;
                    case 2: RefundOrChange();
                        break;
                    default:
                        Console.WriteLine("Invalid Input! Please Try Again!");
                        Console.WriteLine("----------------------------------");
                        BuyAppleJuice();
                        break;
                }
            }
        }

        static void BuyKitKat()
            {
            ItemCost = 3;
            Console.WriteLine("You have selected Kit-Kat");
            Console.WriteLine("----------------------------------");
            if (totalcredit == 0)
            {
                Console.WriteLine("Insert 3 AED");
                InsertMoney(totalcredit);

                if (totalcredit >= ItemCost)
                {
                    Console.WriteLine("You have bought a Kit-Kat!");
                    totalcredit = totalcredit - ItemCost;
                    Console.WriteLine("Current Balance: {0}", totalcredit);
                    Console.WriteLine("Take Your Item");
                    Console.WriteLine("----------------------------------");
                    Console.Write("Would You like to buy more? \nPress 1 for yes, 2 for no: ");
                    int option;
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------------------------------");
                    
                    switch (option)
                    {
                        case 1: BuyDrinkOrSnack();
                            break;
                        case 2: Exit();
                            break;
                        default:
                            Console.WriteLine("Invalid Input! Please Try Again!");
                            Console.WriteLine("----------------------------------");
                            BuyKitKat();
                            break;
                    }
                }

                else if (totalcredit < ItemCost)
                {
                    Console.WriteLine("Insufficient Funds!");
                    Console.WriteLine("Insert at least {0} to buy the product.", ItemCost - totalcredit);
                    InsertMoney(totalcredit);
                    BuyKitKat();
                }
                else if (totalcredit <= 0)
                {
                    Console.WriteLine("Invalid Input! Enter Again!");
                    Console.WriteLine("----------------------------------");
                    BuyKitKat();
                }
            }
            else if (totalcredit < ItemCost)
            {
                Console.WriteLine("Insufficient Funds!");
                Console.WriteLine("Insert at least {0} to buy the product.", ItemCost - totalcredit);
                InsertMoney(totalcredit);
                BuyKitKat();
            }

            else if (totalcredit >= ItemCost)
            {
                totalcredit = totalcredit - ItemCost;
                Console.WriteLine("Current Balance: {0}", totalcredit);
                Console.WriteLine("You have bought a Kit-Kat!");
                Console.WriteLine("Take Your Item");
                Console.WriteLine("----------------------------------");
                Console.Write("Would you like to buy more? \nPress 1 for yes 2 for no: ");
                int option;
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------");
                
                switch (option)
                {
                    case 1: BuyDrinkOrSnack();
                        break;
                    case 2: RefundOrChange();
                        break;
                    default:
                        Console.WriteLine("Invalid Input! Please Try Again!");
                        BuyKitKat();
                        break;
                }
            }
        }

        static void BuySnickers()
            {
            ItemCost = 3;
            Console.WriteLine("You have selected Snickers");
            Console.WriteLine("----------------------------------");
            if (totalcredit == 0)
            {
                Console.WriteLine("Insert 3 AED");
                InsertMoney(totalcredit);

                if (totalcredit >= ItemCost)
                {
                    Console.WriteLine("You have bought a Snickers!");
                    totalcredit = totalcredit - ItemCost;
                    Console.WriteLine("Current Balance: {0}", totalcredit);
                    Console.WriteLine("Take Your Item");
                    Console.WriteLine("----------------------------------");
                    Console.Write("Would You like to buy more? \nPress 1 for yes, 2 for no: ");
                    int option;
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------------------------------");
                    
                    switch (option)
                    {
                        case 1: BuyDrinkOrSnack();
                            break;
                        case 2: Exit();
                            break;
                        default:
                            Console.WriteLine("Invalid Input! Please Try Again!");
                            Console.WriteLine("----------------------------------");
                            BuySnickers();
                            break;
                    }
                }

                else if (totalcredit < ItemCost)
                {
                    Console.WriteLine("Insufficient Funds!");
                    Console.WriteLine("Insert at least {0} to buy the product.", ItemCost - totalcredit);
                    InsertMoney(totalcredit);
                    BuySnickers();
                }
                else if (totalcredit <= 0)
                {
                    Console.WriteLine("Invalid Input! Enter Again!");
                    Console.WriteLine("----------------------------------");
                    BuyKitKat();
                }
            }
            else if (totalcredit >= ItemCost)
            {
                totalcredit = totalcredit - ItemCost;
                Console.WriteLine("Current Balance: {0}", totalcredit);
                Console.WriteLine("You have bought a Snickers!");
                Console.WriteLine("Take Your Item");
                Console.WriteLine("----------------------------------");
                Console.Write("Would you like to buy more? \nPress 1 for yes 2 for no: ");
                int option;
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------");
                
                switch (option)
                {
                    case 1: BuyDrinkOrSnack();
                        break;
                    case 2: RefundOrChange();
                        break;
                    default:
                        Console.WriteLine("Invalid Input! Please Try Again!");
                        Console.WriteLine("----------------------------------");
                        BuySnickers();
                        break;
                }
            }
            else if (totalcredit < ItemCost)
            {
                Console.WriteLine("Insufficient Funds!");
                Console.WriteLine("Insert at least {0} to buy the product.", ItemCost - totalcredit);
                InsertMoney(totalcredit);
                BuySnickers();
            }
        }
        static void BuyDoritos()
            {
            ItemCost = 2;
            Console.WriteLine("You have selected Doritos");
            Console.WriteLine("----------------------------------");
            if (totalcredit == 0)
            {
                Console.WriteLine("Insert 2 AED");
                InsertMoney(totalcredit);

                if (totalcredit >= ItemCost)
                {
                    Console.WriteLine("You have bought a Doritos!");
                    totalcredit = totalcredit - ItemCost;
                    Console.WriteLine("Current Balance: {0}", totalcredit);
                    Console.WriteLine("Take Your Item");
                    Console.WriteLine("----------------------------------");
                    Console.Write("Would You like to buy more? \nPress 1 for yes, 2 for no: ");
                    int option;
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------------------------------");
                    
                    switch (option)
                    {
                        case 1: BuyDrinkOrSnack();
                            break;
                        case 2: Exit();
                            break;
                        default:
                            Console.WriteLine("Invalid Input! Please Try Again!");
                            Console.WriteLine("----------------------------------");
                            BuyDoritos();
                            break;
                    }
                }

                else if (totalcredit < ItemCost)
                {
                    Console.WriteLine("Insufficient Funds!");
                    Console.WriteLine("Insert at least {0} to buy the product.", ItemCost - totalcredit);
                    InsertMoney(totalcredit);
                    BuyDoritos();
                }
                else if (totalcredit <= 0)
                {
                    Console.WriteLine("Invalid Input! Enter Again!");
                    Console.WriteLine("----------------------------------");
                    BuyKitKat();
                }
            }
            else if (totalcredit >= ItemCost)
            {
                totalcredit = totalcredit - ItemCost;
                Console.WriteLine("Current Balance: {0}", totalcredit);
                Console.WriteLine("You have bought a Doritos!");
                Console.WriteLine("Take Your Item");
                Console.WriteLine("----------------------------------");
                Console.Write("Would you like to buy more? \nPress 1 for yes 2 for no: ");
                int option;
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------");
                
                switch (option)
                {
                    case 1: BuyDrinkOrSnack();
                        break;
                    case 2: RefundOrChange();
                        break;
                    default:
                        Console.WriteLine("Invalid Input! Please Try Again!");
                        Console.WriteLine("----------------------------------");
                        BuyDoritos();
                        break;
                }
            }
        }
        static void BuyLays()
            {
            ItemCost = 2;
            Console.WriteLine("You have selected Lays");
            Console.WriteLine("----------------------------------");
            if (totalcredit == 0)
            {
                Console.WriteLine("Insert 2 AED");
                InsertMoney(totalcredit);

                if (totalcredit >= ItemCost)
                {
                    Console.WriteLine("You have bought a Lays!");
                    totalcredit = totalcredit - ItemCost;
                    Console.WriteLine("Current Balance: {0}", totalcredit);
                    Console.WriteLine("Take Your Item");
                    Console.WriteLine("----------------------------------");
                    Console.Write("Would You like to buy more? \nPress 1 for yes, 2 for no: ");
                    int option;
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------------------------------");
                    
                    switch (option)
                    {
                        case 1: BuyDrinkOrSnack();
                            break;
                        case 2: Exit();
                            break;
                        default:
                            Console.WriteLine("Invalid Input! Please Try Again!");
                            Console.WriteLine("----------------------------------");
                            BuyLays();
                            break;
                    }
                }

                else if (totalcredit < ItemCost)
                {
                    Console.WriteLine("Insufficient Funds!");
                    Console.WriteLine("Insert at least {0} to buy the product.", ItemCost - totalcredit);
                    InsertMoney(totalcredit);
                    BuyLays();
                }
                else if (totalcredit <= 0)
                {
                    Console.WriteLine("Invalid Input! Enter Again!");
                    BuyLays();
                }
            }
            else if (totalcredit >= ItemCost)
            {
                totalcredit = totalcredit - ItemCost;
                Console.WriteLine("Current Balance: {0}", totalcredit);
                Console.WriteLine("You have bought a Lays!");
                Console.WriteLine("Take Your Item");
                Console.WriteLine("----------------------------------");
                Console.Write("Would you like to buy more? \nPress 1 for yes 2 for no: ");
                int option;
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------");
                
                switch (option)
                {
                    case 1: BuyDrinkOrSnack();
                        break;
                    case 2: RefundOrChange();
                        break;
                    default:
                        Console.WriteLine("Invalid Input! Please Try Again!");
                        Console.WriteLine("----------------------------------");
                        BuyLays();
                        break;
                }
            }
        }
        static void BuyCheetos()
        {
            ItemCost = 2;
            Console.WriteLine("You have selected Cheetos");
            Console.WriteLine("----------------------------------");
            if (totalcredit == 0)
            {
                Console.WriteLine("Insert 2 AED");
                InsertMoney(totalcredit);

                if (totalcredit >= ItemCost)
                {
                    Console.WriteLine("You have bought a Cheetos!");
                    totalcredit = totalcredit - ItemCost;
                    Console.WriteLine("Current Balance: {0}", totalcredit);
                    Console.WriteLine("Take Your Item");
                    Console.WriteLine("----------------------------------");
                    Console.Write("Would You like to buy more? \nPress 1 for yes, 2 for no: ");
                    int option;
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------------------------------");
                    
                    switch (option)
                    {
                        case 1: BuyDrinkOrSnack();
                            break;
                        case 2: Exit();
                            break;
                        default:
                            Console.WriteLine("Invalid Input! Please Try Again!");
                            Console.WriteLine("----------------------------------");
                            BuyCheetos();
                            break;
                    }
                }

                else if (totalcredit < ItemCost)
                {
                    Console.WriteLine("Insufficient Funds!");
                    Console.WriteLine("Insert at least {0} to buy the product.", ItemCost - totalcredit);
                    InsertMoney(totalcredit);
                    BuyCheetos();
                }
                else if (totalcredit <= 0)
                {
                    Console.WriteLine("Invalid Input! Enter Again!");
                    Console.WriteLine("----------------------------------");
                    BuyCheetos();
                }
            }
            else if (totalcredit >= ItemCost)
            {
                totalcredit = totalcredit - ItemCost;
                Console.WriteLine("Current Balance: {0}", totalcredit);
                Console.WriteLine("You have bought a Cheetos!");
                Console.Write("Would you like to buy more? \nPress 1 for yes 2 for no: ");
                int option;
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------");
                
                switch (option)
                {
                    case 1: BuyDrinkOrSnack();
                        break;
                    case 2: RefundOrChange();
                        break;
                    default:
                        Console.WriteLine("Invalid Input! Please Try Again!");
                        Console.WriteLine("----------------------------------");
                        BuyCheetos();
                        break;
                }
            }
        }
    }
}
