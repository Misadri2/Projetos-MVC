#pragma checksum "C:\Users\MAON\Projetos\Estudo MVC Projetos\aula1\Views\Funcionarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15e12189c5a0f4fe0dccaf240aa883c02318fc51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionarios_Index), @"mvc.1.0.view", @"/Views/Funcionarios/Index.cshtml")]
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
#line 1 "C:\Users\MAON\Projetos\Estudo MVC Projetos\aula1\Views\_ViewImports.cshtml"
using aula1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MAON\Projetos\Estudo MVC Projetos\aula1\Views\_ViewImports.cshtml"
using aula1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15e12189c5a0f4fe0dccaf240aa883c02318fc51", @"/Views/Funcionarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2263627dffc3d2cfd0c5ca5130a23d7baf321d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<aula1.Models.Funcionario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Todos os funcionários</h2>\r\n<a href=\"/Funcionarios/Cadastrar\" class=\"btn btn-success\">Novo Funcionario</a>\r\n<hr>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\MAON\Projetos\Estudo MVC Projetos\aula1\Views\Funcionarios\Index.cshtml"
 foreach (var funcionario in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>CPF: ");
#nullable restore
#line 9 "C:\Users\MAON\Projetos\Estudo MVC Projetos\aula1\Views\Funcionarios\Index.cshtml"
       Write(funcionario.CPF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Nome: ");
#nullable restore
#line 10 "C:\Users\MAON\Projetos\Estudo MVC Projetos\aula1\Views\Funcionarios\Index.cshtml"
        Write(funcionario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Salário: ");
#nullable restore
#line 11 "C:\Users\MAON\Projetos\Estudo MVC Projetos\aula1\Views\Funcionarios\Index.cshtml"
           Write(funcionario.Salario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 326, "\"", 369, 2);
            WriteAttributeValue("", 333, "/Funcionarios/Editar/", 333, 21, true);
#nullable restore
#line 12 "C:\Users\MAON\Projetos\Estudo MVC Projetos\aula1\Views\Funcionarios\Index.cshtml"
WriteAttributeValue("", 354, funcionario.Id, 354, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Editar</a>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 413, "\"", 457, 2);
            WriteAttributeValue("", 420, "/Funcionarios/Deletar/", 420, 22, true);
#nullable restore
#line 13 "C:\Users\MAON\Projetos\Estudo MVC Projetos\aula1\Views\Funcionarios\Index.cshtml"
WriteAttributeValue("", 442, funcionario.Id, 442, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Deletar</a>\r\n    <hr>\r\n");
#nullable restore
#line 15 "C:\Users\MAON\Projetos\Estudo MVC Projetos\aula1\Views\Funcionarios\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<aula1.Models.Funcionario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
