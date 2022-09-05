using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace LevelEditorPlugin
{
    public static class StaticBrushes
    {
        private static readonly Dictionary<string, Brush> m_staticBrushes = new Dictionary<string, Brush>();

        /// <summary>
        /// Finds a frozen brush with the specified color code, or creates a new one if it doesn't exist
        /// </summary>
        /// <param name="inColorCode">Hexadecimal color code in ARGB format, ie:"#FF102030"</param>
        /// <returns>A frozen brush</returns>
        public static Brush GetBrush(string inColorCode)
        {
            if (!m_staticBrushes.ContainsKey(inColorCode))
            {
                Brush newBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(inColorCode)); newBrush.Freeze();
                m_staticBrushes.Add(inColorCode, newBrush);
            }
            return m_staticBrushes[inColorCode];
        }

        /// <summary>
        /// Finds a frozen brush with the specified color, or creates a new one if it doesn't exist
        /// </summary>
        /// <param name="inA">Alpha</param>
        /// <param name="inR">Red</param>
        /// <param name="inG">Green</param>
        /// <param name="inB">Blue</param>
        /// <returns>A frozen brush</returns>
        public static Brush GetBrush(byte inA, byte inR, byte inG, byte inB)
        {
            // convert to hex color code
            string colorCode = $"#{inA:X2}{inR:X2}{inG:X2}{inB:X2}";

            if (!m_staticBrushes.ContainsKey(colorCode))
            {
                Brush newBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colorCode)); newBrush.Freeze();
                m_staticBrushes.Add(colorCode, newBrush);
            }
            return m_staticBrushes[colorCode];
        }
    }
}
