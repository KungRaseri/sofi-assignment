using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xunit;

namespace SofiAssignment.Tests
{
    public class MovieResourceTests : TestBase
    {
        /// <summary>
        /// Get the details of a movie and verify the title is correct
        /// </summary>
        /// <param name="movieId"></param>
        /// <param name="expectedMovieTitle"></param>
        [Theory]
        [InlineData(new object[] { 2, "Ariel" })]
        [InlineData(new object[] { 3, "Shadows in Paradise" })]
        public async Task GetDetails_ReturnsValidMovieInformation(int movieId, string expectedMovieTitle)
        {
            // Arrange the necessary data for the test
            var movie = await Client.GetAsync($"movie/{movieId}?api_key={Settings.ApiKey}");

            // Act on the data given
            var inTest = JsonConvert.DeserializeObject<Movie>(await movie.Content.ReadAsStringAsync());

            // Assert the validity of the test
            Assert.True(inTest.Title == expectedMovieTitle);
        }
    }
}
