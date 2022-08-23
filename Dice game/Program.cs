using System;

namespace Dice_game
{
        static void Main(string[] args)
    {
        //mängus osaleb kaks mängijat: arvuti  ja kasutaja;
        //mõlemad mängijad viskavad täringuid;
        //programm kontrollib kumb mängija viskas rohkem;
        //mängija, kes viskas rohkem, on mängu võitja;
        //*täringuid visatakse kolm korda;
        //programm kuulutab välja võitja.

        Random rnd = new Random();

        int cpuScore = 0;
        int userScore = 0;

        for (int i = 0; i < 3; i++)
        {
            int cpuRandom = rnd.Next(1, 7);
            int userRandom = rnd.Next(1, 7);
            cpuScore = cpuScore + cpuRandom;
            userScore = userScore + userRandom;
            Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");
        }
        if (cpuScore < userScore)
        {
            Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
            userScore = userScore + 1;
        }
        else if (cpuScore > userScore)
        {
            Console.WriteLine("Arvuti on mängu võitnud!");
            cpuScore = cpuScore + 1;
        }
        else
        {
            Console.WriteLine("Viik!");
        }
    }
}
}