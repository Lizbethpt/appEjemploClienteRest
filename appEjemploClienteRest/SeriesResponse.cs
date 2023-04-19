using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace appEjemploClienteRest
{
    [DataContract]
    internal class SeriesResponse
    {
        [DataMember(Name = "series")]
        public Serie[] series { get; set; }
    }
}
