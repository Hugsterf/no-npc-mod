using BepInEx;
using HarmonyLib;
using UnityEngine;
using Mirror;
using System.Collections;

namespace NoNPCMod
{
    [BepInPlugin("com.hugsterf.nonpc", "No NPC", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            var harmony = new Harmony("com.hugsterf.nonpc");
            harmony.PatchAll();
            Debug.Log("[NoNPC] Mod loaded! NPCs disabled but game logic preserved.");
        }
    }

    [HarmonyPatch(typeof(NPCSpawner))]
    public static class NPCSpawnerPatch
    {
        [HarmonyPatch("SpawnAllCoroutine")]
        [HarmonyPrefix]
        public static bool ReplaceSpawnAll(ref IEnumerator __result)
        {
            __result = EmptyCoroutine();
            return false;
        }

        [HarmonyPatch("SpawnNPCsForFloor")]
        [HarmonyPrefix]
        public static bool ReplaceSpawnForFloor(ref IEnumerator __result, int floorIndex)
        {
            __result = EmptyCoroutine();
            return false;
        }

        private static IEnumerator EmptyCoroutine()
        {
            yield break;
        }
    }
}