﻿namespace RT
{
    class Program
    {
        static void Main(string[] args)
        {
            Core core = Core.Unit;
            core.PreInit();
            core.Init();
        }
    }
}
