using Microsoft.Maui.Controls;

namespace zadanie27._10Badowski4c;

public partial class MainPage : ContentPage
{
	int[] zwierzeta = { 0, 0, 0 };
    Dictionary<string, string> openWith = new Dictionary<string, string>();

    openWith.Add("txt", "notepad.exe");

	string przycisk;
	public MainPage()
	{
		InitializeComponent();
	}

	void test1(object sender, EventArgs e)
	{
		RadioButton button = sender as RadioButton;
		przycisk = button.StyleId;
    }

	private void akcjaTablica(object sender, EventArgs e)
	{
		if (akcja.IsToggled == true)
		{
			switch (przycisk) {
                case "kot":
					zwierzeta[0]++;
                    break;
				case "pies":
                    zwierzeta[1]++;
					break;
				case "krowa":
					zwierzeta[2]++;
					break;
            }
		}
		else if (akcja.IsToggled == false) {
            switch (przycisk)
            {
                case "kot":
                    zwierzeta[0]--;
                    break;
                case "pies":
                    zwierzeta[1]--;
                    break;
                case "krowa":
                    zwierzeta[2]--;
                    break;
            }
        }
		for (int i = 0; i < zwierzeta.Length; i++)
		{
			if (zwierzeta[i] < 0)
			{
				zwierzeta[i] = 0;
			}
		}
		wynik.Text = "Kot: " + zwierzeta[0] + ", Pies: " + zwierzeta[1] + ", Krowa: " + zwierzeta[2];
	}
}

