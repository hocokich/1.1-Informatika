using System;
using System.Collections.Generic;
using System.IO;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace inf4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string str = "";
        string path = @"C:\Users\1\Desktop\somewords.txt";

        private byte crypt2(byte a, byte b)
        {
            byte s = a;
            byte k = b;
            byte r = (byte)(s ^ k);
            return r;
        }
        private byte decrypt2(byte a, byte b)
        {
            byte s = a;
            byte k = b;
            byte r = (byte)(s ^ k);
            return r;
        }

        void Somefunction()
        {
            //создаём массив строк и записываем в него текст из файла

            EntryText.Text = "";


            String[] lines = System.IO.File.ReadAllLines(@"C:\Users\1\Desktop\somewords.txt");

            //этот цикл делает так ,чтобы каждая строка в тексте тоже записывалась с новой строки
            foreach (string line in lines)
            {
                //записываем текст в пустую строку
                str += line;

                if (line.Contains(""))
                {
                    str += ("\n");
                }

                EntryText.Text = str;
            }
            str = "";
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream file = new FileStream(path, FileMode.OpenOrCreate))
            using (StreamWriter sw = new StreamWriter(file))
                sw.WriteLine(str);
        }

        private void Encrypt_Click(object sender, RoutedEventArgs e)
        {
            string str2 = "";
            str2 = EntryText.Text;
            using (FileStream file = new FileStream(path, FileMode.OpenOrCreate))
            {

                byte[] array = System.Text.Encoding.UTF8.GetBytes(str);

                int k = int.Parse(Key.Text);
                byte[] arr = new byte[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    arr[i] = decrypt2(array[i], (byte)k);

                }

                string textFromFile = System.Text.Encoding.UTF8.GetString(arr);

                str = textFromFile;

                EntryText.Text = str;
            }
        }

        private void Crypt_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream file = new FileStream(path, FileMode.OpenOrCreate))
            {
                string str2 = "";
                str2 = EntryText.Text;

                //создаем 2 массива байт с длиной равной длине файла 
                byte[] array = new byte[file.Length];
                byte[] arr = new byte[array.Length];

                int k = int.Parse(Key.Text);

                file.Read(array, 0, array.Length);

                for (int i = 0; i < array.Length; i++)
                {
                    arr[i] = crypt2(array[i], (byte)k);
                }

                string textFromFile = System.Text.Encoding.UTF8.GetString(arr);

                str += textFromFile;
                str = str.Remove(0, str2.Length);
            }
            EntryText.Text = str;
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            Somefunction();
        }

        private void EntryText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Key_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
