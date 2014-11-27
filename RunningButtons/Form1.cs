using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace RunningButtons
{
    // делегат для манипулирования объектами из разных потоков
    public delegate void CrossPotoker (Button btn);
    
    public partial class MainForm : Form
    {
        Thread t1; // три потока для движения кнопок
        Thread t2;
        Thread t3;
        /// <summary>
        /// закрытая классовая переменная типа string. для отслеживания текущего
        /// состояния потоков. возможные значения: "отсутствуют", "приостановлены", "запущены"
        /// </summary>
        private string threadsStatus = "отсутствуют"; // состояние потоков

        static Random random;

        CrossPotoker crossPotoker;

        int[] koords;

        SoundPlayer motorSound;
        SoundPlayer backMusic;

        public MainForm()
        {
            InitializeComponent();
            backMusic = new SoundPlayer(Properties.Resources.Kalimba);
            backMusic.Play();
            crossPotoker = new CrossPotoker(Motion);
            random = new Random();
            koords = new int[3];
            motorSound = new SoundPlayer(Properties.Resources._94_Truck_snd_run03);
        }


        void Movement1()
        {
            while (true)
            {
                Thread.Sleep(random.Next(5,40));
                Invoke(crossPotoker, first_btn);
                koords[0] = first_btn.Location.X + 75;
                if (koords[0] == koords.Max())
                {
                    first_btn.BackColor = System.Drawing.Color.Gold;
                }
                else
                    first_btn.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        void Movement2()
        {
            while (true)
            {
                Thread.Sleep(random.Next(5, 40));
                Invoke(crossPotoker, second_btn);
                koords[1] = second_btn.Location.X + 75;
                if (koords[1] == koords.Max())
                {
                    second_btn.BackColor = System.Drawing.Color.Gold;
                }
                else
                    second_btn.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        void Movement3()
        {
            while (true)
            {
                Thread.Sleep(random.Next(5, 40));
                Invoke(crossPotoker, third_btn);
                koords[2] = third_btn.Location.X + 75;
                if (koords[2] == koords.Max())
                {
                    third_btn.BackColor = System.Drawing.Color.Gold;
                }
                else
                    third_btn.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        void Motion(Button button)
        {
            const int finishX = 619 - 75;
            int delta = random.Next(3);

            button.Location = 
                new Point(button.Location.X + delta, button.Location.Y);

            if (button.Location.X >= finishX)
            {
                pause_btn_Click(new object(), new EventArgs());
                MessageBox.Show("Победила кнопка под номером " + GetWinnersNumber() + ".", "Финиш!!!");
            }
        }

        private int GetWinnersNumber()
        {
            int winner = 0;
            for (int i = 0; i < 3; i++)
                if (koords[i] == koords.Max())
                    winner = i + 1;
            return winner;
        }

        /// <summary>
        /// Метод - обработчик щелчка по кнопке Start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_button_Click(object sender, EventArgs e)
        {
            motorSound.Play();
            
            if (threadsStatus == "отсутствуют")
                CreateAndRunThreads();
            if (threadsStatus == "приостановлены")
            {
                t1.Resume(); t2.Resume(); t3.Resume();
                threadsStatus = "запущены";
            }
        }

        private void CreateAndRunThreads()
        {
            t1 = new Thread(Movement1);
            t2 = new Thread(Movement2);
            t3 = new Thread(Movement3);
            t1.IsBackground = t2.IsBackground = t3.IsBackground = true; // потоки установили как фоновые.
            t1.Start(); t2.Start(); t3.Start();
            threadsStatus = "запущены";
        }

        /// <summary>
        /// Метод - обработчик события щелчок по кнопке Pause
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pause_btn_Click(object sender, EventArgs e)
        {
            motorSound.Stop();
            backMusic.Play();
            if (threadsStatus == "запущены")
            {
                t1.Suspend(); t2.Suspend(); t3.Suspend();
                threadsStatus = "приостановлены";
            }
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            pause_btn_Click(sender, e);
            Reset();
        }

        private void Reset()
        {
            first_btn.Location = new Point(12, first_btn.Location.Y);
            second_btn.Location = new Point(12, second_btn.Location.Y);
            third_btn.Location = new Point(12, third_btn.Location.Y);
            first_btn.BackColor = System.Drawing.SystemColors.Control;
            second_btn.BackColor = System.Drawing.SystemColors.Control;
            third_btn.BackColor = System.Drawing.SystemColors.Control;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop_btn_Click(sender, new EventArgs());
        }

        
    }
}
