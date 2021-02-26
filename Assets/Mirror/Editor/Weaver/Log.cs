using System;

namespace Mirror.Editor.Weaver
{
    public static class Log
    {
        public static Action<string> Warning;
        public static Action<string> Error;
    }
}
