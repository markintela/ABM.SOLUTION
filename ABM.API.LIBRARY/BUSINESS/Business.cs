using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ABM.API.LIBRARY.BUSINESS
{
    public class Business
    {

        public string ResponseXml(XElement xelement)
        {

            XElement xmlElement = xelement;

            Dictionary<String, String> dc = CheckFile(xmlElement);

            string messageStatus = string.Empty;

            if (!dc["Command"].Equals("DEFAULT"))
            {
                messageStatus = "Code: -1  Error: Invalid Command Specified!";
            }
            else if (!dc["SiteId"].Equals("DUB"))
            {
                messageStatus = "Code: -2  Error: Invalid Site Specified!";
            }
            else
            {
                messageStatus = "Code: 0  OK: Success File!";
            }

            return messageStatus;

        }

        private Dictionary<String, String> CheckFile(XElement xmlElement)
        {

            Dictionary<String, String> dcAttributes = new Dictionary<String, String>();

            /* BEGIN VERIFY COMMAND */
            IEnumerable<XElement> declarationTag =
            from declaration in xmlElement.Descendants("Declaration")
            select declaration;
    
            foreach (XElement code in declarationTag)
            {
                dcAttributes.Add("Command", code.FirstAttribute.Value.ToString());
            }
            /*END VERIFY COMMAND */



            /* BEGIN VERIFY SITE  */   
            IEnumerable<XElement> siteTag =
            from site in xmlElement.Descendants("SiteID")
            select site;    

            foreach (XElement site in siteTag)
            {
                dcAttributes.Add("SiteId", site.Value);
            }
            /*END VERIFY COMMAND */


            return dcAttributes;


        }
    }
}
