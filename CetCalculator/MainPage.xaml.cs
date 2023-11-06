namespace CetCalculator
{
    public partial class MainPage : ContentPage
    {
        double result = 0;
        double firstnumber = 0;
        Operator currentOperator = Operator.None;

        public MainPage()
        {
            InitializeComponent();
            Display.Text = "0";
        }

        private void Button0_Clicked(object sender, EventArgs e)
        {
            Display.Text += "0";
        }

        private void ClearButton_Clicked(object sender, EventArgs e)
        {
            //Homework
        }

        private void BackSpaceButton_Clicked(object sender, EventArgs e)
        {
            //Homework

        }

        private async void Button7_Clicked(object sender, EventArgs e)
        {
            await digitClicked(7);
        }

        private async void Button8_Clicked(object sender, EventArgs e)
        {
            await digitClicked(8);
        }

        private async void Button9_Clicked(object sender, EventArgs e)
        {
            await digitClicked(9);
        }

        private void DivisionButton_Clicked(object sender, EventArgs e)
        {

        }

        private async void Button4_Clicked(object sender, EventArgs e)
        {
            await digitClicked(4);
        }

        private async void Button5_Clicked(object sender, EventArgs e)
        {
            await digitClicked(5);
        }

        private async void Button6_Clicked(object sender, EventArgs e)
        {
            await digitClicked(6);
        }

        private void MultiplyButton_Clicked(object sender, EventArgs e)
        {

        }

        private async void Button1_Clicked(object sender, EventArgs e)
        {
           await digitClicked(1);
        }

        private async void Button2_Clicked(object sender, EventArgs e)
        {
          await  digitClicked(2);
        }

        private async void Button3_Clicked(object sender, EventArgs e)
        {
            await digitClicked(3);
        }

        private void SubtractButton_Clicked(object sender, EventArgs e)
        {

        }

        private void EqualButton_Clicked(object sender, EventArgs e)
        {
            double secondNumber= Convert.ToDouble(Display.Text);
            double result = 0;
            switch (currentOperator)
            {
                case Operator.None:
                    break;
                case Operator.Add:
                    result = firstnumber + secondNumber;
                    break;
                case Operator.Subtract:
                    break;
                case Operator.Multiply:
                    break;
                case Operator.Divide:
                    break;
                default:
                    break;
            }
            Display.Text = result.ToString();
            firstnumber= result; //??
            currentOperator= Operator.None;

        }

        private void AddButton_Clicked(object sender, EventArgs e)
        {
            currentOperator = Operator.Add;
            firstnumber = Convert.ToDouble(Display.Text);
        }

       
        async Task digitClicked(int digit)
        {
            //Homework
            //Should work in a correct way. eg. after operator click, it replace current value
            if(Display.Text.Length>10)
            {
                await DisplayAlert("Hata", "Sayı maksimum 10 basamaklı olabilir", "Tamam");

                return;
            }
            Display.Text += digit;
        }
    }
}