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

namespace PRo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
 public MainWindow()
        {

            float[] E = new float[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            
            float[] D = new float[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            float F;
            InitializeComponent();
            for (int i = 1; i < 16; i++)

            {
                E[i] = i;

                D[i]=i;
                
                F =Convert.ToSingle((2 * D[i] + Math.Sin(E[i])) / D[i]);
                if (F > 1 && F < 3)
                {
                    FontsList.Items.Add(F.ToString());
                }
            }
        }

        private void FontsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
