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

using System.IO;

namespace NotePaadi1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string fileNameWithFullPath;

        
        public MainWindow()
        {
            InitializeComponent();
            fileNameWithFullPath = "";
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("Exit");
            Close();
        }

        Stream myStream;

        public TextBox ActiveControl { get; private set; }

        // Open
        private void MenuOpen_Click(object sender, RoutedEventArgs e)
        {
           
            //MessageBox.Show("Open");
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt";

            if (ofd.ShowDialog() == true)
            {
                fileNameWithFullPath = ofd.FileName.ToString();
                string textOfOurFile = File.ReadAllText(fileNameWithFullPath);
                textBox1.Text = textOfOurFile;
            }
            // Microsoft.Win32.
            // print function can found in moodle uuden ikkuna avaaminen ja tulostaminen 
        }

        // About
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                GetType().Assembly.GetName().Version.ToString()
                );
        }

        // SAVE
        private void MenuSave_Click(object sender, RoutedEventArgs e)
        {
            string newContentOfOurFile = textBox1.Text;
            using(StreamWriter sw = new StreamWriter(fileNameWithFullPath))
            {
                sw.Write(newContentOfOurFile);
            }
            //MessageBox.Show("It WORKS");
            //throw new NotImplementedException();
        }

        // EXIT 
        private void menuExit_Click(object sender, RoutedEventArgs e)
        {
           // Application.Exit();
            //  MessageBox.Show(ofd.FileName);
        }

        // FONT FORMAT
        private void font_Click(object sender, RoutedEventArgs e)
        {
            Window1 mywindow = new Window1();
            mywindow.ShowDialog();

            //textBox1.Text = mywindow.NewWindowTextBox.Text;
            textBox1.FontSize = Convert.ToInt32(mywindow.NewWindowTextBox.Text);// mywindow.NewWindowTextBox.Text;



        }

        // COPY 
        private void copy_Click(object sender, RoutedEventArgs e)
        {
            TextBox txtBox = this.ActiveControl as TextBox;
            if (textBox1.SelectedText != string.Empty)
                Clipboard.SetData(DataFormats.Text, textBox1.SelectedText);
        }

        // PASTE
        private void paste_Click(object sender, RoutedEventArgs e)
        {
            int position = ((TextBox)textBox1).SelectionStart;
            textBox1.Text = textBox1.Text.Insert(position, Clipboard.GetText());
        }

        // PRINT
        private void Print_Click(object sender, RoutedEventArgs e)
        {
            // Create the print dialog object and set options
            PrintDialog dlg = new PrintDialog();
            dlg.ShowDialog();

        }
    }
}
