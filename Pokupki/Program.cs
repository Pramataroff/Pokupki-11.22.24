using System;
using System.Diagnostics;

namespace Pokupki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> products = new LinkedList<string>();

            /*string.empty sum si go napisal az ne sum go kopiral ot nikude*/
            string input = String.Empty;
            while ((input = Console.ReadLine()) != "6")
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "Add":
                        {
                            AddRemove(command, products);
                        }
                        break;
                    case "Remove":
                        {
                            AddRemove(command, products);
                        }
                        break;
                    case "Print":
                        {
                            PrintAll(products);
                        }
                        break;
                    case "Find":
                        {
                            Find(products);
                        }
                        break;
                    case "Change":
                        {
                            ChangeProduct(products);
                        }
                        break;
                }
            }
            static void AddRemove(string input, LinkedList<string> list)
            {
                if (input == "Add")
                {
                    Console.Write("Enter the product: ");
                    string product = Console.ReadLine();
                    list.AddLast(product);
                }
                else if (input == "Remove")
                {
                    if (list.Count < 0)
                    {
                        Console.WriteLine("List is empty.");
                    }
                    else
                    {
                        Console.WriteLine(string.Join(" ", list));
                        list.RemoveFirst();
                    }

                }
            }
            static void PrintAll(LinkedList<string> list)
            {
                if (list.Count < 0)
                {
                    Console.WriteLine("List is empty.");

                }
                else
                {
                    int count = 0;
                    foreach (var item in list)
                    {
                        count++;
                        Console.WriteLine($"{count} ===> {item}");
                    }
                }

            }
            static void Find(LinkedList<string> list)
            {
                Console.Write("What's the name of the product you want to find: ");
                string product = Console.ReadLine();
                int count = 0;
                foreach (string item in list)
                {
                    count++;
                    if (item == product)
                    {
                        Console.WriteLine($"index: {count} || {item}");
                        return;
                    }
                }
                Console.WriteLine($"Product not found: {product}");

            }
            static void ChangeProduct(LinkedList<string> list)
            {
                Console.WriteLine("Enter the product you want to remove product.");
                string oldproduct = Console.ReadLine();
                Console.WriteLine("Enter the product new product.");
                string newproduct = Console.ReadLine();
                LinkedListNode<string> node = list.First;
                while (node != null)
                {
                    if (node.Value == oldproduct)
                    {
                        node.Value = newproduct;
                        return;
                    }
                    node = node.Next;
                }
            }
        }
    }
}
