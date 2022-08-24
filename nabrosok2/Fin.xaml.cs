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

namespace nabrosok2
{
    /// <summary>
    /// Логика взаимодействия для Fin.xaml
    /// </summary>
    public partial class Fin : Window
    {
        public Fin()
        {
            InitializeComponent();
                       
        }

        protected override void OnClosed(EventArgs e)
        {
            App.Current.Shutdown();
        }


        private void txtbl_quit_MouseEnter(object sender, MouseEventArgs e)
        {
            txtbl_quit.FontSize = 86;
        }

        private void txtbl_quit_MouseLeave(object sender, MouseEventArgs e)
        {
            txtbl_quit.FontSize = 72;
        }

        private void txtbl_quit_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {          
            App.Current.Shutdown();
        }
    }
}
