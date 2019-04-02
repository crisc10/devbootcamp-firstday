// --------------------------------------------------------------------------------------------------------------------
// <copyright file="User.cs" company="Jalasoft">
//   Copyright © 2019 Jalasoft
// </copyright>
// <creator name="cchavez"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Jalasoft.DevBootcamp.Pc.Software.User
{
    /// <summary>
    /// Software user class
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets a value indicating whether the user is admin or guest
        /// </summary>
        public bool Type { get; set; }

        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the username
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password
        /// </summary>
        private string Password { get; set; }

        /// <summary>
        /// Sets the user
        /// </summary>
        public void SetUser()
        {
        }

        /// <summary>
        /// Changes the user password
        /// </summary>
        public void ChangePassword()
        {
        }

        /// <summary>
        /// Login with the user credentials
        /// </summary>
        /// <returns>The result of the action</returns>
        public bool Login()
        {
            return false;
        }

        /// <summary>
        /// Logout the user session
        /// </summary>
        /// <returns>The result of the action</returns>
        public bool Logout()
        {
            return true;
        }
    }
}
