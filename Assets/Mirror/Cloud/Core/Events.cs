using System;
using Mirror.Cloud.ListServer;
using UnityEngine.Events;

namespace Mirror.Cloud.Core
{
    [Serializable]
    public class ServerListEvent : UnityEvent<ServerCollectionJson> {}

    [Serializable]
    public class MatchFoundEvent : UnityEvent<ServerJson> {}
}
