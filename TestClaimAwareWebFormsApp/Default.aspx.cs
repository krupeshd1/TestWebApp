using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IdentityModel;
using System.Threading;
using System.Security.Claims;

namespace TestClaimAwareWebFormsApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClaimsPrincipal claimsPrincipal = Thread.CurrentPrincipal as ClaimsPrincipal;

            if (claimsPrincipal != null)
            {
                signedIn.Text = "You are signed in.";

                foreach (Claim claim in claimsPrincipal.Claims)
                {
                    claimType.Text = claim.Type;
                    claimValue.Text = claim.Value;
                    claimValueType.Text = claim.ValueType;
                    claimSubjectName.Text = claim.Subject.Name;
                    claimIssuer.Text = claim.Issuer;
                }
            }
            else
            {
                signedIn.Text = "You are not signed in.";
            }

        }
    }
}