using System;
using System.Collections.Generic;


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
            bool main = true;
            
                while (main)
                {
               
                    Console.Clear();
                    int knightX = 1;
                    int knitghY = 1;
                    int stepp = 0;
                    Dictionary<int, (int X, int Y)> used = new Dictionary<int, (int X, int Y)>();
                    used.Add(stepp, (knightX, knitghY));
                    bool run = true;
                    while (run)
                    {
                    try
                    {
                        for (int y = 0; y < 9; y++)
                        {
                            for (int x = 0; x < 9; x++)
                            {
                                Console.Write(board(x, y, used, knightX, knitghY));
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


                        if (NewTest(NewX, NewY, used))
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
                            used.Add(stepp, (knightX, knitghY));
                        }
                        catch (Exception ex)
                        {

                        }
                        bool pos1 = false;
                        bool pos2 = false;
                        bool pos3 = false;
                        bool pos4 = false;
                        bool pos5 = false;
                        bool pos6 = false;
                        bool pos7 = false;
                        bool pos8 = false;
                        foreach (var z in used)
                        {
                            if (z.Value.X == knightX + 2 && z.Value.Y == knitghY - 1 || 1 > knightX + 2 || 1 > knitghY - 1 || 8 < knightX + 2 || 8 < knitghY - 1)
                            {
                                pos1 = true;
                            }
                            if (z.Value.X == knightX + 2 && z.Value.Y == knitghY + 1 || 1 > knightX + 2 || 1 > knitghY + 1 || 8 < knightX + 2 || 8 < knitghY + 1)
                            {
                                pos2 = true;
                            }
                            if (z.Value.X == knightX - 2 && z.Value.Y == knitghY - 1 || 1 > knightX - 2 || 1 > knitghY - 1 || 8 < knightX - 2 || 8 < knitghY - 1)
                            {
                                pos3 = true;
                            }
                            if (z.Value.X == knightX - 2 && z.Value.Y == knitghY + 1 || 1 > knightX - 2 || 1 > knitghY + 1 || 8 < knightX - 2 || 8 < knitghY + 1)
                            {
                                pos4 = true;
                            }
                            if (z.Value.X == knightX + 1 && z.Value.Y == knitghY - 2 || 1 > knightX + 1 || 1 > knitghY - 2 || 8 < knightX + 1 || 8 < knitghY - 2)
                            {
                                pos5 = true;
                            }
                            if (z.Value.X == knightX - 1 && z.Value.Y == knitghY - 2 || 1 > knightX - 1 || 1 > knitghY - 2 || 8 < knightX - 1 || 8 < knitghY - 2)
                            {
                                pos6 = true;
                            }
                            if (z.Value.X == knightX + 1 && z.Value.Y == knitghY + 2 || 1 > knightX + 1 || 1 > knitghY + 2 || 8 < knightX + 1 || 8 < knitghY + 2)
                            {
                                pos7 = true;
                            }
                            if (z.Value.X == knightX - 1 && z.Value.Y == knitghY + 2 || 1 > knightX - 1 || 1 > knitghY + 2 || 8 < knightX - 1 || 8 < knitghY + 2)
                            {
                                pos8 = true;
                            }
                        }

                        if (pos1 && pos2 && pos3 && pos4 && pos5 && pos6 && pos7 && pos8)
                        {
                            Console.WriteLine("Out of posible steps. Try agin.");
                            Console.ReadLine();
                            run = false;
                        }
                    }
                catch (Exception ex)
                {
                    Console.WriteLine("Only number imputs allowed.");
                    Console.ReadLine();
                }

            }
                
            }
            
            
              
            
            
        }
    }
}
