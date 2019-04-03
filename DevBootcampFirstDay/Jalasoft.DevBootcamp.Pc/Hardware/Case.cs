// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Case.cs" company="Jalasoft">
//   Copyright © 2019 Jalasoft
// </copyright>
// <creator name="cchavez"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Jalasoft.DevBootcamp.Pc.Hardware
{
    /// <summary>
    /// Case class
    /// </summary>
    public class Case : Hardware
    {
        /// <summary>
        /// Gets or sets the motherboard
        /// </summary>
        public Motherboard.Motherboard Motherboard { get; set; }
    }
}
