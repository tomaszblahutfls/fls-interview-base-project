using FluentAssertions;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using fls_interview_base_project;

namespace AddressIntegrationTestsIntegrationTests.Tests
{
    public class AddressIntegrationTests(WebApplicationFactory<Program> factory)
        : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client = factory.CreateClient();
        
        [Fact]
        public async Task TestAddressField()
        {
            var response = await _client.GetAsync("/api/episerver/v3.0/content/102");
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var content = await response.Content.ReadAsStringAsync();
            var jObject = JObject.Parse(content);
            jObject.Should().NotBeNull();
            var addressField = jObject["address"];
            addressField.Should().NotBeNull();
            var addressFieldDataType = addressField["propertyDataType"].Value<string>();
            addressFieldDataType.Should().Be("PropertyLongString");
        }
    }
}
