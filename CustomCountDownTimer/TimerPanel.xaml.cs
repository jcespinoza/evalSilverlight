using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace CustomCountDownTimer
{
    public class Timer: UserControl
    {
        public static string Duration { get; set; }
        public string SomethingElse { get; set; }
        public Timer()
        {
            Duration = "0:2:0";
        }
    }

    public partial class TimerPanel : UserControl
    {
        public long TaskTime { get; set; }
        public bool isRunning { get; set; }
        
        public TimerPanel()
        {
            InitializeComponent();
        }

        public void StartTimer()
        {            
                timerStoryBoard.Begin();
        }

        public void PauseTimer()
        {
            timerStoryBoard.Pause();
            isRunning = false;
        }

        public void ResumeTimer()
        {
            timerStoryBoard.Resume();
            isRunning = true;
        }
    }
}
