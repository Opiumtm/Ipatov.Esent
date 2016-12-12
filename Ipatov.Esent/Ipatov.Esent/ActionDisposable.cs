using System;

namespace Ipatov.Esent
{
    /// <summary>
    /// Action disposable.
    /// </summary>
    internal struct ActionDisposable : IDisposable
    {
        /// <summary>
        /// Action on dispose.
        /// </summary>
        public Action OnDispose;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="onDispose">Action on dispose.</param>
        public ActionDisposable(Action onDispose)
        {
            OnDispose = onDispose;
        }

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        /// <filterpriority>2</filterpriority>
        public void Dispose()
        {
            OnDispose?.Invoke();
        }
    }
}