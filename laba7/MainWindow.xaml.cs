using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace laba7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void colorChange_day()
        {
            //Background color (window) in day mode
            SolidColorBrush bg_win_day_color = (SolidColorBrush)(new BrushConverter().ConvertFrom("#c9c2c1"));
            //Background color (text) in day mode
            SolidColorBrush bg_text_day_color = (SolidColorBrush)(new BrushConverter().ConvertFrom("#383130"));
            //Applying
            this.Background = bg_win_day_color;
            some_text.Foreground = bg_text_day_color;
        }

        private void colorChange_night()
        {
            //Background color (window) in day mode
            SolidColorBrush bg_win_night_color = (SolidColorBrush)(new BrushConverter().ConvertFrom("#403d3d"));
            //Background color (text) in day mode
            SolidColorBrush bg_text_night_color = (SolidColorBrush)(new BrushConverter().ConvertFrom("#ebe4e4"));
            //Applying
            this.Background = bg_win_night_color;
            some_text.Foreground = bg_text_night_color;
        }

        private void day_mode_Click(object sender, RoutedEventArgs e)
        {
            colorChange_day();
        }
        private void night_mode_Click(object sender, RoutedEventArgs e)
        {
            colorChange_night();
        }
    }
}
