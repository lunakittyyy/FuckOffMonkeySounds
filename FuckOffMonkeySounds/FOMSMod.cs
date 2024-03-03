using HarmonyLib;
#if MELONLOADER
using MelonLoader;
using FuckOffMonkeySounds;
#else
using BepInEx;
using System.Reflection;
#endif

#if MELONLOADER
[assembly: MelonInfo(typeof(FOMSMod), "FuckOffMonkeySounds", "1.1.0", "Luna")]
[assembly: MelonGame("Another Axiom", "Gorilla Tag")]
#endif
namespace FuckOffMonkeySounds
{
#if MELONLOADER
    public class FOMSMod : MelonMod { }
#else
    [BepInPlugin("luna.fuckoffmonkeysounds", "FuckOffMonkeySounds", "1.1.0")]
    public class FOMSMod : BaseUnityPlugin {
        
        void Start()
        {
            HarmonyLib.Harmony harmony = new HarmonyLib.Harmony("luna.fuckoffmonkeysounds");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
#endif
    [HarmonyPatch(typeof(VRRig), "LateUpdate")]
    static class RigPatch
    {
        static void Prefix(VRRig __instance)
        {
            __instance.replacementVoiceLoudnessThreshold = float.MaxValue;
        }
    }
}
