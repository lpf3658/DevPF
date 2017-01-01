using System.Collections.Generic;
using Newtonsoft.Json;

namespace DevPF.Model
{
    public class SearchDevice : IBase
    {
    }

    public class SearchDeviceResult : IBase
    {
        public List<int> SiteIds
        {
            get;
            set;
        }
    }

    public class SendReceive : IBase
    {
        [JsonProperty("sendStr")]
        public string Content
        {
            get;
            set;
        }
    }
}