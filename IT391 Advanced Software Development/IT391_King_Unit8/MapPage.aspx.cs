using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT391_King_Unit8
{
    public partial class MapPage : System.Web.UI.Page
    {

        public string strLatitude = string.Empty;
        public string strLongitude = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                strLatitude = Request.QueryString["lat"].ToString();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("exception:" + ex.Message.ToString());
            }
            try
            {
                strLongitude = Request.QueryString["long"].ToString();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("exception:" + ex.Message.ToString());
            }
        }

        protected void BtnReturnClick(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}