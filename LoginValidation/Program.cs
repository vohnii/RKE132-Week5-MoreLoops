using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on "Kasutaja" ja sisestatud salasõna on "Parool1"
            //siis kuvab konsool "Tere tulemast!"
            //muul juhul kuvab konsool "Vale kasutajatunnus või salasõna! Proovi uuesti!"
            //kasutajal on 3 katset;

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPassword = Console.ReadLine();

                if (userName == "Kasutaja" && userPassword == "Parool1")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale kasutajatunnus või salasõna! {3 - i} katset on jäänud. Proovi uuesti!");
                }
            }
        }
    }
}