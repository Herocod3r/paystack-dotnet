﻿using Newtonsoft.Json;

namespace PayStack.Net
{
    public class TransactionFetchResponse
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public TransactionList.Datum Data { get; set; }
    }
}