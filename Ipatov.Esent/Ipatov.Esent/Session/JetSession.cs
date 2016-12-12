using System;
using Microsoft.Isam.Esent.Interop;

namespace Ipatov.Esent
{
    /// <summary>
    /// Jet session.
    /// </summary>
    public sealed class JetSession : IJetSession
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="internalSession">Session.</param>
        public JetSession(Session internalSession)
        {
            Internal = new JetSessionInternal(internalSession);
        }

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        /// <filterpriority>2</filterpriority>
        public void Dispose()
        {
            Internal.Dispose();
        }

        /// <inheritdoc />
        public JetSessionInternal Internal { get; }

        /// <summary>
        /// Bind to current thread.
        /// </summary>
        /// <returns>Disposable to rollback thread binding.</returns>
        public IDisposable BindToThread()
        {
            Api.JetSetSessionContext(Internal.InternalSession, Internal.InternalContext);
            return new ActionDisposable(() => Api.JetResetSessionContext(Internal.InternalSession));
        }

        /// <inheritdoc />
        public IJetTransaction BeginTransaction()
        {
            return new JetTransaction(this, new Transaction(this.Internal.InternalSession));
        }
    }
}