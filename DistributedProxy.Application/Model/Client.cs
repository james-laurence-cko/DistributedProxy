﻿using System.Net.Sockets;

namespace DistributedProxy.Application.Model
{
    internal class Client
    {
        internal Socket ClientSocket { get; set; }
        internal bool InUse { get; set; }
    }
}