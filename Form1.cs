using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Reminder
{
    public partial class Form1 : Form
    {
        private int timeOutMs = 11000;
        private Timer timer = new Timer();
        public Form1(StringBuilder sb)
        {
            InitializeComponent();
            timer.Interval = timeOutMs;
            timer.Tick += Timer_Tick;

            Application.Idle += Application_Idle;
            label1.Text = sb.ToString();
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "For your Reminder ";
            popup.TitleFont = new Font(FontFamily.GenericSerif,20);
            popup.Image = Properties.Resources.remind;
            popup.ContentText = sb.ToString();
            popup.ContentFont = new Font(FontFamily.GenericSerif, 13, FontStyle.Bold);
            popup.AnimationDuration = 4000;
            //popup.AnimationInterval = 3000;
            popup.BodyColor = Color.White;
            popup.TitleColor = Color.Red;
            popup.ContentColor = Color.Black;
            popup.Size = new Size(400, 400);
            popup.Delay = 10000;
            popup.Popup(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void Timer_Tick(object sender, EventArgs e)
        {
            Close();
        }

        void Application_Idle(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
            }
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}