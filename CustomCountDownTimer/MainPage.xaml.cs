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
                VisualStateManager.GoToState(this.playButton, "PauseState", true);
                return;
            }

            if (timerPanelChild.isRunning)
            {
                timerPanelChild.PauseTimer();
                VisualStateManager.GoToState(this.playButton, "PauseState", true);
            }
            else
            {
                timerPanelChild.ResumeTimer();
                VisualStateManager.GoToState(this.playButton, "PlayState", true);
                
            }
        }

        private void stopTimer(object sender, RoutedEventArgs e)
        {
            timerPanelChild.timerStoryBoard.Stop();
            VisualStateManager.GoToState(this.playButton, "PlayState", true);
        }

        private void TBox_OnLostFocus(object sender, RoutedEventArgs e)
        {
            
        }

        private void OpenCloseButtonClick(object sender, RoutedEventArgs e)
        {
          //  VisualStateManager.GoToState(this, "exapanded", true);
            if (VisualStateGroup2.CurrentState != null && VisualStateGroup2.CurrentState.Name == "collapsed")
            {
                VisualStateManager.GoToState(this, "exapanded", true);
                VisualStateManager.GoToState(this.arrowButton, "PointingLeft", true);
            }
            else
            {
                VisualStateManager.GoToState(this, "collapsed", true);
                VisualStateManager.GoToState(this.arrowButton, "PointingRight", true);
            }
        }

        private void CollapsePanel(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
