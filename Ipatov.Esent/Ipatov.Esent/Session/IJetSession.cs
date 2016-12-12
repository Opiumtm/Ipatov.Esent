using System;

namespace Ipatov.Esent
{
    /// <summary>
    /// Jet session object.
    /// </summary>
    public interface IJetSession : IDisposable
    {
        /// <summary>
        /// Internals.
        /// </summary>
        JetSessionInternal Internal { get; }

        /// <summary>
        /// Bind to current thread.
        /// </summary>
        /// <returns>Disposable to rollback thread binding.</returns>
        IDisposable BindToThread();

        /// <summary>
        /// Begin transaction.
        /// </summary>
        /// <returns>Transaction.</returns>
        IJetTransaction BeginTransaction();
    }
}
