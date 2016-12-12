using System;
using Microsoft.Isam.Esent.Interop;

namespace Ipatov.Esent
{
    /// <summary>
    /// Internal transaction.
    /// </summary>
    public struct JetTransactionInternal : IDisposable
    {
        /// <summary>
        /// Internal transaction.
        /// </summary>
        public readonly Transaction InternalTransaction;

        /// <summary>
        /// Internal session.
        /// </summary>
        public readonly IJetSession InternalSession;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="internalTransaction">Internal transaction.</param>
        /// <param name="internalSession">Internal session.</param>
        public JetTransactionInternal(Transaction internalTransaction, IJetSession internalSession)
        {
            if (internalSession == null) throw new ArgumentNullException(nameof(internalSession));
            InternalTransaction = internalTransaction;
            InternalSession = internalSession;
        }

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        /// <filterpriority>2</filterpriority>
        public void Dispose()
        {
            InternalTransaction.Dispose();
        }
    }
}