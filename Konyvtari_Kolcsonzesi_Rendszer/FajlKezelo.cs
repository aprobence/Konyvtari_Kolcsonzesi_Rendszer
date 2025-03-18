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
    }
}