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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Form_Action_Footer.cshtml")]
    public partial class _Views_Shared__Form_Action_Footer_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Form_Action_Footer_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\_Form_Action_Footer.cshtml"
  
     var entity = Model as IEntity;
    var isNew = entity.IsNullKey;
    var set = NewLife.Cube.Setting.Current;
    var cls_fix = set.FormGroupClass;
    if (cls_fix.IsNullOrEmpty()) { cls_fix = "form-group col-12 col-sm-6 col-lg-6"; }

    var cls = cls_fix + " flex align-items-start kt-padding-0";
    var cls_lab = "col-lg-2 col-form-label text-right";
    var cls_content = "col-lg-10";

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"kt-portlet__foot\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"kt-form__actions\"");

WriteLiteral(">\r\n        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 490), Tuple.Create("\"", 502)
            
            #line 14 "..\..\Views\Shared\_Form_Action_Footer.cshtml"
, Tuple.Create(Tuple.Create("", 498), Tuple.Create<System.Object, System.Int32>(cls
            
            #line default
            #line hidden
, 498), false)
);

WriteLiteral(">\r\n            <div");

WriteAttribute("class", Tuple.Create(" class=\"", 522), Tuple.Create("\"", 538)
            
            #line 15 "..\..\Views\Shared\_Form_Action_Footer.cshtml"
, Tuple.Create(Tuple.Create("", 530), Tuple.Create<System.Object, System.Int32>(cls_lab
            
            #line default
            #line hidden
, 530), false)
);

WriteLiteral("></div>\r\n            <div");

WriteAttribute("class", Tuple.Create(" class=\"", 564), Tuple.Create("\"", 584)
            
            #line 16 "..\..\Views\Shared\_Form_Action_Footer.cshtml"
, Tuple.Create(Tuple.Create("", 572), Tuple.Create<System.Object, System.Int32>(cls_content
            
            #line default
            #line hidden
, 572), false)
);

WriteLiteral(">\r\n                <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-brand\"");

WriteLiteral(">\r\n                    <i");

WriteAttribute("class", Tuple.Create(" class=\"", 672), Tuple.Create("\"", 712)
, Tuple.Create(Tuple.Create("", 680), Tuple.Create("la", 680), true)
, Tuple.Create(Tuple.Create(" ", 682), Tuple.Create("la-", 683), true)
            
            #line 18 "..\..\Views\Shared\_Form_Action_Footer.cshtml"
, Tuple.Create(Tuple.Create("", 686), Tuple.Create<System.Object, System.Int32>(isNew ? "plus" : "save"
            
            #line default
            #line hidden
, 686), false)
);

WriteLiteral(" style=\"margin-top: -1px;\"");

WriteLiteral("></i>\r\n                    <span");

WriteLiteral(" class=\"kt-hidden-mobile\"");

WriteLiteral(">");

            
            #line 19 "..\..\Views\Shared\_Form_Action_Footer.cshtml"
                                               Write(isNew ? "保 存" : "保 存");

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </button>\r\n            </div>\r\n        </div>\r\n    </div" +
">\r\n</div>");

        }
    }
}
#pragma warning restore 1591