#pragma checksum "C:\Users\LIMA\Desktop\Site Advocacia\siteApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9101011a96e0687ca0370f5a0827a2c12a100d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\LIMA\Desktop\Site Advocacia\siteApp\Views\_ViewImports.cshtml"
using siteApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LIMA\Desktop\Site Advocacia\siteApp\Views\_ViewImports.cshtml"
using siteApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9101011a96e0687ca0370f5a0827a2c12a100d2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"017ce465682b1a138e16f1a3379ebc0eacc568db", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\LIMA\Desktop\Site Advocacia\siteApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<nav class=\"navbar navbar-expand-lg navbar-dark bg-dark container-lg .sticky-custom-top fixed-lg-top menu-flutuante\" id=\"menu\">\r\n    <div class=\"container\">\r\n        <a class=\"d-flex d-lg-none navbar-brand expand\" href=\"#page-top\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e9101011a96e0687ca0370f5a0827a2c12a100d24187", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
        <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#NAV"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation""><span class=""navbar-toggler-icon""></span></button>
        <div class=""collapse navbar-collapse"" id='NAV'>
            <ul class=""navbar-nav my-2 my-lg-0 mx-auto"">
                <li class=""nav-item""><a class=""nav-link mx-lg-3"" href=""#about"" style=""font-size:18px"">O Escritório</a></li>
                <li class=""nav-item menu"">
                    <a class=""nav-link mx-lg-3"" href=""javascript:void(0)"" style=""font-size:18px"">Áreas de atuação  <i class=""fas fa-stream""></i></i></a>
                    <ul class=""bg-dark px-3"">
	                  <li class=""nav-item""><a class=""nav-link"" href=""javascript:void(0)"">Item 1</a></li>
	                  <li class=""nav-item""><a class=""nav-link"" href=""javascript:void(0)"">Item 2</a></li>
	                  <li class=""nav-item""><a class=""nav-link"" href=""javascr");
            WriteLiteral(@"ipt:void(0)"">Item 3</a></li>
	       		    </ul>
                </li>
                <li class=""nav-item ""><a class=""nav-link mx-lg-3"" href=""#photos"" style=""font-size:18px"">Advogados</a></li>
                <li class=""nav-item""><a class=""nav-link mx-lg-3"" href=""#blog"" style=""font-size:18px"">Blog</a></li>
                <li class=""nav-item""><a class=""nav-link mx-lg-3"" href=""#contact"" style=""font-size:18px"">Contato</a></li>           
            </ul>
            <ul class=""navbar-nav my-2 my-lg-0 ml-auto"">
                <li class=""nav-item pesquisa"">
                    <a class=""nav-link mx-lg-3"" href=""javascript:void(0)""><i class=""fas fa-search  align-middle text-center"" style=""font-size:22px""></i></a>
                    <ul class=""bg-dark p-0"">
                        <input class=""form-control bg-dark""/>
                    </ul>
                </li>
            </ul>
        </div>
    </div>
</nav>
<div id=""page-top"" class=""h-50 bg-img-custom"">
    <h2 class=""text-center text-");
            WriteLiteral(@"white font-weight-bold pt-5"">Costa</h2>
    <h3 class=""text-center text-white font-weight-bold"">Assessoria Jurídica</h3>
</div>
<!-- About-->
<div class=""bg-dark"">
    <div class=""container"" style=""padding-bottom:10em"">
        <div class=""row justify-content-center"">
            <div class=""col-md-6 border"" style=""height:20em"">
                <h3 class=""text-center text-white font-weight-bold mt-5"">Conteúdo 1</h3>
            </div>
            <div class=""col-md-6 border"" style=""height:20em"">
                <h3 class=""text-center text-white font-weight-bold mt-5"">Conteúdo 2</h3>
            </div>
            <div class=""col-md-3 border"" style=""height:10em"">
                <h3 class=""text-center text-white font-weight-bold mt-5"">Conteúdo 3</h3>
            </div>
            <div class=""col-md-3 border"" style=""height:10em"">
                <h3 class=""text-center text-white font-weight-bold mt-5"">Conteúdo 4</h3>
            </div>
            <div class=""col-md-3 border"" style=""height:1");
            WriteLiteral(@"0em"">
                <h3 class=""text-center text-white font-weight-bold mt-5"">Conteúdo 5</h3>
            </div>
            <div class=""col-md-3 border"" style=""height:10em"">
                <h3 class=""text-center text-white font-weight-bold mt-5"">Conteúdo 6</h3>
            </div>
        </div>
    </div>
</div>
<!-- Footer-->
<footer class=""bg-light py-5"">
    <div class=""container""><div class=""small text-center text-muted"">© 2019 - ");
#nullable restore
#line 65 "C:\Users\LIMA\Desktop\Site Advocacia\siteApp\Views\Home\Index.cshtml"
                                                                         Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" COSTA ASSESSORIA JURÍDICA</div></div>\r\n</footer>");
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