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

namespace MyGoods.Forms
{
    /// <summary>
    /// Interaction logic for frmManufacturres.xaml
    /// </summary>
    public partial class frmManufacturres : Window
    {
        public frmManufacturres()
        {
            InitializeComponent();
        }
        private void DataView_CustomCellAppearance(object sender, DevExpress.Xpf.Grid.CustomCellAppearanceEventArgs e)
        {
            if (e.RowSelectionState != DevExpress.Xpf.Grid.SelectionState.None)
            {
                e.Result = e.ConditionalValue;
                e.Handled = true;
            }
        }
    }
}
