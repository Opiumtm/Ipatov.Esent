using System;
using Microsoft.Isam.Esent.Interop;

namespace Ipatov.Esent
{
    /// <summary>
    /// Jet transaction.
    /// </summary>
    public interface IJetTransaction : IDisposable
    {
        /// <summary>
        /// Internal transaction.
        /// </summary>
        JetTransactionInternal Internal { get; }

        /// <summary>
        /// Commit transaction.
        /// </summary>
        /// <param name="flags">Commit flags.</param>
        void Commit(CommitTransactionGrbit flags = CommitTransactionGrbit.LazyFlush);
        
        /// <summary>
        /// Rollback transaction.
        /// </summary>
        void Rollback();
    }
}