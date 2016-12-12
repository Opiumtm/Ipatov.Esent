using System;

namespace Ipatov.Esent
{
    /// <summary>
    /// Jet instance.
    /// </summary>
    public interface IJetInstance : IDisposable
    {
        /// <summary>
        /// Internals.
        /// </summary>
        JetInstanceInternal Internal { get; }

        /// <summary>
        /// Create session.
        /// </summary>
        /// <returns>Session.</returns>
        IJetSession CreateSession();
    }
}