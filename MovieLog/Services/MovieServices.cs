using MovieLog.Models;

namespace MovieLog.Services;
//MovieService работает только со списком фильмов.
// Он не должен знать, как устроен DatabaseService и как он сохраняет фильмы.   

public class MovieService
{
    private List<Leffa> leffat = new();

    public List<Leffa> GetMovies()
    {
        return leffat;
    }

    public void SetMovies(List<Leffa> movies)
    {
        leffat = movies;
    }

    public void AddMovie(string nimi, int kesto, int vuosi)
    {
        leffat.Add(new Leffa(nimi, kesto, vuosi));
    }

    public void RemoveMovie(int index)
    {
        if (index >= 0 && index < leffat.Count)
            leffat.RemoveAt(index);
    }

    public int TotalDuration()
    {
        int total = 0;

        foreach (var movie in leffat)
            total += movie.Kesto;

        return total;
    }
}