#pragma checksum "D:\интернет программирование\931921.solomin.dmitrii.lab11\931921.solomin.dmitrii.lab11\Views\CalcService\PassUsingModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6db1c2f1373f992faa8db8e5f8b1acc8e806a728"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CalcService_PassUsingModel), @"mvc.1.0.view", @"/Views/CalcService/PassUsingModel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6db1c2f1373f992faa8db8e5f8b1acc8e806a728", @"/Views/CalcService/PassUsingModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_CalcService_PassUsingModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_931921.solomin.dmitrii.lab11.Models.CalcModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\интернет программирование\931921.solomin.dmitrii.lab11\931921.solomin.dmitrii.lab11\Views\CalcService\PassUsingModel.cshtml"
   ViewBag.Title = "PassUsingModel - Backend1"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>PassUsingModel</h1>\r\n<b>Rand value first:</b> ");
#nullable restore
#line 5 "D:\интернет программирование\931921.solomin.dmitrii.lab11\931921.solomin.dmitrii.lab11\Views\CalcService\PassUsingModel.cshtml"
                    Write(Model.X);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<b>Rand value second:</b> ");
#nullable restore
#line 7 "D:\интернет программирование\931921.solomin.dmitrii.lab11\931921.solomin.dmitrii.lab11\Views\CalcService\PassUsingModel.cshtml"
                     Write(Model.Y);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n<b>Add:</b>\r\n<br />\r\n");
#nullable restore
#line 12 "D:\интернет программирование\931921.solomin.dmitrii.lab11\931921.solomin.dmitrii.lab11\Views\CalcService\PassUsingModel.cshtml"
Write(Model.Sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n<b>Dif:</b>\r\n<br />\r\n");
#nullable restore
#line 17 "D:\интернет программирование\931921.solomin.dmitrii.lab11\931921.solomin.dmitrii.lab11\Views\CalcService\PassUsingModel.cshtml"
Write(Model.Dif);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n<b>Mult:</b>\r\n<br />\r\n");
#nullable restore
#line 22 "D:\интернет программирование\931921.solomin.dmitrii.lab11\931921.solomin.dmitrii.lab11\Views\CalcService\PassUsingModel.cshtml"
Write(Model.Mult);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n<b>Div:</b>\r\n<br />\r\n");
#nullable restore
#line 27 "D:\интернет программирование\931921.solomin.dmitrii.lab11\931921.solomin.dmitrii.lab11\Views\CalcService\PassUsingModel.cshtml"
Write(Model.Div);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_931921.solomin.dmitrii.lab11.Models.CalcModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
