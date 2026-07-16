using MovieLog.Services;
using MovieLog.UI;

namespace MovieLog;
//Program только запускает приложение. 
class Program
{
    static void Main()
    {
        var movieService = new MovieService();
        var databaseService = new DatabaseService();

        var menu = new Menu(movieService, databaseService);
        menu.Run();
    }
}