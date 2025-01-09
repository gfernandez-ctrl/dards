using System;

class Dards
{
    static void Main()
    {
        PlayGame();
    }

    public static void PlayGame()
    {
        
        var nw = new si();
        Random rnd = new Random();
        int[,] diana = nw.InitializeDiana();

        
        
        int jugador1 = 0;
        int jugador2 = 0;

        while (jugador1 < 50 && jugador2 < 50)
        {
            jugador1 = nw.PlayerTurn(rnd, diana, jugador1, 1);
            jugador2 = nw.PlayerTurn(rnd, diana, jugador2, 2);
        }

        if (jugador1 == jugador2)
        {
            jugador1 = nw.PlayerTurn(rnd, diana, jugador1, 1);
            jugador2 = nw.PlayerTurn(rnd, diana, jugador2, 2);
        }

        nw.DeclareWinner(jugador1, jugador2);
    }

    public class si
    {
        public int[,] InitializeDiana()
        {
            return new int[,]
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 1, 1, 1, 1, 1, 1, 0 },
                { 0, 1, 2, 2, 2, 2, 2, 1, 0},
                { 0, 1, 2, 5, 5, 5, 2, 1, 0 },
                { 0, 1, 2, 5, 10, 5, 2, 1, 0 },
                { 0, 1, 2, 5, 5, 5, 2, 1, 0 },
                { 0, 1, 2, 2, 2, 2, 2, 1, 0 },
                { 0, 1, 1, 1, 1, 1, 1, 1, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            };
        }

        public int PlayerTurn(Random rnd, int[,] diana, int currentScore, int playerNumber)
        {
            int x = rnd.Next(0, 8);
            int y = rnd.Next(0, 8);
            int points = diana[x, y];
            currentScore += points;
            Console.WriteLine($"El jugador {playerNumber} tira a {points} - {currentScore} punts");
            return currentScore;
        }

        public void DeclareWinner(int jugador1, int jugador2)
        {
            if (jugador1 > jugador2)
            {
                Console.WriteLine("Ha guanyat el jugador 1.");
            }
            else
            {
                Console.WriteLine("Ha guanyat el jugador 2.");
            }
        }
    }

   
}