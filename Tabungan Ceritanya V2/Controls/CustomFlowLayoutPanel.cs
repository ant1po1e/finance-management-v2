using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Tabungan_Ceritanya_V2.Controls
{
    public partial class CustomFlowLayoutPanel: FlowLayoutPanel
    {
        [DllImport("user32.dll")]
        private static extern int ShowScrollBar(nint hWnd, int wBar, bool bShow);

        private const int SB_HORZ = 0;
        private const int SB_VERT = 1;

        public CustomFlowLayoutPanel()
        {
            AutoScroll = true;
            DoubleBuffered = true;
            Resize += (s, e) => RefreshScrollBars();
            ControlAdded += (s, e) => RefreshScrollBars();
            ControlRemoved += (s, e) => RefreshScrollBars();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            RefreshScrollBars();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x85 || m.Msg == 0x14 || m.Msg == 0x0015 || m.Msg == 0x020A)
            {
                RefreshScrollBars();
            }
        }

        private void RefreshScrollBars()
        {
            if (IsHandleCreated)
            {
                ShowScrollBar(Handle, SB_HORZ, false);
                ShowScrollBar(Handle, SB_VERT, false);
            }
        }
    }
}
