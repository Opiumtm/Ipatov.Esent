using System;
using Microsoft.Isam.Esent.Interop;
using System.Runtime.InteropServices;

namespace Ipatov.Esent
{
    /// <summary>
    /// Internal <see cref="JET_SESID"/> holder.
    /// </summary>
    public struct JetSessionInternal : IDisposable
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="internalSession">Internal session.</param>
        public JetSessionInternal(Session internalSession)
        {
            InternalSession = internalSession;
            _handle = GCHandle.Alloc(internalSession);
            InternalContext = GCHandle.ToIntPtr(_handle);
        }

        /// <summary>
        /// Internal session.
        /// </summary>
        public readonly Session InternalSession;

        private GCHandle _handle;

        /// <summary>
        /// Internal context.
        /// </summary>
        public IntPtr InternalContext { get; }

        /// <summary>
        /// Dispose.
        /// </summary>
        public void Dispose()
        {
            InternalSession.Dispose();
            _handle.Free();
        }
    }
}