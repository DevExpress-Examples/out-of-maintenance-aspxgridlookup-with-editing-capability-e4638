using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {
    protected void ads_Modifying(object sender, SqlDataSourceCommandEventArgs e) {
        throw new NotImplementedException("Data modification is not allowed in the online example");
    }
    protected void Page_Load(object sender, EventArgs e) {
        ASPxGridLookup1.GridView.Width = 600;
    }
}
