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
        static string message;

        static void Main(string[] args)
        {
            //Initiation du tableau           
            bool[] tabDeplacement = new bool[100];
            int nombreAleatoire = 0;
            Random rnd = new Random();

            ConsoleKeyInfo touche;
            int positionPersonX = 50;
            int cptessais = 0;
            int cptFalse = 0;
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
               

            }
            AfficheEntier(tabDeplacement);
            Console.WriteLine("\n" + "position de Départ de BOB : " + positionPersonX);
            touche = Console.ReadKey(true);
            while (touche.Key != ConsoleKey.Q) 
            {
             
                touche = Console.ReadKey(true);
                switch (touche.Key)
                {

                    case ConsoleKey.A:
                        positionPersonX -= 3;
                        Console.Write("\n" + "position de BOB : " + positionPersonX + " " + tabDeplacement[positionPersonX] + "\n");
                        positionPersonX++;
                        for (int i = 0; i < 4; i++)
                        {
                            positionPersonX++;
                            if (tabDeplacement[positionPersonX] == false)
                            {
                                cptFalse++;
                                if (cptFalse == 4)
                                {
                                    Console.Write("imposible d'avancer!!!");
                                    cptFalse = 0;
                                }
                            }
                        }
                        break;
                    case ConsoleKey.S:
                        positionPersonX -= 2;
                        Console.Write("\n" + "position de BOB : " + positionPersonX + " " + tabDeplacement[positionPersonX] + "\n");
                        positionPersonX++;
                        for (int i = 0; i < 4; i++)
                        {
                            positionPersonX++;
                            if (tabDeplacement[positionPersonX] == false)
                            {
                                cptFalse++;
                                if (cptFalse == 4)
                                {
                                    Console.Write("imposible d'avancer!!!");
                                    cptFalse = 0;
                                }
                            }
                        }
                        break;
                    case ConsoleKey.D:
                        positionPersonX -= 1;
                        Console.Write("\n" + "position de BOB : " + positionPersonX + " " + tabDeplacement[positionPersonX] + "\n");
                        for (int i = 0; i < 4; i++)
                        {
                            positionPersonX++;
                            if (tabDeplacement[positionPersonX] == false)
                            {
                                cptFalse++;
                                if (cptFalse == 4)
                                {
                                    Console.Write("imposible d'avancer!!!");
                                    cptFalse = 0;
                                }
                            }
                        }
                        break;
                    case ConsoleKey.G:
                        positionPersonX += 2;
                        Console.Write("\n" + "position de BOB : " + positionPersonX + " " + tabDeplacement[positionPersonX] + "\n");
                        for(int i = 0; i < 4;i++)
                        {
                            positionPersonX++;
                            if(tabDeplacement[positionPersonX] == false)
                            {
                                cptFalse++;
                                if (cptFalse == 4)
                                {
                                    Console.Write("imposible d'avancer!!!");
                                    cptFalse = 0;
                                }
                            }
                        }
                        break;
                    case ConsoleKey.H:
                        positionPersonX += 4;
                        Console.Write("\n" + "position de BOB : " + positionPersonX + " " + tabDeplacement[positionPersonX] + "\n");
                        for (int i = 0; i < 4; i++)
                        {
                            positionPersonX++;
                            if (tabDeplacement[positionPersonX] == false)
                            {
                                cptFalse++;
                                if (cptFalse == 4)
                                {
                                    Console.Write("imposible d'avancer!!!");
                                    cptFalse = 0;
                                }
                            }
                        }
                        break;
                    case ConsoleKey.Enter:
                        Console.WriteLine();
                        break;
                    case ConsoleKey.P:
                        Affichage10(tabDeplacement, positionPersonX);
                        break;
                }
                cptessais++;
            } 
            
                Console.Clear();
                Console.Write("\n" + "Nombre d'essais: " + cptessais);
                Console.Write("\n" + "Fin de partie!!!");
                Console.ReadLine();
            
        }


        static void AfficheEntier(bool[] tabDeplacement)
        {

            for (int i = 0; i < tabDeplacement.Length; i++)
            {
                Console.Write(" " + i + " " + tabDeplacement[i] + " ");
            }
        }
            static void Affichage10(bool[] tabDeplacement,int positionPersonX)
            {
            for (int i = positionPersonX + 1; i < positionPersonX + 11; i++)
             {
                 if (i <= tabDeplacement.Length)
                   {
                     Console.Write(tabDeplacement[i] + "\n ");                                      }
                 }

        }


    }
    }



 

                  
                        
                       
               
        