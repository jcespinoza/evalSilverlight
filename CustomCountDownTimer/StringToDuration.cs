using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace CustomCountDownTimer
{
    public class StringToDuration : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
            Duration d = new Duration(TimeSpan.Parse( (string)value ));
            return d;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Duration d = (Duration) value;
            //return string.Format("{0}:{1}:{2}", d.TimeSpan.Hours, d.TimeSpan.Minutes, d.TimeSpan.Seconds);
            return d.ToString();
        }
    }
}