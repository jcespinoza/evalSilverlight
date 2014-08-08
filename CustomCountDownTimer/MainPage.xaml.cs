using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using SilverlightContrib.Controls;


namespace CustomCountDownTimer
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            App.Current.Host.Content.ZoomFactor = 2;
        }

        private void pausePlayIndicator(object sender, RoutedEventArgs e)
        {
            if (timerPanelChild.timerStoryBoard.GetCurrentState() == ClockState.Stopped)
            {
                timerPanelChild.timerStoryBoard.Begin();
                timerPanelChild.ResumeTimer();
                VisualStateManager.GoToState(this.playButton, "PauseState", true);
            }
            else
            {
                if (timerPanelChild.isRunning)
                {
                    timerPanelChild.PauseTimer();
                    VisualStateManager.GoToState(this.playButton, "PlayState", true);
                }
                else
                {
                    timerPanelChild.ResumeTimer();
                    VisualStateManager.GoToState(this.playButton, "PauseState", true);
                }
            }
        }

        private void stopTimer(object sender, RoutedEventArgs e)
        {
            timerPanelChild.timerStoryBoard.Stop();
            timerPanelChild.isRunning = false;
            VisualStateManager.GoToState(this.playButton, "PlayState", true);
        }
        
        private void CollapsePanel(object sender, RoutedEventArgs e)
        {
           
        }

        private void downBackColorPicker(object sender, MouseEventArgs mouseEventArgs)
        {
            SolidColorBrush sb = new SolidColorBrush(((ColorPicker) sender).SelectedColor);
            timerPanelChild.numberRoundShape.Fill = sb;
            timerPanelChild.roundPlaque.Fill = sb;
            timerPanelChild.roundPlaque_Copy5.Fill = sb;
        }

        private void downForeColorPicker(object sender, MouseButtonEventArgs e)
        {
            SolidColorBrush sb = new SolidColorBrush(((ColorPicker)sender).SelectedColor);
            timerPanelChild.roundIndicator.Fill = sb;
        }

        private void openPanel(object sender, MouseEventArgs e)
        {
            VisualStateManager.GoToState(this, "exapanded", true);
            VisualStateManager.GoToState(this.arrowButton, "PointingLeft", true);
        }

        private void closePanel(object sender, MouseEventArgs e)
        {
            VisualStateManager.GoToState(this, "collapsed", true);
            VisualStateManager.GoToState(this.arrowButton, "PointingRight", true);
        }
    }
}
