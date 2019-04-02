// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Speaker.cs" company="Jalasoft">
//   Copyright © 2019 Jalasoft
// </copyright>
// <creator name="cchavez"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Jalasoft.DevBootcamp.Pc.Hardware
{
    /// <summary>
    /// Speaker class
    /// </summary>
    public class Speaker : Hardware
    {
        /// <summary>
        /// Gets or sets the frequency
        /// </summary>
        public decimal Frequency { get; set; }

        /// <summary>
        /// Turn up or down the volume level
        /// </summary>
        public void SetVolume()
        {
            int volume = 10;
            volume++;
        }
    }
}
