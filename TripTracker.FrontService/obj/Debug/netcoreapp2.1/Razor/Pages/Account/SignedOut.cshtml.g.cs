#pragma checksum "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Account\SignedOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2130c0ebaaa494a380f6c6967590eff73db15bb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TripTracker.FrontService.Pages.Account.Pages_Account_SignedOut), @"mvc.1.0.razor-page", @"/Pages/Account/SignedOut.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Account/SignedOut.cshtml", typeof(TripTracker.FrontService.Pages.Account.Pages_Account_SignedOut), null)]
namespace TripTracker.FrontService.Pages.Account
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
#line 1 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Account\_ViewImports.cshtml"
using TripTracker.FrontService.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2130c0ebaaa494a380f6c6967590eff73db15bb5", @"/Pages/Account/SignedOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c34e055f3144877773723e05f7237f85f5197730", @"/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1a3fc0bbd0bbe94c7a463d4b6ab18613af6b879", @"/Pages/Account/_ViewImports.cshtml")]
    public class Pages_Account_SignedOut : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Account\SignedOut.cshtml"
  
    ViewData["Title"] = "Signed out";

#line default
#line hidden
            BeginContext(76, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(83, 17, false);
#line 7 "C:\Users\User\source\repos\TripTracker.BackService\TripTracker.FrontService\Pages\Account\SignedOut.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(100, 57, true);
            WriteLiteral("</h2>\r\n<p>\r\n    You have successfully signed out.\r\n</p>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignedOutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SignedOutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SignedOutModel>)PageContext?.ViewData;
        public SignedOutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
