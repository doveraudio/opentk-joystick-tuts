using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Threading;

namespace TestOpenTK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ControllerEngine controller;

        public MainWindow()
        {
            InitializeComponent();
            controller = new ControllerEngine();

            this.Loaded += initializeController;
        }

        private void initializeController(Object sender, EventArgs e)
        {
            txtGamePadCapabilitiesDebug.Text = controller.CapabilitiesGamepad.ToString();
            txtJoystickCapabilitiesDebug.Text = controller.Joystick.Capabilities.ToString();

            controller.Joystick.Action += controller_JoystickAction;
            controller.GamepadAction += controller_GamePadAction;

            controller.Joystick.Buttons[0].Pressed += controller_Button0Pressed;
            controller.Joystick.Buttons[0].Released += controller_Button0Released;
            controller.Joystick.Buttons[1].Pressed += controller_Button1Pressed;
            controller.Joystick.Buttons[1].Released += controller_Button1Released;
            controller.Joystick.Buttons[2].Pressed += controller_Button2Pressed;
            controller.Joystick.Buttons[2].Released += controller_Button2Released;
            controller.Joystick.Buttons[3].Pressed += controller_Button3Pressed;
            controller.Joystick.Buttons[3].Released += controller_Button3Released;
            controller.Joystick.Buttons[4].Pressed += controller_Button4Pressed;
            controller.Joystick.Buttons[4].Released += controller_Button4Released;
            controller.Joystick.Buttons[5].Pressed += controller_Button5Pressed;
            controller.Joystick.Buttons[5].Released += controller_Button5Released;
            controller.Joystick.Buttons[6].Pressed += controller_Button6Pressed;
            controller.Joystick.Buttons[6].Released += controller_Button6Released;
            controller.Joystick.Buttons[7].Pressed += controller_Button7Pressed;
            controller.Joystick.Buttons[7].Released += controller_Button7Released;
            controller.Joystick.Buttons[8].Pressed += controller_Button8Pressed;
            controller.Joystick.Buttons[8].Released += controller_Button8Released;
            controller.Joystick.Buttons[9].Pressed += controller_Button9Pressed;
            controller.Joystick.Buttons[9].Released += controller_Button9Released;
            controller.Joystick.Buttons[10].Pressed += controller_Button10Pressed;
            controller.Joystick.Buttons[10].Released += controller_Button10Released;
            controller.Joystick.Buttons[11].Pressed += controller_Button11Pressed;
            controller.Joystick.Buttons[11].Released += controller_Button11Released;
            controller.Joystick.Buttons[12].Pressed += controller_Button12Pressed;
            controller.Joystick.Buttons[12].Released += controller_Button12Released;
            controller.Joystick.Buttons[13].Pressed += controller_Button13Pressed;
            controller.Joystick.Buttons[13].Released += controller_Button13Released;
            controller.Joystick.Buttons[14].Pressed += controller_Button14Pressed;
            controller.Joystick.Buttons[14].Released += controller_Button14Released;
            controller.Joystick.Buttons[15].Pressed += controller_Button15Pressed;
            controller.Joystick.Buttons[15].Released += controller_Button15Released;
            controller.Joystick.Buttons[16].Pressed += controller_Button16Pressed;
            controller.Joystick.Buttons[16].Released += controller_Button16Released;
            controller.Joystick.Buttons[17].Pressed += controller_Button17Pressed;
            controller.Joystick.Buttons[17].Released += controller_Button17Released;
            controller.Joystick.Buttons[18].Pressed += controller_Button18Pressed;
            controller.Joystick.Buttons[18].Released += controller_Button18Released;
            controller.Joystick.Buttons[19].Pressed += controller_Button19Pressed;
            controller.Joystick.Buttons[19].Released += controller_Button19Released;
        }

        private void controller_Button0Pressed(object sender, ActionEventArgs e)
        {
            
            cbButton0.IsChecked = true;
            txtLastButton.Text = "Button Pressed";
        }

        private void controller_Button0Released(object sender, ActionEventArgs e)
        {
            cbButton0.IsChecked = false;
            txtLastButton.Text = "Button Released";
        }

        private void controller_Button1Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed";
            cbButton1.IsChecked = true;
        }

        private void controller_Button1Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released";
            cbButton1.IsChecked = false;
        }

        private void controller_Button2Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed";
            cbButton2.IsChecked = true;
        }

        private void controller_Button2Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released";
            cbButton2.IsChecked = false;
        }

        private void controller_Button3Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed";
            cbButton3.IsChecked = true;
        }

        private void controller_Button3Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released";
            cbButton3.IsChecked = false;
        }

        private void controller_Button4Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed";
            cbButton4.IsChecked = true;
        }

        private void controller_Button4Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released";
            cbButton4.IsChecked = false;
        }

        private void controller_Button5Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed";
            cbButton5.IsChecked = true;
        }

        private void controller_Button5Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released";
            cbButton5.IsChecked = false;
        }

        private void controller_Button6Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed";
            cbButton6.IsChecked = true;
        }

        private void controller_Button6Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released";
            cbButton6.IsChecked = false;
        }

        private void controller_Button7Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed";

            cbButton7.IsChecked = true;
        }

        private void controller_Button7Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released";
            cbButton7.IsChecked = false;
        }

        private void controller_Button8Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed";
            cbButton8.IsChecked = true;
        }

        private void controller_Button8Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released";
            cbButton8.IsChecked = false;
        }

        private void controller_Button9Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed";
            cbButton9.IsChecked = true;
        }

        private void controller_Button9Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released";
            cbButton9.IsChecked = false;
        }

        private void controller_Button10Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed";
            cbButton10.IsChecked = true;
        }

        private void controller_Button10Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released";
            cbButton10.IsChecked = false;
        }

        private void controller_Button11Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed";
            cbButton11.IsChecked = true;
        }

        private void controller_Button11Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released";
            cbButton11.IsChecked = false;
        }

        private void controller_Button12Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed";
            cbButton12.IsChecked = true;
        }

        private void controller_Button12Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released";
            cbButton12.IsChecked = false;
        }

        private void controller_Button13Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed";
            cbButton13.IsChecked = true;
        }

        private void controller_Button13Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released";
            cbButton13.IsChecked = false;
        }

        private void controller_Button14Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released";
            cbButton14.IsChecked = false;
        }

        private void controller_Button14Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed";
            cbButton14.IsChecked = true;
        }

        private void controller_Button15Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released";
            cbButton15.IsChecked = false;
        }

        private void controller_Button15Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed";
            cbButton15.IsChecked = true;
        }

        private void controller_Button16Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released";
            cbButton16.IsChecked = false;
        }

        private void controller_Button16Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed";
            cbButton16.IsChecked = true;
        }

        private void controller_Button17Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed";

            cbButton17.IsChecked = true;
        }

        private void controller_Button17Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released";
            cbButton17.IsChecked = false;
        }

        private void controller_Button18Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed";
            cbButton18.IsChecked = true;
        }

        private void controller_Button18Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released";
            cbButton18.IsChecked = false;
        }

        private void controller_Button19Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released";
            cbButton19.IsChecked = false;
        }

        private void controller_Button19Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed";
            cbButton19.IsChecked = true;
        }

        private void controller_GamePadAction(object sender, ActionEventArgs e)
        {
            txtGamePadStateDebug.Text = e.GamepadState.ToString();
        }

        private void controller_JoystickAction(object sender, ActionEventArgs e)
        {
            txtJoystickStateDebug.Text = e.JoystickState.ToString();
        }
    }

}