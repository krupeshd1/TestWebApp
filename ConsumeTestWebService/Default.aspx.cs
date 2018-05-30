using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

using System.Xml.Linq;


namespace ConsumeTestWebService
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblmessage.Text = "First Loading Time: " + DateTime.Now.ToLongTimeString();
            }
            else
            {
                lblmessage.Text = "PostBack at: " + DateTime.Now.ToLongTimeString();
            }

        }
        protected void btnservice_Click(object sender, EventArgs e)
        {
            localhost.TestWebService proxy = new localhost.TestWebService();
            lblmessage.Text = String.Format("Current SATYAM Price:{0}",
            proxy.GetPrice("SATYAM").ToString());
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            lblmessage.Text = "";
        }

    }

}
