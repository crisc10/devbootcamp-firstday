// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Jalasoft">
//   Copyright © 2019 Jalasoft
// </copyright>
// <creator name="cchavez"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Jalasoft.DevBootcamp.Console
{
    using System;
    using System.Collections.Generic;
    using Jalasoft.DevBootcamp.Pc;
    using Jalasoft.DevBootcamp.Pc.Hardware;
    using Jalasoft.DevBootcamp.Pc.Software;
    using Jalasoft.DevBootcamp.Pc.Software.User;
    
    /// <summary>
    /// Main class
    /// </summary>
    /// Modificado por roger
    public class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args">Initial args</param>
        public static void Main(string[] args)
        {
            PersonalComputer myPc = new PersonalComputer();
            myPc.Guarantee = 2;
            myPc.Price = 1000;
            myPc.Provider = "World PC";
            
            myPc.HardwarePc = new List<Hardware>();

            // setting screen
            Screen myScreen = new Screen();
            myScreen.Brand = "Samsung";
            myPc.HardwarePc.Add(myScreen);

            // setting keyboard
            Keyboard myKeyboard = new Keyboard();
            myKeyboard.Brand = "Genius";
            myPc.HardwarePc.Add(myKeyboard);

            // setting mouse
            Mouse myMouse = new Mouse();
            myMouse.Brand = "Genius";
            myPc.HardwarePc.Add(myMouse);

            // setting case
            Case myCase = new Case();
            myCase.Brand = "Ducky";
            myPc.HardwarePc.Add(myCase);

            // setting camera
            Camera myCamera = new Camera();
            myCamera.Color = "Silver";
            myPc.HardwarePc.Add(myCamera);

            // setting speaker
            Speaker mySpeaker = new Speaker();
            mySpeaker.Frequency = 100;
            myPc.HardwarePc.Add(mySpeaker);

            myPc.SoftwarePc = new List<Software>();

            // setting softwareOS
            Software mySoftwareOS = new Software();
            mySoftwareOS.Version = 2;
            mySoftwareOS.LastUpdate = DateTime.Now.AddYears(-10);
            mySoftwareOS.Name = "Windows XP";
            myPc.SoftwarePc.Add(mySoftwareOS);

            Software mySoftwareApp = new Software();
            mySoftwareApp.Version = 5;
            mySoftwareApp.LastUpdate = DateTime.Now.AddYears(-2);
            mySoftwareApp.Name = "League of Legends";
            mySoftwareApp.Release = DateTime.Now.AddYears(-8);
            myPc.SoftwarePc.Add(mySoftwareApp);

            // Mauricio rules as usually
            User myUser = new User();
            myUser.FirstName = "Mauricio";
            myUser.LastName = "Sure?";
            myUser.UserName = "mgates";
            myUser.LastName = "Iriarte";

            mySoftwareOS.Users = new List<User>();
            mySoftwareOS.Users.Add(myUser);

            myScreen.Brand = "Samsung";
            myPc.HardwarePc.Add(myScreen);
        }
    }
}
