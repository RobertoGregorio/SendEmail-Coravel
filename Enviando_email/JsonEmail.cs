using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enviando_email
{
    public class JsonEmail
    {
        [JsonProperty("To")]
        public string RecipientEmail { get; set; }
        [JsonProperty("From")]
        public string SenderEmail { get; set; }
        [JsonProperty("Title")]
        public string TitleEmail { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
    }
}
