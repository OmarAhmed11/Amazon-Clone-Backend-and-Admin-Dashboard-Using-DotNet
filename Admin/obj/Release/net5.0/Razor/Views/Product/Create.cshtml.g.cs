#pragma checksum "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "124f85713bac8d9ad86627b787f50a794017b1fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Create), @"mvc.1.0.view", @"/Views/Product/Create.cshtml")]
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
#line 2 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
using ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"124f85713bac8d9ad86627b787f50a794017b1fa", @"/Views/Product/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425c13ece3d0cfbb1fc0f84962af70815be6a0e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Product/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "124f85713bac8d9ad86627b787f50a794017b1fa5306", async() => {
                WriteLiteral("\r\n            <h4>Add Product</h4>\r\n            <hr />\r\n\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 15 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 17 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                ");
#nullable restore
#line 19 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
           Write(Html.ValidationMessageFor(i => i.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 23 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(model => model.Name_AR, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 25 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Name_AR, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                ");
#nullable restore
#line 27 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
           Write(Html.ValidationMessageFor(i => i.Name_AR));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 31 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(model => model.Discount, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 33 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Discount, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 38 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(model => model.Shipping, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 40 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Shipping, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 44 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(model => model.Shipping_AR, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 46 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Shipping_AR, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 51 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(model => model.Price, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 53 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Price, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 58 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(model => model.Picture, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 60 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
               Write(Html.TextBox("Picture","", new {  @type = "file" } ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 65 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(model => model.Stock, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 67 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Stock, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 72 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(model => model.Brand, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 74 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Brand, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            \r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 79 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(model => model.Brand_AR, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 81 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Brand_AR, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 86 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 88 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 93 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(model => model.Description_AR, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 95 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Description_AR, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group\">\r\n");
#nullable restore
#line 101 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
                  
                    List<SelectListItem> CatList = new List<SelectListItem>();
                    foreach (var item in Model.categories)
                    {

                        CatList.Add(new SelectListItem
                        {
                            Text = item.Name,
                            Value = item.Id.ToString()
                        });
                    }

                

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
#nullable restore
#line 114 "C:\Users\LeNoVo\OneDrive\Desktop\Last one working right now\MVC and API\Amazon-Clone---ITI-final-project\Admin\Views\Product\Create.cshtml"
           Write(Html.DropDownListFor(model => model.categoryId, CatList, "Select Category"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </div>\r\n\r\n\r\n");
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"col-md-offset-2 col-md-10\">\r\n                    <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n                </div>\r\n            </div>\r\n        ");
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
