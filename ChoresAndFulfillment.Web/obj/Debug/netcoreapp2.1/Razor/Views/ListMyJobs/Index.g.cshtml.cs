#pragma checksum "C:\Users\Vasko\source\repos\Chores_And_Fulfillment\ChoresAndFulfillment.Web\Views\ListMyJobs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b0089664bf74b7bed87d71c8be76eaca70ae8d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ListMyJobs_Index), @"mvc.1.0.view", @"/Views/ListMyJobs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ListMyJobs/Index.cshtml", typeof(AspNetCore.Views_ListMyJobs_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b0089664bf74b7bed87d71c8be76eaca70ae8d3", @"/Views/ListMyJobs/Index.cshtml")]
    public class Views_ListMyJobs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Vasko\source\repos\Chores_And_Fulfillment\ChoresAndFulfillment.Web\Views\ListMyJobs\Index.cshtml"
  
    ViewData["Title"] = "List my Jobs";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(97, 64, true);
            WriteLiteral("<h3>Your active jobs:</h3>\r\n<br/>\r\n<ul class=\"list-group\">\r\n    ");
            EndContext();
            BeginContext(162, 26, false);
#line 9 "C:\Users\Vasko\source\repos\Chores_And_Fulfillment\ChoresAndFulfillment.Web\Views\ListMyJobs\Index.cshtml"
Write(Html.Raw(ViewData["Jobs"]));

#line default
#line hidden
            EndContext();
            BeginContext(188, 11, true);
            WriteLiteral("\r\n</ul>\r\n\r\n");
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