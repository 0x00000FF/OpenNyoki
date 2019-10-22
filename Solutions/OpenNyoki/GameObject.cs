using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenNyoki
{
    /// <summary>
    /// Base game object that will be painted on GameWindow
    /// </summary>
    public class GameObject : Drawable
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public uint Height { get; set; }
        public uint Width { get; set; }

        public void Draw(RenderTarget target, RenderStates states)
        {
            throw new NotImplementedException();
        }
    }
}
