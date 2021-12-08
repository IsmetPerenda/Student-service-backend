using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StudentService.Common
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Status
    {
        Redovan,
        Vanredan
    }
}
