using WebAPIDemo.Entites;

namespace WebAPIDemo.Services
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetAllMovies();
        public Movie GetMovieById(int id);
        public int AddMovie(Movie movie);
        public int UpdateMovie(Movie movie);
        public int DeleteMovie(int id);
    }
}
