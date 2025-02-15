using System.ComponentModel;
using Patikaflix;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Series> seriesList = new List<Series>();
        string answer;

        do
        {
            Console.WriteLine("Dizinin Adını Giriniz:");
            var name = Console.ReadLine();

            Console.WriteLine("Dizinin Yapım Yılını Giriniz:");
            var productionYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dizinin Türünü Giriniz:");
            var genre = Console.ReadLine();

            Console.WriteLine("Dizinin Yayınlanmaya Başladığı Yılı Giriniz:");
            var releaseYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dizinin Yönetmenini Giriniz:");
            var director = Console.ReadLine();

            Console.WriteLine("Dizinin İlk Yayınlandığı Platformu Giriniz:");
            var firstPlatform = Console.ReadLine();

            seriesList.Add(new Series
            {
                Name = name,
                ProductionYear = productionYear,
                Genre = genre,
                ReleaseYear = releaseYear,
                Director = director,
                FirstPlatform = firstPlatform
            });

            Console.WriteLine("Yeni Bir Dizi Eklemek İster misiniz? (E/H):");
            answer = Console.ReadLine();

        } while (answer is "E" or "e");

        Console.WriteLine("Oluşturduğunuz Dizi:");
        foreach (var item in seriesList)
        {
            Console.WriteLine($"Ad: {item.Name}, Yapım Yılı: {item.ProductionYear}, Tür: {item.Genre}, Yayın Yılı: {item.ReleaseYear}, Yönetmen: {item.Director}, Platform: {item.FirstPlatform}");
        }

        var newList = seriesList
                .Where(m => m.Genre.ToLower().Contains("komedi"))
                .Select(m => new NewSeries { Name = m.Name, Genre = m.Genre, Director = m.Director })
                .OrderBy(m => m.Name) 
                .ThenBy(m => m.Director)
                .ToList();

        Console.WriteLine("\nKomedi Dizileri Listesi:");
        foreach (var item in newList)
        {
            Console.WriteLine($"Dizi Adı: {item.Name}, Tür: {item.Genre}, Yönetmen: {item.Director}");
        }

    }
}
