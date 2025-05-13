using CommunityToolkit.Maui.Alerts;

using RFC;

namespace RFCalc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnCalc_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbApeM.Text) || 
                string.IsNullOrWhiteSpace(tbApeP.Text) || 
                string.IsNullOrWhiteSpace(tbNom.Text)) 
            {
                await Toast.Make("Ingrese los datos correspondientes").Show();

                return;
            }

            tbRFC.Text = new GetRFC().RFCPersonaFisica
            (
                tbApeP?.Text ?? string.Empty,
                tbApeM?.Text ?? string.Empty,
                tbNom?.Text ?? string.Empty,
                dtFecha?.Date.ToString("yy/MM/dd") ?? DateTime.UnixEpoch.ToString("yy/MM/dd")
            );
        }

        private async void btnCopy_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbRFC.Text)) 
            {
                await Toast.Make("Primero genere un RFC").Show();

                return;
            }

            await Clipboard.Default.SetTextAsync(tbRFC.Text);
            await Toast.Make("El RFC está en el portapapeles").Show();
        }

        private void btnClear_Clicked(object sender, EventArgs e)
        {
            tbApeM.Text = string.Empty;
            tbApeP.Text = string.Empty;
            tbNom.Text = string.Empty;
            tbRFC.Text = string.Empty;
        }
    }
}
