using Repository;
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
using System.Windows.Shapes;

namespace TranNhatHoangWPS
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private StaffRepository staffRepository;
        public AdminWindow()
        {
            InitializeComponent();
            LoadProductList();
        }

        private void LoadProductList()
        {
            staffRepository = new StaffRepository();
            StaffDataGrid.ItemsSource = staffRepository.GetAll();
        }

        private void StaffDataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }

    }
}
