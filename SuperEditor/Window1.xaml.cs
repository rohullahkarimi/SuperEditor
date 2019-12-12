using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NotePaadi1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            //Label1.FontSize = new Font("Murtuza", 30);
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            // Accept the dialog and return the dialog result
            this.DialogResult = true;
            Close();

        }


        // label.Font = new Font("Murtuza", 10);
        private void cancel_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
/*
 * 
 *  MainWindow mywindow = new MainWindow();
            Window1 mywindow1 = new Window1();
            //mywindow.NewWindowTextBox.Text = textBox1.Text;
            mywindow.textBox1.Text = mywindow1.NewWindowTextBox.Text;
            if (mywindow.ShowDialog() == true)
            {
                mywindow.textBox1.Text = mywindow1.NewWindowTextBox.Text; // from main to new 
                //NewWindowTextBox.Text = mywindow.textBox1.Text;
            }
 * */
