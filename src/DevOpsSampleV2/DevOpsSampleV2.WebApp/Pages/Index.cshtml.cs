using DevOpsSampleV2.Models;
using DevOpsSampleV2.Service;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DevOpsSampleV2.WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IMovieService _movieService;
        public IList<Movie> Movies { get; set; } = new List<Movie>();
        public IndexModel(ILogger<IndexModel> logger, IMovieService movieService)
        {
            _logger = logger;
            _movieService = movieService;
        }

        public async Task OnGet()
        {
            Movies = await _movieService.GetTop10ListAsync();
        }
    }
}