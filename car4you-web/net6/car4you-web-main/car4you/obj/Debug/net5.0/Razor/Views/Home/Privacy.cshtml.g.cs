#pragma checksum "D:\Nova pasta\NetBeansProjects\car4you-web\net6\car4you-web-main\car4you\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5aa9d1d3a103e0ed9045e43572e000ca571c7739"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "D:\Nova pasta\NetBeansProjects\car4you-web\net6\car4you-web-main\car4you\Views\_ViewImports.cshtml"
using car4you;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Nova pasta\NetBeansProjects\car4you-web\net6\car4you-web-main\car4you\Views\_ViewImports.cshtml"
using car4you.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aa9d1d3a103e0ed9045e43572e000ca571c7739", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96e4a1c45780fcc527ab8b3d6cfce8f9f6b193a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Nova pasta\NetBeansProjects\car4you-web\net6\car4you-web-main\car4you\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "D:\Nova pasta\NetBeansProjects\car4you-web\net6\car4you-web-main\car4you\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n  \n  \n<table>\n    <thead>\n    <tr>\n        <th>Nome</th>\n        <th>Tlm</th>\n        <th>Morada</th>\n    </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 16 "D:\Nova pasta\NetBeansProjects\car4you-web\net6\car4you-web-main\car4you\Views\Home\Privacy.cshtml"
     foreach (var utilizador in @Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 19 "D:\Nova pasta\NetBeansProjects\car4you-web\net6\car4you-web-main\car4you\Views\Home\Privacy.cshtml"
           Write(utilizador.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 20 "D:\Nova pasta\NetBeansProjects\car4you-web\net6\car4you-web-main\car4you\Views\Home\Privacy.cshtml"
           Write(utilizador.telemovel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 21 "D:\Nova pasta\NetBeansProjects\car4you-web\net6\car4you-web-main\car4you\Views\Home\Privacy.cshtml"
           Write(utilizador.morada);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 23 "D:\Nova pasta\NetBeansProjects\car4you-web\net6\car4you-web-main\car4you\Views\Home\Privacy.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
