#pragma checksum "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Trips\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "950b52edf0bce22dc7041f132fa6f399809ac993"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TripTracker.FrontService.Pages.Trips.Pages_Trips_Index), @"mvc.1.0.razor-page", @"/Pages/Trips/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Trips/Index.cshtml", typeof(TripTracker.FrontService.Pages.Trips.Pages_Trips_Index), null)]
namespace TripTracker.FrontService.Pages.Trips
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\_ViewImports.cshtml"
using TripTracker.FrontService;

#line default
#line hidden
#line 3 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\_ViewImports.cshtml"
using TripTracker.FrontService.Data;

#line default
#line hidden
#line 5 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Trips\Index.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"950b52edf0bce22dc7041f132fa6f399809ac993", @"/Pages/Trips/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c34e055f3144877773723e05f7237f85f5197730", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Trips_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 6 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Trips\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
            BeginContext(274, 18, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n");
            EndContext();
#line 12 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Trips\Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
            BeginContext(333, 17, true);
            WriteLiteral("    <p>\r\n        ");
            EndContext();
            BeginContext(350, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bb1d04fcaad48e3b2309f7379381bf3", async() => {
                BeginContext(371, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(385, 10, true);
            WriteLiteral("\r\n    </p>");
            EndContext();
#line 16 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Trips\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(398, 84, true);
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(483, 49, false);
#line 21 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Trips\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Trips[0].Name));

#line default
#line hidden
            EndContext();
            BeginContext(532, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(588, 54, false);
#line 24 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Trips\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Trips[0].StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(642, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(698, 52, false);
#line 27 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Trips\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Trips[0].EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(750, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 33 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Trips\Index.cshtml"
         foreach (var item in Model.Trips)
        {

#line default
#line hidden
            BeginContext(891, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(952, 39, false);
#line 37 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Trips\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(991, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1059, 44, false);
#line 40 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Trips\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1171, 42, false);
#line 43 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Trips\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1213, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 46 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Trips\Index.cshtml"
                     if (SignInManager.IsSignedIn(User))
                    {

#line default
#line hidden
            BeginContext(1341, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1365, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c144bca7aea48c0b8dbeac8e3248e02", async() => {
                BeginContext(1410, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Trips\Index.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1418, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1421, 3, true);
            WriteLiteral("|\r\n");
            EndContext();
#line 49 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Trips\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1447, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1467, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0db5e846920744f39abf98ecf03b3ad7", async() => {
                BeginContext(1515, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Trips\Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1526, 1, true);
            WriteLiteral(" ");
            EndContext();
#line 50 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Trips\Index.cshtml"
                                                                                 if (SignInManager.IsSignedIn(User))
                    {

#line default
#line hidden
            BeginContext(1588, 27, true);
            WriteLiteral("|\r\n                        ");
            EndContext();
            BeginContext(1615, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4ea4edfc9914a59b488b221024615f0", async() => {
                BeginContext(1662, 8, true);
                WriteLiteral(" Delete ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Trips\Index.cshtml"
                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1674, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 53 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Trips\Index.cshtml"

                    }

#line default
#line hidden
            BeginContext(1701, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 57 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Trips\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1754, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Authorization.IAuthorizationService Auth { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TripTracker.FrontService.Pages.Trips.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TripTracker.FrontService.Pages.Trips.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TripTracker.FrontService.Pages.Trips.IndexModel>)PageContext?.ViewData;
        public TripTracker.FrontService.Pages.Trips.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
