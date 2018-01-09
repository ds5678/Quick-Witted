using Harmony;

namespace QuickWitted
{
    [HarmonyPatch(typeof(SkillsManager))]
    [HarmonyPatch("IncrementPointsAndNotify")]
    public class QuickWitted
    {
        static bool Prefix(ref int numPoints)
        {
            numPoints = numPoints * 2;
            return true;
        }
    }
}

