// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Mouse.cs" company="Jalasoft">
//   Copyright © 2019 Jalasoft
// </copyright>
// <creator name="cchavez"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Jalasoft.DevBootcamp.Pc.Hardware
{
    /// <summary>
    /// Mouse class
    /// </summary>
    public class Mouse : Hardware
    {
        /// <summary>
        /// Gets or sets the number of buttons
        /// </summary>
        public int NumberOfButtons { get; set; }

        /// <summary>
        /// Process the click action
        /// </summary>
        /// <param name="button">Identify the clicked button</param>
        /// <returns>The result of the action</returns>
        public bool Click(int button)
        {
            return false;
        }

        /// <summary>
        /// Identify the scrolling action
        /// </summary>
        public void Scroll()
        {
        }
    }
}
