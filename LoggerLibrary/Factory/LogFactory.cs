// ---------------------------------------------------------------------------------------------------------------------
// <copyright file="LogEnum" company="BhalanderSingh">
// © Bhalander Singh. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------

namespace LoggerLibrary
{
    using System;

    using LoggerLibrary.Logger;
    using LoggerLibrary.Model;

    internal class LogFactory
    {
        public ILogSaved GetLogIns(DestinationType destinationType, string ConnectSteing)
        {
            switch (destinationType)
            {
                case DestinationType.textFile:
                    //Return object for save message log in text file
                    return new LogTextfile(ConnectSteing);

                case DestinationType.dataBase:
                    //Return object for save message log in Data base
                    return new LogDataBase(ConnectSteing);

                case DestinationType.console:
                    //Return object for save message log in Console
                    return new LogConsole();

                default:    
                    return null;
            }
        }
    }
}
