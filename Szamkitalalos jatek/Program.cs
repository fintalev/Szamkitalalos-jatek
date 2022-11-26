using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamkitalalos_jatek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {

                Random random = new Random();
                
                int min = 1;
                int max = 100;
                int tipp;
                int szam;
                int tippek;
                

                
                
                    tipp = 0;
                    tippek = 0;
                    szam = random.Next(min, max + 1);

                    while (tipp != szam)
                    {
                        Console.Write($"Tippelj egy számra {min} és {max} között :");
                        tipp = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Tipp: " + tippek);

                        if (tipp > szam)
                        {
                            Console.WriteLine(tipp + " túl nagy!");

                        }
                        else if (tipp < szam)
                        {
                            Console.WriteLine(tipp + " túl kicsi!");
                        }
                        tippek++;
                    }
                    Console.WriteLine("A szám: " + szam);
                    Console.WriteLine("NYERTÉL!!");
                    Console.WriteLine("Tippek száma: " + tippek);

                    Console.WriteLine("Szeretnél újra játszani?  (I=igen  ,  N=nem):  ");
                
            } while (Console.ReadLine().ToUpper() == "I");

            Console.WriteLine("Viszlát!");
            System.Environment.Exit(0);





            Console.ReadKey();


            }
        }
    }

