using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Drawing.Imaging;


namespace SerialPortTest
{
    public partial class Main : Form
    {
        private const String ss_filename_prefix = "ss_";
        private Thread thread;
        private String comboKey1Str, comboKey2Str;
        private int mousePosX, mousePosY;
        private String commandText;
        private int delayKey, delayScreenShot, delayPeriod;

        public Main()
        {
            InitializeComponent();
            thread = new Thread(new ThreadStart(threadLoop));
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            serialPort.PortName = "COM" + numPort.Value.ToString();
            if (serialPort.IsOpen)
            {
                MessageBox.Show("Serial port is already opened.\n");
                return;
            }
            try
            {
                serialPort.Open();
                MessageBox.Show("Connection is established.\n");
            }
            catch
            {
                MessageBox.Show("Serial port open error\n");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                MessageBox.Show("Connection is closed.\n");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine(textCommand.Text);
        }

        private void btnSetSSDir_Click(object sender, EventArgs e)
        {
            if (ssFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textSSDir.Text = ssFolderBrowserDialog.SelectedPath;
            }
        }

        private void threadLoop()
        {
            while (true)
            {
                // Craete file name.
                DateTime dt = DateTime.Now;
                String filename = ssFolderBrowserDialog.SelectedPath + "\\" +
                   ss_filename_prefix + "_" + dt.ToString("yyyyMMddHHmmss") + ".png";
                serialPort.WriteLine(commandText);
                Thread.Sleep(1000 * delayKey);
                pushKeyboard();
                mouseLeftClick();
                Thread.Sleep(1000 * delayScreenShot);
                saveScreenShot(filename);
                Thread.Sleep(1000 * delayPeriod);
            }
        }

        private void saveScreenShot(String path)
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), bmp.Size);
            g.Dispose();
            bmp.Save(path, ImageFormat.Png);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("Serial port is not opened.");
                return;
            }
            if (textSSDir.Text.Equals(""))
            {
                MessageBox.Show("Screen shot output directory is not selected.");
                return;
            }
            if (textCommand.Text.Equals(""))
            {
                MessageBox.Show("Command has to be inserted.");
                return;
            }
            if (comboKey1.SelectedItem.ToString().Equals("") ||
                comboKey2.SelectedItem.ToString().Equals(""))
            {
                MessageBox.Show("Key is not configured.");
                return;
            }

            timerCurrPos.Enabled = false;
            textCurrPosX.Text = "";
            textCurrPosY.Text = "";
            
            // Copy control parameter to private variables.
            comboKey1Str = comboKey1.SelectedItem.ToString();
            comboKey2Str = comboKey2.SelectedItem.ToString();
            mousePosX = (int)numMousePosX.Value;
            mousePosY = (int)numMousePosY.Value;
            commandText = textCommand.Text;
            delayKey = (int)numDelayKey.Value;
            delayScreenShot = (int)numDelayScreenShot.Value;
            delayPeriod = (int)numPeriod.Value;

            thread.Start();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            thread.Suspend();
            timerCurrPos.Enabled = true;
        }

        private bool pushKeyboard()
        {
            VirtualInput vi = new VirtualInput();
            String keystr = comboKey1Str + "+" + comboKey2Str;
            vi.push2Keys(keystr);
            return true;
        }

        private bool mouseLeftClick()
        {
            VirtualInput vi = new VirtualInput();
            vi.mouseLeftClick(mousePosX, mousePosY);
            return true;
        }

        private void timerCurrPos_Tick(object sender, EventArgs e)
        {
            textCurrPosX.Text = Cursor.Position.X.ToString();
            textCurrPosY.Text = Cursor.Position.Y.ToString();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (thread.ThreadState == ThreadState.Running)
            {
                thread.Abort();
                serialPort.Close();
            }
        }

    }
}
