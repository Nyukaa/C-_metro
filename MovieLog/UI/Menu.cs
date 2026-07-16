using MovieLog.Services;

namespace MovieLog.UI;

public class Menu
{
    private readonly MovieService movieService;
    private readonly DatabaseService databaseService;

    public Menu(MovieService movieService,
                DatabaseService databaseService)
    {
        this.movieService = movieService;
        this.databaseService = databaseService;
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Leffojen Katseluloki");
            Console.WriteLine("====================");
            Console.WriteLine("1) Lisää Leffa");
            Console.WriteLine("2) Poista Leffa");
            Console.WriteLine("3) Näytä Raportti");
            Console.WriteLine("4) Lataa Tietokanta");
            Console.WriteLine("5) Tallenna Tietokanta");
            Console.WriteLine("6) Lopeta");

            Console.Write("Syöte: ");

            string? input = Console.ReadLine();

            Console.WriteLine();

            switch (input)
            {
                case "1":
                    AddMovie();
                    break;

                case "2":
                    RemoveMovie();
                    break;

                case "3":
                    ShowReport();
                    break;

                case "4":
                    LoadDatabase();
                    break;

                case "5":
                    SaveDatabase();
                    break;

                case "6":
                    return;

                default:
                    Console.WriteLine("Tuntematon komento");
                    break;
            }
        }
    }

    private void AddMovie()
    {
        Console.WriteLine("Lisää Leffa:");

        Console.Write("Nimi:");
        string nimi = Console.ReadLine()!;

        Console.Write("Kesto (min):");
        int kesto = int.Parse(Console.ReadLine()!);

        Console.Write("Vuosi:");
        int vuosi = int.Parse(Console.ReadLine()!);

        movieService.AddMovie(nimi, kesto, vuosi);
    }

    private void RemoveMovie()
    {
        Console.WriteLine("Poista Leffa:");

        var movies = movieService.GetMovies();

        for (int i = 0; i < movies.Count; i++)
        {
            Console.WriteLine($"{i + 1}) {movies[i].Nimi} ({movies[i].Vuosi}), {movies[i].Kesto} minuuttia.");
        }

        if (movies.Count == 0)
            return;

        Console.Write("Syöte: ");

        int index = int.Parse(Console.ReadLine()!);

        movieService.RemoveMovie(index - 1);
    }

    private void ShowReport()
    {
        var movies = movieService.GetMovies();

        foreach (var movie in movies)
        {
            Console.WriteLine($"{movie.Nimi} ({movie.Vuosi}), {movie.Kesto} minuuttia.");
        }

        Console.WriteLine();

        Console.WriteLine($"Leffoja katsottu yhteensä {movies.Count}, yhteiskesto {movieService.TotalDuration()} minuuttia.");
    }

    private void SaveDatabase()
    {
        databaseService.Save(movieService.GetMovies());
    }

    private void LoadDatabase()
    {
        var movies = databaseService.Load();

        if (movies != null)
            movieService.SetMovies(movies);
    }
}