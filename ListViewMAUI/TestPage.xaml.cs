using System.Threading.Tasks;

namespace ListViewMAUI;

public partial class TestPage : ContentPage
{
	public TestPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
    }

	private void Button_Clicked_1(object sender, EventArgs e)
	{
		GC.Collect();
		GC.WaitForPendingFinalizers();
		GC.Collect();
    }


}