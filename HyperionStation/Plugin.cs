using BepInEx;
using System.IO;
using System.Reflection;
using UnityEngine;
using LethalLevelLoader;

namespace HyperionStation
{
    [BepInPlugin(GUID, NAME, VERSION)]
    [BepInDependency("imabatby.lethallevelloader")]
    public class Plugin : BaseUnityPlugin
    {
        public const string GUID = "Tolian.HyperionStation";
        public const string NAME = "Hyperion Station";
        public const string VERSION = "0.0.1";
        private void Awake()
        {
            // Loading Interior Dungeon assets from AssetBundle
            string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var hyperionStation = AssetBundle.LoadFromFile(Path.Combine(directoryName, "hyperionstation")); // Loading Assetbundle name it your mod and asset name
            if (hyperionStation == null)
            {
                Logger.LogError("Failed to load Interior Dungeon assets.");
                return;
            }

            Logger.LogInfo("Interior Assets loaded successfully");

            ExtendedDungeonFlow hyperionStationExtendedDungeon = hyperionStation.LoadAsset<ExtendedDungeonFlow>("Assets/LethalCompany/Mods/HyperStation/LLL/HyperionStationFlow.asset");
            PatchedContent.RegisterExtendedDungeonFlow(hyperionStationExtendedDungeon);
            Logger.LogInfo("Loaded Extended DungeonFlow");

        }

    }
}