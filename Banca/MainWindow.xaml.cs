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

namespace Banca
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmb_Residenza.Items.Add("Foligno");
            cmb_Residenza.Items.Add("Perugia");
            cmb_Residenza.Items.Add("Bastia");
            cmb_Residenza.Items.Add("Terni");
            cmb_Residenza.Items.Add("Passignano");
            cmb_Residenza.Items.Add("Tuoro");
            cmb_Residenza.Items.Add("Città di Castello");
            cmb_Residenza.Items.Add("Gualdo Tadino");
            cmb_Residenza.Items.Add("Assisi");
            cmb_Residenza.Items.Add("Spoleto");
            cmb_Residenza.Items.Add("Orivieto");
            cmb_Residenza.Items.Add("Spello");
            cmb_Residenza.Items.Add("Norcia");
            cmb_Residenza.Items.Add("Narni");
            cmb_Residenza.Items.Add("Castiglione del Lago");
            cmb_Residenza.Items.Add("Bevagna");
            cmb_Residenza.Items.Add("Trevi");
            cmb_Residenza.Items.Add("Città della Pieve");
            cmb_Residenza.Items.Add("Montefalco");
            cmb_Residenza.Items.Add("Magione");
        }

        private void btn_Calcola_Click(object sender, RoutedEventArgs e)
        {
            DateTime Data = (DateTime)Data_Nascita.SelectedDate;
            string frase;
            string cognome = txt_Cognome.Text;
            string nome = txt_Nome.Text;
            if (Femmina.IsChecked == true)
            {
                frase = $"{txt_Cognome.Text}{txt_Nome.Text} Residente in {cmb_Residenza.SelectedItem} nata il {Data.ToShortDateString()} ";
            }
            else
            {
                frase = $"{txt_Cognome.Text}{txt_Nome.Text} Residente in {cmb_Residenza.SelectedItem} nato il {Data.ToShortDateString()} ";
            }
        }
    }
}
