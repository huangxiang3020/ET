﻿using System;

namespace ET
{
    public interface IMActorHandler
    {
        ETTask Handle(Entity entity, Address fromAddress, object actorMessage);
        Type GetRequestType();
        Type GetResponseType();
    }
}