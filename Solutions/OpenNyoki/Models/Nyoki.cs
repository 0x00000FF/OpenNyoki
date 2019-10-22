using System;
using System.Collections.Generic;
using System.Text;

namespace OpenNyoki.Models
{
    public enum NyokiPanel
    {
        Left, Right
    }

    public enum NyokiTypes
    {
        Green = 0, Red = 1, Blue = 2, Purple = 3, Yellow = 4
    }

    public struct NyokiPosition
    {
        public NyokiPanel Panel { get; set; } 
        public byte X { get; set; }
        public byte Y { get; set; }

        public static NyokiPosition CreatePosition(NyokiPanel panel) => new NyokiPosition { Panel = panel };
    }

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
