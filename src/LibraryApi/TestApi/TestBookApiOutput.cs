using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestApi;

public class TestBookApiOutput : BaseTest
{
    [Theory]
    [InlineData("Book 1", "", 1, 1, 2022)]
    [InlineData("Book 2", "", 1, 1, 2022)]
    [InlineData("Book 3", "", 1, 1, 2022)]
    public async Task TestInsert(string title, string description, long authorId, long publisherId, int publishYear)
    {
        string url = $"/book";
        string json = JsonConvert.SerializeObject(new
        {
            Title = title,
            Description = description,
            AuthorId = authorId,
            PublisherId = publisherId,
            PublishYear = publishYear
        });
        HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
        HttpResponseMessage? httpResponse = await httpClinet.PostAsync(url, content);
        Assert.Equal(HttpStatusCode.OK, httpResponse.StatusCode);
    }
}