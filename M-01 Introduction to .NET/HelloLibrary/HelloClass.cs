using System;

namespace HelloLibrary
{
    public static class HelloClass
    {
        public static string GenerateWelcomeString(DateTime dateTime, string name)
        {
            return string.Format($"[{dateTime}] Hello, {name}!");
        }
    }
}
