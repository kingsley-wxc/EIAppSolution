﻿namespace LoggerUtils
{
    public class Log4Nlog : Log4ILog
    {
        private NLog.Logger logger = null;

        public Log4Nlog()
        {
            //配置文件位置
            NLog.LogManager.Configuration = new NLog.Config.XmlLoggingConfiguration("LogConfig/NLog.config");
            logger = NLog.LogManager.GetCurrentClassLogger();
        }

        /// <summary>
        /// Debug Log
        /// </summary>
        /// <param name="msg"></param>
        public void WriteDebugLog(string msg)
        {
            logger.Debug(msg);
        }

        /// <summary>
        /// Info
        /// </summary>
        /// <param name="msg"></param>
        public void WriteInfoLog(string msg)
        {
            logger.Info(msg);
        }

        /// <summary>
        ///  Error
        /// </summary>
        /// <param name="msg"></param>
        public void WriteErrorLog(string msg)
        {
            logger.Error(msg);
        }
    }
}