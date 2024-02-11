﻿using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Microsoft.eShopWeb.Web.Views.Manage;

public static class ManageNavPages
{
    public static string? ActivePageKey => "ActivePage";

    public static string? Index => "Index";

    public static string? ChangePassword => "ChangePassword";

    public static string? ExternalLogins => "ExternalLogins";

    public static string? TwoFactorAuthentication => "TwoFactorAuthentication";

#pragma warning disable CS8604 // Possible null reference argument.
    public static string? IndexNavClass(ViewContext viewContext) => PageNavClass(viewContext, Index);
#pragma warning restore CS8604 // Possible null reference argument.

#pragma warning disable CS8604 // Possible null reference argument.
    public static string? ChangePasswordNavClass(ViewContext viewContext) => PageNavClass(viewContext, ChangePassword);
#pragma warning restore CS8604 // Possible null reference argument.

    public static string? ExternalLoginsNavClass(ViewContext viewContext) => PageNavClass(viewContext, ExternalLogins);

    public static string? TwoFactorAuthenticationNavClass(ViewContext viewContext) => PageNavClass(viewContext, TwoFactorAuthentication);

    public static string? PageNavClass(ViewContext viewContext, string? page)
    {
        var activePage = viewContext.ViewData["ActivePage"] as string ?? "";
        return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
    }

    public static void AddActivePage(this ViewDataDictionary viewData, string? activePage) => viewData[ActivePageKey] = activePage;
}
