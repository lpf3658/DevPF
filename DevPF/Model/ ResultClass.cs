using Newtonsoft.Json;
using System;

namespace DevPF.Model
{
    public class ResultClass<T>
    {
        [JsonProperty("result")]
        public bool Result
        {
            get;
            set;
        }

        [JsonProperty("msg")]
        public string Message
        {
            get;
            set;
        }

        [JsonProperty("data")]
        public T ResultInfo
        {
            get;
            set;
        }
    }
}
