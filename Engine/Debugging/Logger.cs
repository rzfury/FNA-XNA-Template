using System;
using System.IO;
using System.Collections.Generic;

namespace RZEngine.Core.Debugging
{
    public class Logger
    {
        public static Logger Instance
        {
            get
            {
                return Game.Instance.Logger;
            }
        }

        private List<string> _logs;

        public Logger()
        {
            _logs = new();
        }

        public void Write(string log)
        {
            _logs.Add(log);
        }

        public void SaveLog()
        {
            using FileStream stream = new(AppDomain.CurrentDomain.BaseDirectory, FileMode.Create);
            using StreamWriter writer = new(stream);
            foreach(string log in _logs)
            {
                writer.Write(log);
            }
            writer.Flush();
            stream.Close();
        }
    }
}
