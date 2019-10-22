using System;
using System.Collections.Generic;
using System.Text;

namespace OpenNyoki.Models
{
    /// <summary>
    /// Determines Panel that Nyoki will be shown.
    /// </summary>
    public enum NyokiPanel
    {
        Left, Right
    }

    /// <summary>
    /// Determines Type of Nyoki.
    /// </summary>
    public enum NyokiTypes
    {
        Green = 0, Red = 1, Blue = 2, Purple = 3, Yellow = 4
    }

    /// <summary>
    /// Determines Position of Nyoki.
    /// </summary>
    public struct NyokiPosition
    {
        public NyokiPanel Panel { get; set; } 
        public byte X { get; set; }
        public byte Y { get; set; }

        /// <summary>
        /// Creates position structure with position (0, 0) and user defined panel info
        /// </summary>
        /// <param name="panel">Desired panel to show nyoki</param>
        /// <returns>A NyokiPosition structure</returns>
        public static NyokiPosition CreatePosition(NyokiPanel panel) => new NyokiPosition { Panel = panel };
    }

    /// <summary>
    /// Describes a Nyoki
    /// </summary>
    public class Nyoki : GameObject
    {
        public bool IsPinNyoki { get; set; } = false;
        public NyokiTypes Type { get; set; }
        public NyokiPosition Position { get; set; }

        public Nyoki(NyokiTypes type, NyokiPanel panel)
        {
            Type = type;
            Position = NyokiPosition.CreatePosition(panel);
        }
    }
}
