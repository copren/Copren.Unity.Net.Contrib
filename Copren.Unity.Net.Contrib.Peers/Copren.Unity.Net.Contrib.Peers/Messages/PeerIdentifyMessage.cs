using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using Copren.Unity.Net.Domain;
using Copren.Unity.Net.Domain.Extensions;
using Copren.Unity.Net.Domain.Messaging.Messages;
using ProtoBuf;

namespace Copren.Unity.Net.Contrib.Peers.Messages
{
    [ProtoContract]
    public class PeerIdentifyMessage : Message
    {
        [ProtoMember(1)]
        public Guid PeerId { get; }
        [ProtoMember(2)]
        public Uri Uri { get; }

        internal PeerIdentifyMessage() { }

        internal PeerIdentifyMessage(Client client)
        {
            PeerId = client.ClientId;
            Uri = client.Uris[ProtocolType.Udp];
        }
    }
}