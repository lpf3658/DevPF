using Newtonsoft.Json;
using System;

namespace DevPF.Model
{
    public class UserLogin : IBase
    {
        [JsonProperty("username")]
        public string UserName
        {
            get;
            set;
        }

        [JsonProperty("password")]
        public string PassWord
        {
            get;
            set;
        }
    }

    public class VideoLogin : UserLogin, IFlagBase, IBase
    {
        [JsonProperty("ip")]
        public string IpStr
        {
            get;
            set;
        }

        [JsonProperty("port")]
        public string Port
        {
            get;
            set;
        }

        [JsonProperty("flag")]
        public int Flag
        {
            get;
            set;
        }
    }
}
