using System.Text.Json.Serialization;

namespace Giphy.Application.UseCases.Giphy.Queries.Models
{
    public class GiphyResponse
    {
        public object Giphy { get; set; }

        [JsonIgnore]
        public bool UpdateCache { get; set; }
    }
}
