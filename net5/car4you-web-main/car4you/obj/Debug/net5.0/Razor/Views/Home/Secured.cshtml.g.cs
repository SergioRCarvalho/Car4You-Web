#pragma checksum "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Home\Secured.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32fc8adb5f6ac34c690e4c958fcd0307996f3e86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Secured), @"mvc.1.0.view", @"/Views/Home/Secured.cshtml")]
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
#line 1 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\_ViewImports.cshtml"
using car4you;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\_ViewImports.cshtml"
using car4you.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32fc8adb5f6ac34c690e4c958fcd0307996f3e86", @"/Views/Home/Secured.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96e4a1c45780fcc527ab8b3d6cfce8f9f6b193a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Secured : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Home\Secured.cshtml"
  
    ViewData["Title"] = "Secured";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<h1>");
#nullable restore
#line 8 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Home\Secured.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<h2>Welcome ");
#nullable restore
#line 9 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Home\Secured.cshtml"
       Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<ul>\n");
#nullable restore
#line 11 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Home\Secured.cshtml"
     foreach (var c in User.Claims)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 13 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Home\Secured.cshtml"
       Write(c.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 13 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Home\Secured.cshtml"
               Write(c.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 14 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Home\Secured.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n");
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
