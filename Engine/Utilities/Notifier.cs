using System;
using System.Collections.Generic;

namespace RZEngine.Core.Utilities
{
    /// <summary>
    /// Simple "Event Listener"-like Class
    /// </summary>
    public class Notifier
    {
        private Dictionary<string, Action<object>> _listeners;

        public static Notifier Global = new Notifier();

        public Notifier()
        {
            _listeners = new Dictionary<string, Action<object>>();
        }

        public void ListenTo(string name, Action<object> callback)
        {
            _listeners.Add(name, callback);
        }

        public void Notify(string name, object data)
        {
            if (_listeners.TryGetValue(name, out Action<object> callback))
            {
                callback.Invoke(data);
            }
            else
            {
                Debug.Log("RZEngine - [Notifier.cs]: \"" + name + "\" event does not exists.");
            }
        }

        public void DisposeListeners()
        {
            _listeners.Clear();
            _listeners = null;
        }
    }
}
