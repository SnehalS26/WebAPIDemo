using WebAPIDemo.Entites;

namespace WebAPIDemo.Repositories
{
    public class MovieRepository:IMovieRepository
    {
        private readonly ApplicationDbContext context;
        public MovieRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public int AddMovie(Movie movie)
        {
            int result = 0;
            movie.IsActive = 1;
            context.Movies.Add(movie);
            result = context.SaveChanges();
            return result;
        }

        public int DeleteMovie(int id )
        {
            int result = 0;
            var mov = context.Movies.Where(x => x.Id == id).FirstOrDefault();
            if (mov != null)
            {
                mov.IsActive = 0;
                result = context.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return context.Movies.Where(x => x.IsActive == 1).ToList();
        }

        public Movie GetMovieById(int id)
        {
            int result = 0;
            var movi = context.Movies.Where(x => x.Id == id).FirstOrDefault();
            return movi;
        }

        public int UpdateMovie(Movie movie)
        {
            int result = 0;
            var m = context.Movies.Where(x => x.Id == movie.Id).FirstOrDefault();
            if (m != null)
            {
                m.Id = movie.Id;
                m.Name = movie.Name;
                m.Genere = movie.Genere;
                m.Realeased_Date = movie.Realeased_Date;
                m.Starcast = movie.Starcast;
                m.IsActive = 1;
                result = context.SaveChanges();
            }
            return result;
        }
    }
}
