#pragma checksum "D:\BookStore\BookStore\WebStore\WebStore\Views\Manager\DetailsBook.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5b24c090ece7dae537d542edd01246387ef7d7d72a66842f4484be2a6deeba41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_DetailsBook), @"mvc.1.0.view", @"/Views/Manager/DetailsBook.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\BookStore\BookStore\WebStore\WebStore\Views\_ViewImports.cshtml"
using WebStore

#nullable disable
    ;
#nullable restore
#line 1 "D:\BookStore\BookStore\WebStore\WebStore\Views\Manager\DetailsBook.cshtml"
 using WebStore.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5b24c090ece7dae537d542edd01246387ef7d7d72a66842f4484be2a6deeba41", @"/Views/Manager/DetailsBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0ca74d9d3d8f0fda11e57151523a5ee9557a88a1c5aba4211246523de85a92d1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Manager_DetailsBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManagerBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\BookStore\BookStore\WebStore\WebStore\Views\Manager\DetailsBook.cshtml"
  
    ViewData["Title"] = "DetailsBook";
    Layout = "~/Views/Shared/_ManagerLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<div>\r\n    <h2>chi tiết sách</h2>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-4\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 263, "\"", 294, 2);
            WriteAttributeValue("", 269, "/images/", 269, 8, true);
            WriteAttributeValue("", 277, 
#nullable restore
#line 14 "D:\BookStore\BookStore\WebStore\WebStore\Views\Manager\DetailsBook.cshtml"
                               Model.book.Image

#line default
#line hidden
#nullable disable
            , 277, 17, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 313, "\"", 319, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"col-sm-8\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-3\">\r\n                    BookID:\r\n                </div>\r\n                <div class=\"col-sm-9\">\r\n                    ");
            Write(
#nullable restore
#line 22 "D:\BookStore\BookStore\WebStore\WebStore\Views\Manager\DetailsBook.cshtml"
                     Model.book.BookID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-3\">\r\n                    BookName:\r\n                </div>\r\n                <div class=\"col-sm-9\">\r\n                    ");
            Write(
#nullable restore
#line 28 "D:\BookStore\BookStore\WebStore\WebStore\Views\Manager\DetailsBook.cshtml"
                     Model.book.BookName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-3\">\r\n                    BookType:\r\n                </div>\r\n                <div class=\"col-sm-9\">\r\n                    ");
            Write(
#nullable restore
#line 34 "D:\BookStore\BookStore\WebStore\WebStore\Views\Manager\DetailsBook.cshtml"
                     Model.bookType.BookTypeName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-3\">\r\n                    Author:\r\n                </div>\r\n                <div class=\"col-sm-9\">\r\n                    ");
            Write(
#nullable restore
#line 40 "D:\BookStore\BookStore\WebStore\WebStore\Views\Manager\DetailsBook.cshtml"
                     Model.book.Author

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-3\">\r\n                    Nhà xuất bản:\r\n                </div>\r\n                <div class=\"col-sm-9\">\r\n                    ");
            Write(
#nullable restore
#line 46 "D:\BookStore\BookStore\WebStore\WebStore\Views\Manager\DetailsBook.cshtml"
                     Model.book.Nxb

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-3\">\r\n                    Price:\r\n                </div>\r\n                <div class=\"col-sm-9\">\r\n                    ");
            Write(
#nullable restore
#line 52 "D:\BookStore\BookStore\WebStore\WebStore\Views\Manager\DetailsBook.cshtml"
                     Model.book.Price

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-3\">\r\n                    Quantity:\r\n                </div>\r\n                <div class=\"col-sm-9\">\r\n                    ");
            Write(
#nullable restore
#line 58 "D:\BookStore\BookStore\WebStore\WebStore\Views\Manager\DetailsBook.cshtml"
                     Model.book.Quantity

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-3\">\r\n                    Ordered:\r\n                </div>\r\n                <div class=\"col-sm-9\">\r\n                    ");
            Write(
#nullable restore
#line 64 "D:\BookStore\BookStore\WebStore\WebStore\Views\Manager\DetailsBook.cshtml"
                     Model.book.OrderedQuantity

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-3\">\r\n                    Description:\r\n                </div>\r\n                <div class=\"col-sm-9\">\r\n                    ");
            Write(
#nullable restore
#line 70 "D:\BookStore\BookStore\WebStore\WebStore\Views\Manager\DetailsBook.cshtml"
                     Model.book.Description

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </div>\r\n                <br/>\r\n                <div class=\"col-sm-1\"></div>\r\n                <div class=\"col-sm-6\">\r\n                    <a class=\"button\"");
            BeginWriteAttribute("href", " href=\"", 2362, "\"", 2424, 1);
            WriteAttributeValue("", 2369, 
#nullable restore
#line 75 "D:\BookStore\BookStore\WebStore\WebStore\Views\Manager\DetailsBook.cshtml"
                                             Url.Action("EditBook",new { id = @Model.book.BookID })

#line default
#line hidden
#nullable disable
            , 2369, 55, false);
            EndWriteAttribute();
            WriteLiteral(" >Edit</a>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b24c090ece7dae537d542edd01246387ef7d7d72a66842f4484be2a6deeba419859", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-5\"></div>\r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
