using System;
using System.Windows;
using System.Windows.Controls;
using System.IO;

namespace WpfApp1
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

        void Clear_Click(object sender, RoutedEventArgs e)
        {
            inkDraw.Strokes.Clear();
        }
        void Save_Click(object sender, RoutedEventArgs e)
        {
            FileStream outputfile = new FileStream(@"C:\Users\IDC\source\repos\inkstrokes.ink", FileMode.Create);
            inkDraw.Strokes.Save(outputfile);
            outputfile.Close();
        }
        void Load_Click(object sender, RoutedEventArgs e)
        {
            FileStream inputfile = new FileStream(@"C:\Users\IDC\source\repos\inkstrokes.ink", FileMode.Open);
            inkDraw.Strokes = new System.Windows.Ink.StrokeCollection(inputfile);
            inputfile.Close();
        }
    }
}
