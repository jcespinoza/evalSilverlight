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
    public partial class OptionsPaneView : UserControl
    {
        public OptionsPaneView()
        {
            InitializeComponent();
            VisualStateManager.GoToState(this, "Collapsed", false);
        }

        private void OpenCloseButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Should expand the panel to the right", "Click works", MessageBoxButton.OK);
            if ( visualStateGroupOptionPanel.CurrentState != null && visualStateGroupOptionPanel.CurrentState.Name == "Collapsed")
            {
                VisualStateManager.GoToState(this, "Expanded", true);
            }
            else
            {
                VisualStateManager.GoToState(this, "Collapsed", true);
                var curr = visualStateGroupOptionPanel.CurrentState;
                MessageBox.Show(string.Format("{0}", curr));
            }
            
        }

        private void CollapsePanel(object sender, RoutedEventArgs e)
        {
            
            VisualStateManager.GoToState(this, "Collapsed", true);
        }
    }
}
