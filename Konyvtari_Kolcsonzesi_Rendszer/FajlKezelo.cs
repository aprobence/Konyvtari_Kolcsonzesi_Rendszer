using System.Threading.Channels;

namespace Konyvtari_Kolcsonzesi_Rendszer;

internal class FajlKezelo
{
    private static string konyvFajl = "konyvek.txt";
    
    public static void KonyvekMentese(List<Konyv> konyvek)
    {
        using (StreamWriter sw = new StreamWriter(konyvFajl))
        {
            foreach (var konyv in konyvek)
            {
                sw.WriteLine($"{konyv.Cim};{konyv.Szerzo};{konyv.ISBN};{konyv.Kolcsonozheto}");
            }
        }
        Console.WriteLine("Könyvek elmentve!");
    }
    
    public static List<Konyv> KonyvekBetoltese()
    {
        List<Konyv> konyvek = new List<Konyv>();
        if (File.Exists(konyvFajl)) return konyvek;

        foreach (var sor in File.ReadLines(konyvFajl))
        {
            var adatok = sor.Split(';');
            var konyv = new Konyv(adatok[0], adatok[1], adatok[2]);
            konyvek.Add(konyv);
        }
        
        Console.WriteLine("Könyvek betöltve!");
        return konyvek;
    }
}