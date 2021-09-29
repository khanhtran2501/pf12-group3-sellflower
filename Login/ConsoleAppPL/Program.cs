using System;
using System.Collections.Generic;
using Persistence;
using BL;

namespace ConsoleAppPL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================");
            Console.WriteLine("|            LOGIN            |");
            Console.WriteLine("===============================");
            Console.Write("| User Name | ");
            string userName = Console.ReadLine();
            Console.Write("| Password  | ");
            string pass = GetPassword();
            Console.WriteLine();
            Console.WriteLine("===============================");
            //valid username password here
            Cashier cashier = new Cashier(){UserName = userName, Password = pass};
            CashierBL bl = new CashierBL();
            int login = bl.Login(cashier);
            if(login <= 0)
            {
                Console.WriteLine("Can't Login");
            }else{
                Console.WriteLine("Welcome to system...");
                MainMenu();
            }
        }

       

        static string GetPassword()
        {
            var pass = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && pass.Length > 0)
                {
                    Console.Write("\b \b");
                    pass = pass[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    pass += keyInfo.KeyChar;
                }
            }while (key != ConsoleKey.Enter);
            return pass;
        }
