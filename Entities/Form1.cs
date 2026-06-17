using AYUSH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
    public partial class Form1 : Form
    {
        private static INTERNAL AYUSH = new INTERNAL();

        string AimbotScan = "FF FF FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 ?? ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 00 00 00 00 A5 43";

        string headoffset = "B8";
        string chestoffset = "B4";

        // Already applied addresses
        private HashSet<long> appliedAddresses = new HashSet<long>();
        public Form1()
        {
            InitializeComponent();
        }
        private async Task<bool> RunAimbotScan()
        {
            try
            {
                long readOffset = Convert.ToInt64(headoffset, 16);
                long writeOffset = Convert.ToInt64(chestoffset, 16);

                Process proc = Process.GetProcessesByName("HD-Player").FirstOrDefault();
                if (proc == null) return false;

                AYUSH.OpenProcess(proc.Id);

                var results = (await AYUSH.AoBScan(AimbotScan, writable: true, executable: false)).ToList();
                if (results.Count == 0) return false;

                foreach (long baseAddr in results)
                {
                    long addrHead = baseAddr + writeOffset;
                    long addrChest = baseAddr + readOffset;

                    if (appliedAddresses.Contains(addrHead))
                        continue;

                    int headVal = AYUSH.ReadInt(addrHead);
                    int chestVal = AYUSH.ReadInt(addrChest);

                    // swap
                    AYUSH.WriteMemory(addrChest.ToString("X"), "int", headVal.ToString());
                    AYUSH.WriteMemory(addrHead.ToString("X"), "int", chestVal.ToString());

                    appliedAddresses.Add(addrHead);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
        private async void ON_Click(object sender, EventArgs e)
        {
            sta.Text = "Waiting...";

            bool success = await RunAimbotScan();

            if (success)
                sta.Text = "Injected...";
            else
                sta.Text = "Failed";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
