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

namespace HelloWPF
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

        private void Button_Click(object sender, RoutedEventArgs e) // sender = 이벤트를 발생시킨 원인
        {
            if(sender == btn1)
            {
                MessageBox.Show("안녕하세요~ btn1 입니다");
            }
            else if(sender == btn2)
            {
                MessageBox.Show("안녕하세요! btn 2 입니다");
            }
        }
    }
}
