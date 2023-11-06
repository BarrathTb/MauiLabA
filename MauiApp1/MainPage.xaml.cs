namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            if (int.TryParse(StartNum.Text, out int inputValue))
            {
                count = inputValue * 7;

                if (count == 1)
                    Output.Text = $"Clicked {count} time";
                else
                    Output.Text = $"Clicked {count} times";

                SemanticScreenReader.Announce(CounterBtn.Text);
            }
            else
            {
                // Handle invalid input, e.g., show an error message
                Output.Text = "Invalid input. Please enter a number.";
            }
        }
    }
}
