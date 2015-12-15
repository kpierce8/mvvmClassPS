using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLightVideo1.Model
{
    public class ListOfLands
    {
        [JsonProperty("theLands")]
        public IEnumerable<ltdilRecord> Lands
        {
            get;
            set;
        }
    }


    public class Land : ltdilRecord
    {


    }
}
