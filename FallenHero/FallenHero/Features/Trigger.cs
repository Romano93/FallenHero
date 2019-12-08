using FallenHero.Manager;
using FallenHero.Other;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallenHero.Features
{
    class Trigger
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public static void Run()
        {
            while (true)
            {
                if (!Settings.Instance.aimTrigger)
                    continue;

                // entity in crosshair
                int entityInCrossId = Memory.ReadMemory<int>(Structs.LocalPlayer.m_iBase + Offsets.m_iCrosshairId);
                
                if(entityInCrossId != 0)
                {
                    int entityTeam = Structs.LocalPlayer.m_iTeamNum;
                    try
                    {
                        entityTeam = Memory.ReadMemory<int>(Structs.Arrays.Entity[entityInCrossId - 1].m_iBase + Offsets.m_iTeamNum);
                    }
                    catch
                    {
                        //well xD
                    }

                    if (entityTeam == Structs.LocalPlayer.m_iTeamNum)
                        continue;
                    
                    if (GetAsyncKeyState(Keys.XButton2) == -32768)
                    {
                        uint X = (uint)Cursor.Position.X;
                        uint Y = (uint)Cursor.Position.Y;

                        mouse_event(MOUSEEVENTF_LEFTDOWN , X, Y, 0, 0);
                        Thread.Sleep(50);
                        mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                        Thread.Sleep(50);
                    }
                }
            }
        }
    }
}
