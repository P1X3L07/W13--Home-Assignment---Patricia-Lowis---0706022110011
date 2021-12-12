using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_list_continue_Pak_CT_
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = 0;
            var counter = 0;
            var add = 0;
            var queuePosition = 0;
            var searchScroll = 0;

            List<string> newScroll = new List<string>();
            List<string> scrolls = new List<string>() { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };
            while (true)
            {
                Console.Write("1. My Scroll List\n2. Add Scroll\n3. Search Scroll\n4. Remove Scroll\nChoose what to do : ");
                menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 1)
                {
                    Console.WriteLine();
                    counter = 0;
                    Console.WriteLine("Scroll to learn list : ");
                    foreach (var scroll in scrolls)
                    {
                        counter++;
                        Console.WriteLine($"Scroll {counter} : {scroll}");
                    }
                    Console.WriteLine();
                    Console.ReadLine();
                }
                else if (menu == 2)
                {
                    Console.Write("How many scroll to add : ");
                    add = Convert.ToInt32(Console.ReadLine());
                    Console.Write("In what number of Queue : ");
                    queuePosition = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < add; i++)
                    {
                        Console.WriteLine($"Scroll {i + 1} Name : ");
                        newScroll.Add(Console.ReadLine());
                    }
                    if (queuePosition < 1)
                    {
                        queuePosition = 0;
                    }
                    else if (queuePosition > scrolls.Count())
                    {
                        queuePosition = scrolls.Count();
                    }
                    counter = -1;
                    foreach (var scroll in newScroll)
                    {
                        scrolls.Insert(queuePosition + counter, scroll);
                        counter++;
                    }
                    newScroll.Clear();
                }
                else if (menu == 3)
                {
                    Console.WriteLine("Insert scroll name: ");
                    string search = Console.ReadLine();

                    if (scrolls.Contains(search))
                    {
                        Console.WriteLine($"Book found. Queue number {queuePosition}");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Book not found");
                        Console.ReadLine();
                    }
                    Console.ReadLine();
                }
                else if (menu == 4)
                {
                    Console.WriteLine("Remove from list by scroll name? (Y/N) ");
                    string ans = Console.ReadLine().ToUpper();
                    while (ans != "Y" && ans != "N")
                    {
                        Console.WriteLine("Wrong selection. Choose again: ");
                        Console.WriteLine("Remove from scroll list by scroll name? Y/N: ");
                        ans = Console.ReadLine().ToUpper();
                    }
                    if (ans == "Y")
                    {
                        Console.Write("Input scroll name: ");
                        string name = Console.ReadLine();
                        if (scrolls.Contains(name))
                        {
                            scrolls.Remove(name);
                        }
                    }
                    else if (ans == "N")
                    {
                        Console.Write("Input scroll queue: ");
                        int queue = Convert.ToInt32(Console.ReadLine());
                        for(int i = 0; i < scrolls.Count; i++)
                        {
                            if (queue == scrolls.Count)
                            {
                                scrolls.RemoveAt(queue);
                                Console.WriteLine("Book Removed");
                            }
                            while (queue != queuePosition)
                            {
                                Console.WriteLine("Queue not found");
                                Console.WriteLine("Insert scroll queue : ");
                                queue = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                    }
                }
                Console.Clear();
            }
        }
    }
}
