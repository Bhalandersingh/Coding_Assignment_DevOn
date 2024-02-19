// ---------------------------------------------------------------------------------------------------------------------
// <copyright file="LogEnum" company="BhalanderSingh">
// © Bhalander Singh. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------


namespace LoggerLibrary.Model
{
    using System;

    /// <summary>
    /// Destination or sink of the message
    /// </summary>
    public enum DestinationType
    {
        textFile,
        dataBase,
        console
    }

    /// <summary>
    /// Log level for track message
    /// </summary>
    public enum LogLevel
    {
        FATAL = 0,
        ERROR,
        WARN,
        INFO,
        DEBUG,
    }
}
