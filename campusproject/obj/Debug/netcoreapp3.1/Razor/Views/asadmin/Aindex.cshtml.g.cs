#pragma checksum "C:\Users\Terpex\source\repos\campusproject\campusproject\Views\asadmin\Aindex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd09c625e3586b2d4e19ce4f505093f655f1ff10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_asadmin_Aindex), @"mvc.1.0.view", @"/Views/asadmin/Aindex.cshtml")]
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
#line 1 "C:\Users\Terpex\source\repos\campusproject\campusproject\Views\_ViewImports.cshtml"
using campusproject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Terpex\source\repos\campusproject\campusproject\Views\_ViewImports.cshtml"
using campusproject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd09c625e3586b2d4e19ce4f505093f655f1ff10", @"/Views/asadmin/Aindex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bd623fe6c431d9a742029f41fbd77580d71ebc3", @"/Views/_ViewImports.cshtml")]
    public class Views_asadmin_Aindex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Terpex\source\repos\campusproject\campusproject\Views\asadmin\Aindex.cshtml"
  

    Layout = "_Layoutadmin";


#line default
#line hidden
#nullable disable
            WriteLiteral(@" 
<div class=""column1"">
    <div class=""container"">
        <h2>Student Detail</h2>
        <table class=""table"">
            <thead>
                <tr>
                    <th>Student Name</th>
                    <th>Qualification</th>
                    <th>Email</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>PQR</td>
                    <td>PQR has done BE from banglor </td>
                    <td style=""margin-left:auto;"">
                        beinbanglor@gmail.com
                    </td>
                </tr>
            </tbody>
        </table>
        <button style=""margin-bottom:500px"" type=""button"" class=""btn btn-primary"">Add student</button>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
