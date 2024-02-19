// ---------------------------------------------------------------------------------------------------------------------
// <copyright file="LogEnum" company="BhalanderSingh">
// © Bhalander Singh. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------


namespace LoggerLibrary
{
    using System;
    internal class LogDataBase : ILogSaved
    {
        string connectionSteing;
        public LogDataBase(string ConnectionSteing)
        {
            connectionSteing = ConnectionSteing;
        }

        /// <summary>
        /// This is used to save the message in data base
        /// </summary>
        /// <param name="Msg">Message to save</param>
        public void AddLogMessage(string msg)
        {
            throw new NotImplementedException();
        }
    }
}
