using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume_application.Models
{
    public class DiceDoneAtSpellLevel
    {
        [JsonProperty("1")]
        public string One { get; set; }
        [JsonProperty("2")]
        public string Two { get; set; }
        [JsonProperty("3")]
        public string Three { get; set; }
        [JsonProperty("4")]
        public string Four { get; set; }
        [JsonProperty("5")]
        public string Five { get; set; }
        [JsonProperty("6")]
        public string Six { get; set; }
        [JsonProperty("7")]
        public string Seven { get; set; }
        [JsonProperty("8")]
        public string Eight { get; set; }
        [JsonProperty("9")]
        public string Nine { get; set; }
    }
}
