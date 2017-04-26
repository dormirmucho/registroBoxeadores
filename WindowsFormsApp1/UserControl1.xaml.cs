using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace WindowsFormsApp1
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : Window
    {
        public UserControl1()
        {
            InitializeComponent();
            MostrarGrid();
        }

        private void MostrarGrid()
        {
            string datoConexion = "Server=localhost;Database=combates;User ID=root;Password=agustito;Pooling=false;";
            MySqlConnection cliente = new MySqlConnection(datoConexion);
            cliente.Open();
            string consulta = "SELECT id_box,id_combats,id_victories,id_ko,best_assault,best_time,id_box_rival FROM clasificacion;";
            MySqlCommand comando = new MySqlCommand(consulta, cliente);

            MySqlDataAdapter msda = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable("clasificacion");
            msda.Fill(dt);
            datos.ItemsSource = dt.DefaultView;
            Login l = new Login();
            l.
        }
    }
}
