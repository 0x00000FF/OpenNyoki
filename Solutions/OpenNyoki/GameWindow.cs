using System;
using System.Collections.Generic;
using System.Text;

using SFML.Graphics;
using SFML.Window;

namespace OpenNyoki
{
    class GameWindow
    {
        private RenderWindow m_RenderWindow = null;

        public GameWindow(RenderWindow _window = null)
        {
            m_RenderWindow = _window ??
                             new RenderWindow(
                                 mode: new VideoMode(800, 600),
                                 title: "OpenNyoki"
                                 );

            AssignEvents();

            while (m_RenderWindow.IsOpen)
            {
                m_RenderWindow.Display();
                m_RenderWindow.DispatchEvents();
            }
        }

        private void AssignEvents(GameWindowEvents events)
        {
            m_RenderWindow.Closed += new EventHandler(events.WindowClosed);
        }
    }
}
