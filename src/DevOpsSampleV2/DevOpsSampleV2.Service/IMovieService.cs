using DevOpsSampleV2.Models;

namespace DevOpsSampleV2.Service
{
    public interface IMovieService
    {
        Task<List<Movie>> GetListAsync();
    }
}