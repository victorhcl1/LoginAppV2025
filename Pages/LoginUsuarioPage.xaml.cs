namespace LoginAppV2025.Pages;

public partial class LoginUsuarioPage : ContentPage
{
    
    public LoginUsuarioPage()
	{
		InitializeComponent();
	}

    private async void btnEntrar_Clicked(object sender, EventArgs e)
    {
        string email = txtEmail.Text;
        string senha = txtSenha.Text;
        if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(senha))
        {
            var usuario = await App.BancoDados.UsuarioDataTable.ObtemUsuario(email, senha);

            if (usuario != null)
            {
                await DisplayAlert("Sucesso", "Login efetuado com sucesso", "OK");
                //Application.Current.MainPage = new AppShell();
                await Navigation.PushAsync(new HomePage());
                App.Usuario = usuario;
            }
            else
            {
                await DisplayAlert("Erro", "Usuário ou senha inválidos", "OK");
                return;
            }
        }
        else
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                await DisplayAlert("Erro", "Preencha o campo de e-mail", "OK");
            }
            else if (string.IsNullOrWhiteSpace(senha))
            {
               await DisplayAlert("Erro", "Preencha o campo de senha", "OK");
            }
        }
    }

    private async void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EditaUsuarioPage());
    }

    private async void btnEsqueci_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EsqueciSenha());
    }

    private void btnToggleSenha_Clicked(object sender, EventArgs e)
    {
        txtSenha.IsPassword = !txtSenha.IsPassword;

        // Atualiza o ícone do botão conforme estado
        if (txtSenha.IsPassword)
            btnToggleSenha.Source = "hidden.png";  // olho fechado
        else
            btnToggleSenha.Source = "eye.png";      // olho aberto
    }
}