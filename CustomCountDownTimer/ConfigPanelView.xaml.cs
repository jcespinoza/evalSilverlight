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
    public partial class OptionPanelView : UserControl
    {
        public OptionPanelView()
        {
            InitializeComponent();
            taskCreationOKButton.MouseEnter += bottonMouseEnter;
        }

        private void bottonMouseEnter(object sender, MouseEventArgs e)
        {
            VisualStateManager.GoToState(((Button)sender),"ButtonAcceptMouseOverState",true);
        }
    }
}
