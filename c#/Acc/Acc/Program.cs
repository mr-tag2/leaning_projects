using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Accounting;


namespace AccountingAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Transaction> list = new List<Transaction>();
            while (true)
            {
                Console.WriteLine("Well Come !\n-------------------------------------------\n");
                Console.WriteLine("1 - Add Transaction ");
                Console.WriteLine("2 - Show All ");
                Console.WriteLine("3 - Exit ");
                Console.Write("Enter Your Choose : ");
                try
                {
                    int Choise = Convert.ToInt16(Console.ReadLine());
                    if (Choise == 3) break;
                    else if (Choise == 1)
                    {
                        Transaction arrayValues = new Transaction();
                        Console.WriteLine("\n\nEnter Your Transaction Values.\n\n");
                        Console.Write("Enter Value : ");
                        arrayValues.Value = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Enter Title : ");
                        arrayValues.Title = Console.ReadLine();
                        Console.Write("Enter Description : ");
                        arrayValues.Description = Console.ReadLine();

                        list.Add(arrayValues);
                    }
                    else if (Choise == 2)
                    {
                        Console.Write("\nTitle\t\tValue\t\tDescription\n-------------------------------------------");

                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.Write("\n{0}\t\t{1}\t\t{2}\n", list[i].Title, list[i].Value, list[i].Description);
                        }


                        Console.Write("\nPress Enter To Confirm   ");
                        Console.ReadLine();

                    }
                    Console.Clear();

                }
                catch
                {
                    Console.WriteLine("\n-------------------------------------------\nError\n-------------------------------------------\n");
                }
            }
        }
    }
}
