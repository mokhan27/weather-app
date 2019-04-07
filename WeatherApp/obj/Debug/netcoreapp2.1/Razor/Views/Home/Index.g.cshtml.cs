#pragma checksum "C:\Users\Administrator\Downloads\WeatherApp\WeatherApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81db2cd05af9cd79732e137f7cda1b8b757be84a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81db2cd05af9cd79732e137f7cda1b8b757be84a", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WeatherApp.Models.CityIndex>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator\Downloads\WeatherApp\WeatherApp\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Weather";
    Layout = null;

#line default
#line hidden
            BeginContext(98, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\Administrator\Downloads\WeatherApp\WeatherApp\Views\Home\Index.cshtml"
 if (Model.City == null || Model.City == "")
{

#line default
#line hidden
            BeginContext(149, 357, true);
            WriteLiteral(@"    <div class=""searchForm"">
        <h2>Search for a location</h2>

        <div>
            <form asp-action=""Index"" asp-controller=""Home"" method=""post"">
                CityName, State:
                <input type=""text"" name=""City""> <br />
                <input type=""submit"" value=""Search"" />
            </form>
        </div>
    </div>
");
            EndContext();
#line 21 "C:\Users\Administrator\Downloads\WeatherApp\WeatherApp\Views\Home\Index.cshtml"
}

#line default
#line hidden
#line 22 "C:\Users\Administrator\Downloads\WeatherApp\WeatherApp\Views\Home\Index.cshtml"
 if (Model.TempC != null && Model.TempC != "")
{

#line default
#line hidden
            BeginContext(560, 40, true);
            WriteLiteral("    <h2 class=\"h2\">Weather forecast for ");
            EndContext();
            BeginContext(601, 10, false);
#line 24 "C:\Users\Administrator\Downloads\WeatherApp\WeatherApp\Views\Home\Index.cshtml"
                                   Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(611, 194, true);
            WriteLiteral("</h2>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n\r\n            <div class=\"span2\">\r\n                <div class=\"box\">\r\n                    <p class=\"day\">\r\n                        ");
            EndContext();
            BeginContext(806, 9, false);
#line 31 "C:\Users\Administrator\Downloads\WeatherApp\WeatherApp\Views\Home\Index.cshtml"
                   Write(Model.Day);

#line default
#line hidden
            EndContext();
            BeginContext(815, 60, true);
            WriteLiteral("<br />\r\n                    </p>\r\n\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 875, "\"", 934, 3);
            WriteAttributeValue("", 881, "http://openweathermap.org/img/w/", 881, 32, true);
#line 34 "C:\Users\Administrator\Downloads\WeatherApp\WeatherApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 913, Model.SymbolId, 913, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 930, ".png", 930, 4, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 935, "\"", 954, 1);
#line 34 "C:\Users\Administrator\Downloads\WeatherApp\WeatherApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 941, Model.Desc, 941, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 955, "\"", 976, 1);
#line 34 "C:\Users\Administrator\Downloads\WeatherApp\WeatherApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 963, Model.Desc, 963, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(977, 68, true);
            WriteLiteral(">\r\n\r\n                    <p class=\" temp\">\r\n                        ");
            EndContext();
            BeginContext(1046, 11, false);
#line 37 "C:\Users\Administrator\Downloads\WeatherApp\WeatherApp\Views\Home\Index.cshtml"
                   Write(Model.TempC);

#line default
#line hidden
            EndContext();
            BeginContext(1057, 93, true);
            WriteLiteral(" C\r\n                    </p>\r\n                    <p class=\" temp\">\r\n                        ");
            EndContext();
            BeginContext(1151, 11, false);
#line 40 "C:\Users\Administrator\Downloads\WeatherApp\WeatherApp\Views\Home\Index.cshtml"
                   Write(Model.TempF);

#line default
#line hidden
            EndContext();
            BeginContext(1162, 123, true);
            WriteLiteral(" F\r\n                    </p>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(1286, 53, false);
#line 48 "C:\Users\Administrator\Downloads\WeatherApp\WeatherApp\Views\Home\Index.cshtml"
   Write(Html.ActionLink("Search for a new Location", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1339, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 50 "C:\Users\Administrator\Downloads\WeatherApp\WeatherApp\Views\Home\Index.cshtml"
}
else if(Model.City != null && Model.City != "")
{

#line default
#line hidden
            BeginContext(1408, 38, true);
            WriteLiteral("    <h2 class=\"h2\">Invalid city name: ");
            EndContext();
            BeginContext(1447, 10, false);
#line 53 "C:\Users\Administrator\Downloads\WeatherApp\WeatherApp\Views\Home\Index.cshtml"
                                 Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(1457, 26, true);
            WriteLiteral("</h2>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(1484, 57, false);
#line 55 "C:\Users\Administrator\Downloads\WeatherApp\WeatherApp\Views\Home\Index.cshtml"
   Write(Html.ActionLink("Search for a correct Location", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1541, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 57 "C:\Users\Administrator\Downloads\WeatherApp\WeatherApp\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeatherApp.Models.CityIndex> Html { get; private set; }
    }
}
#pragma warning restore 1591