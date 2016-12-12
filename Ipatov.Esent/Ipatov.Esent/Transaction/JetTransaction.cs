using Microsoft.Isam.Esent.Interop;

namespace Ipatov.Esent
{
    /// <summary>
    /// Jet transaction.
    /// </summary>
    public sealed class JetTransaction : IJetTransaction
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="session">Session.</param>
        /// <param name="transaction">Transaction.</param>
        public JetTransaction(IJetSession session, Transaction transaction)
        {
            Internal = new JetTransactionInternal(transaction, session);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            Internal.Dispose();
        }

        /// <inheritdoc />
        public JetTransactionInternal Internal { get; }

        /// <inheritdoc />
        public void Commit(CommitTransactionGrbit flags = CommitTransactionGrbit.LazyFlush)
        {
            Internal.InternalTransaction.Commit(flags);
        }

        /// <inheritdoc />
        public void Rollback()
        {
            Internal.InternalTransaction.Rollback();
        }
    }
}