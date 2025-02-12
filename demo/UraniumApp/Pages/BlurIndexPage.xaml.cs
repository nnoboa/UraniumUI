using UraniumApp.Pages.Blurs;

namespace UraniumApp.Pages;

public partial class BlurIndexPage : ContentPage
{
	public BlurIndexPage()
	{
		InitializeComponent();
	}

    private void GoToPreviewPage(object sender, EventArgs e)
    {
		this.Navigation.PushAsync(new BlursPreviewPage());
    }
}