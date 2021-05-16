using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT391_King_Unit7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentGrades sg = new StudentGrades("./studentGrades.xml");
            txtAverageGrade.Text = sg.AvgGrade.ToString();
            txtHighestGrade.Text = sg.MaxGrade.ToString();
            txtLowestGrade.Text = sg.MinGrade.ToString();
        }
    }
}