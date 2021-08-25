#pragma checksum "D:\ITi 3M\LibraryTask\LibraryTask\Views\BorrowedBooks\Availablebooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ad0be8f8c81a9a2d2fc1c6f6b27351bf1dfcf1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BorrowedBooks_Availablebooks), @"mvc.1.0.view", @"/Views/BorrowedBooks/Availablebooks.cshtml")]
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
#line 1 "D:\ITi 3M\LibraryTask\LibraryTask\Views\_ViewImports.cshtml"
using LibraryTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ITi 3M\LibraryTask\LibraryTask\Views\_ViewImports.cshtml"
using LibraryTask.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad0be8f8c81a9a2d2fc1c6f6b27351bf1dfcf1f", @"/Views/BorrowedBooks/Availablebooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9b09b60bd6f71f87d0c9214ae44448b73df8930", @"/Views/_ViewImports.cshtml")]
    public class Views_BorrowedBooks_Availablebooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BL.Models.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <h3 class=\"text-center\">Available books</h3>\r\n<hr />\r\n");
#nullable restore
#line 5 "D:\ITi 3M\LibraryTask\LibraryTask\Views\BorrowedBooks\Availablebooks.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success text-center\">\r\n        <h5>There are no books currently available for this customer</h5>\r\n    </div>\r\n");
#nullable restore
#line 10 "D:\ITi 3M\LibraryTask\LibraryTask\Views\BorrowedBooks\Availablebooks.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-hover text-center\">\r\n        <thead class=\"table-dark\">\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 17 "D:\ITi 3M\LibraryTask\LibraryTask\Views\BorrowedBooks\Availablebooks.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 20 "D:\ITi 3M\LibraryTask\LibraryTask\Views\BorrowedBooks\Availablebooks.cshtml"
               Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "D:\ITi 3M\LibraryTask\LibraryTask\Views\BorrowedBooks\Availablebooks.cshtml"
               Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 29 "D:\ITi 3M\LibraryTask\LibraryTask\Views\BorrowedBooks\Availablebooks.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 33 "D:\ITi 3M\LibraryTask\LibraryTask\Views\BorrowedBooks\Availablebooks.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 36 "D:\ITi 3M\LibraryTask\LibraryTask\Views\BorrowedBooks\Availablebooks.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 39 "D:\ITi 3M\LibraryTask\LibraryTask\Views\BorrowedBooks\Availablebooks.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <button id=\"return\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1294, "\"", 1320, 3);
            WriteAttributeValue("", 1304, "Borrow(", 1304, 7, true);
#nullable restore
#line 42 "D:\ITi 3M\LibraryTask\LibraryTask\Views\BorrowedBooks\Availablebooks.cshtml"
WriteAttributeValue("", 1311, item.Id, 1311, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1319, ")", 1319, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Borrow the book</button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 45 "D:\ITi 3M\LibraryTask\LibraryTask\Views\BorrowedBooks\Availablebooks.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>  \r\n");
#nullable restore
#line 48 "D:\ITi 3M\LibraryTask\LibraryTask\Views\BorrowedBooks\Availablebooks.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BL.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
