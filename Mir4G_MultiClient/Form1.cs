using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Management;
namespace Mir4G_MultiClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void refresh_btn_Click(object sender, EventArgs e)
        {
            Process[] pMir4G = Process.GetProcessesByName("Mir4G");
            processView.Items.Clear();
            foreach (var p in pMir4G)
            {
                Console.WriteLine(p.Id + " " + p.MainWindowTitle);
                string[] pArguments = GetCommandLine(p.Id).Split('\"');
                ListViewItem pList = new ListViewItem(p.Id.ToString());
                pList.SubItems.Add(p.MainWindowTitle);
                pList.SubItems.Add(GetExecutablePath(p.Id));
                pList.SubItems.Add(pArguments[2]);
                processView.Items.Add(pList);
            }

        }

        private string GetExecutablePath(int processId)
        {
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT ExecutablePath FROM Win32_Process WHERE ProcessId = " + processId))
            using (ManagementObjectCollection objects = searcher.Get())
            {
                return objects.Cast<ManagementBaseObject>().SingleOrDefault()?["ExecutablePath"]?.ToString();
            }
        }
        private string GetCommandLine(int processId)
        {
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT CommandLine FROM Win32_Process WHERE ProcessId = " + processId))
            using (ManagementObjectCollection objects = searcher.Get())
            {
                return objects.Cast<ManagementBaseObject>().SingleOrDefault()?["CommandLine"]?.ToString();
            }
        }

        private void ปดToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void เรยกToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetForegroundWindow(Process.GetProcessById(int.Parse(processView.SelectedItems[0].Text)).MainWindowHandle);
        }

        private void menu_Opening(object sender, CancelEventArgs e)
        {
            if (processView.SelectedItems.Count > 0)
            {
                menu.Items[0].Enabled = true;
                menu.Items[1].Enabled = true;
            }
            else
            {
                menu.Items[0].Enabled = false;
                menu.Items[1].Enabled = false;
            }
        }
    }
}
