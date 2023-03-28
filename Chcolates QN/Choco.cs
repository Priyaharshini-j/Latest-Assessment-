using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorChocolates
{
    internal class Choco
    {
        public static ArrayList col = new ArrayList();
        public static ArrayList no = new ArrayList();
        public static int green_count = 0, silver_count = 0, crimson_count = 0, purple_count = 0, red_count = 0;
        static void Main(string[] args)
        {
            int choice = 0;
            Console.WriteLine("Enter the choice of yours:");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                string color = "";
                int count = 0;
                Console.WriteLine("Enter the color of Chocolate you want to add:");
                color = Console.ReadLine();
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
            if (choice == 3) {

                int count = 0;
                Console.WriteLine($"Enter the No of Chocolate you want to add:");
                count = Convert.ToInt32(Console.ReadLine());
                dispenseChocolates(count); 
            }
            if (choice == 4)
            {
                string color = "";
                int count = 0;
                Console.WriteLine("Enter the color of Chocolate you want to add:");
                color = Console.ReadLine();
                Console.WriteLine($"Enter the No of {color}Chocolate you want to add:");
                count = Convert.ToInt32(Console.ReadLine());
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
            if (choice == 7) {
                Console.WriteLine("Enter the color of Chocolate you want to change:");
                string old_color = Console.ReadLine();
                Console.WriteLine("Enter the new color of Chocolate you want to add:");
                string new_color = Console.ReadLine();
                int count = 0;
                Console.WriteLine($"Enter the No of Chocolate you want to add:");
                count = Convert.ToInt32(Console.ReadLine());
                changeChocolateColor(old_color,new_color,count); 
            }
            if (choice == 8) {
                Console.WriteLine("Enter the color of Chocolate you want to change:");
                string old_color = Console.ReadLine();
                Console.WriteLine("Enter the new color of Chocolate you want to add:");
                string new_color = Console.ReadLine();
                changeChocolateColorAllOfxCount(old_color,new_color); 
            }
            if (choice == 9) {
                Console.WriteLine("Enter the color of Chocolate you want to remove from top:");
                string color = Console.ReadLine();
                removeChocolateOfColor(color); }
            /*if (choice == 10) { 
                dispenseRainbowChocolates(); }*/
        }
        static void addChocolates(string color, int count)
        {
            for(int i=1; i<count; i++) {
                col.Add(color);
                no.Add(1);
            }
            Console.WriteLine("Added");
        }
        static void removeChocolates(int count)
        {
            for(int i=col.Count-1; i > (col.Count - count); i--)
            {
                col.RemoveAt(i);
                no.RemoveAt(i);
            }
            Console.WriteLine("Removed");
        }
        static void dispenseChocolates(int count)
        {
            for(int i=0; i<count; i++)
            {
                col.RemoveAt(i);
                no.Remove(i);
            }
            Console.WriteLine("Dispensed");
        }
        static void DispenseChocolateOfColor(string color, int count)
        {
            for(int i = 0,j=0; i < col.Length && j<count ; i++,j++)
            {
                if (col[i] == color)
                {
                    col.RemoveAt(i);
                    no.RemoveAt(i);
                }
            }
            Console.WriteLine("Dispensed Color of Chocolates");
        }
        static void noOfChocolates()
        {
            
            for (int i = 0; i < col.Count; i++)
            {
                string str = col[i];
               
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
            if(green_count>=silver_count && green_count>=crimson_count && green_count>=purple_count && green_count>= red_count)
            {
                Console.WriteLine($"Green:{green_count}")
            }
            if (green_count <= silver_count && silver_count >= crimson_count && silver_count >= purple_count && silver_count >= red_count)
            {
                Console.WriteLine($"Silver:{silver_count}")
            }
            if (crimson_count >= green_count && silver_count <= crimson_count && crimson_count >= purple_count && crimson_count >= red_count)
            {
                Console.WriteLine($"Crimson:{crimson_count}")
            }
            if (green_count <= purple_count && purple_count >= crimson_count && silver_count <= purple_count && purple_count >= red_count)
            {
                Console.WriteLine($"Purple:{purple_count}")
            }
            if (green_count <= red_count && red_count >= crimson_count && silver_count <= red_count && purple_count <= red_count)
            {
                Console.WriteLine($"Red:{red_count}")
            }
        }
        static void changeChocolateColor(strinng old_color,string new_color,int count)
        {
            noOfChocolates();
            if (old_color == new_color) { }
            if (old_color != new_color)
            {
                if (old_color == "green" && count <= green_count) {
                    for (int i = 0,j=0,j<count && i< col.Count; j++,i++)
                    {
                        if (col[i] == "green")
                        {
                            col[i] = new_color;
                        }

                    }
                }
                if (old_color == "silver" && count <= silver_count)
                {
                    for (int i = 0,j=0,j<count && i< col.Count;j++, i++)
                    {
                        if (col[i] == "silver")
                        {
                            col[i] = new_color;

                        }

                    }
                }

                if (old_color == "crimson" && count <= crimson_count)
                {
                    for (int i = 0, j=0 ,j<count && i< col.Count; j++, i++)
                    {
                        if (col[i] == "crimson")
                        {
                            col[i] = new_color;

                        }

                    }
                }
                if (old_color == "purple" && count <= purpler_count)
                {
                    for (int i = 0, j=0 ,j<count && i< col.Count; j++ ,i++)
                    {
                        if (col[i] == "purple")
                        {
                            col[i] = new_color;

                        }

                    }
                }
                if (old_color == "red" && count <= red_count)
                {
                    for (int i = 0 , j=0 , j< count && i< col.Count; j++, i++)
                    {
                        if (col[i] == "red")
                        {
                            col[i] = new_color;

                        }

                    }
                }
            }

        }
        static void changeChocolateColorAllOfxCount(string old_color,string new_color)
        {
            if (old_color == "green" ) {
                    for (int i = 0, i< col.Count ; i++)
                    {
                        if (col[i] == "green")
                        {
                            col[i] = new_color;
                        }

                    }
                }
                if (old_color == "silver")
                {
                    for (int i = 0, i< col.Count; i++)
                    {
                        if (col[i] == "silver")
                        {
                            col[i] = new_color;

                        }

                    }
                }

                if (old_color == "crimson" )
                {
                    for (int i = 0, i< col.Count; i++)
                    {
                        if (col[i] == "crimson")
                        {
                            col[i] = new_color;

                        }

                    }
                }
                if (old_color == "purple")
                {
                    for (int i = 0, i< col.Count; i++)
                    {
                        if (col[i] == "purple")
                        {
                            col[i] = new_color;

                        }

                    }
                }
                if (old_color == "red")
                {
                    for (int i = 0, i< col.Count; i++)
                    {
                        if (col[i] == "red")
                        {
                            col[i] = new_color;

                        }

                    }
                }
            noOfChocolates();
        }
        static void removeChocolateOfColor(string color)
        {
            for(int i = col.Count - 1; i >= 0; i--)
            {
                if (col[i] == color)
                {
                    col.RemoveAt(i);
                    no.RemoveAt(i);
                    break;
                }
            }
            Console.WriteLine($"The Chocolate is removed from top");
        }

    }
}
