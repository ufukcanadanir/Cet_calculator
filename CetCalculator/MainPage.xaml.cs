

namespace CetCalculator
{
    public partial class MainPage : ContentPage
    {
        double result = 0;
        double firstnumber = 0;
        double secondnumber = 0;
        Operator currentOperator = Operator.None;
        bool isFirstNumberAfterOperator = true;
        bool isFirstOperatorClicked = false;

        public MainPage()
        {
            InitializeComponent();
            Display.Text = "0";
        }

        private async void Button0_Clicked(object sender, EventArgs e)
        {
            await digitClicked(0);
        }

        private void ClearButton_Clicked(object sender, EventArgs e)
        {
            //Homework
            firstnumber = 0;
            currentOperator = Operator.None;
            result = 0;
            Display.Text = "0";
            isFirstOperatorClicked = false;
        }

        private void BackSpaceButton_Clicked(object sender, EventArgs e)
        {
            //Homework
            //"289898" => substring(

            Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
            if (Display.Text.Length == 0) Display.Text = "0";
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


        private async void Button1_Clicked(object sender, EventArgs e)
        {
            await digitClicked(1);
        }

        private async void Button2_Clicked(object sender, EventArgs e)
        {
            await digitClicked(2);
        }

        private async void Button3_Clicked(object sender, EventArgs e)
        {
            await digitClicked(3);
        }
        private void DivisionButton_Clicked(object sender, EventArgs e)
        {
            if (isFirstOperatorClicked == true)
            {
                secondnumber = Convert.ToDouble(Display.Text);
                isFirstNumberAfterOperator = true;
                DoOperation();
            }
            else
            {
                firstnumber = Convert.ToDouble(Display.Text);
                isFirstNumberAfterOperator = true;

                isFirstOperatorClicked = true;
            }
            currentOperator = Operator.Divide;
        }


        private void MultiplyButton_Clicked(object sender, EventArgs e)
        {
            if (isFirstOperatorClicked == true)
            {
                secondnumber = Convert.ToDouble(Display.Text);
                isFirstNumberAfterOperator = true;
                DoOperation();
            }
            else
            {
                firstnumber = Convert.ToDouble(Display.Text);
                isFirstNumberAfterOperator = true;

                isFirstOperatorClicked = true;
            }
            currentOperator = Operator.Multiply;
        }
        private void SubtractButton_Clicked(object sender, EventArgs e)
        {
            if (isFirstOperatorClicked == true)
            {
                secondnumber = Convert.ToDouble(Display.Text);
                isFirstNumberAfterOperator = true;
                DoOperation();
            }
            else
            {
                firstnumber = Convert.ToDouble(Display.Text);
                isFirstNumberAfterOperator = true;

                isFirstOperatorClicked = true;
            }
            currentOperator = Operator.Subtract;
        }
            private void AddButton_Clicked(object sender, EventArgs e)
        {

            if (isFirstOperatorClicked == true)
            {
                secondnumber = Convert.ToDouble(Display.Text);
                isFirstNumberAfterOperator = true;
                DoOperation();
            }
            else
            {
            firstnumber = Convert.ToDouble(Display.Text);
            isFirstNumberAfterOperator = true;
            isFirstOperatorClicked = true;
            }
            currentOperator = Operator.Add;
        }


        private void DoOperation()
        {
            switch (currentOperator)
            {
                case Operator.None:
                    break;
                case Operator.Add:
                    result = firstnumber + secondnumber;
                    break;
                case Operator.Subtract:
                    result = firstnumber - secondnumber;
                    break;
                case Operator.Multiply:
                    result = firstnumber * secondnumber;
                    break;
                case Operator.Divide:
                    if(secondnumber != 0)
                    {
                    result = firstnumber / secondnumber;
                    }
                    break;
                default:
                    break;
            }
            Display.Text = result.ToString();
            firstnumber = result; //??
            currentOperator = Operator.None;

        }
        private void EqualButton_Clicked(object sender, EventArgs e)
        {
            switch (currentOperator)
            {
                case Operator.None:
                    break;
                case Operator.Add:
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
            firstnumber = result; //??
            currentOperator = Operator.None;

        }



        async Task digitClicked(int digit)
        {
            //Homework
            //Should work in a correct way. eg. after operator click, it replace current value
            string current = "";

            current = isFirstNumberAfterOperator ? digit.ToString() : Display.Text + digit.ToString();

            //if (isFirstNumberAfterOperator)
            //{
            //    current = digit.ToString();
            //} else
            //{
            //    current = Display.Text + digit.ToString();
            //}



            isFirstNumberAfterOperator = false;
            if (current.Length > 10)
            {
                await DisplayAlert("Hata", "Sayı maksimum 10 basamaklı olabilir", "Tamam");

                return;
            }


            Display.Text = current.TrimStart('0');
            if (Display.Text == "") { Display.Text = "0"; }
        }
    }
}