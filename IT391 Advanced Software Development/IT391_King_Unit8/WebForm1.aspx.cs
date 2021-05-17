using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT391_King_Unit8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            protected void btnMap_Click(object sender, EventArgs e)
            {
                string address = txtStreet.Text + " " + txtCity.Text + " " + txtState.Text + " " + txtZip.Text;

                var gKey = ""
                var requestUri = string.Format("https://maps.googleapis.com/maps/api/geocode/xml?address=333+E+Trade+Street+Charlotte+NC&key=AIzaSyC6Gb_Dtv00W4QWtFoApeKvAH9Wr5z2Qw8");
                Uri.EscapeDataString(address), gKey);

                var request = WebRequest.Create(requestUri);
                var response = request.GetResponse();
                var xdoc = XDocument.Load(response.GetResponseStream());

                var result = xdoc.Element("GeocodeResponse").Element("result");
                var locationElement = result.Element("geometry").Element("location");
                String strLatitude = locationElement.Element("lat").ToString();
                strLatitude = strLatitude.Substring(5);
                strLatitude = strLatitude.Substring(0, strLatitude.Length - 6));

                String strLongitude = locationElement.Element("lng").ToString();
                strLongitude = strLongitude.Substring(5);
                strLongitude = strLongitude.Substring(0, strLongitude.Length - 6));

                Response.Redirect("MapPage.aspx?lat=" + strLatitude + "&long=" + strLongitude):
            }
        }
    }
}