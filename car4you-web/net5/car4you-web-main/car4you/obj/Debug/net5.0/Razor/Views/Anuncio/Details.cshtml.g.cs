#pragma checksum "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "522de45176f27a703592ca1d27d7a10e6291451b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anuncio_Details), @"mvc.1.0.view", @"/Views/Anuncio/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"522de45176f27a703592ca1d27d7a10e6291451b", @"/Views/Anuncio/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96e4a1c45780fcc527ab8b3d6cfce8f9f6b193a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Anuncio_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<car4you.Models.Anuncio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
  
    ViewData["Title"] = "Detalhes";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Detalhes</h1>
 <h4>anúncio</h4>
    <hr />

<asp:Content ID=""Content3"" ContentPlaceHolderID=""ContentPlaceHolder1"" runat=""server"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>


    <style>

     


        .vertical .carousel-inner {
            height: 400px;
        }

        .carousel.vertical .item {
            -webkit-transition: 0.6s ease-in-out top  ;
            -moz-transition: 0.6s ease-in-out top  ;
            -ms-transition: 0.6s ease-in-out top  ;
            -o-transition: 0.6s ease-in-out top  ;
            transition: 0.6s ease-in-out top ;
             left: 0;
        }
      

        .carousel.vertical .active {
            top: 0;
           
        }

        .carousel.vertical .next {
            top: 100%;
      
        }

        ");
            WriteLiteral(@".carousel.vertical .prev {
            top: -100%;
       
        }

            .carousel.vertical .next.left,
            .carousel.vertical .prev.right {
                top: 0;
            }

        .carousel.vertical .active.left {
            top: -100%;

        }

        .carousel.vertical .active.right {
            top: 100%;
            
        }
        .imagem{
        width: 400px;
        height: 400px;
        padding: 10px 0;
          border: 3px;
        }
        img{
        width: 400px;
        }

        
    </style>



    <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" style=""overflow: hidden;height: 400px;width: 400px"">
        <!-- Indicators -->
        <ol class=""carousel-indicators"">
            <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#myCarousel"" data-slide-to=""1""></li>
            <li data-target=""#myCarousel"" data-slide-to=""2""></li>
        </ol>
        <!-- Wrapper for slides -->
        <div cl");
            WriteLiteral("ass=\"carousel-inner\" style=\"height: 400px\">\n            <div class=\"item active imagem\">\n                <img src=\"http://www.motorespt.com/wp-content/uploads/2012/01/honda_delsol_vti7169904705076431682.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2373, "\"", 2379, 0);
            EndWriteAttribute();
            WriteLiteral(" >\n            </div>\n\n            <div class=\"item imagem\">\n                <img src=\"http://thumbs.img-sprzedajemy.pl/1000x901c/ce/50/67/sprzedam-vw-polo-lift-slawkow-529790435.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2563, "\"", 2569, 0);
            EndWriteAttribute();
            WriteLiteral(" >\n            </div>\n\n            <div class=\"item\" imagem>\n                <img src=\"http://image.ceneostatic.pl/data/products/74174708/f-volkswagen-polo-1-4-tdi-bluemotion-80-km.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2755, "\"", 2761, 0);
            EndWriteAttribute();
            WriteLiteral(@" >
            </div>
        </div>

        <!-- Left and right controls -->
        <a class=""left carousel-control"" data-target=""#myCarousel"" data-slide=""prev"">
            <span class=""glyphicon glyphicon-chevron-left""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""right carousel-control"" data-target=""#myCarousel"" data-slide=""next"">
            <span class=""glyphicon glyphicon-chevron-right""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
</asp:Content>
  
<div>
   
    <dl class=""row"">    
        <dt class = ""col-sm-2"">
            Título
        </dt>
        <dd class = ""col-sm-10"">
            ");
#nullable restore
#line 122 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.designacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Data de criação\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 128 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.datacriado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            URL\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 134 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Descrição\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 140 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Negociável\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 146 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.renegociar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        \n        <dt class = \"col-sm-2\">\n            Preço \n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 153 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.valor));

#line default
#line hidden
#nullable disable
            WriteLiteral(" €\n        </dd>\n        <dt class = \"col-sm-2\">\n            Cor\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 159 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.cor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Número de portas\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 165 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.nporta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Tipo de caixa\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 171 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.caixa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Matricula\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 177 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.matricula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Lotação\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 183 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.lotacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Ano da viatura\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 189 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.ano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Cilindrada\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 195 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.cilindrada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Potência\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 201 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.potencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Quilômetros\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 207 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.kms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Modelo\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 213 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.Modelo.designacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Desgaste\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 219 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.Desgaste.designacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Tipo de segmento\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 225 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.Segmento.designacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        </dd>\n        <dt class=\"col-sm-2\">\n            Tipo Veiculo\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 232 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.TipoVeiculo.designacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Utilizador\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 238 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.Utilizador.nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n    <div>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "522de45176f27a703592ca1d27d7a10e6291451b16089", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 242 "D:\Nova pasta\NetBeansProjects\car4you-web-main\car4you-web-main\car4you\Views\Anuncio\Details.cshtml"
                               WriteLiteral(Model.IDANUNCIO);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "522de45176f27a703592ca1d27d7a10e6291451b18270", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \n    </div>\n</div>\n<br>\n<br>\n<br>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<car4you.Models.Anuncio> Html { get; private set; }
    }
}
#pragma warning restore 1591
