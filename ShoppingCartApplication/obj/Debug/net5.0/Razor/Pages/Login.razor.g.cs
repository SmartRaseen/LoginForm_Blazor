#pragma checksum "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05fa4f4281e4bb28cb3bcf2312a2e71f94701f82"
// <auto-generated/>
#pragma warning disable 1591
namespace ShoppingCartApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\_Imports.razor"
using ShoppingCartApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\_Imports.razor"
using ShoppingCartApplication.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : LoginBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
 if (ShowLoader)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"lds-roller\"><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div></div>");
#nullable restore
#line 9 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container register");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "<div class=\"col-md-3 register-left\"><img src=\"https://image.ibb.co/n7oTvU/logo_white.png\" alt=\"Img not found\">\r\n                <h3>Welcome</h3>\r\n                <p>Start your day fresh with RSN Software</p></div>\r\n            ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-9 register-right");
            __builder.OpenElement(8, "ul");
            __builder.AddAttribute(9, "class", "nav nav-tabs nav-justified");
            __builder.AddAttribute(10, "id", "myTab");
            __builder.AddAttribute(11, "role", "tablist");
            __builder.OpenElement(12, "li");
            __builder.AddAttribute(13, "class", "nav-item");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "class", "nav-link" + " " + (
#nullable restore
#line 22 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                             IsLoginForm ? "active" : ""

#line default
#line hidden
#nullable disable
            ) + " login-btn");
            __builder.AddAttribute(16, "id", "login-tab");
            __builder.AddAttribute(17, "data-toggle", "tab");
            __builder.AddAttribute(18, "href", "#login");
            __builder.AddAttribute(19, "role", "tab");
            __builder.AddAttribute(20, "ariacontrols", "login");
            __builder.AddAttribute(21, "aria-selected", "true");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                                                                                                                                                                                   (() => SelectForm(true))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Login");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "li");
            __builder.AddAttribute(26, "class", "nav-item");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "class", "nav-link" + " login-btn" + " " + (
#nullable restore
#line 25 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                                       IsLoginForm ? "" : "active"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "id", "newuser-tab");
            __builder.AddAttribute(30, "data-toggle", "tab");
            __builder.AddAttribute(31, "href", "#newuser");
            __builder.AddAttribute(32, "role", "tab");
            __builder.AddAttribute(33, "ariacontrols", "newuser");
            __builder.AddAttribute(34, "aria-selected", "false");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                                                                                                                                                                                          (() => SelectForm(false))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, "New User");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "tab-content");
            __builder.AddAttribute(40, "id", "myTabContent");
#nullable restore
#line 29 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                     if (IsLoginForm)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "tab-pane fade show active");
            __builder.AddAttribute(43, "style", "padding:80px 275px;");
            __builder.AddAttribute(44, "id", "login");
            __builder.AddAttribute(45, "role", "tabpanel");
            __builder.AddAttribute(46, "aria-labelledby", "login-tab");
            __builder.AddMarkupContent(47, "<h3 class=\"register-heading\">Login</h3>\r\n                            ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "row register-form");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col-md-12 profile_card");
            __builder.OpenElement(52, "form");
            __builder.AddAttribute(53, "class", "form-inline");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(54);
            __builder.AddAttribute(55, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 36 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                                          User

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 36 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                                                                HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group pb-3");
                __builder2.AddMarkupContent(60, "<i class=\"fa fa-envelope-o\"></i>\r\n                                                ");
                __builder2.OpenElement(61, "input");
                __builder2.AddAttribute(62, "type", "text");
                __builder2.AddAttribute(63, "class", "formcontrol");
                __builder2.AddAttribute(64, "placeholder", "Username");
                __builder2.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                                                                                                                           User.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.Username = __value, User.Username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                                            ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "col-sm-10");
                __builder2.OpenElement(70, "small");
                __builder2.AddAttribute(71, "class", "text-danger");
                __Blazor.ShoppingCartApplication.Pages.Login.TypeInference.CreateValidationMessage_0(__builder2, 72, 73, 
#nullable restore
#line 43 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                                                              () => User.Username

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                                            ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "form-group");
                __builder2.AddMarkupContent(77, "<i class=\"fa fa-lock\"></i>\r\n                                                ");
                __builder2.OpenElement(78, "input");
                __builder2.AddAttribute(79, "type", "password");
                __builder2.AddAttribute(80, "lass", "formcontrol");
                __builder2.AddAttribute(81, "placeholder", "Password");
                __builder2.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                                                                                                                           User.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.Password = __value, User.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                                            ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "col-sm-10");
                __builder2.OpenElement(87, "small");
                __builder2.AddAttribute(88, "class", "text-danger");
                __Blazor.ShoppingCartApplication.Pages.Login.TypeInference.CreateValidationMessage_1(__builder2, 89, 90, 
#nullable restore
#line 52 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                                                              () => User.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(92);
                __builder2.CloseComponent();
#nullable restore
#line 56 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                             if (ShowError)
                                            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(93, "<div class=\"col-md-16\"><small class=\"text-danger\">\r\n                                                        Invalid Username or Password.\r\n                                                    </small></div>");
#nullable restore
#line 63 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(94, "<div class=\"float-left pt-3\"><input type=\"submit\" class=\"btn btn-primary\" value=\"Log In\"></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 72 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "tab-pane fade show");
            __builder.AddAttribute(97, "id", "newuser");
            __builder.AddAttribute(98, "role", "tabpanel");
            __builder.AddAttribute(99, "aria-labelledby", "newuser-tab");
            __builder.AddAttribute(100, "style", "opacity:1;");
            __builder.AddMarkupContent(101, "<h3 class=\"register-heading\">New User</h3>\r\n                            ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "row register-form");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(104);
            __builder.AddAttribute(105, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 78 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                                  Register

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(106, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 78 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                                                            AddNewUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "col-md-16");
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "form-group");
                __builder2.OpenElement(112, "input");
                __builder2.AddAttribute(113, "type", "text");
                __builder2.AddAttribute(114, "class", "form-control");
                __builder2.AddAttribute(115, "placeholder", "Username *");
                __builder2.AddAttribute(116, "required");
                __builder2.AddAttribute(117, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 81 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                                                                                                                       Register.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(118, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Register.Username = __value, Register.Username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n                                        ");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "col-sm-10");
                __builder2.OpenElement(122, "small");
                __builder2.AddAttribute(123, "class", "text-danger");
                __Blazor.ShoppingCartApplication.Pages.Login.TypeInference.CreateValidationMessage_2(__builder2, 124, 125, 
#nullable restore
#line 85 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                                                          () => Register.Username

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(126, "\r\n                                        ");
                __builder2.OpenElement(127, "div");
                __builder2.AddAttribute(128, "class", "form-group");
                __builder2.OpenElement(129, "input");
                __builder2.AddAttribute(130, "type", "email");
                __builder2.AddAttribute(131, "class", "form-control");
                __builder2.AddAttribute(132, "placeholder", "Email *");
                __builder2.AddAttribute(133, "required");
                __builder2.AddAttribute(134, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 89 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                                                                                                                       Register.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(135, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Register.Email = __value, Register.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\r\n                                        ");
                __builder2.OpenElement(137, "div");
                __builder2.AddAttribute(138, "class", "col-sm-10");
                __builder2.OpenElement(139, "small");
                __builder2.AddAttribute(140, "class", "text-danger");
                __Blazor.ShoppingCartApplication.Pages.Login.TypeInference.CreateValidationMessage_3(__builder2, 141, 142, 
#nullable restore
#line 93 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                                                          () => Register.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n                                        ");
                __builder2.OpenElement(144, "div");
                __builder2.AddAttribute(145, "class", "form-group");
                __builder2.OpenElement(146, "input");
                __builder2.AddAttribute(147, "type", "password");
                __builder2.AddAttribute(148, "class", "form-control");
                __builder2.AddAttribute(149, "placeholder", "Password *");
                __builder2.AddAttribute(150, "required");
                __builder2.AddAttribute(151, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 97 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                                                                                                                       Register.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(152, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Register.Password = __value, Register.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(153, "\r\n                                        ");
                __builder2.OpenElement(154, "div");
                __builder2.AddAttribute(155, "class", "col-sm-10");
                __builder2.OpenElement(156, "small");
                __builder2.AddAttribute(157, "class", "text-danger");
                __Blazor.ShoppingCartApplication.Pages.Login.TypeInference.CreateValidationMessage_4(__builder2, 158, 159, 
#nullable restore
#line 101 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                                                          () => Register.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(160, "\r\n                                        ");
                __builder2.OpenElement(161, "div");
                __builder2.AddAttribute(162, "class", "form-group");
                __builder2.OpenElement(163, "input");
                __builder2.AddAttribute(164, "type", "text");
                __builder2.AddAttribute(165, "maxlength", "10");
                __builder2.AddAttribute(166, "minlength", "10");
                __builder2.AddAttribute(167, "class", "form-control");
                __builder2.AddAttribute(168, "placeholder", "Phone *");
                __builder2.AddAttribute(169, "required");
                __builder2.AddAttribute(170, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 105 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                                                                                                                                              Register.Phone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(171, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Register.Phone = __value, Register.Phone));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(172, "\r\n                                        ");
                __builder2.OpenElement(173, "div");
                __builder2.AddAttribute(174, "class", "col-sm-10");
                __builder2.OpenElement(175, "small");
                __builder2.AddAttribute(176, "class", "text-danger");
                __Blazor.ShoppingCartApplication.Pages.Login.TypeInference.CreateValidationMessage_5(__builder2, 177, 178, 
#nullable restore
#line 109 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                                                          () => Register.Phone

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(179, "\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(180);
                __builder2.CloseComponent();
#nullable restore
#line 114 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                     if (ShowRegistrationError)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(181, "<div class=\"col-md-16\"><small class=\"text-danger\">\r\n                                                Username or EmailId already exist.\r\n                                            </small></div>");
#nullable restore
#line 121 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(182, "<div class=\"col-md-16\"><div class=\"float-left\"><input type=\"submit\" class=\"btn btn-primary\" value=\"Register\"></div></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 130 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 135 "C:\Users\USER\Desktop\ShoppingCart_Blazor\ShoppingCartApplication\ShoppingCartApplication\Pages\Login.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.ShoppingCartApplication.Pages.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
