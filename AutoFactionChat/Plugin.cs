using HarmonyLib;
using NLog;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using VRage.Plugins;

namespace AutoFactionChat
{
    public class Plugin : IPlugin, IDisposable
    {
        public static readonly Logger Log = LogManager.GetCurrentClassLogger();

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void Init(object gameInstance)
        {
            new Harmony("AutoFactionChat").PatchAll(Assembly.GetExecutingAssembly());
            Log.Info($"AutoFactionChat loaded");
        }
        public void Dispose()
        {
        }
        public void Update()
        {
        }
    }
}
