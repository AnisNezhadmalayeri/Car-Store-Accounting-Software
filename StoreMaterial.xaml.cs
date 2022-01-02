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
using CarsStore.DA;

namespace CarsStore
{
    /// <summary>
    /// Interaction logic for StoreMaterial.xaml
    /// </summary>
    public partial class StoreMaterial : Page
    {
        public StoreMaterial()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (name1.Text != "" && model.Text != "" && color.Text != "" && price.Text != "")
            {
                GoodsDA.StoreMaterials(name1.Text, color.Text, model.Text, Convert.ToInt64(price.Text));
                if (name1_Copy.Text != "" && model_Copy.Text != "" && color_Copy.Text != "" && price_Copy.Text != "")
                {
                    GoodsDA.StoreMaterials(name1_Copy.Text, color_Copy.Text, model_Copy.Text, Convert.ToInt64(price_Copy.Text));

                    if (name1_Copy1.Text != "" && color_Copy1.Text != "" && model_Copy1.Text != "" && price_Copy1.Text != "")
                    {
                        GoodsDA.StoreMaterials(name1_Copy1.Text, color_Copy1.Text, model_Copy1.Text, Convert.ToInt64(price_Copy1.Text));

                        if (name1_Copy2.Text != "" && color_Copy2.Text != "" && model_Copy2.Text != "" && price_Copy2.Text != "")
                        {
                            GoodsDA.StoreMaterials(name1_Copy2.Text, color_Copy2.Text, model_Copy2.Text, Convert.ToInt64(price_Copy2.Text));

                            if (name1_Copy3.Text != "" && color_Copy3.Text != "" && model_Copy3.Text != "" && price_Copy3.Text != "")
                            {
                                GoodsDA.StoreMaterials(name1_Copy3.Text, color_Copy3.Text, model_Copy3.Text, Convert.ToInt64(price_Copy3.Text));
                            }
                        }
                    }
                }
            }

        }
    }
}
