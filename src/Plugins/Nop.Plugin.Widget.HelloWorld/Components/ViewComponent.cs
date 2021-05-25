using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Widget.HelloWorld.Components
{
    [ViewComponent(Name = "HelloWorldWidget")]
    public class ViewComponent : NopViewComponent
    {
        public IViewComponentResult Invoke(string widgetZone)
        {
            return Content("Hello Sakhawat. How are you today.");
        }
    }
}
