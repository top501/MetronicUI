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
    
    #line 1 "..\..\Views\Shared\ListTree.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\ListTree.cshtml"
    using XCode;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/ListTree.cshtml")]
    public partial class _Views_Shared_ListTree_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared_ListTree_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\ListTree.cshtml"
  
    Layout = NewLife.Cube.Setting.Current.Layout;

    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"kt-portlet kt-portlet--mobile\"");

WriteLiteral(" id=\"kt_portlet\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"kt-portlet__head p-0  border-bottom-0\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 11 "..\..\Views\Shared\ListTree.cshtml"
   Write(Html.Partial("_List_Toolbar"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"kt-portlet__body p-0\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 14 "..\..\Views\Shared\ListTree.cshtml"
   Write(Html.Partial("_ListTree_Data"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591