using DevOpsSampleV2.Service;
using System.Threading.Tasks;
using Xunit;

namespace DevOpsSampleV2.Tests
{
    public class MovieServiceTest
    {
        [Fact]
        public async Task GetTop10Test1()
        {
            var movieService = new MovieService();
            var list = await movieService.GetTop10ListAsync();
            Assert.Equal(10, list.Count);
            
        }
    }
}