using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;

namespace WitcherDebug
{
    public class WDCActivator
    {
        public static Mem Mem { get; private set; } = new Mem();

        // g_cAuroraSettings.m_nDebugMode
        private const string DEBUG_CONSOLE_ADDRESS = "witcher.exe+0x85068C";
        private const string DEBUG_CONSOLE_KEY_ADDRESS = "witcher.exe+0x34EC3F";
        // g_cAuroraSettings.m_bUnlockCamera
        // alt address: witcher.exe+0x00005020,3C
        private const string UNLOCK_CAMERA_ADDRESS = "witcher.exe+0x85046C";
        // g_cAuroraSettings.m_bFreeFlightCamera
        private const string FREE_FLIGHT_CAMERA_ADDRESS = "witcher.exe+0x850470";
        // g_bDisableGui
        private const string DISABLE_GUI = "witcher.exe+0x850CD4";

        public static int PId { get; private set; } = 0;
        public static bool IsLoaded { get; set; }

        public static void Load()
        {
            PId = Mem.GetProcIdFromName("witcher");
            if (PId > 0 && !IsLoaded)
            {
                Mem.OpenProcess(PId);
                //Mem.WriteMemory(_debugAddress, "byte", "1");
                IsLoaded = true;
            }
        }

        public static void Activate(string value)
        {
            if (Mem.mProc != null)
                Mem.WriteMemory(DEBUG_CONSOLE_ADDRESS, "byte", value);
        }

        // должен использоваться какойто индекс, 31 это нумпад
        public static void SetNewKey(string value)
        {
            if (Mem.mProc != null)
                Mem.WriteMemory(DEBUG_CONSOLE_KEY_ADDRESS, "int", value);
        }

        public static void ActivateFreeCamera(string value)
        {
            if (Mem.mProc != null)
            {
                Mem.WriteMemory(UNLOCK_CAMERA_ADDRESS, "byte", value);
                Mem.WriteMemory(FREE_FLIGHT_CAMERA_ADDRESS, "byte", value);
            }
        }

        public static void DisableGUI(string value)
        {
            if (Mem.mProc != null)
            {
                Mem.WriteMemory(DISABLE_GUI, "byte", value);
            }
        }
    }
}
