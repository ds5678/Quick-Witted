using Harmony;
using MelonLoader;
using UnityEngine;

namespace QuickWitted
{
    
    public class Implementation : MelonMod
    {

        public override void OnApplicationStart()
        {
            Debug.Log($"[{Info.Name}] Version {Info.Version} loaded!");
            QuickWittedModSettings.OnLoad();
        }

        internal static int GetRateForSkill(SkillType type)
        {
            switch (type)
            {
                case SkillType.Archery:
                    return QuickWittedModSettings.settings.archeryrate;
                case SkillType.CarcassHarvesting:
                    return QuickWittedModSettings.settings.carcassharvestingrate;
                case SkillType.ClothingRepair:
                    return QuickWittedModSettings.settings.clothingrepairrate;
                case SkillType.Cooking:
                    return QuickWittedModSettings.settings.cookingrate;
                case SkillType.Firestarting:
                    return QuickWittedModSettings.settings.firestartingrate;
                case SkillType.Gunsmithing:
                    return QuickWittedModSettings.settings.gunsmithingrate;
                case SkillType.IceFishing:
                    return QuickWittedModSettings.settings.icefishingrate;
                case SkillType.Revolver:
                    return QuickWittedModSettings.settings.revolverrate;
                case SkillType.Rifle:
                    return QuickWittedModSettings.settings.riflerate;
                case SkillType.ToolRepair:
                    return QuickWittedModSettings.settings.toolrepairrate;
                default:
                    return 1;
            }
        }
    }

    internal class Patches 
    {
        [HarmonyPatch(typeof(SkillsManager), "IncrementPointsAndNotify")]
        internal class SkillIncreasePatch
        {
            static void Prefix(SkillType skillType, ref int numPoints)
            {
                numPoints = numPoints * Implementation.GetRateForSkill(skillType);
            }
        }
    }
}

