#pragma checksum "C:\Users\amalf\source\repos\Shopping\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "358a811bb58dad7f4d71d99e3f8c466b79bfc5b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\amalf\source\repos\Shopping\Views\_ViewImports.cshtml"
using Shopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amalf\source\repos\Shopping\Views\_ViewImports.cshtml"
using Shopping.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"358a811bb58dad7f4d71d99e3f8c466b79bfc5b5", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4487f0c86abf7612e0a877d6bdae29213eff1b91", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\amalf\source\repos\Shopping\Views\Products\Index.cshtml"
  
    var products = (List<ProductModel>)ViewData["products"];
    Layout = "_LayoutDesign";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 style=""text-align: center"">Books</h1>
<table class=""table table-striped table-hover"" style=""text-align: center"">
    <tr>
        <th scope=""col"">ID</th>
        <th scope=""col"">Name</th>
        <th scope=""col"">Price</th>
        <th scope=""col"">Image</th>
        <th scope=""col"">Show</th>
    </tr>
");
#nullable restore
#line 15 "C:\Users\amalf\source\repos\Shopping\Views\Products\Index.cshtml"
     foreach (var item in products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td> ");
#nullable restore
#line 18 "C:\Users\amalf\source\repos\Shopping\Views\Products\Index.cshtml"
            Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 19 "C:\Users\amalf\source\repos\Shopping\Views\Products\Index.cshtml"
            Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\amalf\source\repos\Shopping\Views\Products\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("src", " src=\"", 596, "\"", 613, 1);
#nullable restore
#line 21 "C:\Users\amalf\source\repos\Shopping\Views\Products\Index.cshtml"
WriteAttributeValue("", 602, item.Image, 602, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 614, "\"", 631, 1);
#nullable restore
#line 21 "C:\Users\amalf\source\repos\Shopping\Views\Products\Index.cshtml"
WriteAttributeValue("", 620, item.Image, 620, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150px\" height=\"200px\" /></td>\r\n            <td><button class=\"btn btn-outline-info\"><a");
            BeginWriteAttribute("href", " href=\"", 726, "\"", 760, 2);
            WriteAttributeValue("", 733, "/Products/Details/", 733, 18, true);
#nullable restore
#line 22 "C:\Users\amalf\source\repos\Shopping\Views\Products\Index.cshtml"
WriteAttributeValue(" ", 751, item.Id, 752, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> show</button></td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "C:\Users\amalf\source\repos\Shopping\Views\Products\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
