using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PinPasscodeView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SetPinPasscodePage : ContentPage
    {
        Stack<int> f;
        Stack<int> s;

        public SetPinPasscodePage()
        {
            InitializeComponent();
            f = new Stack<int>();
            s = new Stack<int>();
        }

        private void PinOne_Tapped(object sender, EventArgs e)
        {
            if (f.Count < 4) f.Push(1);
            else if (f.Count == 4 && s.Count < 4) s.Push(1);
            else return;

            UpdateVisual_Passcode();
        }

        private void PinTwo_Tapped(object sender, EventArgs e)
        {
            if (f.Count < 4) f.Push(2);
            else if (f.Count == 4 && s.Count < 4) s.Push(2);
            else return;

            UpdateVisual_Passcode();
        }

        private void PinThree_Tapped(object sender, EventArgs e)
        {
            if (f.Count < 4) f.Push(3);
            else if (f.Count == 4 && s.Count < 4) s.Push(3);
            else return;

            UpdateVisual_Passcode();
        }

        private void PinFour_Tapped(object sender, EventArgs e)
        {
            if (f.Count < 4) f.Push(4);
            else if (f.Count == 4 && s.Count < 4) s.Push(4);
            else return;

            UpdateVisual_Passcode();
        }

        private void PinFive_Tapped(object sender, EventArgs e)
        {
            if (f.Count < 4) f.Push(5);
            else if (f.Count == 4 && s.Count < 4) s.Push(5);
            else return;

            UpdateVisual_Passcode();
        }

        private void PinSix_Tapped(object sender, EventArgs e)
        {
            if (f.Count < 4) f.Push(6);
            else if (f.Count == 4 && s.Count < 4) s.Push(6);
            else return;

            UpdateVisual_Passcode();
        }

        private void PinSeven_Tapped(object sender, EventArgs e)
        {
            if (f.Count < 4) f.Push(7);
            else if (f.Count == 4 && s.Count < 4) s.Push(7);
            else return;

            UpdateVisual_Passcode();
        }

        private void PinEight_Tapped(object sender, EventArgs e)
        {
            if (f.Count < 4) f.Push(8);
            else if (f.Count == 4 && s.Count < 4) s.Push(8);
            else return;

            UpdateVisual_Passcode();
        }

        private void PinNine_Tapped(object sender, EventArgs e)
        {
            if (f.Count < 4) f.Push(9);
            else if (f.Count == 4 && s.Count < 4) s.Push(9);
            else return;

            UpdateVisual_Passcode();
        }

        private void PinZero_Tapped(object sender, EventArgs e)
        {
            if (f.Count < 4) f.Push(0);
            else if (f.Count == 4 && s.Count < 4) s.Push(0);
            else return;

            UpdateVisual_Passcode();
        }

        private void PinDelete_Tapped(object sender, EventArgs e)
        {
            if (f.Count == 0)
                return;

            if (s.Count > 0 && s.Count <= 4) s.Pop();
            else if (s.Count == 0) f.Pop();
            else return;

            UpdateVisual_Passcode();
        }

        private void UpdateVisual_Passcode()
        {
            switch (f.Count)
            {
                case 0:
                    PasscodeOne.TextColor = Color.FromHex("#8F8F8F");
                    PasscodeTwo.TextColor = Color.FromHex("#8F8F8F");
                    PasscodeThree.TextColor = Color.FromHex("#8F8F8F");
                    PasscodeFour.TextColor = Color.FromHex("#8F8F8F");
                    break;
                case 1:
                    PasscodeOne.TextColor = Color.FromHex("#4549D1");
                    PasscodeTwo.TextColor = Color.FromHex("#8F8F8F");
                    PasscodeThree.TextColor = Color.FromHex("#8F8F8F");
                    PasscodeFour.TextColor = Color.FromHex("#8F8F8F");
                    break;
                case 2:
                    PasscodeOne.TextColor = Color.FromHex("#4549D1");
                    PasscodeTwo.TextColor = Color.FromHex("#4549D1");
                    PasscodeThree.TextColor = Color.FromHex("#8F8F8F");
                    PasscodeFour.TextColor = Color.FromHex("#8F8F8F");
                    break;
                case 3:
                    PasscodeOne.TextColor = Color.FromHex("#4549D1");
                    PasscodeTwo.TextColor = Color.FromHex("#4549D1");
                    PasscodeThree.TextColor = Color.FromHex("#4549D1");
                    PasscodeFour.TextColor = Color.FromHex("#8F8F8F");
                    break;
                case 4:
                    PasscodeOne.TextColor = Color.FromHex("#4549D1");
                    PasscodeTwo.TextColor = Color.FromHex("#4549D1");
                    PasscodeThree.TextColor = Color.FromHex("#4549D1");
                    PasscodeFour.TextColor = Color.FromHex("#4549D1");
                    break;
            }

            switch (s.Count)
            {
                case 0:
                    RepPasscodeOne.TextColor = Color.FromHex("#8F8F8F");
                    RepPasscodeTwo.TextColor = Color.FromHex("#8F8F8F");
                    RepPasscodeThree.TextColor = Color.FromHex("#8F8F8F");
                    RepPasscodeFour.TextColor = Color.FromHex("#8F8F8F");
                    break;
                case 1:
                    RepPasscodeOne.TextColor = Color.FromHex("#4549D1");
                    RepPasscodeTwo.TextColor = Color.FromHex("#8F8F8F");
                    RepPasscodeThree.TextColor = Color.FromHex("#8F8F8F");
                    RepPasscodeFour.TextColor = Color.FromHex("#8F8F8F");
                    break;
                case 2:
                    RepPasscodeOne.TextColor = Color.FromHex("#4549D1");
                    RepPasscodeTwo.TextColor = Color.FromHex("#4549D1");
                    RepPasscodeThree.TextColor = Color.FromHex("#8F8F8F");
                    RepPasscodeFour.TextColor = Color.FromHex("#8F8F8F");
                    break;
                case 3:
                    RepPasscodeOne.TextColor = Color.FromHex("#4549D1");
                    RepPasscodeTwo.TextColor = Color.FromHex("#4549D1");
                    RepPasscodeThree.TextColor = Color.FromHex("#4549D1");
                    RepPasscodeFour.TextColor = Color.FromHex("#8F8F8F");
                    break;
                case 4:
                    RepPasscodeOne.TextColor = Color.FromHex("#4549D1");
                    RepPasscodeTwo.TextColor = Color.FromHex("#4549D1");
                    RepPasscodeThree.TextColor = Color.FromHex("#4549D1");
                    RepPasscodeFour.TextColor = Color.FromHex("#4549D1");
                    break;
            }

            ConfirmPinCodeButton.IsEnabled = false;

            if (s.Count == 4)
            {
                checkPasscodeSimilarity();
            }
        }

        private void checkPasscodeSimilarity()
        {
            bool isValid = true;

            if (f.Count == 4 && s.Count == 4)
            {
                int[] firstStack = new int[4];
                int[] secondStack = new int[4];

                int i = 0;
                foreach (int pinNum in f)
                {
                    firstStack[i] = pinNum;
                    i++;
                }

                i = 0;
                foreach (int pinNum in s)
                {
                    secondStack[i] = pinNum;
                    i++;
                }

                for (int j = 0; j < 4; j++)
                {
                    if (firstStack[j] != secondStack[j])
                        isValid = false;
                }
            }

            if (isValid)
            {
                ConfirmPinCodeButton.IsEnabled = true;
            }
            else
            {
                f.Clear();
                s.Clear();
                ConfirmPinCodeButton.IsEnabled = false;

                UpdateVisual_Passcode();
            }
        }

        private void ConfirmPinCode_Clicked(object sender, EventArgs e)
        {
            ConfirmPinCodeButton.IsVisible = false;
        }
    }
}