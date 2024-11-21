using System;
using System.Diagnostics;

    namespace Pokupki
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                LinkedList<string> products = new LinkedList<string>();

                /*string.empty sum si go napisal az ne sum go kopiral ot nikude

                 celiq kod e napisan i izmislen sobstvenoruchno ot men bez drugi iztochnici*/


                Console.WriteLine("1 - Adding new product in the end of the list. ");
                Console.WriteLine("2 - Removing product from the front of the list. ");
                Console.WriteLine("3 - Printing all the products. ");
                Console.WriteLine("4 - Finding product. ");
                Console.WriteLine("5 - Changing product. ");
                Console.WriteLine("6 - End of the program. ");
                Console.Write("Command: ");
                string input = String.Empty; /*string.empty = null*/
                while ((input = Console.ReadLine()) != "6")
                {
                    switch (input)
                    {

                        case "1":
                            {
                                Add(products);
                            }
                            break;
                        case "2":
                            {
                                Remove(products);
                            }
                            break;
                        case "3":
                            {
                                PrintAll(products);
                            }
                            break;
                        case "4":
                            {
                                Find(products);
                            }
                            break;
                        case "5":
                            {
                                ChangeProduct(products);
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Invalid command");
                            }
                            break;
                    }
                    Console.Write("Command: ");
                }
                static void Add(LinkedList<string> list)
                {
                    Console.Write("Enter the product you want to add: ");
                    string product = Console.ReadLine();
                    list.AddLast(product);
                }
                static void Remove(LinkedList<string> list)
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("List is empty.");
                    }
                    else
                    {
                        Console.WriteLine(string.Join(" ", list));
                        Console.WriteLine($"Product: {list.First.Value} is removed");
                        list.RemoveFirst();

                    }
                }
                static void PrintAll(LinkedList<string> list)
                {
                    if (list.Count == 0)
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
                    Console.WriteLine("Enter the product you want to replace.");
                    string oldproduct = Console.ReadLine();
                    Console.WriteLine("Enter the new product.");
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

