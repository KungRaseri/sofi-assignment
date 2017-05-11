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
        protected HttpClient Client { get; set; }
        protected ApiSettings Settings { get; set; }

        public TestBase()
        {
            var file = File.ReadAllText("appsettings.json");
            Settings = JsonConvert.DeserializeObject<ApiSettings>(file);
            Client = new HttpClient { BaseAddress = new Uri(Settings.ApiUrl) };
        }
    }
}
