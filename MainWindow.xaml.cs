using System;
using System.Collections;
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

namespace arraylist
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }
        private void Add_click(object sender, RoutedEventArgs e)
        {
            //Add Data
            arrayList.Add(txtData.Text);
            txtData.Text = "";
        }
        private void Remove_click(object sender, RoutedEventArgs e)
        {
            //Remove Data
            arrayList.Remove(txtData.Text);
            txtData.Text = "";
        }

        private void Show_click(object sender, RoutedEventArgs e)
        {
            //Show Data
            foreach(string data in arrayList)
            {
                MessageBox.Show(data);
            }
        }
    }
}
