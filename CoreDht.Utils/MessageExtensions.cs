﻿using CoreMemoryBus.Messages;

namespace CoreDht.Utils
{
    public static class MessageExtensions
    {
        public static string TypeName(this Message msg)
        {
            return msg.GetType().Name;
        }
    }
}
