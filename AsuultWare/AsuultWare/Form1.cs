using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AsuultWare
{
    public partial class Form1 : Form
    {
        Mem m = new Mem();

        string carbin = "ac_client.exe+0x0018AC00,130";
        string shotgunammo = "ac_client.exe+0x0018AC00,134";
        string submachammo = "ac_client.exe+0x0018AC00,138";
        string Sniperammo = "ac_client.exe+0x0018AC00,13C";
        string ammoadressRifle = "ac_client.exe+0x0018AC00,140";
        string ammoadressPistol = "ac_client.exe+0x0018AC00,12C";
        string PlayerHealth = "ac_client.exe+0x00195404,EC";
        string grenade = "ac_client.exe+0x0018AC00,144";
        string Armour = "ac_client.exe+0x0017E0A8,F0";
        string DuelPistol = "ac_client.exe+0x0018AC00,148";

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(Keys vkey);


        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            this.TopMost = true;
            int PID = m.GetProcIdFromName("ac_client");
            if (PID > 0)
            {
                m.OpenProcess(PID);
                timer1.Start();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox4.Checked)
            {
                m.WriteMemory(ammoadressRifle, "int", "99");
                m.WriteMemory(ammoadressPistol, "int", "99");
                m.WriteMemory(Sniperammo, "int", "99");
                m.WriteMemory(submachammo, "int", "99");
                m.WriteMemory(shotgunammo, "int", "99");
                m.WriteMemory(carbin, "int", "99");
                m.WriteMemory(DuelPistol, "int", "99");
            }

            if (guna2CustomCheckBox1.Checked)
            {
                m.WriteMemory(PlayerHealth, "int", "1000");
            }

            if (guna2CustomCheckBox3.Checked)
            {
                m.WriteMemory(grenade, "int", "99");

            }

            if (guna2CustomCheckBox2.Checked)
            {
                m.WriteMemory(Armour, "int", "999");
            }
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            this.TopMost = true;
            int PID = m.GetProcIdFromName("ac_client");
            if (PID > 0)
            {
                m.OpenProcess(PID);
                timer1.Start();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

     

    }

}
