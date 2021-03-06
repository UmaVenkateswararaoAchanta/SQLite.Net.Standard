﻿using SQLite.Net.Interop;

namespace SQLite.Net.Platform.Generic
{
    public class SQLitePlatformGeneric : ISQLitePlatform
    {
        public SQLitePlatformGeneric()
        {
            SQLiteApi = new SQLiteApiGeneric();
            StopwatchFactory = new StopwatchFactory();
            ReflectionService = new ReflectionService();
            VolatileService = new VolatileService();
        }

        public ISQLiteApi SQLiteApi { get; private set; }
        public IStopwatchFactory StopwatchFactory { get; private set; }
        public IReflectionService ReflectionService { get; private set; }
        public IVolatileService VolatileService { get; private set; }
    }
}
