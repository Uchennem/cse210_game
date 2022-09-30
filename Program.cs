// Program: CSE 210 Tic Tac Toe
// Author: Uche Oranye
using System;
using System.Collections.Generic;

namespace cse210_student_csharp_tictactoe_complete
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            int count = 1;
            bool gameRunning = true;
            string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };    
            List<string> gameNumbs = new List<string>(numbers);
            
            void CallBoard()
            {
                Console.WriteLine($"{gameNumbs[0]}|{gameNumbs[1]}|{gameNumbs[2]}");
                Console.WriteLine("-+-+-");
                Console.WriteLine($"{gameNumbs[3]}|{gameNumbs[4]}|{gameNumbs[5]}");
                Console.WriteLine("-+-+-");
                Console.WriteLine($"{gameNumbs[6]}|{gameNumbs[7]}|{gameNumbs[8]}");
            }
            
            void UserXInput()
            {
                if (count%2 != 0)
                {
                    Console.Write("X's turn to choose a square (1-9): ");
                    string userInput = Console.ReadLine();
                    int number = int.Parse(userInput);
                    if ((string.Compare((gameNumbs[number-1]),"O") < 0) || (string.Compare((gameNumbs[number-1]),"O") > 0))
                        {
                            gameNumbs[number-1] = "X";
                        }
                    else
                    {
                        Console.WriteLine("Player is already in that spot!");
                    }
                }

                else
                {
                    Console.Write("O's turn to choose a square (1-9): ");
                    string userInput = Console.ReadLine();
                    int number = int.Parse(userInput);
                    if ((string.Compare((gameNumbs[number-1]),"X") < 0) || (string.Compare((gameNumbs[number-1]),"X") > 0))
                        {
                            gameNumbs[number-1] = "O";
                        }
                    else
                    {
                        Console.WriteLine("Player is already in that spot!");
                    }
                }
            }

            // check for winner or tie 

            void CheckWinner ()
            // check rows
            {
                if ((string.Compare(gameNumbs[0], gameNumbs[1]) == 0) && (string.Compare(gameNumbs[0], gameNumbs[2]) == 0))
                            {
                                string winner = gameNumbs[0];
                                Console.WriteLine($"The winner is {winner}");
                                gameRunning = false;
                            }
                else if ((string.Compare(gameNumbs[3], gameNumbs[4]) == 0) && (string.Compare(gameNumbs[3], gameNumbs[5]) == 0))
                            {
                                string winner = gameNumbs[3];
                                Console.WriteLine($"The winner is {winner}");
                                gameRunning = false;
                            }
                else if ((string.Compare(gameNumbs[6], gameNumbs[7]) == 0) && (string.Compare(gameNumbs[6], gameNumbs[8]) == 0))
                            {
                                string winner = gameNumbs[6];
                                Console.WriteLine($"The winner is {winner}");
                                gameRunning = false;
                            }

                // check columns
                else if ((string.Compare(gameNumbs[0], gameNumbs[3]) == 0) && (string.Compare(gameNumbs[0], gameNumbs[6]) == 0))
                            {
                                string winner = gameNumbs[0];
                                Console.WriteLine($"The winner is {winner}");
                                gameRunning = false;
                            }
                else if ((string.Compare(gameNumbs[1], gameNumbs[4]) == 0) && (string.Compare(gameNumbs[1], gameNumbs[7]) == 0))
                            {
                                string winner = gameNumbs[1];
                                Console.WriteLine($"The winner is {winner}");
                                gameRunning = false;
                            }
                else if ((string.Compare(gameNumbs[2], gameNumbs[5]) == 0) && (string.Compare(gameNumbs[2], gameNumbs[8]) == 0))
                            {
                                string winner = gameNumbs[2];
                                Console.WriteLine($"The winner is {winner}");
                                gameRunning = false;
                            }

                
                // check diagonals
                else if ((string.Compare(gameNumbs[0], gameNumbs[4]) == 0) && (string.Compare(gameNumbs[0], gameNumbs[8]) == 0))
                            {
                                string winner = gameNumbs[0];
                                Console.WriteLine($"The winner is {winner}");
                                gameRunning = false;
                            }
                else if ((string.Compare(gameNumbs[2], gameNumbs[4]) == 0) && (string.Compare(gameNumbs[2], gameNumbs[6]) == 0))
                            {
                                string winner = gameNumbs[2];
                                Console.WriteLine($"The winner is {winner}");
                                gameRunning = false;
                            }
            }
            
            // Check for tie
            void CheckTie()
            {
                if (count == 9)
                    {
                        Console.WriteLine("It's a tie");
                        gameRunning = false;  
                    }
            }

        while (gameRunning == true) 
        {
            CallBoard();
            UserXInput();
            CheckWinner();
            CheckTie();
            count ++;
        }

        }

            
        
    }
}