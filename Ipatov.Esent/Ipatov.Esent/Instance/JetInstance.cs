using Microsoft.Isam.Esent.Interop;

namespace Ipatov.Esent
{
    /// <summary>
    /// Jet instance.
    /// </summary>
    public sealed class JetInstance : IJetInstance
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="instance">Instance.</param>
        public JetInstance(Instance instance)
        {
            Internal = new JetInstanceInternal(instance);
        }

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        /// <filterpriority>2</filterpriority>
        public void Dispose()
        {
            Internal.InternalInstance.Dispose();
        }

        /// <summary>
        /// Internals.
        /// </summary>
        public JetInstanceInternal Internal { get; }

        /// <summary>
        /// Create session.
        /// </summary>
        /// <returns>Session.</returns>
        public IJetSession CreateSession()
        {
            return new JetSession(new Session(Internal.InternalInstance));
        }
    }
}