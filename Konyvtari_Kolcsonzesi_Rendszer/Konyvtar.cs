namespace Konyvtari_Kolcsonzesi_Rendszer;

internal class Konyvtar
{
    public List<Konyv> Konyvek { get; private set; }

    public Konyvtar()
    {
        Konyvek = new List<Konyv>();
    }
    
    public void HozzaadKonyv(Konyv konyv)
    {
        Konyvek.Add(konyv);
        Console.WriteLine($"Könyv hozzáadva: {konyv.Cim}");
    }
    
    public void ListazKonyveket()
    {
        Console.WriteLine("A könyvtár könyvei:");
        foreach (var konyv in Konyvek)
        {
            Console.WriteLine(konyv);
        }
    }
    
    public Konyv KeresKonyv(string isbn)
    {
        return Konyvek.FirstOrDefault(k => k.ISBN == isbn);
    }
}