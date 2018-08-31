using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonVeriOkuma1
{
    public class RootObject
    {
        public int creditsLeft { get; set; }
        public Provider provider { get; set; }
        public int ttl { get; set; }
        public string v { get; set; }
        public bool cache { get; set; }
        public List<Datum> data { get; set; }
        public bool cache2 { get; set; }
    }
}