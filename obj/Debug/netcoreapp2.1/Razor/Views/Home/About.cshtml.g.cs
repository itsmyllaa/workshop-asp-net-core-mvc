#pragma checksum "C:\Users\camila.xavier.santos\Documents\ProjetosC\SalesWebMvc\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0de4b338740a2e3e45803299a8b4a9bef9828a80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\camila.xavier.santos\Documents\ProjetosC\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "C:\Users\camila.xavier.santos\Documents\ProjetosC\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0de4b338740a2e3e45803299a8b4a9bef9828a80", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2e2b60b9eed1441a894d9b4653357ac35914ada", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\camila.xavier.santos\Documents\ProjetosC\SalesWebMvc\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(46, 17, false);
#line 4 "C:\Users\camila.xavier.santos\Documents\ProjetosC\SalesWebMvc\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(63, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(75, 19, false);
#line 5 "C:\Users\camila.xavier.santos\Documents\ProjetosC\SalesWebMvc\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(94, 22, true);
            WriteLiteral("</h3>\r\n\r\n<p>Professor ");
            EndContext();
            BeginContext(117, 21, false);
#line 7 "C:\Users\camila.xavier.santos\Documents\ProjetosC\SalesWebMvc\Views\Home\About.cshtml"
        Write(ViewData["Professor"]);

#line default
#line hidden
            EndContext();
            BeginContext(138, 18, true);
            WriteLiteral("</p>\r\n<p>Aluno(a) ");
            EndContext();
            BeginContext(157, 25, false);
#line 8 "C:\Users\camila.xavier.santos\Documents\ProjetosC\SalesWebMvc\Views\Home\About.cshtml"
       Write(ViewData["Participantes"]);

#line default
#line hidden
            EndContext();
            BeginContext(182, 241, true);
            WriteLiteral("</p>\r\n\r\n<address>\r\n    <strong>More information: </strong> <a href=\"http://educandoweb.com.br\">Educandoweb.com.br</a>\r\n    <strong> Participants: </strong> <a href=\"https://github.com/itsmyllaa\"> Camila Gabriela Xavier Santos</a>\r\n</address>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
