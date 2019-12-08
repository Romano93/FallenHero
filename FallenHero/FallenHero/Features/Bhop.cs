using FallenHero.Manager;
using FallenHero.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallenHero.Features
{
    internal class Bhop
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        public static void Run()
        {            
            while (true)
            {
                Thread.Sleep(5);
                
                if (!Settings.Instance.miscHop)
                    continue;
                
                if (Structs.LocalPlayer.m_fFlags == 257 && GetAsyncKeyState(Keys.Space) == -32768)
                {
                    Memory.WriteMemory<int>(Structs.Base.ClientPointer + signatures.dwForceJump, 1);
                    Thread.Sleep(20);
                    Memory.WriteMemory<int>(Structs.Base.ClientPointer + signatures.dwForceJump, 0);
                }
            }
        }
    }
}
