using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using ShoppingCartApplication.Data;
using ShoppingCartApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartApplication.Pages
{
    public class HomeBase : ComponentBase
    {
        [Inject]
        private NavigationManager NavigationMgr { get; set; }

        [Inject]
        private ShopCartService ShopCartSvc { get; set; }

        [Inject]
        protected SessionState SessionState { get; set; }

        [Inject]
        protected IJSRuntime JsRuntime { get; set; }

        public bool ShowLoader { get; set; }

        protected override void OnInitialized()
        {
            if (!SessionState.IsAuthenticated)
            {
                ShowLoader = true;
            }
            else
            {

            }
        }
    }
}
