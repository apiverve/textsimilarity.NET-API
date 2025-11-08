using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Difference data
    /// </summary>
    public class Difference
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("percentage")]
        public double Percentage { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("simiarity")]
        public double Simiarity { get; set; }

        [JsonProperty("similarityCaseSensitive")]
        public double SimilarityCaseSensitive { get; set; }

        [JsonProperty("difference")]
        public Difference Difference { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
