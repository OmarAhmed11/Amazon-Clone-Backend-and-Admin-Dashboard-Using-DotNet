#pragma checksum "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26a71b29a306db4a9ed4c1290b8d8b5d04eb53da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Edit), @"mvc.1.0.view", @"/Views/Customer/Edit.cshtml")]
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
#line 1 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\_ViewImports.cshtml"
using Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\_ViewImports.cshtml"
using Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
using Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26a71b29a306db4a9ed4c1290b8d8b5d04eb53da", @"/Views/Customer/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425c13ece3d0cfbb1fc0f84962af70815be6a0e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Customer/Editing"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"main-container\">\r\n    <div class=\"pd-ltr-20\">\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26a71b29a306db4a9ed4c1290b8d8b5d04eb53da4937", async() => {
                WriteLiteral("\r\n            <h4>Add Customer</h4>\r\n            <hr />\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 14 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
           Write(Html.LabelFor(model => model.Id, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 16 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
               Write(Html.TextBoxFor(model => model.Id, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                ");
#nullable restore
#line 18 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
           Write(Html.ValidationMessageFor(i => i.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 22 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
           Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 24 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
               Write(Html.TextBoxFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                ");
#nullable restore
#line 26 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
           Write(Html.ValidationMessageFor(i => i.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 30 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
           Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
               Write(Html.TextBoxFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                ");
#nullable restore
#line 34 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
           Write(Html.ValidationMessageFor(i => i.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n");
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 46 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
           Write(Html.LabelFor(model => model.PhoneNumber, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 48 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
               Write(Html.TextBoxFor(model => model.PhoneNumber, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                ");
#nullable restore
#line 50 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
           Write(Html.ValidationMessageFor(i => i.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 54 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
           Write(Html.LabelFor(model => model.Gender, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 56 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
               Write(Html.TextBoxFor(model => model.Gender, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                ");
#nullable restore
#line 58 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
           Write(Html.ValidationMessageFor(i => i.Gender));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 62 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
           Write(Html.LabelFor(model => model.City, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 64 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
               Write(Html.TextBoxFor(model => model.City, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                ");
#nullable restore
#line 66 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
           Write(Html.ValidationMessageFor(i => i.City));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 70 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
           Write(Html.LabelFor(model => model.PostalCode, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 72 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
               Write(Html.TextBoxFor(model => model.PostalCode, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                ");
#nullable restore
#line 74 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
           Write(Html.ValidationMessageFor(i => i.PostalCode));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 78 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
           Write(Html.LabelFor(model => model.Street, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 80 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
               Write(Html.TextBoxFor(model => model.Street, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                ");
#nullable restore
#line 82 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
           Write(Html.ValidationMessageFor(i => i.Street));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 86 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
           Write(Html.LabelFor(model => model.profileID, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 88 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
               Write(Html.TextBoxFor(model => model.profileID, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                ");
#nullable restore
#line 90 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Edit.cshtml"
           Write(Html.ValidationMessageFor(i => i.profileID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <div class=\"col-md-offset-2 col-md-10\">\r\n                    <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <div class=\"footer-wrap pd-20 mb-20 card-box\">\r\n            DeskApp - Bootstrap 4 Admin Template By <a href=\"https://github.com/dropways\" target=\"_blank\">Ankit Hingarajiya</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
