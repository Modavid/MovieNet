using MovieNetLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MovieNetWCF
{
	// singleton
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
	public class MovieService : IMovieService
	{
		public Movie GetMovie(int id)
		{
            MovieEntity movieEntity = null;

            try
            {
                DataModelContainer ctx = new DataModelContainer();
                NoteService ns = new NoteService();
                movieEntity = (from m in ctx.MovieEntitySet.Include("NoteEntity") where m.Id == id select m).FirstOrDefault();
                if (movieEntity == null)
                    return null;
            }
            catch (SqlException ex)
            {
                throw new FaultException("Erreur GetMovie: " + ex.Errors);
            }

            return TranslateMovie(movieEntity);
        }
		public Movie CreateMovie(string title, string genre, string summary)
		{
            MovieEntity movie = null;

            try
            {
                DataModelContainer ctx = new DataModelContainer();
                movie = new MovieEntity
                {
                    Title = title,
                    Genre = genre,
                    Summary = summary
                };

                ctx.MovieEntitySet.Add(movie);
                ctx.SaveChanges();
            }
            catch (SqlException ex)
            {
                throw new FaultException("Erreur CreateMovie: " + ex.Errors);
            }

			return TranslateMovie(movie);
		}

		public Movie UpdateMovie(int id, string title, string genre, string summary)
		{
            MovieEntity movieEntity = null;

            try
            {
                DataModelContainer ctx = new DataModelContainer();
                movieEntity = (from m in ctx.MovieEntitySet where m.Id == id select m).FirstOrDefault();
                if (movieEntity == null)
                    return null;

                movieEntity.Title = title;
                movieEntity.Genre = genre;
                movieEntity.Summary = summary;
                ctx.SaveChanges();
            }
            catch (SqlException ex)
            {
                throw new FaultException("Erreur UpdateMovie: " + ex.Errors);
            }

			return TranslateMovie(movieEntity);	
		}

		public Boolean DeleteMovie(int id)
		{
            try
            {
                DataModelContainer ctx = new DataModelContainer();

                var movieEntity = (from m in ctx.MovieEntitySet where m.Id == id select m).FirstOrDefault();
                if (movieEntity == null)
                    return false;
				foreach (var n in ctx.NoteEntitySet.Where(n => n.MovieEntity.Id == id))
				{
					ctx.NoteEntitySet.Remove(n);
				}
				ctx.MovieEntitySet.Remove(movieEntity);
                ctx.SaveChanges();
            }
            catch (SqlException ex)
            {
                throw new FaultException("Erreur DeleteMovie: " + ex.Errors);
            }

			return true;
		}

		public List<Movie> FindMovieTitle(string title)
		{
            List<Movie> movies = new List<Movie>();

            try
            {
                DataModelContainer ctx = new DataModelContainer();

                var query = (from m in ctx.MovieEntitySet select m).ToList();
                List<MovieEntity> list = query.Where(item => title.Any(t => item.Title.ToLower().Contains(title.ToLower()))).ToList();

                foreach (var movie in list)
                    movies.Add(TranslateMovie(movie));
            }
            catch (SqlException ex)
            {
                throw new FaultException("Erreur FindMovieTitle: " + ex.Errors);
            }

			return movies;
		}

		public List<Movie> FindMovieGenre(string genre)
		{
            List<Movie> movies = new List<Movie>();

            try
            {
                DataModelContainer ctx = new DataModelContainer();

                var query = (from m in ctx.MovieEntitySet select m).ToList();
                List<MovieEntity> list = query.Where(item => genre.Any(t => item.Genre.Contains(genre))).ToList();

                foreach (var movie in list)
                {
                    movies.Add(TranslateMovie(movie));
                }
            }
            catch (SqlException ex)
            {
                throw new FaultException("Erreur FindMovieGenre: " + ex.Errors);
            }

			return movies;
		}

		public List<Movie> GetAllMovies()
		{
            List<Movie> movies = new List<Movie>();

            try
            {
                DataModelContainer ctx = new DataModelContainer();

                var query = (from m in ctx.MovieEntitySet select m).ToList();
                
                foreach (var movie in query)
                {
                    movies.Add(TranslateMovie(movie));
                }
            }
            catch (SqlException ex)
            {
                throw new FaultException("Erreur GetAllMovies: " + ex.Errors);
            }

			return movies;
		}
		internal Movie TranslateMovie(MovieEntity movieEntity)
		{
			Movie movie = new Movie
			{
				Id = movieEntity.Id,
				Title = movieEntity.Title,
				Summary = movieEntity.Summary,
				Genre = movieEntity.Genre
			};
			return movie;
		}

		internal MovieEntity ReverseTranslateMovie(Movie movie)
		{
			MovieEntity movieEntity = new MovieEntity
			{
				Id = movie.Id,
				Title = movie.Title,
				Summary = movie.Summary,
				Genre = movie.Genre
			};
			return movieEntity;
		}
	}
}
