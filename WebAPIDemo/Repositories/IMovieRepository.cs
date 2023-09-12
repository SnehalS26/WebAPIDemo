using WebAPIDemo.Entites;

namespace WebAPIDemo.Repositories
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAllMovies();
        public Movie GetMovieById(int id);
        public int AddMovie(Movie movie);
        public int UpdateMovie(Movie movie);    
        public int DeleteMovie(int id);
    }
}
