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

namespace OptionalWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void simpanbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                informasi info = new informasi();
                info.NIMMahasiswa = txtbox1.Text;
                info.NamaMahasiswa = txtbox2.Text;
                info.ProgramStudiMahasiswa = txtbox3.Text;
                info.AsalMahasiswa = txtbox4.Text;
                info.AlamatTinggalKosMahasiswa = txtbox5.Text;
                SimpanXML.simpandata(info, "DataMahasiswa.xml");
                msg_label.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetbtn_Click(object sender, RoutedEventArgs e)
        {
            txtbox1.Text = "";
            txtbox2.Text = "";
            txtbox3.Text = "";
            txtbox4.Text = "";
            txtbox5.Text = "";
            msg_label.Visibility = Visibility.Hidden;
        }
    }
}
