using DevOpsSampleV2.Service;
using System.Threading.Tasks;
using Xunit;

namespace DevOpsSampleV2.Tests
{
    public class MovieServiceTest
    {
        [Fact]
        public async Task Test1()
        {
            var movieService = new MovieService();
            var list = await movieService.GetListAsync();
            Assert.Equal(10, list.Count);
            
        }
    }
}