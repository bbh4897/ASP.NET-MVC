using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JsonVeriOkuma1
{
    public partial class ReadJson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var webClient = new WebClient())
            {
               String rowJson = webClient.DownloadString("https://opensky-network.org/api/states/all?lamin=45.8389&lomin=5.9962&lamax=47.8229&lomax=10.5226");
               Class2 class2 = JsonConvert.DeserializeObject <Class2> (rowJson);
               Console.WriteLine(class2.Class1.Count);
               
            }
        }
    }
}