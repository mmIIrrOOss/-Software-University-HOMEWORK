﻿namespace _01.Logger.Models.Constrains
{
    using System.Collections.Generic;

    public interface ILogger
    {
        IReadOnlyCollection<IAppender> Appenders { get; }

        void Log(IError error);  
    }
}
