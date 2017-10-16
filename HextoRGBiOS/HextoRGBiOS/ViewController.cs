﻿using System;

using UIKit;

namespace HextoRGBiOS
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            convertButton.TouchUpInside += ConvertButton_TouchUpInside;
        }

        void ConvertButton_TouchUpInside(object sender, EventArgs e)
        {
            string hexValue = hexValueTextField.Text;
			//Gets the hex value from the hex value text vield

			string redHexValue = hexValue.Substring(0, 2);
            //Gets the first two characters from the hex value which is the hex value of red.

            string greenHexValue = hexValue.Substring(2, 2);
			//Gets the next two characters from the hex value which is the hex value of green.

			string blueHexValue = hexValue.Substring(4, 2);
			//Gets the last two characters from the hex value which is the hex value of blue.


			int redValue = int.Parse(redHexValue, System.Globalization.NumberStyles.HexNumber);
            int greenValue = int.Parse(greenHexValue, System.Globalization.NumberStyles.HexNumber);
            int blueValue = int.Parse(blueHexValue, System.Globalization.NumberStyles.HexNumber);
            //Turns the string from above into an integer.

            redValueLabel.Text = redValue.ToString();
            greenValueLabel.Text = greenValue.ToString();
            blueValueLabel.Text = blueValue.ToString();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
