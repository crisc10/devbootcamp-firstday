// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Software.cs" company="Jalasoft">
//   Copyright © 2019 Jalasoft
// </copyright>
// <creator name="cchavez"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Jalasoft.DevBootcamp.Pc.Software
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Computer software class
    /// </summary>
    public class Software
    {
        /// <summary>
        /// Gets or sets the name of the software
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the manufacturer
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Gets or sets the version
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// Gets or sets the software last update
        /// </summary>
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// Gets or sets the software release date
        /// </summary>
        public DateTime Release { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is open source or private
        /// </summary>
        public bool Licensing { get; set; }

        /// <summary>
        /// Gets or sets the software users
        /// </summary>
        public List<User.User> Users { get; set; }

        /// <summary>
        /// Starts the program
        /// </summary>
        /// <returns>The status of the request</returns>
        public bool OpenProgram()
        {
            return false;
        }

        /// <summary>
        /// Closes the program
        /// </summary>
        /// <returns>The status of the request</returns>
        public bool CloseProgram()
        {
            return true;
        }

        /// <summary>
        /// Asks for admin authorization
        /// </summary>
        /// <returns>The status of the request</returns>
        public bool AdminPermission()
        {
            return false;
        }

        /// <summary>
        /// Gets the current memory used by the program
        /// </summary>
        /// <returns>The amount of memory used</returns>
        private decimal MemoryUse()
        {
            return 0;
        }

        /// <summary>
        /// Gets the current processor used by the program
        /// </summary>
        /// <returns>The amount of processor used</returns>
        private decimal CpuUse()
        {
            return 0;
        }

        /// <summary>
        /// Gets the current disk used by the program
        /// </summary>
        /// <returns>The amount of disk used</returns>
        private decimal DiskUse()
        {
            return 0;
        }

        /// <summary>
        /// Gets the current network used by the program
        /// </summary>
        /// <returns>The amount of network used</returns>
        private decimal NetworkUse()
        {
            return 0;
        }
    }
}
