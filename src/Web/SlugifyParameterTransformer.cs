using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Routing;

namespace Microsoft.eShopWeb.Web;

public class SlugifyParameterTransformer : IOutboundParameterTransformer
{
    public string? TransformOutbound(object? value)
    {
        if (value == null) { return null; }

        // Slugify value
#pragma warning disable CS8604 // Possible null reference argument.
        return Regex.Replace(value.ToString(), "([a-z])([A-Z])", "$1-$2").ToLower();
#pragma warning restore CS8604 // Possible null reference argument.
    }
}
