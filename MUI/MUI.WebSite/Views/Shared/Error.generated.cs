﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using MUI.WebSite;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Error.cshtml")]
    public partial class _Views_Shared_Error_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared_Error_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!DOCTYPE html>\r\n<html");

WriteLiteral(" lang=\"en\"");

WriteLiteral(">\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <title>Metronic | Error Page - 1</title>\r\n    <meta");

WriteLiteral(" name=\"description\"");

WriteLiteral(" content=\"Latest updates and statistic charts\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1, maximum-scale=1, shrink-to-fit=no\"" +
"");

WriteLiteral(">\r\n    <script");

WriteLiteral(" src=\"https://ajax.googleapis.com/ajax/libs/webfont/1.6.16/webfont.js\"");

WriteLiteral(@"></script>
    <script>
        WebFont.load({
            google: { ""families"": [""Poppins:300,400,500,600,700"", ""Roboto:300,400,500,600,700""] },
            active: function () {
                sessionStorage.fonts = true;
            }
        });
    </script>
    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 669), Tuple.Create("\"", 716)
, Tuple.Create(Tuple.Create("", 676), Tuple.Create<System.Object, System.Int32>(Href("~/Assets/metronic/css/vendors.bundle.css")
, 676), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 748), Tuple.Create("\"", 793)
, Tuple.Create(Tuple.Create("", 755), Tuple.Create<System.Object, System.Int32>(Href("~/Assets/metronic/css/style.bundle.css")
, 755), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"shortcut icon\"");

WriteLiteral(" href=\"../../../../assets/favicon.ico\"");

WriteLiteral(" />\r\n</head>\r\n<body>\r\n\r\n        <div");

WriteLiteral(" style=\"background-image: url(../../assets/media/error/bg4.jpg);\"");

WriteLiteral(">\r\n                    <h1>404</h1>\r\n                    OOPS! Something went wro" +
"ng here\r\n        </div>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1101), Tuple.Create("\"", 1163)
, Tuple.Create(Tuple.Create("", 1107), Tuple.Create<System.Object, System.Int32>(Href("~/Assets/metronic/js/framework/vendors/scripts.bundle.js")
, 1107), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1187), Tuple.Create("\"", 1249)
, Tuple.Create(Tuple.Create("", 1193), Tuple.Create<System.Object, System.Int32>(Href("~/Assets/metronic/js/framework/vendors/vendors.bundle.js")
, 1193), false)
);

WriteLiteral("></script>\r\n</body>\r\n</html>");

        }
    }
}
#pragma warning restore 1591