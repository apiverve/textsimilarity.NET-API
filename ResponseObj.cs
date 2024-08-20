using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class difference
{
    [JsonProperty("count")]
    public int count { get; set; }

    [JsonProperty("percentage")]
    public double percentage { get; set; }

}

public class data
{
    [JsonProperty("simiarity")]
    public double simiarity { get; set; }

    [JsonProperty("similarityCaseSensitive")]
    public double similarityCaseSensitive { get; set; }

    [JsonProperty("difference")]
    public difference difference { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
