﻿namespace InterfaceExtensibility
{
    public interface ILogger
    {
        void LogError(string error);
        void LogInfo(string info);
    }
}