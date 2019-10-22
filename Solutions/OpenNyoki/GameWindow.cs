using System;
using System.Collections.Generic;
using System.Text;

using SFML.Graphics;
using SFML.Window;

namespace OpenNyoki
{
    /// <summary>
    /// Describes Game Window.
    /// </summary>
    class GameWindow
    {
        private RenderWindow m_RenderWindow = null;
        private GameWindowEvents m_GameEvents = null;

        private Game m_Game = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_window">SFML Render Window</param>
        /// <param name="_events">Event Object for Window Event Handling</param>
        /// <param name="_game">Main Game Object</param>
        public GameWindow(RenderWindow _window = null, 
                          GameWindowEvents _events = null, 
                          Game _game = null)
        {
            m_RenderWindow = _window ??
                             new RenderWindow(
                                 mode: new VideoMode(800, 600),
                                 title: "OpenNyoki"
                                 );
            m_GameEvents = _events ?? new GameWindowEvents();
            m_Game = _game ?? new Game();

            AssignEvents(m_GameEvents);

            while (m_RenderWindow.IsOpen)
            {
                m_RenderWindow.Display();
                m_RenderWindow.DispatchEvents();
            }
        }

        /// <summary>
        /// Assigns Event Handlers for Game Window
        /// </summary>
        /// <param name="events">Event Handler Implementation Object</param>
        private void AssignEvents(GameWindowEvents events)
        {
            m_RenderWindow.Closed += new EventHandler(events.WindowClosed);
            m_RenderWindow.GainedFocus += new EventHandler(events.WindowGainedFocus);
            m_RenderWindow.KeyPressed += new EventHandler<KeyEventArgs>(events.KeyDown);
            m_RenderWindow.KeyReleased += new EventHandler<KeyEventArgs>(events.KeyUp);
            m_RenderWindow.LostFocus += new EventHandler(events.WindowLostFocus);
            m_RenderWindow.MouseButtonPressed += new EventHandler<MouseButtonEventArgs>(events.MouseDown);
            m_RenderWindow.MouseButtonReleased += new EventHandler<MouseButtonEventArgs>(events.MouseUp);
            m_RenderWindow.MouseMoved += new EventHandler<MouseMoveEventArgs>(events.MouseMove);
            m_RenderWindow.MouseWheelScrolled += new EventHandler<MouseWheelScrollEventArgs>(events.MouseScrolled);
        }
    }
}
