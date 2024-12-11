namespace combatdeboxe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriu el nom del primer boxejador:");
            string nom1 = Console.ReadLine();
            Console.WriteLine("Escriu la resistencia que tindrà el primer boxejador:");
            int resistencia1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriu el nom del segon boxejador:");
            string nom2 = Console.ReadLine();
            Console.WriteLine("Escriu la resistencia que tindrà el segon boxejador:");
            int resistencia2 = int.Parse(Console.ReadLine());

            var jugador1 = new boxejadors(nom1, resistencia1);
            var jugador2 = new boxejadors(nom2, resistencia2);

            var combat = new combat(jugador1, jugador2);

            bool combatFinalitzat = false;
            while (!combatFinalitzat)
            {
                combatFinalitzat = combat.RealitzarElTorn(jugador1, jugador2);

                if (combatFinalitzat) break;

                combatFinalitzat = combat.RealitzarElTorn(jugador2, jugador1);
            }

            Console.WriteLine("Combat finalitzat!");
        }
    }
}