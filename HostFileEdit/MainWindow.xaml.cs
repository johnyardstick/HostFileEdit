using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HostFileEdit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {


            InitializeComponent();

            //string hostsFile = File.ReadAllText(@"C:\Windows\System32\drivers\etc\hosts");

            //TextBox.Text = hostsFile;

            Host myHost = new Host();
            Binding mybinding = new Binding("MyDataProperty");
            mybinding.Source = myHost;
            myText.SetBinding(TextBox.TextProperty, myBinding);

            SaveButton.Click += SaveButton_Click;



        }

        public class Host
        {
            public string hostsFile { get; set; }

            public Host()
            {
                this.hostsFile = File.ReadAllText(@"C:\Windows\System32\drivers\etc\hosts");
            }

            
        }


        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }

}