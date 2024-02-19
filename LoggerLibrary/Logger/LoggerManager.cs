// ---------------------------------------------------------------------------------------------------------------------
// <copyright file="LogEnum" company="BhalanderSingh">
// © Bhalander Singh. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------


namespace LoggerLibrary
{
    using System;

    using LoggerLibrary.Model;

    /// <summary>
    /// LoggerManager used for save log
    /// </summary>
    public class LoggerManager : ILoggerManager
    {
        ILogSaved objMsgStore;
        LoggerModel objLoggerModel = new LoggerModel();
        LogFactory logFactory = new LogFactory();

        public LoggerManager(string logLevel, string desType, string connectString)
        {
            objLoggerModel._destinationType = desType.ToEnum<DestinationType>();
            objLoggerModel._logLevel = logLevel.ToEnum<LogLevel>();
            objMsgStore = logFactory.GetLogIns(objLoggerModel._destinationType, connectString);
        }

        public void LogFatal(string msgSendBy, string message)
        {
            try
            {
                if((int)LogLevel.FATAL >= (int)objLoggerModel._logLevel)
                {
                    objLoggerModel._message = message;
                    objLoggerModel._msgSendByApplication = msgSendBy;
                    string Msg = message.LogMsgFormat(objLoggerModel);
                    objMsgStore.AddLogMessage(Msg);
                }
            }
            catch (Exception ex) { }
        }

        public void LogDebug(string msgSendBy, string message)
        {
            try
            {
                if ((int)LogLevel.DEBUG >= (int)objLoggerModel._logLevel)
                {
                    objLoggerModel._message = message;
                    objLoggerModel._msgSendByApplication = msgSendBy;
                    string Msg = message.LogMsgFormat(objLoggerModel);
                    objMsgStore.AddLogMessage(Msg);
                }
            } catch (Exception ex) { }          
        }

        public void LogError(string msgSendBy, string message)
        {
            try
            {
                if ((int)LogLevel.ERROR >= (int)objLoggerModel._logLevel)
                {
                    objLoggerModel._message = message;
                    objLoggerModel._msgSendByApplication = msgSendBy;
                    string Msg = message.LogMsgFormat(objLoggerModel);
                    objMsgStore.AddLogMessage(Msg);
                }
            }
            catch (Exception ex) { }
        }

        public void LogInfo(string msgSendBy, string message)
        {
            try
            {
                if ((int)LogLevel.INFO >= (int)objLoggerModel._logLevel)
                {
                    objLoggerModel._message = message;
                    objLoggerModel._msgSendByApplication = msgSendBy;
                    string Msg = message.LogMsgFormat(objLoggerModel);
                    objMsgStore.AddLogMessage(Msg);
                }
            }
            catch (Exception ex) { }
        }

        public void LogWarn(string msgSendBy, string message)
        {
            try
            {
                if ((int)LogLevel.WARN >= (int)objLoggerModel._logLevel)
                {
                    objLoggerModel._message = message;
                    objLoggerModel._msgSendByApplication = msgSendBy;
                    string Msg = message.LogMsgFormat(objLoggerModel);
                    objMsgStore.AddLogMessage(Msg);
                }
            }
            catch (Exception ex) { }
        }
    }
}
