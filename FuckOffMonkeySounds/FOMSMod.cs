using FuckOffMonkeySounds;
using HarmonyLib;
using MelonLoader;

[assembly: MelonInfo(typeof(FOMSMod), "FuckOffMonkeySounds", "0.2.0", "Luna")]
[assembly: MelonGame("Another Axiom", "Gorilla Tag")]
namespace FuckOffMonkeySounds
{
    public class FOMSMod : MelonMod { }

    [HarmonyPatch(typeof(VRRig), "LateUpdate")]
    static class ComputerPatch
    {
        static void Prefix(VRRig __instance)
        {
            __instance.replacementVoiceLoudnessThreshold = float.MaxValue;
        }
    }
}
