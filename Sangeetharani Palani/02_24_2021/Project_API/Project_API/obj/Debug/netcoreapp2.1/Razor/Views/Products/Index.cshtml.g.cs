#pragma checksum "E:\Sangeetharani\Project_API\Project_API\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "368263b90a6461d0b24c98331354a292e6a268c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Index.cshtml", typeof(AspNetCore.Views_Products_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"368263b90a6461d0b24c98331354a292e6a268c8", @"/Views/Products/Index.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Project_API.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Sangeetharani\Project_API\Project_API\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(91, 158, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(250, 40, false);
#line 16 "E:\Sangeetharani\Project_API\Project_API\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(290, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(346, 44, false);
#line 19 "E:\Sangeetharani\Project_API\Project_API\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(390, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(446, 41, false);
#line 22 "E:\Sangeetharani\Project_API\Project_API\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(487, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "E:\Sangeetharani\Project_API\Project_API\Views\Products\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(605, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(654, 39, false);
#line 31 "E:\Sangeetharani\Project_API\Project_API\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(693, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(749, 43, false);
#line 34 "E:\Sangeetharani\Project_API\Project_API\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
            EndContext();
            BeginContext(792, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(848, 40, false);
#line 37 "E:\Sangeetharani\Project_API\Project_API\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(888, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 963, "\"", 986, 1);
#line 40 "E:\Sangeetharani\Project_API\Project_API\Views\Products\Index.cshtml"
WriteAttributeValue("", 978, item.Id, 978, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(987, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1039, "\"", 1062, 1);
#line 41 "E:\Sangeetharani\Project_API\Project_API\Views\Products\Index.cshtml"
WriteAttributeValue("", 1054, item.Id, 1054, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1063, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1117, "\"", 1140, 1);
#line 42 "E:\Sangeetharani\Project_API\Project_API\Views\Products\Index.cshtml"
WriteAttributeValue("", 1132, item.Id, 1132, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1141, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "E:\Sangeetharani\Project_API\Project_API\Views\Products\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1191, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Project_API.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
