﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HyperLink1.NavigateUrl = this.GetRouteUrl("product-browse", new { category = "Category_1" });
        HyperLink2.NavigateUrl = this.GetRouteUrl("product-browse", new { category = "Category_2" });
    }
}
