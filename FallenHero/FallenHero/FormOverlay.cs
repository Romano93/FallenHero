using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace FallenHero
{
    public partial class FormOverlay : Form
    {

        public const string WINDOW_NAME = "Counter-Strike: Global Offensive";

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        private static extern int SetWindowLong32(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
        private static extern IntPtr SetWindowLongPtr64(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        public struct RECT
        {
            public int left, top, right, bottom;
        }

        IntPtr handel = FindWindow(null, WINDOW_NAME);

        System.Timers.Timer timer;

        public FormOverlay()
        {
            InitializeComponent();
            timer = new System.Timers.Timer(1000);
            timer.Enabled = true;
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            timer.Start();
        }

        private void FormOverlay_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LawnGreen;
            this.TransparencyKey = Color.LawnGreen;
            this.TopMost = true;
            // this.FormBorderStyle = FormBorderStyle.None;

            // if it flickers:
            // this.DoubleBuffered = true;

            RECT rect;
            int initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong32(this.Handle, -20, initialStyle | 0x800000 | 0x20);

            // keep the form over the game
            GetWindowRect(handel, out rect);
            this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);
            this.Top = rect.top;
            this.Left = rect.left;

        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            RECT rect;
            try
            {

                int initialStyle = GetWindowLong(this.Handle, -20);
                SetWindowLong32(this.Handle, -20, initialStyle | 0x800000 | 0x20);

                // keep the form over the game
                GetWindowRect(handel, out rect);
                this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);
                this.Top = rect.top;
                this.Left = rect.left;
            }
            catch (Exception)
            {

            }
        }

        private void FormOverlay_Paint(object sender, PaintEventArgs e)
        {

            ///// Paint example //////
            /*
            Console.WriteLine("paint");
            g = e.Graphics;
            g.DrawRectangle(pen, 100, 100, 200, 200);
            */
        }

    }
}
