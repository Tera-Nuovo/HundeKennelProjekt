using HundKenneProjekt;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
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

namespace HundekennelWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DogListManager DLMan = new DogListManager();
        DogListDisplayer DLDisplayer = new DogListDisplayer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            DLMan.RequestRemoveSort(SearchSpecifier.GetSearchSpecifier(HD_IndexInputMax.Text,HD_IndexInputMin.Text,DogGender.Text));

            DogsDisplay.ItemsSource = DLMan.CurentDogList;
        }

        private void Gender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
