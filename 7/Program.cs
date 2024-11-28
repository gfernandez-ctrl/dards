class dards
{
    static void Main()
    {
        Random rnd = new Random();
        int dards = rnd.Next(0, 8);

        int jugador1 = 0;
        int jugador2 = 0;

        int[,] diana =
        {
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 1, 1, 1, 1, 1, 1, 1, 0 },
            { 0, 1, 2, 2, 2, 2, 2, 1, 0},
            {0, 1, 2, 5, 5, 5, 2, 1, 0},
            {0, 1, 2, 5, 10, 5, 2, 1, 0},
            {0, 1, 2, 5, 5, 5, 2, 1, 0},
            { 0, 1, 2, 2, 2, 2, 2, 1, 0},
            { 0, 1, 1, 1, 1, 1, 1, 1, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        };
        while (jugador1 < 50 && jugador2 < 50)
        {
            var x1 = rnd.Next(0, 8);
            var y1 = rnd.Next(0, 8);
            var punts1 =diana[x1, y1];
            int PuntsJugador1 = jugador1 + punts1;
            Console.WriteLine("El jugador 1 tira a" + diana[x1, y1] + " - " + PuntsJugador1 + "punts");
            jugador1 = jugador1 + punts1;
            
            var x2 = rnd.Next(0, 8);
            var y2 = rnd.Next(0, 8);
            var punts2 =diana[x2, y2];
            int PuntsJugador2 = jugador2 + punts2;
            Console.WriteLine("El jugador 2 tira a" + diana[x2, y2] + " - " + PuntsJugador2 + "punts");
            jugador2 = jugador2 + punts2;
        }

        if (jugador1 == jugador2)
        {
            var x1 = rnd.Next(0, 8);
            var y1 = rnd.Next(0, 8);
            var punts1 =diana[x1, y1];
            int PuntsJugador1 = jugador1 + punts1;
            Console.WriteLine("El jugador 1 tira a" + diana[x1, y1] + " - " + PuntsJugador1 + "punts");
            jugador1 = jugador1 + punts1;
            
            var x2 = rnd.Next(0, 8);
            var y2 = rnd.Next(0, 8);
            var punts2 =diana[x2, y2];
            int PuntsJugador2 = jugador2 + punts2;
            Console.WriteLine("El jugador 2 tira a" + diana[x2, y2] + " - " + PuntsJugador2 + "punts");
            jugador2 = jugador2 + punts2;
        }

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