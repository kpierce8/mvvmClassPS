using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLightVideo1.Model
{
    public class ltdilRecord
    {

        [JsonProperty("questionType")]
        public int questionType { get; set; }

        [JsonProperty("questionID")]
        public int questionID { get; set; }

        [JsonProperty("isCorrect")]
        public string isCorrect { get; set; }

        [JsonProperty("justTextID")]
        public int justTextID { get; set; }

        [JsonProperty("rideID")]
        public int rideID { get; set; }

        [JsonProperty("targetDB")]
        public int targetDB { get; set; }

        [JsonProperty("answerID")]
        public int answerID { get; set; }

        [JsonProperty("landID")]
        public int landID { get; set; }

        [JsonProperty("lineValue")]
        public string lineValue { get; set; }

        [JsonProperty("parkID")]
        public int parkID { get; set; }

        [JsonProperty("section")]
        public string section { get; set; }
    }
}
