#pragma checksum "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\Customer\_CheckUsernameAvailability.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97b0681e9bdda8567aa0da9923ecf3ef02dba7ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer__CheckUsernameAvailability), @"mvc.1.0.view", @"/Views/Customer/_CheckUsernameAvailability.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 9 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using static Nop.Services.Common.NopLinksDefaults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Boards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Checkout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Media;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Newsletter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.PrivateMessages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Profile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Vendors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97b0681e9bdda8567aa0da9923ecf3ef02dba7ff", @"/Views/Customer/_CheckUsernameAvailability.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36d1b9cf4fa5ba34fd858c89c406a07634618cfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer__CheckUsernameAvailability : Nop.Web.Framework.Mvc.Razor.NopRazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Nop.Web.Framework.TagHelpers.Public.ScriptTagHelper __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97b0681e9bdda8567aa0da9923ecf3ef02dba7ff9282", async() => {
                WriteLiteral(@"
    $(document).ready(function () {
        $('#check-availability-button').before('<span id=""username-availabilty""></span>');
        $('#Username').on({
            keydown: function () {
                $('#username-availabilty').text('');
            }
        });
        $('#check-availability-button').on('click', function () {
            $('#username-availabilty').text('');
            if ($(""#Username"").val().length > 0) {
                $('#availability-check-progress').show();
                $('#check-availability-button').prop('disabled', true);

                var postData = {
                    Username: $('#Username').val()
                };
                addAntiForgeryToken(postData);

                $.ajax({
                    cache: false,
                    type: ""POST"",
                    url: """);
#nullable restore
#line 23 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\Customer\_CheckUsernameAvailability.cshtml"
                     Write(Url.RouteUrl("CheckUsernameAvailability"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                    data: postData,
                    dataType: ""json"",
                    success: function (data, textStatus, jqXHR) {
                        $('#availability-check-progress').hide();
                        $('#username-availabilty').removeAttr('class').attr('class', ((data.Available) ? 'username-available-status' : 'username-not-available-status'));
                        $('#username-availabilty').text(data.Text);
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                        $('#availability-check-progress').hide();
                    },
                    complete: function (jqXHR, textStatus) {
                        $('#check-availability-button').prop('disabled', false);
                    }
                });
            } else {
                $('#username-availabilty').attr('class', 'username-not-available-status');
                $('#username-availabilty').text('");
#nullable restore
#line 40 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\Customer\_CheckUsernameAvailability.cshtml"
                                            Write(T("Account.CheckUsernameAvailability.EnterUsername"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n            }\r\n            return false;\r\n        });\r\n    });\r\n");
            }
            );
            __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper);
#nullable restore
#line 1 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\Customer\_CheckUsernameAvailability.cshtml"
__Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper.Location = global::Nop.Web.Framework.UI.ResourceLocation.Footer;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-location", __Nop_Web_Framework_TagHelpers_Public_ScriptTagHelper.Location, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<button type=\"button\" id=\"check-availability-button\" class=\"button-2 check-username-availability-button\">");
#nullable restore
#line 46 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\Customer\_CheckUsernameAvailability.cshtml"
                                                                                                    Write(T("Account.CheckUsernameAvailability.Button"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n<span id=\"availability-check-progress\" style=\"display: none;\" class=\"please-wait\">");
#nullable restore
#line 47 "D:\BSS_OFFICE\New folder\nopCommerce_4.40.3_Source1\src\Presentation\Nop.Web\Views\Customer\_CheckUsernameAvailability.cshtml"
                                                                             Write(T("Common.Wait"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
