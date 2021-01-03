using Microsoft.AspNetCore.Mvc;
using SarayCilingir.Infrastructure;
using SarayCilingir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SarayCilingir.Components
{
    public class CartSummaryViewComponent : ViewComponent 
    {
        public string Invoke()
        {
            return HttpContext.Session.GetJSon<Cart>("Cart")?.Products.Count().ToString() ?? "0";
        }
    }
}
