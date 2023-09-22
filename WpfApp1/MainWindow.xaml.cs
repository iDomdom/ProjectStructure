using PostgreDB;
using System.Windows;

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
            PgContext context = new PgContext("Host=185.217.199.23;Port=5432;Username=user;Password=123;Database=autosmeta");
            MessageBox.Show("KHUY");
        }
    }
}
