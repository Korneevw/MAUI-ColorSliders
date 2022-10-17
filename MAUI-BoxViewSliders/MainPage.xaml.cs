namespace MAUI_BoxViewSliders;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		page.BackgroundColor = new Color((float)redSlider.Value, (float)greenSlider.Value, (float)blueSlider.Value);
    }
}

