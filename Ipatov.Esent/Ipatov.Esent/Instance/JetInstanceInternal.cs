using System;
using Microsoft.Isam.Esent.Interop;

namespace Ipatov.Esent
{
    /// <summary>
    /// Jet instance internal.
    /// </summary>
    public struct JetInstanceInternal : IDisposable
    {
        /// <summary>
        /// Internal instance.
        /// </summary>
        public readonly Instance InternalInstance;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="internalInstance">Internal instance.</param>
        public JetInstanceInternal(Instance internalInstance)
        {
            InternalInstance = internalInstance;
        }

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        /// <filterpriority>2</filterpriority>
        public void Dispose()
        {
            InternalInstance.Term();
        }
    }
}