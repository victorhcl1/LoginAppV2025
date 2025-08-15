using LoginAppV2025.Data;
using LoginAppV2025.Model;
using LoginAppV2025.Pages;

namespace LoginAppV2025
{
    public partial class App : Application
    {
        static SQLiteData _bancoDados;

        public static SQLiteData BancoDados
        {
            get
            {
                if (_bancoDados == null)
                {
                    _bancoDados = new SQLiteData(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Dados.db3"));
                }
                return _bancoDados;
            }
        }
        public static Usuario Usuario { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginUsuarioPage());
        }
    }

}