using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speridian.MMS.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public String Name { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        public Gender Gender { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }


    }
}
