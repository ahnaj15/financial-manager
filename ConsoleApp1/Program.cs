using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double Amount;
            string Note;
            double initialBudget = 0;
            string AccountName = null;
            Account account = null;
            do
            {

                while (AccountName == null)
                {
                    Console.Write("Enter your Name: ");
                    AccountName = Console.ReadLine();

                    Console.Write("Enter your current budget: ");
                    initialBudget = Convert.ToDouble(Console.ReadLine());

                    account = new Account(AccountName, initialBudget);
                    Console.WriteLine($"Account was created for {account.OwnerName} with RM {account.Balance} initial balance.");

                }
                Console.WriteLine($"Hi {AccountName}");
                Console.WriteLine($"Current Budget: RM {initialBudget}");
                Console.WriteLine($"Business\t\tRM {account.BusinessBalance}\n" +
                                   $"Must\t\tRM {account.MustBalance}\n" +
                                    $"Needs\t\tRM {account.NeedsBalance}\n" +
                                     $"Fun\t\tRM {account.FunBalance}\n" +
                                     $"Savings\t\tRM {account.SavingsBalance}");
                //Console.ReadLine();
                Console.WriteLine("\n1 - Income\n" +
                                  "2 - Expenses\n" +
                                  "3 - Debts");
                int selectedNum = Convert.ToInt16(Console.ReadLine());
                switch (selectedNum)
                {
                    case 1:
                        Console.Write("\nEnter the amount: ");
                        Amount = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter any note: ");
                        Note = Console.ReadLine();
                        account.MoneyIncome(Amount, DateTime.Now, Note);
                        break;
                    case 2:
                        Console.WriteLine("\nSelect the category:\n" +
                                      "1 Business\n" +
                                      "2 Must\n" +
                                      "3 Needs\n" +
                                      "4 Fun\n" +
                                      "5 Savings");
                        int category = Convert.ToInt16(Console.ReadLine());
                        Console.Write("\nEnter the amount: ");
                        Amount = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter any note: ");
                        Note = Console.ReadLine();
                        switch (category)
                        {
                            case 1:
                                account.ExpensesBusiness(Amount, DateTime.Now, Note);
                                break;
                            case 2:
                                account.ExpensesMust(Amount, DateTime.Now, Note);
                                break;
                            case 3:
                                account.ExpensesNeeds(Amount, DateTime.Now, Note);
                                break;
                            case 4:
                                account.ExpensesFun(Amount, DateTime.Now, Note);
                                break;
                            case 5:
                                account.ExpensesSavings(Amount, DateTime.Now, Note);
                                break;
                            default:
                                Console.WriteLine("Wrong input !");
                                break;
                        }
                        break;
                    //case 3:
                    //    Console.Write("Enter the amount: ");
                    //    Amount = Convert.ToDouble(Console.ReadLine());
                    //    Console.Write("Enter any note: ");
                    //    Note = Console.ReadLine();
                    //    Account.MoneyIncome(Amount, DateTime.Now, Note);
                    //    break;
                    default:
                        Console.WriteLine("Wrong input !");
                        break;
                }

                Console.WriteLine(account.Balance);
                Console.WriteLine(account.BusinessBalance);
                Console.WriteLine("Do you want to close ?\n1 Yes\n2 No");
                i = Convert.ToInt32(Console.ReadLine());


            } while (i == 2);




        }


    }
}