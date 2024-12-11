using combatdeboxe;

public class combat
{
    private boxejadors _jugador1;
    private boxejadors _jugador2;

    public combat(boxejadors jugador1, boxejadors jugador2)
    {
        _jugador1 = jugador1;
        _jugador2 = jugador2;
    }

    public bool RealitzarElTorn(boxejadors atacant, boxejadors defensor)
    {
        

        string zonaAtacada = atacant.EscollirOnAtacar(null);
        string zonaProtegida = defensor.ProtegitZones();

        if (zonaAtacada == zonaProtegida)
        {
            Console.WriteLine(defensor.Nom + " ha bloquejat l'atac a la zona: " + zonaAtacada);
        }
        else
        {
            defensor.RebreUnAtac(zonaAtacada);
        }

        if (defensor.EstatKO())
        {
            Console.WriteLine(defensor.Nom + " cau derrotat! " + atacant.Nom + " és el guanyador!");
            return true; 
        }

        return false;
    }
}