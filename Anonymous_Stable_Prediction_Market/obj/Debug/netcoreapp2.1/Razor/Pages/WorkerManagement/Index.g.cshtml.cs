#pragma checksum "C:\Users\Vasko\source\repos\Chores_And_Fulfillment\Anonymous_Stable_Prediction_Market\Pages\WorkerManagement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4da32a8f8af1241be0a63e4a58e08e588846ae41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_WorkerManagement_Index), @"mvc.1.0.razor-page", @"/Pages/WorkerManagement/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/WorkerManagement/Index.cshtml", typeof(AspNetCore.Pages_WorkerManagement_Index), null)]
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
#line 1 "C:\Users\Vasko\source\repos\Chores_And_Fulfillment\Anonymous_Stable_Prediction_Market\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Vasko\source\repos\Chores_And_Fulfillment\Anonymous_Stable_Prediction_Market\Pages\_ViewImports.cshtml"
using ChoresAndFulfillment;

#line default
#line hidden
#line 3 "C:\Users\Vasko\source\repos\Chores_And_Fulfillment\Anonymous_Stable_Prediction_Market\Pages\_ViewImports.cshtml"
using ChoresAndFulfillment.Data;

#line default
#line hidden
#line 4 "C:\Users\Vasko\source\repos\Chores_And_Fulfillment\Anonymous_Stable_Prediction_Market\Pages\_ViewImports.cshtml"
using ChoresAndFulfillment.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4da32a8f8af1241be0a63e4a58e08e588846ae41", @"/Pages/WorkerManagement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ff0dcc0e6f6b38c1893a1c0d9d217c1d880ddaa", @"/Pages/_ViewImports.cshtml")]
    public class Pages_WorkerManagement_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Vasko\source\repos\Chores_And_Fulfillment\Anonymous_Stable_Prediction_Market\Pages\WorkerManagement\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(111, 11, true);
            WriteLiteral("<h3>Hello, ");
            EndContext();
            BeginContext(123, 30, false);
#line 6 "C:\Users\Vasko\source\repos\Chores_And_Fulfillment\Anonymous_Stable_Prediction_Market\Pages\WorkerManagement\Index.cshtml"
      Write(HttpContext.User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(153, 318, true);
            WriteLiteral(@". Here is what you can do from here:</h3>
<ul>
    <li>
        <a href=""/ListAllJobs/Index"">Apply for a job</a>
    </li>
    <li>
        <a href=""/YourApplications/Index"">Look through all your job applications</a>
    </li>
    <li>
        <a href=""/ListMyJobs/Index"">All your active jobs</a>
    </li>
");
            EndContext();
            BeginContext(639, 11, true);
            WriteLiteral("</ul>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChoresAndFulfillment.Pages.WorkerManagement.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ChoresAndFulfillment.Pages.WorkerManagement.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ChoresAndFulfillment.Pages.WorkerManagement.IndexModel>)PageContext?.ViewData;
        public ChoresAndFulfillment.Pages.WorkerManagement.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
