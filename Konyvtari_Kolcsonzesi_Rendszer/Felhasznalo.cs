namespace Konyvtari_Kolcsonzesi_Rendszer;

internal class Felhasznalo
{
    public string Nev { get; set; }
    public List<Konyv> KolcsonzesiLista { get; private set; }
    
    public Felhasznalo(string nev)
    {
        Nev = nev;
        KolcsonzesiLista = new List<Konyv>();
    }
    
    public void Kolcsonoz(Konyv konyv)
    {
        if (!konyv.Kolcsonozheto)
        {
            Console.WriteLine("A könyv jelenleg nem kölcsönözhető.");
        }

        if (KolcsonzesiLista.Count >= 3)
        {
            Console.WriteLine("Maximum 3 könyvet kölcsönözhetsz egyszerre.");
            return;
        }
        KolcsonzesiLista.Add(konyv);
        konyv.Kolcsonzes();
        Console.WriteLine($"{Nev} kölcsönözte a könyvet: {konyv.Cim}");
    }

    public void Visszavisz(Konyv konyv)
    {
        if (KolcsonzesiLista.Contains(konyv))
        {
            KolcsonzesiLista.Remove(konyv);
            konyv.Visszahoz();
            Console.WriteLine($"{Nev} visszahozta: {konyv.Cim}");
        }
        else
        {
            Console.WriteLine($"Ez a könyv nincs a kölcsönzési listádban, {Nev}.");
        }
    }
    
    public override string ToString()
    {
        return $"{Nev} - Kölcsönzött könyvek: {KolcsonzesiLista.Count}";
    }
}