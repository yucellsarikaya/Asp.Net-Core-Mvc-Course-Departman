#pragma checksum "C:\Users\sarik\Desktop\Course\Asp.Net-Core-Mvc-Course-Departman\ProjeCore\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ad7780e040a7251eef4c56e6ab1f05f80ef3104"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Index), @"mvc.1.0.view", @"/Views/Default/Index.cshtml")]
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
#line 1 "C:\Users\sarik\Desktop\Course\Asp.Net-Core-Mvc-Course-Departman\ProjeCore\Views\_ViewImports.cshtml"
using ProjeCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\sarik\Desktop\Course\Asp.Net-Core-Mvc-Course-Departman\ProjeCore\Views\Default\Index.cshtml"
using ProjeCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ad7780e040a7251eef4c56e6ab1f05f80ef3104", @"/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f6887fc2a081498e457a98abd035f4ecf5faaf7", @"/Views/_ViewImports.cshtml")]
    public class Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Birim>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\sarik\Desktop\Course\Asp.Net-Core-Mvc-Course-Departman\ProjeCore\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Departmanlar</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Departman</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n        <th>Detaylar</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 19 "C:\Users\sarik\Desktop\Course\Asp.Net-Core-Mvc-Course-Departman\ProjeCore\Views\Default\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 22 "C:\Users\sarik\Desktop\Course\Asp.Net-Core-Mvc-Course-Departman\ProjeCore\Views\Default\Index.cshtml"
           Write(item.BirimID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 23 "C:\Users\sarik\Desktop\Course\Asp.Net-Core-Mvc-Course-Departman\ProjeCore\Views\Default\Index.cshtml"
           Write(item.BirimAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th><a");
            BeginWriteAttribute("href", " href=\"", 495, "\"", 532, 2);
            WriteAttributeValue("", 502, "Default/BirimSil/", 502, 17, true);
#nullable restore
#line 24 "C:\Users\sarik\Desktop\Course\Asp.Net-Core-Mvc-Course-Departman\ProjeCore\Views\Default\Index.cshtml"
WriteAttributeValue("", 519, item.BirimID, 519, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></th>\r\n            <th><a");
            BeginWriteAttribute("href", " href=\"", 597, "\"", 636, 2);
            WriteAttributeValue("", 604, "Default/BirimGetir/", 604, 19, true);
#nullable restore
#line 25 "C:\Users\sarik\Desktop\Course\Asp.Net-Core-Mvc-Course-Departman\ProjeCore\Views\Default\Index.cshtml"
WriteAttributeValue("", 623, item.BirimID, 623, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></th>\r\n            <th><a");
            BeginWriteAttribute("href", " href=\"", 707, "\"", 746, 2);
            WriteAttributeValue("", 714, "Default/BirimDetay/", 714, 19, true);
#nullable restore
#line 26 "C:\Users\sarik\Desktop\Course\Asp.Net-Core-Mvc-Course-Departman\ProjeCore\Views\Default\Index.cshtml"
WriteAttributeValue("", 733, item.BirimID, 733, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Detaylar</a></th>\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\sarik\Desktop\Course\Asp.Net-Core-Mvc-Course-Departman\ProjeCore\Views\Default\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n<a href=\"/Default/YeniBirim\" class=\"btn btn-outline-primary\">Yeni Birim Ekle</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Birim>> Html { get; private set; }
    }
}
#pragma warning restore 1591