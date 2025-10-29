using Newtonsoft.Json;
using System;

namespace DbOperationsWithEFCoreApp.Core.Entities
{
    [Serializable]
    public class ResponseResult<T> where T: class
    {
        [JsonProperty("StatusCode")]
        public int StatusCode { get; set; }
        [JsonProperty("Message")]
        public string Message { get; set; }
        [JsonProperty("Data")]
        public T Data { get; set; }
    }
}
