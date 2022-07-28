using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RZEngine.Core.Extended
{
    public class ContentManager : Microsoft.Xna.Framework.Content.ContentManager
    {
        public ContentManager(Microsoft.Xna.Framework.GameServiceContainer service)
            : base(service)
        { }
    }
}
