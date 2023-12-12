using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace BeepSoundApp
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int frequency, int duration);

        [DllImport("user32.dll")]
      
        public static extern bool MessageBeep(uint uType);


        public Form1()
        {
            InitializeComponent();
        }

        private void btnBeep_Click(object sender, EventArgs e)
        {
            int frequency = 450; // Частота звука (в герцах)
            int duration = 1000;   // Продолжительность звука (в миллисекундах)

            for (int i = 0; i < 10; i++)
            {
                Beep(frequency, duration);
                Thread.Sleep(1000); // Пауза между звуками
            }
        }

        private void btnMessageBeep_Click(object sender, EventArgs e)
        {

           
                MessageBeep((uint)MessageBoxIcon.Asterisk);   // Звук "Asterisk"
                Thread.Sleep(1000); // Пауза 
           
        }
    }

    }
