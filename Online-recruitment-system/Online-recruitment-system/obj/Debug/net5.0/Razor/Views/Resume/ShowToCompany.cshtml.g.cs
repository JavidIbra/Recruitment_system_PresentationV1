#pragma checksum "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Resume\ShowToCompany.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e5a6d3f674b73aeff3d2efb4ee8321a0f1501e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Resume_ShowToCompany), @"mvc.1.0.view", @"/Views/Resume/ShowToCompany.cshtml")]
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
#line 1 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\_ViewImports.cshtml"
using Online_recruitment_system;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\_ViewImports.cshtml"
using Online_recruitment_system.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\_ViewImports.cshtml"
using Online_recruitment_system.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\_ViewImports.cshtml"
using Online_recruitment_system.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e5a6d3f674b73aeff3d2efb4ee8321a0f1501e9", @"/Views/Resume/ShowToCompany.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89ac1693e6f770a2b15eb1669a9c02a27e3830dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Resume_ShowToCompany : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResumeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/upload.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:800px; height:800px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Resume\ShowToCompany.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e5a6d3f674b73aeff3d2efb4ee8321a0f1501e95369", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title>Cv</title>
    <link rel=""stylesheet""
          href=""https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css""
          integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T""
          crossorigin=""anonymous"" />
    <link rel=""stylesheet""
          href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.3/font/bootstrap-icons.css"" />
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1e5a6d3f674b73aeff3d2efb4ee8321a0f1501e96220", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e5a6d3f674b73aeff3d2efb4ee8321a0f1501e98102", async() => {
                WriteLiteral(@"
    <div class=""loader"">
        <div class=""d-table"">
            <div class=""d-table-cell"">
                <div class=""spinner""></div>
            </div>
        </div>
    </div>

    <section class=""option"">
        <div class=""d-table"">
            <div class=""d-table-cell"">
                <div class=""container align-items-center"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
");
#nullable restore
#line 37 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Resume\ShowToCompany.cshtml"
                             if (Model.Resumes.Count() > 0)
                            {

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Resume\ShowToCompany.cshtml"
                                 foreach (var item in Model.Resumes)
                                {

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Resume\ShowToCompany.cshtml"
                                     if (item.Resume_Uploading != null)
                                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("embed", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1e5a6d3f674b73aeff3d2efb4ee8321a0f1501e99867", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1546, "~/resumes/", 1546, 10, true);
#nullable restore
#line 46 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Resume\ShowToCompany.cshtml"
AddHtmlAttributeValue("", 1556, item.Resume_Uploading, 1556, 22, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Resume\ShowToCompany.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <h3>\r\n                                            Some problems occured during proccess\r\n                                        </h3>\r\n");
#nullable restore
#line 53 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Resume\ShowToCompany.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Resume\ShowToCompany.cshtml"
                                     

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Resume\ShowToCompany.cshtml"
                                 
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <h3>\r\n                                    Candidate does\'nt has a CV\r\n                                </h3>\r\n");
#nullable restore
#line 62 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Resume\ShowToCompany.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    <script src=\"/js/jquery.js\"></script>\r\n    <script src=\"/js/script.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResumeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
