using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace MyFirstWPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        private string boundText;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string BoundText
        {
            get { return boundText; }
            set 
            { 
                boundText = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void buttonSet_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "Set from code";
        }

        private void buttonClick_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Hello buddy", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            MessageBoxResult result = MessageBox.Show("Hello buddy", "Will you marry me!", MessageBoxButton.YesNo, MessageBoxImage.Error);
            if (result == MessageBoxResult.Yes) {
                textBlockInfo.Text = "Agreed";
            }
            else{
                textBlockInfo.Text = "Not agreed";
            }
        }
    }
}