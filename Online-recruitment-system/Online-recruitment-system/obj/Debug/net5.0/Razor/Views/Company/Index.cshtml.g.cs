#pragma checksum "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Company\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba0cfff96f1f62cffb61df99cd1fb2df310200c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Index), @"mvc.1.0.view", @"/Views/Company/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba0cfff96f1f62cffb61df99cd1fb2df310200c4", @"/Views/Company/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89ac1693e6f770a2b15eb1669a9c02a27e3830dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:200px;width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Posted", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Company", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostJob", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""title-details two"">
    <div class=""d-table"">
        <div class=""d-table-cell"">
            <div class=""container-fluid"">
                <div class=""row align-items-end just"">
                    <div class=""col-lg-8"">
                        <div class=""left text-left"">
                            <h2>");
#nullable restore
#line 10 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Company\Index.cshtml"
                           Write(Model.Company.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ba0cfff96f1f62cffb61df99cd1fb2df310200c46397", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 416, "~/img/companyimg/", 416, 17, true);
#nullable restore
#line 11 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Company\Index.cshtml"
AddHtmlAttributeValue("", 433, Model.Company.Image, 433, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <ul>\r\n\r\n                                <li>\r\n                                    <i class=\"bi bi-geo-alt\"></i>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 652, "\"", 659, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Company\Index.cshtml"
                                          Write(Model.Company.Location.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </li>\r\n                                <li>\r\n                                    <i class=\"bi bi-telephone-outbound\"></i>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 891, "\"", 898, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Company\Index.cshtml"
                                          Write(Model.Company.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-lg-4"">
                        <div class=""right"">
                            <ul>
                                <li>
                                    <a href=""#"">
                                        <i class=""bi bi-heart""></i>
                                        Save
                                    </a>
                                </li>
                                <li>
                                    <a href=""#"">
                                        <i class=""bi bi-share""></i>
                                        Share
                                    </a>
                                </li>
                                <li>
                                    <a href=""#"">
                                        <i class=""bi bi-file-earmark-bar-graph""></i>
                  ");
            WriteLiteral(@"                      Report
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div id=""candidate-details"">
    <div class=""container-fluid"">
        <div class=""row"">

            <div class=""col-lg-8"">
                <div class=""details-item"">
                    <div class=""profile"">


                        <h3>About Company</h3>
                        <p>
                            <b> ");
#nullable restore
#line 66 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Company\Index.cshtml"
                           Write(Model.Company.About);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </b>

                            
                        </p>

                    </div>
                    <div class=""experience bottom-item"">
                        <h3>Job Responsibilities</h3>
                        <ul>
                            <li>
                                <i class=""bi bi-check""></i>
                                <span> Ability to work under pressure</span>
                            </li>

                            <li>
                                <i class=""bi bi-check""></i>
                                <span> Enterprise and entrepreneurial skills</span>
                            </li>

                            <li>
                                <i class=""bi bi-check""></i>
                                <span> Negotiation and persuasion</span>
                            </li>

                            <li>
                                <i class=""bi bi-check""></i>
                                <span>
              ");
            WriteLiteral(@"                      Understand where the other person is coming from so that
                                    you can both get what
                                </span>
                            </li>
                        </ul>
                    </div>

                    <div class=""portfolio"">

");
#nullable restore
#line 102 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Company\Index.cshtml"
                         if (Model.Company.CompanyImages.Count != 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h3>Image Gallery</h3>\r\n");
            WriteLiteral(@"                            <div class=""job-details-slider owl-theme owl-carousel owl-loaded owl-drag imgs"">
                                <div class=""owl-stage-outer"">
                                    <div class=""owl-stage""
                                         style=""
                                          transform: translate3d(-2628px, 0px, 0px);
                                           transition: all 1s ease 0s;
                                               width: 6132px;
                                                          "">

");
#nullable restore
#line 115 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Company\Index.cshtml"
                                         foreach (var item in Model.Company.CompanyImages)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""owl-item""
                                                 style=""width: 856px; margin-right: 20px"">
                                                <div class=""slider-item"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ba0cfff96f1f62cffb61df99cd1fb2df310200c414270", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5085, "~/img/companyimages/", 5085, 20, true);
#nullable restore
#line 120 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Company\Index.cshtml"
AddHtmlAttributeValue("", 5105, item.Image, 5105, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 123 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Company\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                    </div>
                                </div>
                                <div class=""owl-nav"">
                                    <button type=""button"" role=""presentation"" class=""owl-prev"">
                                        <i class=""flaticon-left-arrow""></i>
                                    </button><button type=""button"" role=""presentation"" class=""owl-next"">
                                        <i class=""flaticon-right-arrow""></i>
                                    </button>
                                </div>
                                <div class=""owl-dots disabled""></div>
                            </div>
");
#nullable restore
#line 137 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Company\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                    </div>
                    <!-- <div class=""review"">
                         <h3>Add Review</h3>
                         <span>Your rating for this listing</span>
                         <ul>
                           <li>
                             <i class=""bx bxs-star checked""></i>
                           </li>
                           <li>
                             <i class=""bx bxs-star checked""></i>
                           </li>
                           <li>
                             <i class=""bx bxs-star checked""></i>
                           </li>
                           <li>
                             <i class=""bx bxs-star checked""></i>
                           </li>
                           <li>
                             <i class=""bx bxs-star checked""></i>
                           </li>
                         </ul>
                         <form>
                           <div class=""form-group form-check"">
    ");
            WriteLiteral(@"                         <input
                               type=""checkbox""
                               class=""form-check-input""
                               id=""exampleCheck59""
                             />
                             <label class=""form-check-label"" for=""exampleCheck59""
                               >Save my name, email, and website in this browser for the
                               next time I comment.</label
                             >
                           </div>
                           <div class=""row"">
                             <div class=""col-lg-6"">
                               <div class=""form-group"">
                                 <i class=""bx bx-user""></i>
                                 <input
                                   type=""text""
                                   class=""form-control""
                                   placeholder=""Name*""
                                 />
                               </div>
      ");
            WriteLiteral(@"                       </div>
                             <div class=""col-lg-6"">
                               <div class=""form-group"">
                                 <i class=""bx bx-mail-send""></i>
                                 <input
                                   type=""email""
                                   class=""form-control""
                                   placeholder=""Email*""
                                 />
                               </div>
                             </div>
                             <div class=""col-lg-12"">
                               <div class=""form-group"">
                                 <i class=""bx bx-mail-send""></i>
                                 <textarea
                                   id=""your-message""
                                   rows=""10""
                                   class=""form-control""
                                   placeholder=""Write message""
                                 ></textarea>
           ");
            WriteLiteral(@"                    </div>
                             </div>
                             <div class=""col-lg-12"">
                               <button type=""submit"" class=""btn"">Submit A Review</button>
                             </div>
                           </div>
                         </form>
                       </div> -->
                </div>

                <div class=""download widget-item pt-3"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba0cfff96f1f62cffb61df99cd1fb2df310200c420991", async() => {
                WriteLiteral("Posted Jobs");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba0cfff96f1f62cffb61df99cd1fb2df310200c422378", async() => {
                WriteLiteral("Post Job");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba0cfff96f1f62cffb61df99cd1fb2df310200c423762", async() => {
                WriteLiteral("Edit Profile");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 218 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Company\Index.cshtml"
                                                                           WriteLiteral(Model.Company.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>

            </div>
            <div class=""col-lg-4"">
                <div class=""widget-area"">
                    <div class=""information widget-item"">
                        <h3>Company Information</h3>
                        <ul>
                            <li>
                                <img src=""/img/job-details-icon.png"" alt=""Details"" />
                                <h4>Team Size</h4>
                                <span>50 - 100 Members</span>
                            </li>
                            <li>
                                <img src=""/img/job-details-icon.png"" alt=""Details"" />
                                <h4>Location</h4>
                                <span>");
#nullable restore
#line 235 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Company\Index.cshtml"
                                 Write(Model.Company.Location.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n\r\n                        </ul>\r\n                    </div>\r\n                    <div class=\"owner\">\r\n                        <div class=\"top\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 10842, "\"", 10884, 2);
            WriteAttributeValue("", 10848, "/img/companyimg/", 10848, 16, true);
#nullable restore
#line 242 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Company\Index.cshtml"
WriteAttributeValue("", 10864, Model.Company.Image, 10864, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Owner\" style=\"width:70px;height:70px;p-3\" />\r\n                            <h3>Owner Info</h3>\r\n                            <i class=\"bi bi-send\"></i>\r\n                            <span>");
#nullable restore
#line 245 "C:\Users\Javid\source\repos\Online-recruitment-system\Online-recruitment-system\Views\Company\Index.cshtml"
                             Write(Model.Company.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                        <div class=""information widget-item"">
                            <ul>
                                <li>
                                    <img src=""/img/job-details-icon.png"" alt=""Details"" />
                                    <h4>Baku Office: 28 may AF buissnes house</h4>
                                    <a href=""#"">+994555552322</a>
                                </li>
                                <li>
                                    <img src=""/img/job-details-icon.png"" alt=""Details"" />
                                    <h4>Email</h4>
                                    <a href=""mailto:hello@jecto.com"">hello@ja.com</a>
                                </li>

                            </ul>
                        </div>
                    </div>
                </div>
            </div>


        </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
