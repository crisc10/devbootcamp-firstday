// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PersonalComputer.cs" company="Jalasoft">
//   Copyright © 2019 Jalasoft
// </copyright>
// <creator name="cchavez"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Jalasoft.DevBootcamp.Pc
{
    using System.Collections.Generic;

    /// <summary>
    /// PersonalComputer class
    /// </summary>
    public class PersonalComputer
    {
        /// <summary>
        /// Gets or sets the year until the computer has guarantee.
        /// </summary>
        public int Guarantee { get; set; }

        /// <summary>
        /// Gets or sets the provider
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets the price in $US
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the hardware components
        /// </summary>
        public List<Hardware.Hardware> HardwarePc { get; set; }

        /// <summary>
        /// Gets or sets the software components
        /// </summary>
        public List<Software.Software> SoftwarePc { get; set; }
    }
}
