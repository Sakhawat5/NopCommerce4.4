using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Core.Domain.Catalog;
using Nop.Plugin.Widget.BestSeller.Models;
using Nop.Services.Orders;
using Nop.Web.Infrastructure.Cache;
using Nop.Web.Framework.Components;
using Nop.Services.Catalog;
using Nop.Core.Domain.Orders;
using Nop.Services.Security;
using Nop.Services.Stores;
using Nop.Web.Factories;

namespace Nop.Plugin.Widget.BestSeller.Components
{
    [ViewComponent(Name = "HomePageBestSellerBrand")]
    public class HomePageBestSellerBrand : NopViewComponent
    {
        private readonly CatalogSettings _catalogSettings;
        private readonly IAclService _aclService;
        private readonly IOrderReportService _orderReportService;
        private readonly IProductModelFactory _productModelFactory;
        private readonly IProductService _productService;
        private readonly IStaticCacheManager _staticCacheManager;
        private readonly IStoreContext _storeContext;
        private readonly IStoreMappingService _storeMappingService;
        private readonly IManufacturerService _manufacturerService;

        public HomePageBestSellerBrand(CatalogSettings catalogSettings,
            IAclService aclService,
            IOrderReportService orderReportService,
            IProductModelFactory productModelFactory,
            IProductService productService,
            IStaticCacheManager staticCacheManager,
            IStoreContext storeContext,
            IStoreMappingService storeMappingService,
            IManufacturerService manufacturerService)
        {
            _catalogSettings = catalogSettings;
            _aclService = aclService;
            _orderReportService = orderReportService;
            _productModelFactory = productModelFactory;
            _productService = productService;
            _staticCacheManager = staticCacheManager;
            _storeContext = storeContext;
            _storeMappingService = storeMappingService;
            _manufacturerService = manufacturerService;
        }
        public async Task<IViewComponentResult> InvokeAsync(string widgetZone, int? productThumbPictureSize)
        {
            //load and cache report
            var report = (await _staticCacheManager.GetAsync(_staticCacheManager.PrepareKeyForDefaultCache(NopModelCacheDefaults.HomepageBestsellersIdsKey, await _storeContext.GetCurrentStoreAsync()),
                async () => await _orderReportService.BestSellersReportAsync(
                        storeId: (await _storeContext.GetCurrentStoreAsync()).Id,
                        pageSize: _catalogSettings.NumberOfBestsellersOnHomepage)))
                    .ToList();
            List<ProductManufacturer> productManufacturers = new List<ProductManufacturer>();
            foreach (var item in report)
            {
                productManufacturers.AddRange(await _manufacturerService.GetProductManufacturersByProductIdAsync(item.ProductId, false));
            }

            //load products
            var products = await (await _productService.GetProductsByIdsAsync(productManufacturers.Select(m => m.ProductId).ToArray()))
            //ACL and store mapping
            .WhereAwait(async p => await _aclService.AuthorizeAsync(p) && await _storeMappingService.AuthorizeAsync(p))
            //availability dates
            .Where(p => _productService.ProductIsAvailable(p)).ToListAsync();

            if (!products.Any())
                return Content("");

            //prepare model
            var model = (await _productModelFactory.PrepareProductOverviewModelsAsync(products, true, true, productThumbPictureSize)).ToList();

            return View("~/Plugins/Widget.BestSeller/Views/PublicHomePageBestSellerBrand.cshtml", model);
        }
    }
}
