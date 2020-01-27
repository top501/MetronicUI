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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Form_TaskView_Map.cshtml")]
    public partial class _Views_Shared__Form_TaskView_Map_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Form_TaskView_Map_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Views\Shared\_Form_TaskView_Map.cshtml"
  
    var entity = Model as IEntity;
    var fact = EntityFactory.CreateOperate(entity.GetType());
    var entityId = Convert.ToInt32(entity[fact.Unique.Name]);
    var controllerName = ViewContext.RouteData.Values["controller"].ToString().ToLower();

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"margin-top-125\"");

WriteLiteral(">坐标</div>\r\n<div");

WriteLiteral(" class=\"cube-map-container margin-top-125\"");

WriteLiteral(" style=\"position: relative;\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"input-group cube-map-search-box\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"kt-input-icon kt-input-icon--right kt-margin-l-20 kt-margin-r-20\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" placeholder=\"address...\"");

WriteLiteral(" id=\"generalSearch\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"kt-input-icon__icon kt-input-icon__icon--right\"");

WriteLiteral(" onclick=\"return getText(this)\"");

WriteLiteral(">\r\n                <span><i");

WriteLiteral(" class=\"la la-search\"");

WriteLiteral("></i></span>\r\n            </span>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" id=\"allmap\"");

WriteLiteral("></div>\r\n</div>\r\n\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(" src=\"http://api.map.baidu.com/api?v=2.0&ak=NpAwgtFLSlxATWYIQoGZdFI3d8qCoWN3\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
    var map = new BMap.Map(""allmap"", { enableMapClick: false }), // 创建Map实例
        lng = 113.81294682347,
        lat = 23.051578106566,
        point, adds,
        opts = {
            width: 0, // 信息窗口宽度
            height: 0, // 信息窗口高度
            enableMessage: true //设置允许信息窗发送短息
        };

        //调用控制器方法初始化地图
    $.ajax({
        url: ""../InitMapMarker"",
        data: JSON.stringify({ entityId: ");

            
            #line 36 "..\..\Views\Shared\_Form_TaskView_Map.cshtml"
                                    Write(entityId);

            
            #line default
            #line hidden
WriteLiteral(" }),\r\n        type: \"post\",\r\n        dataType: \"json\",\r\n        cache: false,\r\n  " +
"      contentType: \'application/json\',\r\n        processData: false,\r\n        suc" +
"cess: function (data) {\r\n            console.log(\"初始化地图。\")\r\n            console." +
"log(data);\r\n        }\r\n    });\r\n    // 获取标注列表\r\n    //data = [{\r\n    //    Name: " +
"\"表1\",\r\n    //    LatLng: \"114.222, 36.552\",\r\n    //    Color: \"测试\",\r\n    //    I" +
"con: \"\",\r\n    //    CentrePoint: {\r\n    //        weight: \"222kg\",\r\n    //      " +
"  weight: \"222kg\",\r\n    //        weight: \"222kg\",\r\n    //    }\r\n    //}];\r\n    " +
"adds = [ //标注点数组\r\n        [116.307852, 40.057031, \"标注说明1\",\"标注具体显示内容1\"],\r\n       " +
" [116.313082, 40.047674, \"这是一个div222\", \"标注具体显示内容2\"],\r\n        [116.328749, 40.02" +
"6922, \"这是一个div333\", \"标注具体显示内容3\"],\r\n        [116.347571, 39.988698, \"这是一个div444\"," +
" \"标注具体显示内容4\"],\r\n        [116.316163, 39.997753, \"这是一个div555\", \"标注具体显示内容5\"],\r\n   " +
"     [116.345867, 39.998333, \"这是一个div666\", \"标注具体显示内容6\"],\r\n        [116.403472, 3" +
"9.999411, \"这是一个div777\", \"标注具体显示内容7\"],\r\n        [116.307901, 40.05901, \"这是一个div88" +
"8\", \"标注具体显示内容8\"]\r\n    ];\r\n    if (adds && adds[0] && adds[0][0] && adds[0][1]) {" +
"\r\n        lat = adds[0][0];\r\n        lng = adds[0][1];\r\n        draw(map);\r\n    " +
"} else {\r\n        var geolocation = new BMap.Geolocation();\r\n        //---------" +
"--------- \r\n        // 开启SDK辅助定位\r\n        // geolocation.enableSDKLocation();\r\n " +
"       geolocation.getCurrentPosition(function (r) {\r\n            if (this.getSt" +
"atus() == BMAP_STATUS_SUCCESS) {\r\n                // map.panTo(r.point);\r\n      " +
"          lat = r.point.lat;\r\n                lng = r.point.lng;\r\n              " +
"  draw(map);\r\n            } else {\r\n                alert(\'failed\' + this.getSta" +
"tus());\r\n                draw(map);\r\n            }\r\n        });\r\n    }\r\n    // 绘" +
"制地图\r\n    function draw(map) {\r\n        console.log(\"绘制地图：\" + lat + \',\' + lng);\r\n" +
"        point = new BMap.Point(lat, lng);\r\n        map.centerAndZoom(point, 15);" +
"\r\n        cdr(map)\r\n    }\r\n    // 添加控件和样式\r\n    function cdr(map) {\r\n        // m" +
"ap.addControl(new BMap.NavigationControl()); //缩放控件\r\n        // map.addControl(n" +
"ew BMap.ScaleControl()); //比例尺控件\r\n        map.addControl(new BMap.GeolocationCon" +
"trol()); //定位控件\r\n        // map.enableDragging(); //标记开启拖拽 \r\n        // map.addC" +
"ontrol(new BMap.MapTypeControl()); //添加地图类型控件\r\n        map.enableScrollWheelZoom" +
"(true); //开启鼠标滚轮缩放\r\n        // 添加标注\r\n        marker(map);\r\n        rightClick(ma" +
"p); // 鼠标右键地图事件\r\n    }\r\n    // 添加标注\r\n    function marker(map) {\r\n        for (va" +
"r i = 0; i < adds.length; i++) {\r\n            var content = adds[i][2];\r\n       " +
"     var markersPoint = new BMap.Point(adds[i][0], adds[i][1]);\r\n            var" +
" marker = new BMap.Marker(markersPoint);\r\n            map.addOverlay(marker);\r\n " +
"           // 标注说明\r\n            label(marker, adds[i][2], { offset: new BMap.Siz" +
"e(20, -10) })\r\n            // 右键事件\r\n            var markerMenu = new BMap.Contex" +
"tMenu();\r\n            markerMenu.addItem(new BMap.MenuItem(\'删除标注\', deleteMarker." +
"bind(marker)));\r\n            marker.addContextMenu(markerMenu); //给标记添加右键菜单\r\n   " +
"         // 鼠标经过\r\n            //addClickHandler(map, content, marker);\r\n        " +
"    // 点击事件\r\n            createTag(map, marker, adds[i][2]);\r\n        }\r\n    }\r\n" +
"    // 标注说明\r\n    function label(a, b, c) {\r\n        var label = new BMap.Label(b" +
", c);\r\n        label.setStyle({\r\n            padding: \"0.25rem\",\r\n            ba" +
"ckgroundColor: \"rgba(255,255,255,0.8)\",\r\n            border: \"0\"\r\n        });\r\n " +
"       a.setLabel(label);\r\n    }\r\n    // 删除标注\r\n    function deleteMarker(e) {\r\n " +
"       console.log(\'删除标注:\' + JSON.stringify(e));\r\n        //调用删除 返回json数据\r\n     " +
"   var Latlng = `${e.lng},${e.lat}`;\r\n                console.log(Latlng);\r\n    " +
"            var data = {\r\n                    entityId: ");

            
            #line 145 "..\..\Views\Shared\_Form_TaskView_Map.cshtml"
                         Write(entityId);

            
            #line default
            #line hidden
WriteLiteral(",\r\n                    latlng: Latlng\r\n                }\r\n                var dat" +
"as = JSON.stringify(data);\r\n               $.ajax({\r\n                   url: \".." +
"/DeleteMapMarker\",\r\n            data: datas,\r\n            type: \"post\",\r\n       " +
"     dataType: \"json\",\r\n            cache: false,\r\n            contentType: \'app" +
"lication/json\',\r\n            processData: false,\r\n            success: function " +
"(data) {\r\n                console.log(data);\r\n            }\r\n        })\r\n    }\r\n" +
"    // 鼠标经过\r\n    function addClickHandler(map, content, marker) {\r\n        marke" +
"r.addEventListener(\"mouseover\", function (e) {\r\n            var p = e.target;\r\n " +
"           var point = new BMap.Point(p.getPosition().lng, p.getPosition().lat);" +
"\r\n            var infoWindow = new BMap.InfoWindow(content, opts); // 创建信息窗口对象\r\n" +
"            map.openInfoWindow(infoWindow, point); //开启信息窗口\r\n        });\r\n      " +
"  marker.addEventListener(\"mouseout\", function (e) {\r\n            map.closeInfoW" +
"indow(); //开启信息窗口\r\n        });\r\n    }\r\n    // 点击标注\r\n    function createTag(map, " +
"marker, m) {\r\n        var text = \"<p>许可证号：\" + m + \"</p><p>申请人/单位：\" + m +\r\n      " +
"      \"</p><p>许可事项：\" + m + \"</p><p>现场照片:<a href=\'http://www.baidu.com\'>点击查看</p>\"" +
";\r\n\r\n        //给标记添加点击事件以及显示窗口信息\r\n        var infoWindow = new BMap.InfoWindow(\"" +
"<p style=\'font-size:14px;\'>\" + m + \"</p>\");\r\n        marker.addEventListener(\"cl" +
"ick\", function () {\r\n            this.openInfoWindow(infoWindow);\r\n        });\r\n" +
"    }\r\n    // 鼠标右键地图事件\r\n    function rightClick(map) {\r\n        var menu = new B" +
"Map.ContextMenu();\r\n        var txtMenuItem = [{\r\n            text: \'标注此点\',\r\n   " +
"         callback: function (e) {\r\n                //console.log(\'添加坐标：\' + JSON." +
"stringify(e));\r\n                var Latlng = `${e.lng},${e.lat}`;\r\n             " +
"   console.log(Latlng);\r\n                var data = {\r\n                    entit" +
"yId: ");

            
            #line 195 "..\..\Views\Shared\_Form_TaskView_Map.cshtml"
                         Write(entityId);

            
            #line default
            #line hidden
WriteLiteral(@",
                    latlng: Latlng
                }
                var datas = JSON.stringify(data);
               $.ajax({
             url: ""../SetMapMarker"",
            data: datas,
            type: ""post"",
            dataType: ""json"",
            cache: false,
            contentType: 'application/json',
            processData: false,
            success: function (data) {
                console.log(data);
                
            }
        })
            }
        }];
        for (var i = 0; i < txtMenuItem.length; i++) {
            menu.addItem(new BMap.MenuItem(txtMenuItem[i].text, txtMenuItem[i].callback, 100));
        }
        map.addContextMenu(menu);
    }
    // 关键字检索
    function getText(a) {
        //var myKeys = [""酒店"", ""加油站""];
        var myKeys = a.parentNode.getElementsByTagName('input')[0].value;

        if (myKeys.replace(/(^\s*)|(\s*$)/g, """")) {
            var map = new BMap.Map('allmap', {
                enableMapClick: false
            });
            var local = new BMap.LocalSearch(map, {
                renderOptions: {
                    map: map
                }
            });
            local.search(myKeys);
            map.addControl(new BMap.GeolocationControl()); //定位控件
            map.enableScrollWheelZoom(true); //开启鼠标滚轮缩放
            cdr(map);
        }

    }
</script>");

        }
    }
}
#pragma warning restore 1591