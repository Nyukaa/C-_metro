using System.Text.Json;
using MovieLog.Models;

namespace MovieLog.Services;
//DatabaseService отвечает только за сохранение и загрузку. 
// Он не должен знать, как устроен MovieService и как он хранит фильмы.
// Поэтому DatabaseService не имеет доступа к списку фильмов напрямую.
public class DatabaseService
{
    private const string FileName = "tietokanta.json";

    public void Save(List<Leffa> movies)
    {
        string json = JsonSerializer.Serialize(movies,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });

        File.WriteAllText(FileName, json);

        Console.WriteLine("Tietokanta tallennettu.");
    }

    public List<Leffa>? Load()
    {
        if (!File.Exists(FileName))
        {
            Console.WriteLine("Tietokantaa ei saatavilla.");
            return null;
        }

        string json = File.ReadAllText(FileName);

        Console.WriteLine("Tietokanta ladattu.");

        return JsonSerializer.Deserialize<List<Leffa>>(json);
    }
}