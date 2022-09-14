using HarmonyLib;
using Sandbox.Game.GameSystems;
using Sandbox.Game.Gui;
using System.Reflection;

namespace AutoFactionChat
{
    [HarmonyPatch]
    internal static class MyChatSystemPatch
    {
        private static MethodBase TargetMethod()
        {
            return AccessTools.Constructor(typeof(MyChatSystem));
        }

        private static void Postfix(ref ChatChannel ___m_currentChannel)
        {
            ___m_currentChannel = ChatChannel.Faction;
            Plugin.Log.Info("Switched to Faction Channel");
        }
    }
}
