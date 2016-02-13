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


namespace SmartVision
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Read file";
        }

        private void setOpen(object sender, RoutedEventArgs e)
        {
            List<Person> list = new List<Person>();
            Microsoft.Win32.OpenFileDialog opd = new Microsoft.Win32.OpenFileDialog();
            opd.DefaultExt=".CSV";
            opd.Filter = "CSV file (*.csv)|*.CSV|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            Nullable<bool> result = opd.ShowDialog();
            if(result==true)
            {
                StreamReader fileReader = new StreamReader(opd.FileName, false);
                while (fileReader.Peek() != -1)
                {
                    string fileRow = fileReader.ReadLine();
                    string[] data= fileRow.Split(',');
                    Person person = new Person(data[0].Trim('\"'), data[1].Trim('\"'), data[2].Trim('\"'), Int32.Parse(data[3].Trim('\"')));
                    Console.Write(person.ToString());
                    list.Add(person);
                }
                dataGrid.ItemsSource = list;

            }           
        }
    }
}
