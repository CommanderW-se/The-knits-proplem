using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_knits_proplem
{
    internal class Program
    {
        static string board(int x, int y, Dictionary<int, (int X, int Y)> used, int knightX, int knightY)
        {
            string block = "* ";
            foreach (var z in used)
            {
                if (y == 0 && x == 0)
                {
                    block = $"# ";
                }
                else if (y == 0)
                {
                    block = $"{x} ";
                }
                else if (x == 0)
                {
                    block = $"{y} ";
                }
                else if (x == knightX && y == knightY)
                {
                    block = "K ";
                }
                else if (z.Value.X == x && z.Value.Y == y)
                {
                    block = $"{z.Key} ";
                }
            }
            return block;
        }
        static bool NewTest(int NewX, int NewY,Dictionary<int, (int X, int Y)> used)
        {
            bool back = true;
            string massige = "";
            foreach (var g in used)
            {
                if (NewX < 1 || NewX > 8)
                {
                    massige = "Out of bounds!";
                    back = false;
                }
                else if (NewY < 1 || NewY > 8)
                {
                    massige = "Out of bounds!";
                    back = false;
                }
                else if (NewX == g.Value.X && NewY == g.Value.Y)
                {
                    massige= "Been used.";
                    back = false;
                }
                
                
            }
            Console.WriteLine(massige);
            return back;
        }
        static void Main(string[] args)
        {
            int knightX = 1;
            int knitghY = 1;
            int stepp = 0;
            Dictionary<int,(int X, int Y)> used = new Dictionary<int, (int X, int Y)>();
            used.Add(stepp, ( knightX, knitghY));
            bool run = true;
            while (run)
            {
                for (int y = 0; y < 9; y++)
                {
                    for (int x = 0; x < 9; x++)
                    {
                        Console.Write(board(x,y,used, knightX, knitghY));
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Nex step: ");
                Console.Write("X cordinat: ");
                int NewX = Convert.ToInt32(Console.ReadLine());
                Console.Write("Y cordinat: ");
                int NewY = Convert.ToInt32(Console.ReadLine());


                if (NewTest(NewX,NewY,used))
                {
                    if (NewX == knightX + 2 && NewY == knitghY - 1)
                    {
                        knightX = NewX;
                        knitghY = NewY;
                        stepp += 1;
                    }
                    else if (NewX == knightX + 2 && NewY == knitghY + 1)
                    {
                        knightX = NewX;
                        knitghY = NewY;
                        stepp += 1;
                    }
                    else if (NewX == knightX - 2 && NewY == knitghY - 1)
                    {
                        knightX = NewX;
                        knitghY = NewY;
                        stepp += 1;
                    }
                    else if (NewX == knightX - 2 && NewY == knitghY + 1)
                    {
                        knightX = NewX;
                        knitghY = NewY;
                        stepp += 1;
                    }
                    else if (NewX == knightX + 1 && NewY == knitghY - 2)
                    {
                        knightX = NewX;
                        knitghY = NewY;
                        stepp += 1;
                    }
                    else if (NewX == knightX - 1 && NewY == knitghY - 2)
                    {
                        knightX = NewX;
                        knitghY = NewY;
                        stepp += 1;
                    }
                    else if (NewX == knightX + 1 && NewY == knitghY + 2)
                    {
                        knightX = NewX;
                        knitghY = NewY;
                        stepp += 1;
                    }
                    else if (NewX == knightX - 1 && NewY == knitghY + 2)
                    {
                        knightX = NewX;
                        knitghY = NewY;
                        stepp += 1;
                    }
                    else
                    {
                        Console.WriteLine("Invalid step.");
                    }
                }

                try
                {
                    used.Add(stepp, ( knightX, knitghY));
                }catch (Exception ex)
                {
                    
                }
                
            }  
            
            
        }
    }
}
