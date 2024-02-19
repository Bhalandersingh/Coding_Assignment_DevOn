// ---------------------------------------------------------------------------------------------------------------------
// <copyright file="LogEnum" company="BhalanderSingh">
// © Bhalander Singh. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------


namespace LoggerLibrary
{
    using System;
    internal class LogConsole : ILogSaved
    {

        /// <summary>
        /// This is used to show message in console 
        /// </summary>
        /// <param name="message">Message to save</param>
        public void AddLogMessage(string message)
        {
            Console.WriteLine(message); 
        }
    }
}
