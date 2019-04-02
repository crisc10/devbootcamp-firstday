// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Motherboard.cs" company="Jalasoft">
//   Copyright © 2019 Jalasoft
// </copyright>
// <creator name="cchavez"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Jalasoft.DevBootcamp.Pc.Hardware.Motherboard
{
    /// <summary>
    /// Motherboard class
    /// </summary>
    public class Motherboard
    {
        /// <summary>
        /// Gets or sets the slots
        /// </summary>
        public int Slots { get; set; }

        /// <summary>
        /// Gets or sets the hard disk drive
        /// </summary>
        public HardDiskDrive HardDiskDrive { get; set; }

        /// <summary>
        /// Gets or sets the memory
        /// </summary>
        private Memory Memory { get; set; }

        /// <summary>
        /// Gets or sets the cooler
        /// </summary>
        private Cooler Cooler { get; set; }

        /// <summary>
        /// Gets or sets the video card
        /// </summary>
        private VideoCard VideoCard { get; set; }

        /// <summary>
        /// Recognize de the connected device
        /// </summary>
        public void RecognizeDevice()
        {
        }
    }
}
