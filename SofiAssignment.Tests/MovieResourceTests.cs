using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SofiAssignment.Tests.Models;
using Xunit;

namespace SofiAssignment.Tests
{
    /// <summary>
    /// Test Suite: This suite tests the Movies Endpoint
    /// 
    /// </summary>
    public class MovieResourceTests : TestBase
    {
        // Arranging the Mock Data into a collection
        public static IEnumerable<object[]> ExpectedMovieData
        {
            get
            {
                yield return new object[] { new Movie { Id = 2, Title = "Ariel", Genres = new List<Genre> { new Genre { Id = 18, Name = "Drama" }, new Genre { Id = 80, Name = "Crime" } } } };
                yield return new object[] { new Movie { Id = 3, Title = "Shadows in Paradise", Genres = new List<Genre> { new Genre { Id = 18, Name = "Drama" }, new Genre { Id = 35, Name = "Comedy" } } } };
                yield return new object[] { new Movie { Id = 5, Title = "Four Rooms", Genres = new List<Genre> { new Genre { Id = 80, Name = "Crime" }, new Genre { Id = 35, Name = "Comedy" } } } };
                yield return new object[] { new Movie { Id = 6, Title = "Judgment Night", Genres = new List<Genre> { new Genre { Id = 28, Name = "Action" }, new Genre { Id = 53, Name = "Thriller" }, new Genre { Id = 80, Name = "Crime" } } } };
            }
        }

        /// <summary>
        /// Theory: Getting the details of a movie by movie id returns valid movie information.
        /// MemberData: Collection of movies to be used for validation
        /// Get the details of a movie and verify the information
        /// </summary>
        /// <param name="expectedMovieDetails">The expected details of the movie</param>
        [Theory, MemberData(nameof(ExpectedMovieData))]
        public async Task Get_Movie_Details_ValidateInformation(Movie expectedMovieDetails)
        {
            // Get the movie information by movie id.
            var movie = await Client.GetAsync($"movie/{expectedMovieDetails.Id}?api_key={Settings.ApiKey}");

            // Deserialize the result into a Movie object
            var inTest = JsonConvert.DeserializeObject<Movie>(await movie.Content.ReadAsStringAsync());

            // Assert that the Id in test is equal to the expected value
            Assert.True(inTest.Id == expectedMovieDetails.Id);

            // Assert that the Title in test is equal to the expected value
            Assert.True(inTest.Title == expectedMovieDetails.Title);

            // Assert that the Adult property on Movie is of the expected type
            Assert.IsType<bool>(inTest.Adult);

            // Assert that object in test is of the expected type
            Assert.IsType<Movie>(inTest);

            // Assert that the Genres are equal to the expected genres
            Assert.Equal(expectedMovieDetails.Genres, inTest.Genres);

            // We can test more of the properties on the Movie object. Or run operations on the lists, etc.
        }

        [Fact]
        public async Task Get_Movie_TopRated()
        {
            var movie = await Client.GetAsync($"movie/top_rated?api_key={Settings.ApiKey}");
            var result = await movie.Content.ReadAsStringAsync();
            var inTest = JsonConvert.DeserializeObject<MoviePageResult>(result);

            Assert.IsType<MoviePageResult>(inTest);
            Assert.NotEmpty(inTest.Results);
            Assert.Equal(20, inTest.Results.Length);
        }
    }
}
