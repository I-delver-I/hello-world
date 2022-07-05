using System;
using System.Runtime.Serialization.Formatters.Binary;

namespace My_task
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "AccountList.dat";

            Bank_accounts accounts = new Bank_accounts();
            accounts.AddAccount(new Account("Dori", "Otter", "Onion", 3456, new DateTime(2005, 12, 3, 16, 4, 54)));
            accounts.AddAccount(new Account("Vitaliy", "Vitrokriliy", "Pilirenko", 100001, new DateTime(2021, 2, 3, 11, 4, 12)));
            accounts.AddAccount(new Account("Sanya", "Rambo", "Vasiliev", 1111, new DateTime(2006, 4, 6, 22, 6, 13)));
            accounts.AddAccount(new Account("Neverland", "Enniy", "Fellow", 9243453, new DateTime(2010, 1, 6, 9, 4, 33)));
            accounts.AddAccount(new Account("Monya", "Qebra", "Bebrovska", 382392, new DateTime(2019, 7, 7, 3, 4, 12)));
            
            using (Stream input = File.Create(path))
            {
                BinaryFormatter fm = new BinaryFormatter();
                fm.Serialize(input, accounts);
            }

            Bank_accounts accountsFromFile;

            using (Stream output = File.Open(path, FileMode.Open))
            {
                BinaryFormatter fm = new BinaryFormatter();
                accountsFromFile = (Bank_accounts)fm.Deserialize(output);
                System.Console.WriteLine($"The accounts from file {path}");
                accountsFromFile.Print();
            }

            System.Console.WriteLine("The account with biggest suma vkladu:");
            System.Console.WriteLine(accountsFromFile.GetAccountWithBiggestSum());

            System.Console.WriteLine("Enter the period:");
            bool exceptionIsCaught = false;
            DateTime beginOfPeriod = default;
            DateTime endOfPeriod = default;

            do
            {
                exceptionIsCaught = false;

                try
                {
                    System.Console.Write("Please, enter the primary date of period: ");
                    beginOfPeriod = DateTime.Parse(Console.ReadLine());
                    System.Console.Write("Please, enter the ending date of period: ");
                    endOfPeriod = DateTime.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("You entered not a period");
                    exceptionIsCaught = true;
                }
                
            } while (exceptionIsCaught);

            System.Console.WriteLine("Clients who made last operation between entered dates:");
            CustomList clients = CustomList.GetAccountsBetweenDates(accountsFromFile.GetAccounts(),
                beginOfPeriod, endOfPeriod);
            clients.Print();
        }
    }

    // static Account CaptureAccount()
    // {
    //     Account result = new Account();
    //     bool exceptionIsCaught = false;

    //     do
    //     {
    //         exceptionIsCaught = false;

    //         try
    //         {
    //             System.Console.Write("Enter first name:");
    //             result.FirstName = Console.ReadLine();
    //             System.Console.Write("Enter second name:");
    //             result.SecondName = Console.ReadLine();
    //             System.Console.Write("Enter patronymic:");
    //             result.Patronymic= Console.ReadLine();
    //             System.Console.WriteLine("Enter sumu vkladu:");
    //             result.SumaVkladu = decimal.Parse(Console.ReadLine());
    //             System.Console.WriteLine("Enter date of operation:");
    //             result.LastOperationDate = DateTime.Parse(Console.ReadLine());
    //         }
    //         catch (FormatException ex)
    //         {
    //             System.Console.WriteLine(ex.Message);
    //             exceptionIsCaught = true;
    //         }
    //     } 
    //     while (exceptionIsCaught || Console.ReadKey().Key != ConsoleKey.Backspace);
        
    //     return result;
    // }

            
}