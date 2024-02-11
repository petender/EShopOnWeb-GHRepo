using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.eShopWeb.Web.Services;
using Microsoft.eShopWeb.Web.ViewModels;

namespace Microsoft.eShopWeb.Web.Pages;

/// <summary>
/// Represents the model for the Index page.
/// </summary>
public class IndexModel : PageModel
{
    private readonly ICatalogViewModelService _catalogViewModelService;

    /// <summary>
    /// Initializes a new instance of the <see cref="IndexModel"/> class.
    /// </summary>
    /// <param name="catalogViewModelService">The catalog view model service.</param>
    public IndexModel(ICatalogViewModelService catalogViewModelService)
    {
        _catalogViewModelService = catalogViewModelService;
    }

    /// <summary>
    /// Gets or sets the catalog model.
    /// </summary>
    public CatalogIndexViewModel CatalogModel { get; set; } = new CatalogIndexViewModel();

    /// <summary>
    /// Handles the HTTP GET request for the Index page.
    /// </summary>
    /// <param name="catalogModel">The catalog model.</param>
    /// <param name="pageId">The page ID.</param>
    public async Task OnGet(CatalogIndexViewModel catalogModel, int? pageId)
    {
        CatalogModel = await _catalogViewModelService.GetCatalogItems(pageId ?? 0, Constants.ITEMS_PER_PAGE, catalogModel.BrandFilterApplied, catalogModel.TypesFilterApplied);
    }
}
