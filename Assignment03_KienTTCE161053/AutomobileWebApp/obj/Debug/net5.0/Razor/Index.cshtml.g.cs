#pragma checksum "D:\Code\GITHUB\CSharpStudy\Assignment03_KienTTCE161053\AutomobileWebApp\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e4463bc16a8cc37fbe72549b28d1150d35c0371"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Index), @"mvc.1.0.view", @"/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e4463bc16a8cc37fbe72549b28d1150d35c0371", @"/Index.cshtml")]
    #nullable restore
    public class Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AutomobileLibreri.DataAccess.Car>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Code\GITHUB\CSharpStudy\Assignment03_KienTTCE161053\AutomobileWebApp\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "`/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>\r\n    Index\r\n</h1>\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\Code\GITHUB\CSharpStudy\Assignment03_KienTTCE161053\AutomobileWebApp\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CarId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\Code\GITHUB\CSharpStudy\Assignment03_KienTTCE161053\AutomobileWebApp\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CarName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\Code\GITHUB\CSharpStudy\Assignment03_KienTTCE161053\AutomobileWebApp\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Manufacturer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\Code\GITHUB\CSharpStudy\Assignment03_KienTTCE161053\AutomobileWebApp\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "D:\Code\GITHUB\CSharpStudy\Assignment03_KienTTCE161053\AutomobileWebApp\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ReleasedYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "D:\Code\GITHUB\CSharpStudy\Assignment03_KienTTCE161053\AutomobileWebApp\Index.cshtml"
         foreach (var car in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "D:\Code\GITHUB\CSharpStudy\Assignment03_KienTTCE161053\AutomobileWebApp\Index.cshtml"
           Write(Html.DisplayFor(modelitem => car.CarId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\Code\GITHUB\CSharpStudy\Assignment03_KienTTCE161053\AutomobileWebApp\Index.cshtml"
           Write(Html.DisplayFor(modelitem => car.CarName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "D:\Code\GITHUB\CSharpStudy\Assignment03_KienTTCE161053\AutomobileWebApp\Index.cshtml"
           Write(Html.DisplayFor(modelitem => car.Manufacturer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "D:\Code\GITHUB\CSharpStudy\Assignment03_KienTTCE161053\AutomobileWebApp\Index.cshtml"
           Write(Html.DisplayFor(modelitem => car.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             </td>\r\n             <td>\r\n                ");
#nullable restore
#line 49 "D:\Code\GITHUB\CSharpStudy\Assignment03_KienTTCE161053\AutomobileWebApp\Index.cshtml"
           Write(Html.DisplayFor(modelitem => car.ReleasedYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             </td>\r\n             <td>\r\n                 ");
#nullable restore
#line 52 "D:\Code\GITHUB\CSharpStudy\Assignment03_KienTTCE161053\AutomobileWebApp\Index.cshtml"
            Write(Html.ActionLink("Edit", "Edit", new { id = car.CarId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                 ");
#nullable restore
#line 53 "D:\Code\GITHUB\CSharpStudy\Assignment03_KienTTCE161053\AutomobileWebApp\Index.cshtml"
            Write(Html.ActionLink("Details", "Details", new { id = car.CarId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                 ");
#nullable restore
#line 54 "D:\Code\GITHUB\CSharpStudy\Assignment03_KienTTCE161053\AutomobileWebApp\Index.cshtml"
            Write(Html.ActionLink("Delete", "Delete", new { id = car.CarId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("|\r\n             </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "D:\Code\GITHUB\CSharpStudy\Assignment03_KienTTCE161053\AutomobileWebApp\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AutomobileLibreri.DataAccess.Car>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
