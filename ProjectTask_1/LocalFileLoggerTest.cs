﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTask_3
{
    public class LocalFileLoggerTest
    {
        public static void TestLogging<T>(string path, string message, Exception exception)
        {
            var logger = new LocalFileLogger<T>(path);

            logger.LogInfo(message);
            logger.LogWarning(message);
            logger.LogError(message, exception);
        }
    }
}
