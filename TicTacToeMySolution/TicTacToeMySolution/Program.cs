using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeMySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] gameMatrix =
            {
                {"1", "2", "3" },
                {"4", "5", "6" },
                {"7", "8", "9" }
            };

            bool player1Wins = false, player2Wins = false;
            bool playerTurn = false;
            while(!player1Wins || !player2Wins)
            {
                if(!CheckGameArray(gameMatrix).Equals("noWinner"))
                {
                    player1Wins = CheckGameArray(gameMatrix).Equals("X") ? true : player2Wins = true;
                    if (player1Wins) {
                        Console.WriteLine("Player 1 wins");
                        break;
                    }
                    Console.WriteLine("Player 2 wins");
                    break;
                }
                Console.Clear();
                displayGameEz(gameMatrix);
                Console.Write("Player {0} - Choose your field: ", playerTurn ? "2" : "1");
                string value = Console.ReadLine();
                int valueParsed = -1;
                bool success = Int32.TryParse(value, out valueParsed);
                if(valueParsed > 9)
                {
                    Console.WriteLine("Please input a number from the ones in the chart");
                    continue;
                }
                if(success)
                {
                    gameMatrix = returnArrayChanged(gameMatrix, valueParsed, playerTurn);
                } else if((!success))
                {
                    Console.WriteLine("Please input a number from the ones in the chart");
                }
                playerTurn = playerTurn == false ? true : false;

            }
            


            Console.ReadKey();
        }
        
        public static string[,] returnArrayChanged(string[,] gameMatrix, int value, bool player)
        {
            for(int i = 0; i<= gameMatrix.Rank; i++)
            {
                for(int j = 0; j < gameMatrix.Length/3; j++)
                {
                    gameMatrix[i, j] = gameMatrix[i, j].Equals(value.ToString()) ? (player ? "O" : "X") : gameMatrix[i, j];
                }
            }
            return gameMatrix;
        }


        public static string CheckGameArray(string[,] gameMatrix)
        {
            string winner = "noWinner";
            if (gameMatrix[0, 0].Equals("X") && gameMatrix[0, 1].Equals("X") && gameMatrix[0, 2].Equals("X") ||
                gameMatrix[1, 0].Equals("X") && gameMatrix[1, 1].Equals("X") && gameMatrix[1, 2].Equals("X") ||
                gameMatrix[2, 0].Equals("X") && gameMatrix[2, 1].Equals("X") && gameMatrix[2, 2].Equals("X") ||
                gameMatrix[0, 0].Equals("X") && gameMatrix[0, 1].Equals("X") && gameMatrix[0, 2].Equals("X") ||
                gameMatrix[1, 0].Equals("X") && gameMatrix[1, 1].Equals("X") && gameMatrix[1, 2].Equals("X") ||
                gameMatrix[2, 2].Equals("X") && gameMatrix[1, 1].Equals("X") && gameMatrix[0, 0].Equals("X") ||
                gameMatrix[0, 0].Equals("X") && gameMatrix[1, 1].Equals("X") && gameMatrix[2, 2].Equals("X")
                )
                {
                    winner = "X"; 
                }
            if (gameMatrix[0, 0].Equals("O") && gameMatrix[0, 1].Equals("O") && gameMatrix[0, 2].Equals("O") ||
                gameMatrix[1, 0].Equals("O") && gameMatrix[1, 1].Equals("O") && gameMatrix[1, 2].Equals("O") ||
                gameMatrix[2, 0].Equals("O") && gameMatrix[2, 1].Equals("O") && gameMatrix[2, 2].Equals("O") ||
                gameMatrix[0, 0].Equals("O") && gameMatrix[0, 1].Equals("O") && gameMatrix[0, 2].Equals("O") ||
                gameMatrix[1, 0].Equals("O") && gameMatrix[1, 1].Equals("O") && gameMatrix[1, 2].Equals("O") ||
                gameMatrix[2, 2].Equals("O") && gameMatrix[1, 1].Equals("O") && gameMatrix[0, 0].Equals("O") ||
                gameMatrix[0, 0].Equals("O") && gameMatrix[1, 1].Equals("O") && gameMatrix[2, 2].Equals("O")
                )
                {
                    winner = "O";
                }
            return winner;
        }



        public static void displayGameEz(string[,] gameMatrix)
        {
            bool start = true, middle = false, end = false;

            for(int i = 0, j = 0; j<=gameMatrix.Rank; j++)
            {
                // was trying to be dynamic somehow but just overcomplicated this and left it in the dust
                //Console.WriteLine(gameMatrix.Rank);
                if(i == gameMatrix.Length)
                {
                    i = 0;
                    continue;
                }
                if(start)
                {
                    Console.WriteLine("   |   |   ");
                    Console.WriteLine(" {0} | {1} | {2} ", gameMatrix[j, i], gameMatrix[j, i+1], gameMatrix[j, i+2]);
                    Console.WriteLine("___|___|___");
                    start = false;
                    middle = true;
                }else if(middle)
                {
                    Console.WriteLine("   |   |   ");
                    Console.WriteLine(" {0} | {1} | {2} ", gameMatrix[j, i], gameMatrix[j, i+1], gameMatrix[j, i+2]);
                    Console.WriteLine("___|___|___");
                    middle = false;
                    end = true;
                }else if(end)
                {
                    Console.WriteLine("   |   |   ");
                    Console.WriteLine(" {0} | {1} | {2} ", gameMatrix[j, i], gameMatrix[j, i+1], gameMatrix[j, i+2]);
                    Console.WriteLine("   |   |   ");
                }
            }
        }




        
    }
}
