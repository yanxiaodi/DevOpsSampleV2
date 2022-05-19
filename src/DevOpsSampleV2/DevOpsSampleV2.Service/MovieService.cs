using DevOpsSampleV2.Models;

namespace DevOpsSampleV2.Service
{
    public class MovieService : IMovieService
    {
        public Task<List<Movie>> GetTop10ListAsync()
        {
            return Task.FromResult(new List<Movie>()
            {
                new() { Genre = "Action", Id = 1, Title = "Die Hard" },
                new() { Genre = "Comedy", Id = 2, Title = "The Hangover" },
                new() { Genre = "Drama", Id = 3, Title = "The Godfather" },
                new() { Genre = "Horror", Id = 4, Title = "The Exorcist" },
                new() { Genre = "Thriller", Id = 5, Title = "The Dark Knight" },
                new() { Genre = "Adventure", Id = 6, Title = "The Lord of the Rings" },
                new() { Genre = "Action", Id = 7, Title = "The Dark Knight Rises" },
                new() { Genre = "Comedy", Id = 8, Title = "The Hangover Part II" },
                new() { Genre = "Drama", Id = 9, Title = "The Godfather Part II" },
                new() { Genre = "Horror", Id = 10, Title = "The Exorcist Part II" }
            });
        }
    }
}
