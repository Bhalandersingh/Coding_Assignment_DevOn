// ---------------------------------------------------------------------------------------------------------------------
// <copyright file="LogEnum" company="BhalanderSingh">
// © Bhalander Singh. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------


namespace LoggerLibrary
{
    using System;
    using LoggerLibrary.Model;

    public static class LoggerExtensions
    {
        public static string LogMsgFormat(this string message, LoggerModel _loggerModel)
        {
            return $"{DateTime.UtcNow.ToString()} : {_loggerModel._logLevel} : {_loggerModel._destinationType} :: {_loggerModel._msgSendByApplication} :-> {message}";
        }

        public static TEnum ToEnum<TEnum>(this string value)
        {
            try
            {
               return (TEnum)Enum.Parse(typeof(TEnum), value, true);
            }
            catch(Exception ex)
            {
                return default(TEnum);
            }
        }
    }
}
