using WebAPIDemo.Entites;
using WebAPIDemo.Repositories;

namespace WebAPIDemo.Services
{
    public class MovieService:IMovieService
    {
        private readonly IMovieRepository repo;
        public MovieService(IMovieRepository repo)
        {
            this.repo = repo;
        }

        public int AddMovie(Movie movie)
        {
            return repo.AddMovie(movie);
        }

        public int DeleteMovie(int id)
        {
            return repo.DeleteMovie(id);
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return repo.GetAllMovies();
        }

        public Movie GetMovieById(int id)
        {
            return repo.GetMovieById(id);
        }

        public int UpdateMovie(Movie movie)
        {
            return repo.UpdateMovie(movie);
        }
    }
}
