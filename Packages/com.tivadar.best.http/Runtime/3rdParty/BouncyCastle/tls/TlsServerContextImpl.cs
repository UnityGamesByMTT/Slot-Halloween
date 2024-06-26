#if !BESTHTTP_DISABLE_ALTERNATE_SSL && (!UNITY_WEBGL || UNITY_EDITOR)
#pragma warning disable
using System;

using Best.HTTP.SecureProtocol.Org.BouncyCastle.Tls.Crypto;

namespace Best.HTTP.SecureProtocol.Org.BouncyCastle.Tls
{
    internal class TlsServerContextImpl
        : AbstractTlsContext, TlsServerContext
    {
        internal TlsServerContextImpl(TlsCrypto crypto)
            : base(crypto, ConnectionEnd.server)
        {
        }

        public override bool IsServer
        {
            get { return true; }
        }
    }
}
#pragma warning restore
#endif
