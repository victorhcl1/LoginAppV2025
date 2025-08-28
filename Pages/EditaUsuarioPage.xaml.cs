using System;
using System.Threading.Tasks;
using LoginAppV2025.Model;
using Microsoft.Maui.Controls;

namespace LoginAppV2025.Pages
{
    public partial class EditaUsuarioPage : ContentPage
    {
        Usuario _usuario;
        public EditaUsuarioPage()
        {
            _usuario = new Usuario();

            this.BindingContext = _usuario;
            InitializeComponent();

        }

        private void btnToggleSenha_Clicked(object sender, EventArgs e)
        {
            txtSenha.IsPassword = !txtSenha.IsPassword;
            btnToggleSenha.Source = txtSenha.IsPassword ? "hidden.png" : "visible.png";
        }

        private async void RegistreSeLabel_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginUsuarioPage());
        }

        private async void btnEntrar_Clicked_1(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(senha))
            {
                DisplayAlert("Erro", "Preencha todos os campos.", "OK");
                return;
            }

            var cadastro = await App.BancoDados.UsuarioDataTable.SalvarUsuario(_usuario);

            if (cadastro > 0)
            {
                DisplayAlert("Sucesso", "Cadastro realizado!", "OK");
                await Navigation.PopAsync();
            }
        }
    }
}