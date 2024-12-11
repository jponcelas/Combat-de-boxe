namespace combatdeboxe;

public class boxejadors
{
    public string Nom { get; set; }
    public int Resistencia { get; set; }
    private static List<string> Zones = new List<string>() { "Cap","BraçDret","BraçEsquerra", "Cos" };
    
    public boxejadors(string nom, int resistencia)
    {
        Nom = nom;
        Resistencia = resistencia;
    }

    public void RebreUnAtac(string zonaAtacada)
    {
            Resistencia--;
            Console.WriteLine(Nom + "ha rebut un cop a la zona" + zonaAtacada + ". Resistencia restant: " + Resistencia);
        
    }

    public string ProtegitZones()
    {
         Random rnd = new Random();
         string zonaProtegida = Zones[rnd.Next(0, Zones.Count)];
         Console.WriteLine(Nom + " ha protegit " + zonaProtegida);
         return zonaProtegida;
    }
    
    public string EscollirOnAtacar(string zona)
    {
        Random rnd = new Random();
        string zones = Zones[rnd.Next(0, Zones.Count)];
        Console.WriteLine(Nom + " ha escollit atacar la zona " + zones);
        return zones;
    }

    public bool EstatKO()
    {
        if (Resistencia == 0)
        {
            Console.WriteLine(Nom + " està KO!");
            return true;
        }
        return false;
    }
}