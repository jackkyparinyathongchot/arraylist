using System.Collections;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ArrayListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        ArrayList arrayList;

        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();  
            hashtable = new Hashtable();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            arrayList.Add(txtUser.Text);
            MessageBox.Show("add "+txtUser.Text+" success");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            arrayList.Remove(txtUser.Text);
            MessageBox.Show("remove "+txtUser.Text+" success");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string dataName = string.Empty;
            foreach (string data in arrayList)
            {
                dataName = data.ToString();
            }
            MessageBox.Show("data in arraylist is  "+dataName);

        }
    }
}