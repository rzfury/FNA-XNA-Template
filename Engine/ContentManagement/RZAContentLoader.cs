using RZEngine.Core.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace RZEngine.Core.ContentManagement
{
    public class RZAContentLoader
    {
        private ContentManager _contentManager;
        private string _packLocation
        {
            get
            {
                return System.IO.Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "pack.rza");
            }
        }

        public RZAContentLoader(ContentManager contentManager)
        {
            _contentManager = contentManager;
        }

        public bool Unpack()
        {
            if(!File.Exists(_packLocation))
            {
                Debug.Log("Pack Not Existed");
                ErrorUtil.CreateErrorWindow(Environment.StackTrace);
                return false;
            }

            return true;
        }

        public bool Load()
        {
            return true;
        }
    }
}
