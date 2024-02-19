// ---------------------------------------------------------------------------------------------------------------------
// <copyright file="LogEnum" company="BhalanderSingh">
// © Bhalander Singh. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------


namespace LoggerLibrary.Model
{
    using System;
    
    public class LoggerModel
    {
        /// <summary>
        /// Destination or sink of the message
        /// </summary>
        public DestinationType _destinationType { get; set; }

        /// <summary>
        /// Log level for track message
        /// </summary>
        public LogLevel _logLevel { get; set; }

        /// <summary>
        /// Message send by part od application
        /// </summary>
        public string _msgSendByApplication { get; set; }

        /// <summary>
        /// Message send to log
        /// </summary>
        public string _message { get; set; }
    }
}
