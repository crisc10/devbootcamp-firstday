// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Keyboard.cs" company="Jalasoft">
//   Copyright © 2019 Jalasoft
// </copyright>
// <creator name="cchavez"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Jalasoft.DevBootcamp.Pc.Hardware
{
    /// <summary>
    /// Keyboard class
    /// </summary>
    public class Keyboard : Hardware
    {
        /// <summary>
        /// Gets or sets the language
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether has numeric pad or not
        /// </summary>
        public bool Numpad { get; set; }

        /// <summary>
        /// Process the pressed key
        /// </summary>
        public void PressKey()
        {
            int key = 0;
            key++;
        }

        /// <summary>
        /// Process the command combination
        /// </summary>
        /// <param name="firstKey">First key pressed</param>
        /// <param name="secondKey">Second key pressed</param>
        /// <param name="optionalKey">Optional key pressed</param>
        public void Combined(int firstKey, int secondKey, int optionalKey = 0)
        {
            int combination = firstKey + secondKey;
            combination++;
        }
    }
}
