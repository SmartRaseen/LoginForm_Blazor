using Microsoft.AspNetCore.Components;
using ShoppingCartApplication.Services;
using System;
using ShoppingCartApplication.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using ShoppingCartApplication.Data;

namespace ShoppingCartApplication.Pages
{
    public class LoginBase : ComponentBase
    {
        [Inject]
        private NavigationManager NavigationMgr { get; set; }

        [Inject]
        private ShopCartService ShopCartSvc { get; set; }

        protected LoginInfo User { get; set; }

        [Inject]
        protected SessionState SessionState { get; set; }

        [Inject]
        protected IJSRuntime JsRuntime { get; set; }

        protected RegisterInfo Register { get; set; }

        public bool ShowError { get; set; }

        public bool ShowLoader { get; set; }

        public bool ShowRegistrationError { get; set; }

        public bool IsLoginForm { get; set; }

        public LoginBase()
        {
            User = new LoginInfo();
            Register = new RegisterInfo();
        }

        protected override void OnInitialized()
        {
            IsLoginForm = true;
            if (SessionState.EnableLoader)
            {
                ShowLoader = true;
            }
        }

        public async Task HandleValidSubmit()
        {
            await ValidateLogin();
        }

        public async Task ValidateLogin()
        {
            try
            {
                ShowLoader = true;
                ShowError = false;
                var user = new LoginInfo
                {
                     Username = User.Username,
                     Password = User.Password
                };

                var userDetails = await ShopCartSvc.CheckUserExist(user);
                if (userDetails != null)
                {
                    RegisterInfo userRecord = await ShopCartSvc.GetUserDetails(userDetails.Id);
                    SessionState.UserId = userRecord.Id;
                    SessionState.Username = userRecord.Username;
                    SessionState.Email = userRecord.Email;
                    SessionState.IsAuthenticated = true;
                    ShowLoader = false;
                    NavigationMgr.NavigateTo("home");
                }
                else
                {
                    SessionState.UserId = 0;
                    SessionState.Username = string.Empty;
                    SessionState.Email = string.Empty;
                    SessionState.IsAuthenticated = false;
                    ShowError = true;
                    ShowLoader = false;
                    StateHasChanged();
                }
            }
            catch
            {
                throw;
            }
        }

        public async Task AddNewUser()
        {
            try
            {
                ShowRegistrationError = false;
                var register = new RegisterInfo()
                {
                    Username = Register.Username,
                    Email = Register.Email,
                    Password = Register.Password,
                    Phone = Register.Phone
                };

                if(await ShopCartSvc.AddNewUser(register))
                {
                    await JsRuntime.InvokeAsync<object>("registrationSuccessAlert", register.Username);
                    IsLoginForm = true;
                    StateHasChanged();
                }
                else
                {
                    ShowRegistrationError = true;
                    StateHasChanged();
                }
            }
            catch
            {
                throw;
            }
        }

        public void SelectForm(bool formType)
        {
            try
            {
                IsLoginForm = formType;
                StateHasChanged();
            }
            catch
            {
                throw;
            }
        }
    }
}
