using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace LevelEditorPlugin.Attributes
{
    /// <summary>
    /// Determines the color of a node's header.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class NodeColorAttribute : Attribute
    {
        /// <summary>
        /// The node header color in the format "#FFFFFFFF" (ARGB)
        /// </summary>
        public string ColorCode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeColorAttribute"/> class using the input color.
        /// </summary>
        /// <param name="inColor">Hexadecimal color code in ARGB format, ie:"#FF102030"</param>
        public NodeColorAttribute(string inColor)
        {
            ColorCode = inColor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeColorAttribute"/> class using the input ARGB color.
        /// </summary>
        /// <param name="inA">Alpha</param>
        /// <param name="inR">Red</param>
        /// <param name="inG">Green</param>
        /// <param name="inB">Blue</param>
        public NodeColorAttribute(byte inA, byte inR, byte inG, byte inB)
        {
            // convert to hex color code
            ColorCode = $"#{inA:X2}{inR:X2}{inG:X2}{inB:X2}";
        }
    }
}
