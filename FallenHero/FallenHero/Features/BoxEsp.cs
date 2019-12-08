using FallenHero.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FallenHero.Features
{
    internal class BoxEsp
    {
        

        public static FormOverlay overlay;

        public static void Run()
        {
            if(overlay == null)
            {
                overlay = new FormOverlay();
            }
            bool overlayIsActive = false;

            Graphics g;
            Pen pen = new Pen(Color.Red);


            while (true)
            {

                Thread.Sleep(5);
                
                if (overlay == null)
                    continue;

                if (!Settings.Instance.boxEsp)
                {
                    overlayIsActive = false;
                    // overlay.Hide();
                    continue;
                }
                if(!overlayIsActive)
                {
                    overlayIsActive = true;
                    // overlay.Show();
                }

                // overlay.Refresh();

                //overlay.Show();

                       

                // draw entitys

                

            }
        }
    }
}
