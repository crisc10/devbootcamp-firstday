// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hardware.cs" company="Jalasoft">
//   Copyright © 2019 Jalasoft
// </copyright>
// <creator name="cchavez"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Jalasoft.DevBootcamp.Pc.Hardware
{
    /// <summary>
    /// Hardware class
    /// </summary>
    public class Hardware
    {
        /// <summary>
        /// Gets or sets the brand
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Gets or sets the color
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets the width
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the height
        /// </summary>
        public decimal Height { get; set; }

        /// <summary>
        /// Gets or sets the wide
        /// </summary>
        public decimal Wide { get; set; }

        /// <summary>
        /// Turn on the device
        /// </summary>
        /// <returns>The result of the action</returns>
        public bool TurnOn()
        {
            return false;
        }

        /// <summary>
        /// Turn off the device
        /// </summary>
        /// <returns>The result of the action</returns>
        public bool TurnOff()
        {
            return true;
        }
    }
}
