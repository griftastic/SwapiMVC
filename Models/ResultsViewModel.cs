using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SwapiMVC.Models
{
    public class ResultsViewModel<TResult>
    {
        [JsonPropertyName("results")]
        public IEnumerable<TResult> Results { get; set; }
    }
    public class ResultsViewModel
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }
        [JsonPropertyName("next")]
        public string Next { get; set; }
        [JsonPropertyName("previous")]
        public string Previous { get; set; }

        public string NextPageNum => Next?.Split("?page=").LastOrDefault();
        public string PreviousPageNum => Previous?.Split("?page=").LastOrDefault();
    }
}