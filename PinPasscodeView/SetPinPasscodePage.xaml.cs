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
                    PasscodeOne.Source = ImageSource.FromResource("PinPasscodeView.images.pinNo.png");
                    PasscodeTwo.Source = ImageSource.FromResource("PinPasscodeView.images.pinNo.png");
                    PasscodeThree.Source = ImageSource.FromResource("PinPasscodeView.images.pinNo.png");
                    PasscodeFour.Source = ImageSource.FromResource("PinPasscodeView.images.pinNo.png");
                    break;
                case 1:
                    PasscodeOne.Source = ImageSource.FromResource("PinPasscodeView.images.pinYes.png");
                    PasscodeTwo.Source = ImageSource.FromResource("PinPasscodeView.images.pinNo.png");
                    PasscodeThree.Source = ImageSource.FromResource("PinPasscodeView.images.pinNo.png");
                    PasscodeFour.Source = ImageSource.FromResource("PinPasscodeView.images.pinNo.png");
                    break;
                case 2:
                    PasscodeOne.Source = ImageSource.FromResource("PinPasscodeView.images.pinYes.png");
                    PasscodeTwo.Source = ImageSource.FromResource("PinPasscodeView.images.pinYes.png");
                    PasscodeThree.Source = ImageSource.FromResource("PinPasscodeView.images.pinNo.png");
                    PasscodeFour.Source = ImageSource.FromResource("PinPasscodeView.images.pinNo.png");
                    break;
                case 3:
                    PasscodeOne.Source = ImageSource.FromResource("PinPasscodeView.images.pinYes.png");
                    PasscodeTwo.Source = ImageSource.FromResource("PinPasscodeView.images.pinYes.png");
                    PasscodeThree.Source = ImageSource.FromResource("PinPasscodeView.images.pinYes.png");
                    PasscodeFour.Source = ImageSource.FromResource("PinPasscodeView.images.pinNo.png");
                    break;
                case 4:
                    PasscodeOne.Source = ImageSource.FromResource("PinPasscodeView.images.pinYes.png");
                    PasscodeTwo.Source = ImageSource.FromResource("PinPasscodeView.images.pinYes.png");
                    PasscodeThree.Source = ImageSource.FromResource("PinPasscodeView.images.pinYes.png");
                    PasscodeFour.Source = ImageSource.FromResource("PinPasscodeView.images.pinYes.png");
                    break;
            }

            switch (s.Count)
            {
                case 0:
                    RepPasscodeOne.Source = ImageSource.FromResource("PinPasscodeView.images.pinNo.png");
                    RepPasscodeTwo.Source = ImageSource.FromResource("PinPasscodeView.images.pinNo.png");
                    RepPasscodeThree.Source = ImageSource.FromResource("PinPasscodeView.images.pinNo.png");
                    RepPasscodeFour.Source = ImageSource.FromResource("PinPasscodeView.images.pinNo.png");
                    break;
                case 1:
                    RepPasscodeOne.Source = ImageSource.FromResource("PinPasscodeView.images.pinYes.png");
                    RepPasscodeTwo.Source = ImageSource.FromResource("PinPasscodeView.images.pinNo.png");
                    RepPasscodeThree.Source = ImageSource.FromResource("PinPasscodeView.images.pinNo.png");
                    RepPasscodeFour.Source = ImageSource.FromResource("PinPasscodeView.images.pinNo.png");
                    break;
                case 2:
                    RepPasscodeOne.Source = ImageSource.FromResource("PinPasscodeView.images.pinYes.png");
                    RepPasscodeTwo.Source = ImageSource.FromResource("PinPasscodeView.images.pinYes.png");
                    RepPasscodeThree.Source = ImageSource.FromResource("PinPasscodeView.images.pinNo.png");
                    RepPasscodeFour.Source = ImageSource.FromResource("PinPasscodeView.images.pinNo.png");
                    break;
                case 3:
                    RepPasscodeOne.Source = ImageSource.FromResource("PinPasscodeView.images.pinYes.png");
                    RepPasscodeTwo.Source = ImageSource.FromResource("PinPasscodeView.images.pinYes.png");
                    RepPasscodeThree.Source = ImageSource.FromResource("PinPasscodeView.images.pinYes.png");
                    RepPasscodeFour.Source = ImageSource.FromResource("PinPasscodeView.images.pinNo.png");
                    break;
                case 4:
                    RepPasscodeOne.Source = ImageSource.FromResource("PinPasscodeView.images.pinYes.png");
                    RepPasscodeTwo.Source = ImageSource.FromResource("PinPasscodeView.images.pinYes.png");
                    RepPasscodeThree.Source = ImageSource.FromResource("PinPasscodeView.images.pinYes.png");
                    RepPasscodeFour.Source = ImageSource.FromResource("PinPasscodeView.images.pinYes.png");
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
            // Handle the Success event (Eg. save pin in secure (local) storage or send to the server)
        }
    }
}