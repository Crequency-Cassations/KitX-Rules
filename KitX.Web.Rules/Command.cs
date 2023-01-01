using System;
using System.Collections.Generic;

namespace KitX.Web.Rules
{
    public class Command
    {
        public CommandType Type { get; set; }

        public DeviceLocator Sender { get; set; }

        public DeviceLocator Target { get; set; }

        public int CallId { get; set; }

        public int CallIdTTL { get; set; }

        public DateTime SendTime { get; set; }

        public string Request { get; set; }

        public List<string> RequestArgs { get; set; }

        public byte[] Body { get; set; }

        public int BodyLength { get; set; }

        public Dictionary<string, string> Tags { get; set; }

    }

    public enum CommandType
    {
        Call = 1, CallBack = 2
    }
}
