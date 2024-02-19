// ---------------------------------------------------------------------------------------------------------------------
// <copyright file="LogEnum" company="BhalanderSingh">
// © Bhalander Singh. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------


namespace LoggerLibrary
{
    using System;

    public interface ILoggerManager
    {
        /// <summary>
        /// LogDebug used for log the debugging message
        /// </summary>
        /// <param name="msgSendBy">Message send by the part of application</param>
        /// <param name="message">message for log</param
        void LogFatal(string msgSendBy, string message);

        /// <summary>
        /// LogDebug used for log the debugging message
        /// </summary>
        /// <param name="msgSendBy">Message send by the part of application</param>
        /// <param name="message">message for log</param
        void LogInfo(string msgSendBy, string message);

        /// <summary>
        /// LogDebug used for log the debugging message
        /// </summary>
        /// <param name="msgSendBy">Message send by the part of application</param>
        /// <param name="message">message for log</param
        void LogWarn(string msgSendBy, string message);

        /// <summary>
        /// LogDebug used for log the debugging message
        /// </summary>
        /// <param name="msgSendBy">Message send by the part of application</param>
        /// <param name="message">message for log</param>
        void LogDebug(string msgSendBy, string message);

        /// <summary>
        /// LogDebug used for log the debugging message
        /// </summary>
        /// <param name="msgSendBy">Message send by the part of application</param>
        /// <param name="message">message for log</param
        void LogError(string msgSendBy, string message);
    }
}
