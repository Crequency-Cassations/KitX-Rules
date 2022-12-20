using System;
using System.Collections.Generic;
using System.Text;

namespace KitX.Web.Rules.Command
{
    public class CallbackCommand
    {
        public DeviceLocator Sender { get; set; }

        public DeviceLocator Target { get; set; }

        public string Command { get; set; }

        public int CallID { get; set; }
    }
}
