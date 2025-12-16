namespace MauiApp14
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterPulubien.Text = $"Polubień: {count}";
            else
                CounterPulubien.Text = $"Polubień: {count}";

            SemanticScreenReader.Announce(CounterPulubien.Text);
        }

        private void OnCounterClickedDrugi(object? sender, EventArgs e)
        {
            if(count>0)
            { count--; }
            

            if (count >0)
                CounterPulubien.Text = $"Polubień: {count}";
            else
                CounterPulubien.Text = $"Polubień: {count}";

            SemanticScreenReader.Announce(CounterPulubien.Text);
        }
    }
}
