using System;
using System.Collections;
using System.Collections.Generic;

namespace RZEngine.Core.Tasking
{
    public class TaskData
    {
        private readonly Hashtable _data;

        public TaskData(Dictionary<string, object> data)
        {
            _data = new Hashtable(data);
        }

        public T Get<T>(string key)
        {
            return (T)_data[key];
        }

        public void SetInt(string key, int value, bool safe = false)
        {
            if(!safe)
            {
                _data[key] = value;
                return;
            }

            if(_data.ContainsKey(key))
            {
                if(_data[key].GetType() == typeof(int))
                {
                    _data[key] = value;
                }
            }
        }

        public void SetFloat(string key, float value, bool safe = false)
        {
            if (!safe)
            {
                _data[key] = value;
                return;
            }

            if (_data.ContainsKey(key))
            {
                if (_data[key].GetType() == typeof(float))
                {
                    _data[key] = value;
                }
            }
        }

        public void AddInt(string key, int value, bool safe = false)
        {
            if (!safe)
            {
                _data[key] = (int)_data[key] + value;
                return;
            }

            if (_data.ContainsKey(key))
            {
                if (_data[key].GetType() == typeof(int))
                {
                    _data[key] = (int)_data[key] + value;
                }
            }
        }

        public void AddFloat(string key, float value, bool safe = false)
        {
            if (!safe)
            {
                _data[key] = (float)_data[key] + value;
                return;
            }

            if (_data.ContainsKey(key))
            {
                if (_data[key].GetType() == typeof(float))
                {
                    _data[key] = (float)_data[key] + value;
                }
            }
        }
    }
}
