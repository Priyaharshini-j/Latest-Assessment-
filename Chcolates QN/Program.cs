using System.Collections;
using System.Diagnostics.Metrics;

namespace Chocolate
{
    internal class Program
    {
        public static ArrayList col = new ArrayList();
        public static ArrayList no = new ArrayList();
        public static int green_count = 0, silver_count = 0, crimson_count = 0, purple_count = 0, red_count = 0;
        static void Main(string[] args)
        {
            int choice = 0; int again_try = 0;
            do
            {
                Console.WriteLine("Enter the choice of yours:");
                Console.WriteLine("1 for adding the chocolates of color \n2 for Removing the Chocolate from Top\n3 for Dispensing the Chocolates\n4 for Dispensing the chocolates of color\n5 for returning the number of chocolates present in each color\n6 for sorting the chocolates based on count\n7 for changing the color of chocolates to another\n8 for changing the color of chocolates \n9 for removing the chocololate of specific color");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    string color = "";
                    int count = 0;
                    Console.WriteLine("Enter the color of Chocolate you want to add:");
                    color = Console.ReadLine();
                    color.ToLower();
                    Console.WriteLine($"Enter the No of {color} Chocolate you want to add:");
                    count = Convert.ToInt32(Console.ReadLine());
                    addChocolates(color, count);
                }

                if (choice == 2)
                {
                    int count = 0;
                    Console.WriteLine($"Enter the No of Chocolate you want to remove:");
                    count = Convert.ToInt32(Console.ReadLine());
                    removeChocolates(count);
                }

                if (choice == 3)
                {
                    int count = 0;
                    Console.WriteLine($"Enter the No of Chocolate you want to have it dispensed:");
                    count = Convert.ToInt32(Console.ReadLine());
                    dispenseChocolates(count);
                }

                if (choice == 4)
                {
                    string color = "";
                    int count = 0;
                    Console.WriteLine("Enter the color of Chocolate you want to dispense:");
                    color = Console.ReadLine();
                    Console.WriteLine($"Enter the No of {color}Chocolate you want to dispense:");
                    count = Convert.ToInt32(Console.ReadLine());
                    color.ToLower();
                    dispenseChocolatesOfColor(color, count);
                }

                if (choice == 5)
                {
                    noOfChocolates();
                }

                if (choice == 6)
                {
                    sortChocolateBasedOnCount();
                }

                if (choice == 7)
                {
                    Console.WriteLine("Enter the color of Chocolate you want to change:");
                    string old_color = Console.ReadLine();
                    Console.WriteLine("Enter the new color of Chocolate you want to add:");
                    string new_color = Console.ReadLine();
                    int count = 0;
                    Console.WriteLine($"Enter the No of Chocolate you want to add:");
                    count = Convert.ToInt32(Console.ReadLine());
                    changeChocolateColor(old_color, new_color, count);
                }

                if (choice == 8)
                {
                    Console.WriteLine("Enter the color of Chocolate you want to change:");
                    string old_color = Console.ReadLine();
                    Console.WriteLine("Enter the new color of Chocolate you want to add:");
                    string new_color = Console.ReadLine();
                    changeChocolateColorAllOfxCount(old_color, new_color);
                }

                if (choice == 8)
                {
                    Console.WriteLine("Enter the color of Chocolate you want to change:");
                    string old_color = Console.ReadLine();
                    Console.WriteLine("Enter the new color of Chocolate you want to add:");
                    string new_color = Console.ReadLine();
                    changeChocolateColorAllOfxCount(old_color, new_color);
                }

                if (choice == 9)
                {
                    Console.WriteLine("Enter the color of Chocolate you want to remove from top:");
                    string color = Console.ReadLine();
                    removeChocolateOfColor(color);
                }

                Console.WriteLine("Enter 1 if you want to try other choices");
                again_try = Convert.ToInt32(Console.ReadLine());
            } while (again_try == 1);
        }
        static void addChocolates(string color, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                col.Add(color);
                no.Add(1);
            }
            noOfChocolates();
            Console.WriteLine($"The {count} {color} is Added to the dispenser");
        }
        static void removeChocolates(int count)
        {
            for (int i = col.Count - 1, j = 0; i > 0 && j < count; j++, i--)
            {
                col.RemoveAt(i);
                no.RemoveAt(i);
            }
            noOfChocolates() ;
            Console.WriteLine($"{count} chocolates are Removed");
        }
        static void dispenseChocolates(int count)
        {
            for (int i = 0; i < count; i++)
            {
                col.RemoveAt(i);
                no.Remove(i);
            }
            noOfChocolates() ;
            Console.WriteLine($"{count} Chocolates are Dispensed");
        }
        static void dispenseChocolatesOfColor(string color, int count)
        {
            for (int i = 0, j = 0; i < col.Count && j < count; i++)
            {
                if ((string)col[i] == color)
                {
                    j++;
                    col.RemoveAt(i);
                    no.RemoveAt(i);
                }
            }
            noOfChocolates() ;
            Console.WriteLine($"{count} {color} Chocolates are dispensed ");
        }
        static void noOfChocolates()
        {
            red_count = 0; green_count = 0;
            purple_count = 0; crimson_count = 0;silver_count = 0;


            for (int i = 0; i < col.Count; i++)
            {
                string str = (string)col[i];

                if ((str.ToLower()).Equals("green"))
                {
                    green_count++;
                }
                if (str.ToLower().Equals("silver"))
                {
                    silver_count++;
                }
                if (str.ToLower().Equals("crimson"))
                {
                    crimson_count++;
                }
                if (str.ToLower().Equals("purple"))
                {
                    purple_count++;
                }
                if (str.ToLower().Equals("red"))
                {
                    red_count++;
                }
            }
            Console.WriteLine($"[{green_count},{silver_count},{crimson_count},{purple_count},{red_count}]");
        }
        static void sortChocolateBasedOnCount()
        {
            noOfChocolates();
            int counter = 0;
            while (counter < 5)
            {
                if (green_count >= silver_count && green_count >= crimson_count && green_count >= purple_count && green_count >= red_count || green_count==0)
                {
                    Console.WriteLine($"Green:{green_count}"); counter++; green_count = 0;
                }
                if (green_count <= silver_count && silver_count >= crimson_count && silver_count >= purple_count && silver_count >= red_count || silver_count==0)
                {
                    Console.WriteLine($"Silver:{silver_count}");counter++; silver_count = 0;
                }
                if (crimson_count >= green_count && silver_count <= crimson_count && crimson_count >= purple_count && crimson_count >= red_count || crimson_count==0)
                {
                    Console.WriteLine($"Crimson:{crimson_count}"); counter++; crimson_count = 0;
                }
                if (green_count <= purple_count && purple_count >= crimson_count && silver_count <= purple_count && purple_count >= red_count || purple_count==0)
                {
                    Console.WriteLine($"Purple:{purple_count}"); counter++; purple_count = 0;
                }
                if (green_count <= red_count && red_count >= crimson_count && silver_count <= red_count && purple_count <= red_count || red_count==0)
                {
                    Console.WriteLine($"Red:{red_count}"); counter++; red_count = 0;
                }
            }
        }
        static void changeChocolateColor(string old_color, string new_color, int count)
        {
            noOfChocolates();
            if (old_color == new_color) { }
            if (old_color != new_color)
            {
                if (old_color == "green" && count <= green_count)
                {
                    for (int i = 0, j = 0; j < count && i < col.Count; i++)
                    {
                        if ((string)col[i] == "green")
                        {
                            col[i] = new_color; j++;
                        }

                    }
                }
                if (old_color == "silver" && count <= silver_count)
                {
                    for (int i = 0, j = 0; j < count && i < col.Count; i++)
                    {
                        if ((string)col[i] == "silver")
                        {
                            col[i] = new_color; j++;

                        }

                    }
                }

                if (old_color == "crimson" && count <= crimson_count)
                {
                    for (int i = 0, j = 0; j < count && i < col.Count;  i++)
                    {
                        if ((string)col[i] == "crimson")
                        {
                            col[i] = new_color;
                            j++;

                        }

                    }
                }
                if (old_color == "purple" && count <= purple_count)
                {
                    for (int i = 0, j = 0; j < count && i < col.Count;  i++)
                    {
                        if ((string)col[i] == "purple")
                        {
                            col[i] = new_color;
                            j++;

                        }

                    }
                }
                if (old_color == "red" && count <= red_count)
                {
                    for (int i = 0, j = 0; j < count && i < col.Count; i++)
                    {
                        if ((string)col[i] == "red")
                        {
                            col[i] = new_color;
                            j++;
                        }

                    }
                }
            }
            noOfChocolates();
            Console.WriteLine($"The {old_color }chocolate is changed to {new_color}");
        }

        static void changeChocolateColorAllOfxCount(string old_color, string new_color)
        {
            if (old_color == "green")
            {
                for (int i = 0; i < col.Count; i++)
                {
                    if ((string)col[i] == "green")
                    {
                        col[i] = new_color;
                    }

                }
            }
            if (old_color == "silver")
            {
                for (int i = 0; i < col.Count; i++)
                {
                    if ((string)col[i] == "silver")
                    {
                        col[i] = new_color;

                    }

                }
            }

            if (old_color == "crimson")
            {
                for (int i = 0; i < col.Count; i++)
                {
                    if ((string)col[i] == "crimson")
                    {
                        col[i] = new_color;

                    }

                }
            }
            if (old_color == "purple")
            {
                for (int i = 0; i < col.Count; i++)
                {
                    if ((string)col[i] == "purple")
                    {
                        col[i] = new_color;

                    }

                }
            }
            if (old_color == "red")
            {
                for (int i = 0; i < col.Count; i++)
                {
                    if ((string)col[i] == "red")
                    {
                        col[i] = new_color;

                    }

                }
            }
            noOfChocolates();
        }

        static void removeChocolateOfColor(string color)
        {
            for (int i = col.Count - 1; i >= 0; i--)
            {
                if ((string)col[i] == color)
                {
                    col.RemoveAt(i);
                    no.RemoveAt(i);
                }
            }
            noOfChocolates() ;
            Console.WriteLine($"The Chocolate is removed from top");
        }

    }
}
