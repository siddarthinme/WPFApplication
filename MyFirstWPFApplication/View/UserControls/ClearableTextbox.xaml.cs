using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace MyFirstWPFApplication.View.UserControls
{
    /// <summary>
    /// Interaction logic for ClearableTextbox.xaml
    /// </summary>
    public partial class ClearableTextbox : UserControl
    {
        public ClearableTextbox()
        {
            InitializeComponent();
        }


        private string placeHolder;

        public string PlaceHolder
        {
            get { return placeHolder; }
            set 
            { 
                placeHolder = value;

                //Do not do this
                //OnPropertyChanged()
                textBoxPlaceholder.Text = placeHolder;
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("placeHolder"));
            }
        }


        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            textBoxInput.Clear();
            textBoxInput.Focus();
        }

        private void textBoxInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBoxPlaceholder.Visibility = String.IsNullOrEmpty(textBoxInput.Text) ? Visibility.Visible : Visibility.Collapsed;   
        }
    }
}
