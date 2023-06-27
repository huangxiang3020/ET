﻿using System.Net;

namespace ET.Server
{
    public struct NetServerComponentOnRead
    {
        public Session Session;
        public object Message;
    }
    
    [ComponentOf(typeof(Fiber))]
    public class NetServerComponent: Entity, IAwake<IPEndPoint>, IDestroy
    {
        public AService AService;
    }
}