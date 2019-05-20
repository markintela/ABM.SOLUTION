using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class Question2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    #region EVENTS
    protected void btnValidation_Click(object sender, EventArgs e)
    {
        Validate();
    }
    #endregion

    #region METODS

    public Boolean Validate()
    {
        Boolean status = false;

        String[] allowedExtension = { ".xml" };
        String fileExtension = System.IO.Path.GetExtension(fluXml.FileName).ToLower();

        if (fileExtension == allowedExtension[0])
        {
            status = true;
            lblStatus.Text = "Success Extension!";
            Dictionary<String, String> listRef = CheckFile();
            gvRef.DataSource = listRef;
            gvRef.DataBind();

            return status;

        }
        else
            lblStatus.Text = "This Extension is not allowed!";
        return status;
    }

    public Dictionary<String, String> CheckFile()
    {

        XElement xmlDoc = XElement.Load(fluXml.FileContent);
        Dictionary<String, String> refCodeList = new Dictionary<String, String>();

        IEnumerable<XElement> refCodes =
            from refer in xmlDoc.Descendants("Reference")
            where (string)refer.Attribute("RefCode") == "MWB"
            || (string)refer.Attribute("RefCode") == "TRV"
            || (string)refer.Attribute("RefCode") == "CAR"
            select refer;

        foreach (XElement code in refCodes)
        {
            String refCode = code.FirstAttribute.Value.ToString();
            String vRef = code.LastNode.Parent.Value.ToString();

            refCodeList.Add(refCode, vRef);
        }
        return refCodeList;
    }
    #endregion

}