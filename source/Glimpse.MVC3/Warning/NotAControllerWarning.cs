﻿using System.Web.Mvc;

namespace Glimpse.Mvc3.Warning
{
    internal class NotAControllerWarning:Net.Warning.Warning
    {
        public NotAControllerWarning(IController controller)
        {
            Message = controller.GetType() + " is not a System.Web.Mvc.Controller.";
        }
    }
}