using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Question1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    #region EVENTS
    protected void btnSend_Click(object sender, EventArgs e)
    {
        string message = txtMessage.Text;
        List<String> convertedList = ConvertEdifact(message);

        gvLoc.DataSource = convertedList;
        gvLoc.DataBind();

    }
    #endregion

    #region METODS
    private List<String> ConvertEdifact(string edifact)
    {
        var lines = edifact.Split('\'');
        List<String> listLoc = new List<String>();

        foreach (var line in lines)
        {
            var segments = line.Split('+', ':');
            if (segments[0].Contains("LOC"))
            {
                listLoc.Add(segments[1]);
                listLoc.Add(segments[2]);
            }

        }

        return listLoc;
    }
    #endregion

}