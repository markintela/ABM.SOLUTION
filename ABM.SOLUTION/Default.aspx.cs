using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using System.Net.Http;
using System.Net.Http.Formatting;

using System.IO;

public partial class _Default : Page
{
    HttpClient client;
    Uri serviceUri;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

}