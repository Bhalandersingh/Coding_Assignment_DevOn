// ---------------------------------------------------------------------------------------------------------------------
// <copyright file="LogEnum" company="BhalanderSingh">
// © Bhalander Singh. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------


namespace LoggerLibrary
{
    using System;

    internal interface ILogSaved
    {
        /// <summary>
        /// AddLogmessage used to save message.
        /// </summary>
        /// <param name="message">this message svaed.</param>
        void AddLogMessage(string message);
    }
}
