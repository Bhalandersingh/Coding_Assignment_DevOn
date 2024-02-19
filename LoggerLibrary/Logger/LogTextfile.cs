// ---------------------------------------------------------------------------------------------------------------------
// <copyright file="LogEnum" company="BhalanderSingh">
// © Bhalander Singh. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------


namespace LoggerLibrary.Logger
{
    using System;
    using System.IO;

    internal class LogTextfile : ILogSaved
    {
        string _filePath;
        public LogTextfile(string filePath)
        {
            _filePath = filePath;
        }

        /// <summary>
        /// This is used to save the message in text file
        /// </summary>
        /// <param name="message">Message to save</param>
        public void AddLogMessage(string message)
        {
            try
            {
                string fileFullPath = Path.Combine(_filePath, DateTime.Now.ToShortDateString() + ".txt");
                //TextWriter tw = new StreamWriter("date.txt", true);
                using (StreamWriter sw = new StreamWriter(fileFullPath,true))
                {
                    sw.WriteLineAsync(message);
                }
            } catch { }
        }
    }
}
