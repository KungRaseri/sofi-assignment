using System;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using SofiAssignment.Tests.Models;
using Xunit;

namespace SofiAssignment.Tests
{
    /// <summary>
    /// Shared properties for each suite to use.
    /// </summary>
    public class TestBase : IClassFixture<TestBase>
    {
        /// <summary>
        /// Client that we use to send requests to the API
        /// </summary>
        protected HttpClient Client { get; set; }
        /// <summary>
        /// Settings to initalize the client
        /// </summary>
        protected ApiSettings Settings { get; set; }

        public TestBase()
        {
            Settings = JsonConvert.DeserializeObject<ApiSettings>(File.ReadAllText("appsettings.json"));
            Client = new HttpClient { BaseAddress = new Uri(Settings.ApiUrl) };
        }
    }
}
