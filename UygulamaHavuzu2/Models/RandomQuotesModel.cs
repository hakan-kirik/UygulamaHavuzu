﻿

namespace UygulamaHavuzu2.Model
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class RandomQuotes
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("authorSlug")]
        public string AuthorSlug { get; set; }

        [JsonProperty("length")]
        public long Length { get; set; }

        [JsonProperty("dateAdded")]
        public DateTimeOffset DateAdded { get; set; }

        [JsonProperty("dateModified")]
        public DateTimeOffset DateModified { get; set; }
    }

    public partial class RandomQuotes
    {
        public static RandomQuotes FromJson(string json) => JsonConvert.DeserializeObject<RandomQuotes>(json,  UygulamaHavuzu2.Model.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this RandomQuotes self) => JsonConvert.SerializeObject(self,  UygulamaHavuzu2.Model.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
