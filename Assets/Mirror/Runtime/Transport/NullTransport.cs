using System;
using Mirror;
using UnityEngine;

public class NullTransport : Transport
{
    public void Awake()
    {
        Debug.LogError("YOU NEED TO ADD A PROPER TRANSPORT! THIS IS JUST A BLANK TEMP TRANSPORT!");
    }

    public override bool Available()
    {
        throw new NotImplementedException();
    }

    public override bool ClientConnected()
    {
        throw new NotImplementedException();
    }

    public override void ClientConnect(string address)
    {
        throw new NotImplementedException();
    }

    public override void ClientSend(int channelId, ArraySegment<byte> segment)
    {
        throw new NotImplementedException();
    }

    public override void ClientDisconnect()
    {
        throw new NotImplementedException();
    }

    public override Uri ServerUri()
    {
        throw new NotImplementedException();
    }

    public override bool ServerActive()
    {
        throw new NotImplementedException();
    }

    public override void ServerStart()
    {
        throw new NotImplementedException();
    }

    public override void ServerSend(int connectionId, int channelId, ArraySegment<byte> segment)
    {
        throw new NotImplementedException();
    }

    public override bool ServerDisconnect(int connectionId)
    {
        throw new NotImplementedException();
    }

    public override string ServerGetClientAddress(int connectionId)
    {
        throw new NotImplementedException();
    }

    public override void ServerStop()
    {
        throw new NotImplementedException();
    }

    public override int GetMaxPacketSize(int channelId = Channels.Reliable)
    {
        throw new NotImplementedException();
    }

    public override void Shutdown()
    {
        throw new NotImplementedException();
    }
}
