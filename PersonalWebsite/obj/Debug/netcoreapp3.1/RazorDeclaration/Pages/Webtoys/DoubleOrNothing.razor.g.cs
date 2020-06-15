#pragma checksum "C:\Users\caina\source\repos\PersonalWebsite\PersonalWebsite\Pages\Webtoys\DoubleOrNothing.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21569aaf66afae6b2a4417a57071b2f5896fdda6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PersonalWebsite.Pages.Webtoys
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\caina\source\repos\PersonalWebsite\PersonalWebsite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\caina\source\repos\PersonalWebsite\PersonalWebsite\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\caina\source\repos\PersonalWebsite\PersonalWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\caina\source\repos\PersonalWebsite\PersonalWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\caina\source\repos\PersonalWebsite\PersonalWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\caina\source\repos\PersonalWebsite\PersonalWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\caina\source\repos\PersonalWebsite\PersonalWebsite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\caina\source\repos\PersonalWebsite\PersonalWebsite\_Imports.razor"
using PersonalWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\caina\source\repos\PersonalWebsite\PersonalWebsite\_Imports.razor"
using PersonalWebsite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\caina\source\repos\PersonalWebsite\PersonalWebsite\Pages\Webtoys\DoubleOrNothing.razor"
using System.Security.Cryptography;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/doublenothing")]
    public partial class DoubleOrNothing : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\caina\source\repos\PersonalWebsite\PersonalWebsite\Pages\Webtoys\DoubleOrNothing.razor"
 
	int _balance = 5;
    int _current;
    int _best;
    string _ticker1Style = "display: none";
    string _ticker2Style = string.Empty;
    Statuses _status = Statuses.GameOver;

    void DoubleNothing()
    {
        if (_status == Statuses.GameOver)
            return;

        if (RandomNumberGenerator.GetInt32(0, 2) > 0)
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
            _balance = 5;
            _ticker1Style = "display: none";
            _ticker2Style = String.Empty;

            _status = Statuses.GameOver;
        }
    }

    void Insert()
    {
        if (_status == Statuses.Playing)
            return;

        _current = 0;
        _current = _balance;
        _balance = 0;

        _ticker2Style = "display: none";
        _ticker1Style = String.Empty;

        _status = Statuses.Playing;
    }

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
