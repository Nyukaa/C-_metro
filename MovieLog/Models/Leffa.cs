namespace MovieLog.Models;

public class Leffa
{
    public string Nimi { get; set; } = "";
    public int Kesto { get; set; }
    public int Vuosi { get; set; }

    public Leffa()
    {
    }

    public Leffa(string nimi, int kesto, int vuosi)
    {
        Nimi = nimi;
        Kesto = kesto;
        Vuosi = vuosi;
    }
}