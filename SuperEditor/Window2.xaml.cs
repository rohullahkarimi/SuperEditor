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

namespace SuperEditor
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            // Accept the dialog and return the dialog result
            this.DialogResult = true;
            Close();

        }

        // CLEAR
        private void clear_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.Strokes.Clear();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {

        }
        //UNDO
        private void undo_Click(object sender, RoutedEventArgs e)
        {
            if (inkCanvas1.Strokes.Count > 0)
            {
                inkCanvas1.Strokes.RemoveAt(inkCanvas1.Strokes.Count - 1);
            }

        }
    }
}
