using HundekennelWPF;
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
using System.Windows.Shapes;

namespace HundekennelProjekt
{
    /// <summary>
    /// Interaction logic for DogProfileDisplayer.xaml
    /// </summary>
    public partial class DogProfileDisplayer : Window
    {
        DogListManager DLMan = new DogListManager();
        DogDBManager DogDB = new DogDBManager();
        AbstractDog selectedDog()
        {
            foreach (AbstractDog dog in DogDB.GetDogsFromDatabase())
            {
                if (SelectedDogsID1.Text == dog.ID)
                {
                    return dog;
                }
            }
            return null;
        }

        public DogProfileDisplayer()
        {
            InitializeComponent();
            DataContext = DLMan;
            this.ResizeMode = ResizeMode.NoResize;

        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(selectedDog != null)
            {
                DLMan.DogprofileDisplayer(selectedDog().Dad());
                DLMan.DogprofileDisplayer(selectedDog().Mom()); 
            }
            
        }
    }
}
