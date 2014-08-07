using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace CustomCountDownTimer
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TimerPanel_Loaded(object sender, RoutedEventArgs e)
        {
            timerPanelChild.StartTimer();
        }

        private void pausePlayIndicator(object sender, RoutedEventArgs e)
        {
            if (timerPanelChild.timerStoryBoard.GetCurrentState() == ClockState.Stopped)
            {
                timerPanelChild.timerStoryBoard.Begin();
                timerPanelChild.isRunning = true;
                return;
            }

            if(timerPanelChild.isRunning)
                timerPanelChild.PauseTimer();
            else
                timerPanelChild.ResumeTimer();
        }

        private void stopTimer(object sender, RoutedEventArgs e)
        {
            timerPanelChild.timerStoryBoard.Stop();
        }

        private void TBox_OnLostFocus(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
