using FuckOffMonkeySounds;
using HarmonyLib;
using MelonLoader;

[assembly: MelonInfo(typeof(FOMSMod), "FuckOffMonkeySounds", "1.0.0", "Luna")]
[assembly: MelonGame("Another Axiom", "Gorilla Tag")]
namespace FuckOffMonkeySounds
{
    public class FOMSMod : MelonMod { }

    [HarmonyPatch(typeof(VRRig), "LateUpdate")]
    static class RigPatch
    {
        static void Prefix(VRRig __instance)
        {
            __instance.replacementVoiceLoudnessThreshold = float.MaxValue;
        }
    }
}
