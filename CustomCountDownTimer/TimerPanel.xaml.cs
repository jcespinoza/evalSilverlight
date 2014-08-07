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

    /*public class DurationConverter: IValueConverter
    {
        //public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    string text = value as string;
        //    var numbers = text.Split(':');
            
        //    int minutes= numbers[1];
        //    int seconds = numbers[2];
        //    return new Duration(new TimeSpan(hours, minutes, seconds));
        //}

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
        }
    }
     */

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
