#pragma checksum "C:\Users\Windows 10\Desktop\Bernardo\Faculdade\3º semestre\Programação Windows Avançada\Projetos\Remake do buffet\Buffet\Atividade1\Views\Shared\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a3a4e0bfeceb205869d67f80cedd81c6ceeef66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Login), @"mvc.1.0.view", @"/Views/Shared/Login.cshtml")]
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
#line 1 "C:\Users\Windows 10\Desktop\Bernardo\Faculdade\3º semestre\Programação Windows Avançada\Projetos\Remake do buffet\Buffet\Atividade1\Views\_ViewImports.cshtml"
using Atividade1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Windows 10\Desktop\Bernardo\Faculdade\3º semestre\Programação Windows Avançada\Projetos\Remake do buffet\Buffet\Atividade1\Views\_ViewImports.cshtml"
using Atividade1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3a4e0bfeceb205869d67f80cedd81c6ceeef66", @"/Views/Shared/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7ed4c3d785faa28005bfa3f4321b875554ce590", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Buffet.Acesso.MsgAcessoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Windows 10\Desktop\Bernardo\Faculdade\3º semestre\Programação Windows Avançada\Projetos\Remake do buffet\Buffet\Atividade1\Views\Shared\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\Users\Windows 10\Desktop\Bernardo\Faculdade\3º semestre\Programação Windows Avançada\Projetos\Remake do buffet\Buffet\Atividade1\Views\Shared\Login.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Windows 10\Desktop\Bernardo\Faculdade\3º semestre\Programação Windows Avançada\Projetos\Remake do buffet\Buffet\Atividade1\Views\Shared\Login.cshtml"
 if(Model.Mensagem != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br /><br />\r\n    <p>");
#nullable restore
#line 10 "C:\Users\Windows 10\Desktop\Bernardo\Faculdade\3º semestre\Programação Windows Avançada\Projetos\Remake do buffet\Buffet\Atividade1\Views\Shared\Login.cshtml"
  Write(Model.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 11 "C:\Users\Windows 10\Desktop\Bernardo\Faculdade\3º semestre\Programação Windows Avançada\Projetos\Remake do buffet\Buffet\Atividade1\Views\Shared\Login.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <label for=""login"">Login:</label>
    <input type=""text"" name=""login"" /><br />
    <label for=""senha"">Senha:</label>
    <input type=""password"" name=""senha"" /><br />
    <input type=""button"" value=""Entrar"" onclick=""location.href= '/Home/Principal'"" />
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Buffet.Acesso.MsgAcessoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
