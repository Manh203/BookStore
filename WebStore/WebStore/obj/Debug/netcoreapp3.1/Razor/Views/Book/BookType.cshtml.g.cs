#pragma checksum "D:\BookStore\BookStore\WebStore\WebStore\Views\Book\BookType.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "630b5469a4cd31308b03e5c19d5f8b6f2d40275c8a9272d5107b6047f862f174"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_BookType), @"mvc.1.0.view", @"/Views/Book/BookType.cshtml")]
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
#line 1 "D:\BookStore\BookStore\WebStore\WebStore\Views\Book\BookType.cshtml"
 using WebStore.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"630b5469a4cd31308b03e5c19d5f8b6f2d40275c8a9272d5107b6047f862f174", @"/Views/Book/BookType.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0ca74d9d3d8f0fda11e57151523a5ee9557a88a1c5aba4211246523de85a92d1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Book_BookType : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\BookStore\BookStore\WebStore\WebStore\Views\Book\BookType.cshtml"
  
    ViewData["Title"] = "BookType";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<div id=\"main\">\r\n    <div class=\"inner\">\r\n\r\n        <div class=\"image main\">\r\n            <img src=\"/images/banner-image-6-1920x500.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 242, "\"", 248, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <h1>");
            Write(
#nullable restore
#line 14 "D:\BookStore\BookStore\WebStore\WebStore\Views\Book\BookType.cshtml"
             Model.booktype.BookTypeName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h1>\r\n\r\n        <hr />\r\n        <!-- Products -->\r\n        <section class=\"tiles\">\r\n");
#nullable restore
#line 19 "D:\BookStore\BookStore\WebStore\WebStore\Views\Book\BookType.cshtml"
             foreach (var item in Model.booktypelist)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <article class=\"style1\">\r\n                    <span class=\"image\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 577, "\"", 602, 2);
            WriteAttributeValue("", 583, "/images/", 583, 8, true);
            WriteAttributeValue("", 591, 
#nullable restore
#line 23 "D:\BookStore\BookStore\WebStore\WebStore\Views\Book\BookType.cshtml"
                                           item.Image

#line default
#line hidden
#nullable disable
            , 591, 11, false);
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" height=\"325\"");
            BeginWriteAttribute("alt", " alt=\"", 628, "\"", 634, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </span>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 691, "\"", 754, 1);
            WriteAttributeValue("", 698, 
#nullable restore
#line 25 "D:\BookStore\BookStore\WebStore\WebStore\Views\Book\BookType.cshtml"
                              Url.Action("Details", "Book", new {id = @item.BookID })

#line default
#line hidden
#nullable disable
            , 698, 56, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <h2>\r\n                            ");
            Write(
#nullable restore
#line 27 "D:\BookStore\BookStore\WebStore\WebStore\Views\Book\BookType.cshtml"
                             item.BookName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                        </h2>\r\n\r\n                        <p><del>");
            Write(
#nullable restore
#line 30 "D:\BookStore\BookStore\WebStore\WebStore\Views\Book\BookType.cshtml"
                                 item.Price

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" đ</del> <strong>");
            Write(
#nullable restore
#line 30 "D:\BookStore\BookStore\WebStore\WebStore\Views\Book\BookType.cshtml"
                                                             item.Price

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" đ</strong></p>\r\n                    </a>\r\n                </article>\r\n");
#nullable restore
#line 33 "D:\BookStore\BookStore\WebStore\WebStore\Views\Book\BookType.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("        </section>\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-6\">\r\n                <div class=\"pagination\">\r\n");
#nullable restore
#line 38 "D:\BookStore\BookStore\WebStore\WebStore\Views\Book\BookType.cshtml"
                     for (int i = 1; i <= Model.maxpage; i++)
                    {
                        if (i == Model.currentpage)
                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1343, "\"", 1394, 4);
            WriteAttributeValue("", 1350, "/Book/BookType/", 1350, 15, true);
            WriteAttributeValue("", 1365, 
#nullable restore
#line 42 "D:\BookStore\BookStore\WebStore\WebStore\Views\Book\BookType.cshtml"
                                                     Model.booktype.BookTypeID

#line default
#line hidden
#nullable disable
            , 1365, 26, false);
            WriteAttributeValue("", 1391, "/", 1391, 1, true);
            WriteAttributeValue("", 1392, 
#nullable restore
#line 42 "D:\BookStore\BookStore\WebStore\WebStore\Views\Book\BookType.cshtml"
                                                                                i

#line default
#line hidden
#nullable disable
            , 1392, 2, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"active\">");
            Write(
#nullable restore
#line 42 "D:\BookStore\BookStore\WebStore\WebStore\Views\Book\BookType.cshtml"
                                                                                                   i

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</a>\r\n");
#nullable restore
#line 43 "D:\BookStore\BookStore\WebStore\WebStore\Views\Book\BookType.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1533, "\"", 1584, 4);
            WriteAttributeValue("", 1540, "/Book/BookType/", 1540, 15, true);
            WriteAttributeValue("", 1555, 
#nullable restore
#line 46 "D:\BookStore\BookStore\WebStore\WebStore\Views\Book\BookType.cshtml"
                                                     Model.booktype.BookTypeID

#line default
#line hidden
#nullable disable
            , 1555, 26, false);
            WriteAttributeValue("", 1581, "/", 1581, 1, true);
            WriteAttributeValue("", 1582, 
#nullable restore
#line 46 "D:\BookStore\BookStore\WebStore\WebStore\Views\Book\BookType.cshtml"
                                                                                i

#line default
#line hidden
#nullable disable
            , 1582, 2, false);
            EndWriteAttribute();
            WriteLiteral(">");
            Write(
#nullable restore
#line 46 "D:\BookStore\BookStore\WebStore\WebStore\Views\Book\BookType.cshtml"
                                                                                    i

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</a>\r\n");
#nullable restore
#line 47 "D:\BookStore\BookStore\WebStore\WebStore\Views\Book\BookType.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable

            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
