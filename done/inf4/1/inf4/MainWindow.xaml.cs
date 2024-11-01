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

namespace inf4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string lengthofpass;
        public string endofpass;
        public string strtofpass;
        public string pass;

        public MainWindow()
        {
            InitializeComponent();
        }

        void Alphabet()
        {
            string hexstr = "";
            for (int j = 0; j < 89; j = j + 7)
            {
                for (int i = 33 + j; i < 41 + j; i++)
                {
                    long n = i;
                    hexstr += (char)i + " = 00" + n.ToString("X") + " ";
                }
                hexstr += "\n";
            }
            hexstr += (char)126 + " = 007D";
            Abc.Text += hexstr;
        }
        void SomeFunction(string StrStrt, string StrEnd, string StrLength)
        {
            pass = "";


            int NumStrt = int.Parse(StrStrt, System.Globalization.NumberStyles.HexNumber); // 33 до 125 
            int NumEnd = int.Parse(StrEnd, System.Globalization.NumberStyles.HexNumber); // 33 до 125 
            int NumLength = int.Parse(StrLength);


            Random rnd = new Random();

            for (int i = 0; i < NumLength; i++)
            {
                int sign = rnd.Next(NumStrt, NumEnd);
                
                pass += (char)sign;
            }

            Pass.Text = pass;
        }

        private void Gen_Click(object sender, RoutedEventArgs e)
        {
            Abc.Text = "";
            Alphabet();
            strtofpass = Start.Text;
            endofpass = End.Text;
            lengthofpass = Length.Text;
            SomeFunction(strtofpass, endofpass, lengthofpass);
        }

        private void Pass_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Abc_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Start_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void End_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Length_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
