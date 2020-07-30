#pragma checksum "C:\Users\caina\source\repos\PersonalWebsite\PersonalWebsite\Components\DoubleOrNothing.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f9cc99967579c47a0ff8216a4a8834e014bd9df"
// <auto-generated/>
#pragma warning disable 1591
namespace PersonalWebsite.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\caina\source\repos\PersonalWebsite\PersonalWebsite\Components\DoubleOrNothing.razor"
using System.Security.Cryptography;

#line default
#line hidden
#nullable disable
    public partial class DoubleOrNothing : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"display-3\">Cain\'s Webtoys!</h1>\r\n");
            __builder.AddMarkupContent(1, "<h2>Double or Nothing</h2>\r\n\r\n");
            __builder.AddMarkupContent(2, "<p>\r\n\tA simple Double or Nothing. If you end up with 0 money then you\'ll get 5 for free, so you can keep playing.\r\n</p>\r\n\r\n");
            __builder.AddMarkupContent(3, "<div style=\"display: flex\">\r\n\t<div class=\"btn-group\">\r\n\t\t<button @onclick=\"DoubleNothing\" class=\"btn btn-primary\">Double or Nothing</button>\r\n\t\t<button @onclick=\"Insert\" class=\"btn btn-secondary\">Insert Money</button>\r\n\t</div>\r\n</div>\r\n\r\n");
            __builder.OpenElement(4, "p");
            __builder.AddAttribute(5, "style", 
#nullable restore
#line 17 "C:\Users\caina\source\repos\PersonalWebsite\PersonalWebsite\Components\DoubleOrNothing.razor"
           _ticker1Style

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, "Note: Insert is for putting money in, and will only work after a game over.");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "p");
            __builder.AddAttribute(9, "style", 
#nullable restore
#line 18 "C:\Users\caina\source\repos\PersonalWebsite\PersonalWebsite\Components\DoubleOrNothing.razor"
           _ticker2Style

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, "Insert your moneys!");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenElement(12, "p");
            __builder.AddMarkupContent(13, "\r\n\tCurrent Amount in play: ");
            __builder.AddContent(14, 
#nullable restore
#line 21 "C:\Users\caina\source\repos\PersonalWebsite\PersonalWebsite\Components\DoubleOrNothing.razor"
                             _current

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "\r\n\t<br>Your high score (resets on refresh): ");
            __builder.AddContent(16, 
#nullable restore
#line 22 "C:\Users\caina\source\repos\PersonalWebsite\PersonalWebsite\Components\DoubleOrNothing.razor"
                                                _best

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n");
            __builder.AddMarkupContent(19, "<p>Built with ASP.NET and Blazor :)</p>");
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\caina\source\repos\PersonalWebsite\PersonalWebsite\Components\DoubleOrNothing.razor"
 
        readonly Random _rand = new Random();
        int _current;
        int _best;
        string _ticker1Style = "display: none";
        string _ticker2Style = string.Empty;
        Statuses _status = Statuses.GameOver;

        void DoubleNothing()
        {
            if (_status == Statuses.GameOver)
                return;

            if (GetRandomBool())
            {
                _current *= 2;
                if (_current > _best)
                    _best = _current;
            }
            else
            {
                if (_current > _best)
                    _best = _current;

                _current = 0;
                _ticker1Style = "display: none";
                _ticker2Style = String.Empty;

                _status = Statuses.GameOver;
            }
        }

        void Insert()
        {
            if (_status == Statuses.Playing)
                return;

            _current = 5;

            _ticker2Style = "display: none";
            _ticker1Style = String.Empty;

            _status = Statuses.Playing;
        }

        bool GetRandomBool() => GetRandomDouble() >= 0.5;

        double GetRandomDouble() => _rand.NextDouble();

	enum Statuses
    {
        Playing,
        GameOver
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
