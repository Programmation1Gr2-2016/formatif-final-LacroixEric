using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Eric Lacroix
//29-11-2016
//ExamenFormatif3 Question 5 Programme déplacement personnage

namespace ExamenFormatif3
{
    class Program
    {

        static void Main(string[] args)
        {
            //Initiation du tableau           
            bool[] tabDeplacement = new bool[100];
            int nombreAleatoire = 0;
            Random rnd = new Random();



            ConsoleKeyInfo touche;
            int positionPersonX = 0;

            //Création du tableau
           
            for (int i = 0; i < tabDeplacement.Length; i++)
            {
                nombreAleatoire = rnd.Next(0, 2);
                if (nombreAleatoire == 1)
                {
                    tabDeplacement[i] = true;
                }
                else
                {
                    tabDeplacement[i] = false;
                }
                tabDeplacement[0] = true;
                tabDeplacement[99] = true;
                Console.Write(" " + i + " " + tabDeplacement[i] + " ");

            }

            Console.WriteLine("\n" + "position de Départ de BOB : " + positionPersonX);
            touche = Console.ReadKey(true);
            while (touche.Key != ConsoleKey.Q) 
            {
             
                touche = Console.ReadKey(true);
                switch (touche.Key)
                {
                      
                    case ConsoleKey.A:
                        positionPersonX -= 3;
                        Console.Write("\n" + "position de BOB : " + tabDeplacement[positionPersonX]);

                        break;
                    case ConsoleKey.S:
                        positionPersonX -= 2;
                        Console.Write("\n" + "position de BOB : " + positionPersonX);
                        break;
                    case ConsoleKey.D:
                        positionPersonX -= 1;
                        Console.Write("\n" + "position de BOB : " + positionPersonX);
                        break;
                    case ConsoleKey.G:
                        positionPersonX += 2;
                        //Console.Write("\n" + "position de BOB : " + positionPersonX);
                        Console.Write("\n" + "position de BOB : " + positionPersonX + " " + tabDeplacement[positionPersonX] + "\n");
                        break;
                    case ConsoleKey.H:
                        positionPersonX += 4;
                        Console.Write("\n" + "position de BOB : " + positionPersonX);
                        break;
                    case ConsoleKey.Enter:
                        Console.WriteLine();
                        break;
                }

            } 
            
                Console.Clear();
                Console.Write("\n" + "Fin de partie!!!");
                Console.ReadLine();
            
        }


            static void AfficheEntier(bool [] tabDeplacement,)
        {
               

               

            }
        }
    }



 

                  
                        
                       
               
        