#pragma checksum "C:\Users\rkala\Dropbox\c#.net\ASP.NET\Service\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccc6d5430200a7eece75736a4bf343f9fc7b596c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\rkala\Dropbox\c#.net\ASP.NET\Service\Views\_ViewImports.cshtml"
using Service;

#line default
#line hidden
#line 2 "C:\Users\rkala\Dropbox\c#.net\ASP.NET\Service\Views\_ViewImports.cshtml"
using Service.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccc6d5430200a7eece75736a4bf343f9fc7b596c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c57f6a16e9791a86ba133440e9a658aaa8166994", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "NewsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\rkala\Dropbox\c#.net\ASP.NET\Service\Views\Home\Index.cshtml"
  
  ViewData["Title"] = "Home";

#line default
#line hidden
            BeginContext(38, 882, true);
            WriteLiteral(@"
<style>

.scrollbar
{
	height: 500px;
	width: 65px;
	background: #F5F5F5;
	overflow-y: scroll;
	margin-bottom: 25px;
}

#wrapper
{
	text-align: center;
	width: 500px;
	margin: auto;
}

#style-5::-webkit-scrollbar-track
{
	-webkit-box-shadow: inset 0 0 6px rgba(0,0,0,0.3);
	background-color: #F5F5F5;
}

#style-5::-webkit-scrollbar
{
	width: 10px;
	background-color: #F5F5F5;
}

#style-5::-webkit-scrollbar-thumb
{
	background-color: #343a40;
	
	background-image: -webkit-gradient(linear, 0 0, 0 100%,
	                   color-stop(.5, rgba(255, 255, 255, .2)),
					   color-stop(.5, transparent), to(transparent));
}
</style>

<div class=""row"">
  <div class=""col-md-7"">
    <h4 class=""text-dark"">News & Announcements</h4>
    <div class=""jumbotron p-2 shadow scrollbar w-100"" id=""style-5"">
      <div class=""overflow-auto"">
        ");
            EndContext();
            BeginContext(920, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ccc6d5430200a7eece75736a4bf343f9fc7b596c4479", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(949, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(959, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ccc6d5430200a7eece75736a4bf343f9fc7b596c5742", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(988, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(998, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ccc6d5430200a7eece75736a4bf343f9fc7b596c7005", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1027, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1037, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ccc6d5430200a7eece75736a4bf343f9fc7b596c8270", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1066, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1076, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ccc6d5430200a7eece75736a4bf343f9fc7b596c9535", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1105, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1115, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ccc6d5430200a7eece75736a4bf343f9fc7b596c10800", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1144, 219, true);
            WriteLiteral("\r\n      </div>\r\n    </div>\r\n  </div>\r\n\r\n  <div class=\"col-md-5\">\r\n    <h4 class=\"text-dark\">Open Tickets</h4>\r\n      <div class=\"jumbotron p-2 shadow scrollbar w-100\" id=\"style-5\">\r\n        <div class=\"overflow-auto\">\r\n");
            EndContext();
#line 64 "C:\Users\rkala\Dropbox\c#.net\ASP.NET\Service\Views\Home\Index.cshtml"
            
            foreach(TicketModel ticket in ViewBag.AllTickets)
            {

#line default
#line hidden
            BeginContext(1455, 167, true);
            WriteLiteral("              <div class=\"card w-100 px-2 pt-2 pb-1 mb-2 shadow-sm\">\r\n                <div class=\"row mx-0 mb-1 pb-1 border-bottom\">\r\n                  <small>Store - ");
            EndContext();
            BeginContext(1623, 24, false);
#line 69 "C:\Users\rkala\Dropbox\c#.net\ASP.NET\Service\Views\Home\Index.cshtml"
                            Write(ticket.Location.Store_Id);

#line default
#line hidden
            EndContext();
            BeginContext(1647, 2, true);
            WriteLiteral(" [");
            EndContext();
            BeginContext(1650, 20, false);
#line 69 "C:\Users\rkala\Dropbox\c#.net\ASP.NET\Service\Views\Home\Index.cshtml"
                                                       Write(ticket.Location.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1670, 15, true);
            WriteLiteral("] | Opened By: ");
            EndContext();
            BeginContext(1686, 28, false);
#line 69 "C:\Users\rkala\Dropbox\c#.net\ASP.NET\Service\Views\Home\Index.cshtml"
                                                                                           Write(ticket.Reported_By.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1714, 13, true);
            WriteLiteral(" | Priority: ");
            EndContext();
            BeginContext(1728, 15, false);
#line 69 "C:\Users\rkala\Dropbox\c#.net\ASP.NET\Service\Views\Home\Index.cshtml"
                                                                                                                                     Write(ticket.Priority);

#line default
#line hidden
            EndContext();
            BeginContext(1743, 11, true);
            WriteLiteral(" | Status: ");
            EndContext();
            BeginContext(1755, 13, false);
#line 69 "C:\Users\rkala\Dropbox\c#.net\ASP.NET\Service\Views\Home\Index.cshtml"
                                                                                                                                                                Write(ticket.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1768, 61, true);
            WriteLiteral(" </small>\r\n                </div>\r\n                <small>WO-");
            EndContext();
            BeginContext(1830, 16, false);
#line 71 "C:\Users\rkala\Dropbox\c#.net\ASP.NET\Service\Views\Home\Index.cshtml"
                     Write(ticket.Ticket_Id);

#line default
#line hidden
            EndContext();
            BeginContext(1846, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(1850, 18, false);
#line 71 "C:\Users\rkala\Dropbox\c#.net\ASP.NET\Service\Views\Home\Index.cshtml"
                                         Write(ticket.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1868, 60, true);
            WriteLiteral("</small>\r\n                <small class=\"text-muted\">Opened: ");
            EndContext();
            BeginContext(1929, 23, false);
#line 72 "C:\Users\rkala\Dropbox\c#.net\ASP.NET\Service\Views\Home\Index.cshtml"
                                             Write(ticket.TimeDiffCreate());

#line default
#line hidden
            EndContext();
            BeginContext(1952, 12, true);
            WriteLiteral(" | Updated: ");
            EndContext();
            BeginContext(1965, 23, false);
#line 72 "C:\Users\rkala\Dropbox\c#.net\ASP.NET\Service\Views\Home\Index.cshtml"
                                                                                 Write(ticket.TimeDiffUpdate());

#line default
#line hidden
            EndContext();
            BeginContext(1988, 52, true);
            WriteLiteral("</small>\r\n                <small class=\"text-muted\">");
            EndContext();
            BeginContext(2041, 20, false);
#line 73 "C:\Users\rkala\Dropbox\c#.net\ASP.NET\Service\Views\Home\Index.cshtml"
                                     Write(ticket.Location.City);

#line default
#line hidden
            EndContext();
            BeginContext(2061, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(2065, 21, false);
#line 73 "C:\Users\rkala\Dropbox\c#.net\ASP.NET\Service\Views\Home\Index.cshtml"
                                                             Write(ticket.Location.State);

#line default
#line hidden
            EndContext();
            BeginContext(2086, 613, true);
            WriteLiteral(@"</small>
                <div class=""row mx-0 mt-1 pt-1 border-top"">
                  <div class=""mr-auto"">
                    <button class=""btn btn-link p-1"" title=""Edit"" style=""line-height: 1;""><i class=""fas fa-pencil-alt text-primary""></i></button>
                    <button class=""btn btn-link p-1"" title=""Delete"" style=""line-height: 1;""><i class=""far fa-trash-alt text-primary""></i></button>
                  </div>
                  <button class=""btn btn-outline-primary btn-sm ml-auto"" style=""font-size: 0.75rem; line-height: 1;"">Check In</button>
                </div>
              </div>");
            EndContext();
#line 81 "C:\Users\rkala\Dropbox\c#.net\ASP.NET\Service\Views\Home\Index.cshtml"
                    ;
            }
          

#line default
#line hidden
            BeginContext(2730, 48, true);
            WriteLiteral("        </div>\r\n      </div>\r\n  </div>\r\n\r\n</div>");
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
