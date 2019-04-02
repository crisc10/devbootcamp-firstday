// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Screen.cs" company="Jalasoft">
//   Copyright © 2019 Jalasoft
// </copyright>
// <creator name="cchavez"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Jalasoft.DevBootcamp.Pc.Hardware
{
    /// <summary>
    /// Screen class
    /// </summary>
    public class Screen : Hardware
    {
        /// <summary>
        /// Gets or sets the inches of the screen
        /// </summary>
        public int Inche { get; set; }

        /// <summary>
        /// Gets or sets the type of the screen
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the resolution
        /// </summary>
        public int Resolution { get; set; }

        /// <summary>
        /// Adjust the brightness
        /// </summary>
        public void SetBright()
        {
            int bright = 10;
            bright++;
        }

        /// <summary>
        /// Adjust the color
        /// </summary>
        public void SetColor()
        {
            int color = 10;
            color++;
        }
    }
}
