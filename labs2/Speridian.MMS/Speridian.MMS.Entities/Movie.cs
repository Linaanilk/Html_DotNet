using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speridian.MMS.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public String Director { get; set; }

        public int ReleaseYear { get; set; }

        public int Rating { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        public Genre Genre { get; set; }

        public TimeSpan Duration { get; set; }

        public Language Language { get; set; }

        public List<string?> Actors { get; set; }
        

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
