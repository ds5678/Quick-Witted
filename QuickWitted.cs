using System;
using System.Xml;
using Harmony;

namespace QuickWitted
{
    [HarmonyPatch(typeof(SkillsManager), "IncrementPointsAndNotify")]
    public class QuickWitted
    {

        static int[] learnRates;
        static bool isRunning;
        static XmlDocument config;

        //Load ratio fo each skill;
        public static void OnLoad()
        {

            //Load XML and initiate the array
            LoadXML();

            int numberOfSkills = Enum.GetNames(typeof(SkillType)).Length;
            learnRates = new int[numberOfSkills];

            foreach (SkillType type in Enum.GetValues(typeof(SkillType)))
            {
                learnRates[(int)type] = GetRateForSkill(type);
            }

        }

        static int GetRateForSkill(SkillType type)
        {
            try
            {

                XmlNodeList elemList = config.GetElementsByTagName(type.ToString());
                int rv = int.Parse(elemList[0].InnerText);

                return rv;
            }
            catch
            {
                //if you can't load it form the XML default it to 2
                return 2;
            }



        }

        static bool LoadXML()
        {

            config = new XmlDocument();
            //stick this whole thin in atry for now. 
            //TODO:Better error managment
            try
            {
                config.Load("QuickWittedConfig.xml");

                return true;
            }
            catch
            {
                return false;
            }
        }


        static void Prefix(SkillType skillType, ref int numPoints)
        {
            numPoints = numPoints * learnRates[(int)skillType];
        }
    }
}

