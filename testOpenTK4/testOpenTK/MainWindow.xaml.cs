using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Threading;

namespace testOpenTK
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
            txtGamePadCapabilitiesDebug.Text = controller.CapabilitiesGamePad.ToString();
            txtJoystickCapabilitiesDebug.Text = controller.CapabilitiesJoystick.ToString();
            controller.JoystickAction += controller_JoystickAction;
            controller.GamePadAction += controller_GamePadAction;
            controller.Button0Pressed += controller_Button0Pressed;
            controller.Button0Released += controller_Button0Released;
            controller.Button1Pressed += controller_Button1Pressed;
            controller.Button1Released += controller_Button1Released;
            controller.Button2Pressed += controller_Button2Pressed;
            controller.Button2Released += controller_Button2Released;
            controller.Button3Pressed += controller_Button3Pressed;
            controller.Button3Released += controller_Button3Released;
            controller.Button4Pressed += controller_Button4Pressed;
            controller.Button4Released += controller_Button4Released;
            controller.Button5Pressed += controller_Button5Pressed;
            controller.Button5Released += controller_Button5Released;
            controller.Button6Pressed += controller_Button6Pressed;
            controller.Button6Released += controller_Button6Released;
            controller.Button7Pressed += controller_Button7Pressed;
            controller.Button7Released += controller_Button7Released;
            controller.Button8Pressed += controller_Button8Pressed;
            controller.Button8Released += controller_Button8Released;
            controller.Button9Pressed += controller_Button9Pressed;
            controller.Button9Released += controller_Button9Released;
            controller.Button10Pressed += controller_Button10Pressed;
            controller.Button10Released += controller_Button10Released;
            controller.Button11Pressed += controller_Button11Pressed;
            controller.Button11Released += controller_Button11Released;
            controller.Button12Pressed += controller_Button12Pressed;
            controller.Button12Released += controller_Button12Released;
            controller.Button13Pressed += controller_Button13Pressed;
            controller.Button13Released += controller_Button13Released;
            controller.Button14Pressed += controller_Button14Pressed;
            controller.Button14Released += controller_Button14Released;
            controller.Button15Pressed += controller_Button15Pressed;
            controller.Button15Released += controller_Button15Released;
            controller.Button16Pressed += controller_Button16Pressed;
            controller.Button16Released += controller_Button16Released;
            controller.Button17Pressed += controller_Button17Pressed;
            controller.Button17Released += controller_Button17Released;
            controller.Button18Pressed += controller_Button18Pressed;
            controller.Button18Released += controller_Button18Released;
            controller.Button19Pressed += controller_Button19Pressed;
            controller.Button19Released += controller_Button19Released;
        }

        private void controller_Button0Pressed(object sender, ActionEventArgs e)
        {
            cbButton0.IsChecked = true;
            txtLastButton.Text = "Button Pressed\r\n";
        }

        private void controller_Button0Released(object sender, ActionEventArgs e)
        {
            cbButton0.IsChecked = false;
            txtLastButton.Text = "Button Released\r\n";
        }

        private void controller_Button1Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed\r\n";
            cbButton1.IsChecked = true;
        }

        private void controller_Button1Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released\r\n";
            cbButton1.IsChecked = false;
        }

        private void controller_Button2Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed\r\n";
            cbButton2.IsChecked = true;
        }

        private void controller_Button2Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released\r\n";
            cbButton2.IsChecked = false;
        }

        private void controller_Button3Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed\r\n";
            cbButton3.IsChecked = true;
        }

        private void controller_Button3Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released\r\n";
            cbButton3.IsChecked = false;
        }

        private void controller_Button4Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed\r\n";
            cbButton4.IsChecked = true;
        }

        private void controller_Button4Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released\r\n";
            cbButton4.IsChecked = false;
        }

        private void controller_Button5Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed\r\n";
            cbButton5.IsChecked = true;
        }

        private void controller_Button5Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released\r\n";
            cbButton5.IsChecked = false;
        }

        private void controller_Button6Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed\r\n";
            cbButton6.IsChecked = true;
        }

        private void controller_Button6Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released\r\n";
            cbButton6.IsChecked = false;
        }

        private void controller_Button7Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed\r\n";

            cbButton7.IsChecked = true;
        }

        private void controller_Button7Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released\r\n";
            cbButton7.IsChecked = false;
        }

        private void controller_Button8Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed\r\n";
            cbButton8.IsChecked = true;
        }

        private void controller_Button8Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released\r\n";
            cbButton8.IsChecked = false;
        }

        private void controller_Button9Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed\r\n";
            cbButton9.IsChecked = true;
        }

        private void controller_Button9Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released\r\n";
            cbButton9.IsChecked = false;
        }

        private void controller_Button10Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed\r\n";
            cbButton10.IsChecked = true;
        }

        private void controller_Button10Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released\r\n";
            cbButton10.IsChecked = false;
        }

        private void controller_Button11Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed\r\n";
            cbButton11.IsChecked = true;
        }

        private void controller_Button11Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released\r\n";
            cbButton11.IsChecked = false;
        }

        private void controller_Button12Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed\r\n";
            cbButton12.IsChecked = true;
        }

        private void controller_Button12Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released\r\n";
            cbButton12.IsChecked = false;
        }

        private void controller_Button13Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed\r\n";
            cbButton13.IsChecked = true;
        }

        private void controller_Button13Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released\r\n";
            cbButton13.IsChecked = false;
        }

        private void controller_Button14Released(object sender, ActionEventArgs e)
        {
             txtLastButton.Text = "Button Released\r\n";
            cbButton14.IsChecked = false;
        }

        private void controller_Button14Pressed(object sender, ActionEventArgs e)
        {
           txtLastButton.Text = "Button Pressed\r\n";
            cbButton14.IsChecked = true;
        }

        private void controller_Button15Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released\r\n";
            cbButton15.IsChecked = false;
        }

        private void controller_Button15Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed\r\n";
            cbButton15.IsChecked = true;
        }

        private void controller_Button16Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released\r\n";
            cbButton16.IsChecked = false;
        }

        private void controller_Button16Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed\r\n";
            cbButton16.IsChecked = true;
        }

        private void controller_Button17Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed\r\n";

            cbButton17.IsChecked = true;
        }

        private void controller_Button17Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released\r\n";
            cbButton17.IsChecked = false;
        }

        private void controller_Button18Pressed(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Pressed\r\n";
            cbButton18.IsChecked = true;
        }

        private void controller_Button18Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released\r\n";
            cbButton18.IsChecked = false;
        }

        private void controller_Button19Released(object sender, ActionEventArgs e)
        {
            txtLastButton.Text = "Button Released\r\n";
            cbButton19.IsChecked = false;
        }

        private void controller_Button19Pressed(object sender, ActionEventArgs e)
        {
             txtLastButton.Text = "Button Pressed\r\n";
            cbButton19.IsChecked = true;
        }

        private void controller_GamePadAction(object sender, ActionEventArgs e)
        {
            txtGamePadStateDebug.Text = e.GamePadState.ToString();
        }

        private void controller_JoystickAction(object sender, ActionEventArgs e)
        {
            txtJoystickStateDebug.Text = e.JoystickState.ToString();
        }
    }

    public class ControllerEngine
    {
        private DispatcherTimer clock;
        private GamePadState oldgstate;
        private JoystickState oldjstate;

        private List<ButtonState> GamePadButtons;
        private List<ButtonState> JoystickButtons;

        // Event Declaration
        // GamePadAction: Triggered when the oldgstate is different from the current GamePadState
        // JoystickAction: Triggered when the oldjstate is different from the current JoystickState
        

        private int clockspeed = 25; // 25 millisecond window for clock on joystick polling.

        public ControllerEngine()
        {
            this.ActiveDevice = 0;
            this.GamePadButtons = new List<ButtonState>();
            this.JoystickButtons = new List<ButtonState>();
            oldgstate = GamePad.GetState(this.ActiveDevice);

            oldjstate = Joystick.GetState(this.ActiveDevice);
            createNewTimer();
        }

        private void createNewTimer()
        {
            clock = new DispatcherTimer();
            clock.Tick += new EventHandler(checkGamePads);
            clock.Interval = new TimeSpan(0, 0, 0, 0, this.clockspeed);
            clock.Start();
        }

        public int ActiveDevice { get; set; }

        public GamePadCapabilities CapabilitiesGamePad { get { return GamePad.GetCapabilities(this.ActiveDevice); } }

        public JoystickCapabilities CapabilitiesJoystick { get { return Joystick.GetCapabilities(this.ActiveDevice); } }

        protected virtual void OnGamePadAction(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = GamePadAction;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnJoystickAction(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = JoystickAction;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void getButtonStates()
        {
            ActionEventArgs args = new ActionEventArgs(this.ActiveDevice);
            int buttonCount = this.CapabilitiesJoystick.ButtonCount;

            var joystick = Joystick.GetState(this.ActiveDevice);

            if (oldjstate.GetButton(JoystickButton.Button0) != joystick.GetButton(JoystickButton.Button0))
            {
                if (joystick.GetButton(JoystickButton.Button0) == ButtonState.Pressed)
                {
                    OnButton0Pressed(args);
                }
                else if (joystick.GetButton(JoystickButton.Button0).Equals(ButtonState.Released))
                {
                    OnButton0Released(args);
                }
            }
            if (oldjstate.GetButton(JoystickButton.Button1) != joystick.GetButton(JoystickButton.Button1))
            {
                if (joystick.GetButton(JoystickButton.Button1).Equals(ButtonState.Pressed))
                {
                    OnButton1Pressed(args);
                }
                else if (joystick.GetButton(JoystickButton.Button1).Equals(ButtonState.Released))
                {
                    OnButton1Released(args);
                }
            }
            if (oldjstate.GetButton(JoystickButton.Button2) != joystick.GetButton(JoystickButton.Button2))
            {
                if (joystick.GetButton(JoystickButton.Button2).Equals(ButtonState.Pressed))
                {
                    OnButton2Pressed(args);
                }
                else if (joystick.GetButton(JoystickButton.Button2).Equals(ButtonState.Released))
                {
                    OnButton2Released(args);
                }
            }
            if (oldjstate.GetButton(JoystickButton.Button3) != joystick.GetButton(JoystickButton.Button3))
            {
                if (joystick.GetButton(JoystickButton.Button3).Equals(ButtonState.Pressed))
                {
                    OnButton3Pressed(args);
                }
                else if (joystick.GetButton(JoystickButton.Button3).Equals(ButtonState.Released))
                {
                    OnButton3Released(args);
                }
            }
            if (oldjstate.GetButton(JoystickButton.Button4) != joystick.GetButton(JoystickButton.Button4))
            {
                if (joystick.GetButton(JoystickButton.Button4).Equals(ButtonState.Pressed))
                {
                    OnButton4Pressed(args);
                }
                else if (joystick.GetButton(JoystickButton.Button4).Equals(ButtonState.Released))
                {
                    OnButton4Released(args);
                }
            }
            if (oldjstate.GetButton(JoystickButton.Button5) != joystick.GetButton(JoystickButton.Button5))
            {
                if (joystick.GetButton(JoystickButton.Button5).Equals(ButtonState.Pressed))
                {
                    OnButton5Pressed(args);
                }
                else if (joystick.GetButton(JoystickButton.Button5).Equals(ButtonState.Released))
                {
                    OnButton5Released(args);
                }
            }
            if (oldjstate.GetButton(JoystickButton.Button6) != joystick.GetButton(JoystickButton.Button6))
            {
                if (joystick.GetButton(JoystickButton.Button6).Equals(ButtonState.Pressed))
                {
                    OnButton6Pressed(args);
                }
                else if (joystick.GetButton(JoystickButton.Button6).Equals(ButtonState.Released))
                {
                    OnButton6Released(args);
                }
            }
            if (oldjstate.GetButton(JoystickButton.Button7) != joystick.GetButton(JoystickButton.Button7))
            {
                if (joystick.GetButton(JoystickButton.Button7).Equals(ButtonState.Pressed))
                {
                    OnButton7Pressed(args);
                }
                else if (joystick.GetButton(JoystickButton.Button7).Equals(ButtonState.Released))
                {
                    OnButton7Released(args);
                }
            }
            if (oldjstate.GetButton(JoystickButton.Button8) != joystick.GetButton(JoystickButton.Button8))
            {
                if (joystick.GetButton(JoystickButton.Button8).Equals(ButtonState.Pressed))
                {
                    OnButton8Pressed(args);
                }
                else if (joystick.GetButton(JoystickButton.Button8).Equals(ButtonState.Released))
                {
                    OnButton8Released(args);
                }
            }
            if (oldjstate.GetButton(JoystickButton.Button9) != joystick.GetButton(JoystickButton.Button9))
            {
                if (joystick.GetButton(JoystickButton.Button9).Equals(ButtonState.Pressed))
                {
                    OnButton9Pressed(args);
                }
                else if (joystick.GetButton(JoystickButton.Button9).Equals(ButtonState.Released))
                {
                    OnButton9Released(args);
                }
            }
            if (oldjstate.GetButton(JoystickButton.Button10) != joystick.GetButton(JoystickButton.Button10))
            {
                if (joystick.GetButton(JoystickButton.Button10).Equals(ButtonState.Pressed))
                {
                    OnButton10Pressed(args);
                }
                else if (joystick.GetButton(JoystickButton.Button10).Equals(ButtonState.Released))
                {
                    OnButton10Released(args);
                }
            }
            if (oldjstate.GetButton(JoystickButton.Button11) != joystick.GetButton(JoystickButton.Button11))
            {
                if (joystick.GetButton(JoystickButton.Button11).Equals(ButtonState.Pressed))
                {
                    OnButton11Pressed(args);
                }
                else if (joystick.GetButton(JoystickButton.Button1).Equals(ButtonState.Released))
                {
                    OnButton11Released(args);
                }
            }
            if (oldjstate.GetButton(JoystickButton.Button12) != joystick.GetButton(JoystickButton.Button12))
            {
                if (joystick.GetButton(JoystickButton.Button12).Equals(ButtonState.Pressed))
                {
                    OnButton12Pressed(args);
                }
                else if (joystick.GetButton(JoystickButton.Button12).Equals(ButtonState.Released))
                {
                    OnButton12Released(args);
                }
            }
            if (oldjstate.GetButton(JoystickButton.Button13) != joystick.GetButton(JoystickButton.Button13))
            {
                if (joystick.GetButton(JoystickButton.Button13).Equals(ButtonState.Pressed))
                {
                    OnButton13Pressed(args);
                }
                else if (joystick.GetButton(JoystickButton.Button13).Equals(ButtonState.Released))
                {
                    OnButton13Released(args);
                }
            }
            if (oldjstate.GetButton(JoystickButton.Button14) != joystick.GetButton(JoystickButton.Button14))
            {
                if (joystick.GetButton(JoystickButton.Button14) == ButtonState.Pressed)
                {
                    OnButton14Pressed(args);
                }
                else if (joystick.GetButton(JoystickButton.Button14).Equals(ButtonState.Released))
                {
                    OnButton14Released(args);
                }
            }
            if (oldjstate.GetButton(JoystickButton.Button15) != joystick.GetButton(JoystickButton.Button15))
            {
                if (joystick.GetButton(JoystickButton.Button15).Equals(ButtonState.Pressed))
                {
                    OnButton15Pressed(args);
                }
                else if (joystick.GetButton(JoystickButton.Button15).Equals(ButtonState.Released))
                {
                    OnButton15Released(args);
                }
            }
            if (oldjstate.GetButton(JoystickButton.Button16) != joystick.GetButton(JoystickButton.Button16))
            {
                if (joystick.IsButtonDown(JoystickButton.Button16))
                {
                    OnButton16Pressed(args);
                }
                else if (joystick.IsButtonUp(JoystickButton.Button16))
                {
                    OnButton16Released(args);
                }
            }
            if (oldjstate.GetButton(JoystickButton.Button17) != joystick.GetButton(JoystickButton.Button17))
            {
                if (joystick.GetButton(JoystickButton.Button17).Equals(ButtonState.Pressed))
                {
                    OnButton17Pressed(args);
                }
                else if (joystick.GetButton(JoystickButton.Button17).Equals(ButtonState.Released))
                {
                    OnButton17Released(args);
                }
            }
            if (oldjstate.GetButton(JoystickButton.Button18) != joystick.GetButton(JoystickButton.Button18))
            {
                if (joystick.GetButton(JoystickButton.Button18).Equals(ButtonState.Pressed))
                {
                    OnButton18Pressed(args);
                }
                else if (joystick.GetButton(JoystickButton.Button18).Equals(ButtonState.Released))
                {
                    OnButton18Released(args);
                }
            }
            if (oldjstate.GetButton(JoystickButton.Button19) != joystick.GetButton(JoystickButton.Button19))
            {
                if (joystick.GetButton(JoystickButton.Button19).Equals(ButtonState.Pressed))
                {
                    OnButton19Pressed(args);
                }
                else if (joystick.GetButton(JoystickButton.Button19).Equals(ButtonState.Released))
                {
                    OnButton19Released(args);
                }
            }
        }

        private void OnButton0Pressed(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button0Pressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton0Released(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button0Released;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton1Pressed(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button1Pressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton1Released(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button1Released;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton2Pressed(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button2Pressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton2Released(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button2Released;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton3Pressed(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button3Pressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton3Released(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button3Released;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton4Pressed(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button4Pressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton4Released(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button4Released;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton5Pressed(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button5Pressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton5Released(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button5Released;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton6Pressed(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button6Pressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton6Released(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button6Released;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton7Pressed(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button7Pressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton7Released(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button7Released;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton8Pressed(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button8Pressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton8Released(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button8Released;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton9Pressed(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button9Pressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton9Released(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button9Released;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton10Pressed(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button10Pressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton10Released(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button10Released;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton11Pressed(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button11Pressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton11Released(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button11Released;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton12Pressed(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button12Pressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton12Released(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button12Released;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton13Pressed(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button13Pressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton13Released(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button13Released;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton14Pressed(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button14Pressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton14Released(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button14Released;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton15Pressed(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button15Pressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton15Released(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button15Released;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton16Pressed(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button16Pressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton16Released(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button16Released;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton17Pressed(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button17Pressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton17Released(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button17Released;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton18Pressed(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button18Pressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton18Released(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button18Released;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton19Pressed(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button19Pressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void OnButton19Released(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = Button19Released;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void checkGamePads(Object sender, EventArgs e)
        {
            ActionEventArgs args = new ActionEventArgs(this.ActiveDevice);
            if (!args.GamePadState.Equals(oldgstate))
            {
                //call event
                OnGamePadAction(args);

                oldgstate = args.GamePadState;
            }
            if (!args.JoystickState.Equals(oldjstate))
            {
                //call event
                getButtonStates();
                OnJoystickAction(args);
                oldjstate = args.JoystickState;
            }
        }

        public event EventHandler<ActionEventArgs> GamePadAction;

        public event EventHandler<ActionEventArgs> JoystickAction;

        public event EventHandler<ActionEventArgs> Button0Pressed;

        public event EventHandler<ActionEventArgs> Button0Released;

        public event EventHandler<ActionEventArgs> Button1Pressed;

        public event EventHandler<ActionEventArgs> Button1Released;

        public event EventHandler<ActionEventArgs> Button2Pressed;

        public event EventHandler<ActionEventArgs> Button2Released;

        public event EventHandler<ActionEventArgs> Button3Pressed;

        public event EventHandler<ActionEventArgs> Button3Released;

        public event EventHandler<ActionEventArgs> Button4Pressed;

        public event EventHandler<ActionEventArgs> Button4Released;

        public event EventHandler<ActionEventArgs> Button5Pressed;

        public event EventHandler<ActionEventArgs> Button5Released;

        public event EventHandler<ActionEventArgs> Button6Pressed;

        public event EventHandler<ActionEventArgs> Button6Released;

        public event EventHandler<ActionEventArgs> Button7Pressed;

        public event EventHandler<ActionEventArgs> Button7Released;

        public event EventHandler<ActionEventArgs> Button8Pressed;

        public event EventHandler<ActionEventArgs> Button8Released;

        public event EventHandler<ActionEventArgs> Button9Pressed;

        public event EventHandler<ActionEventArgs> Button9Released;

        public event EventHandler<ActionEventArgs> Button10Pressed;

        public event EventHandler<ActionEventArgs> Button10Released;

        public event EventHandler<ActionEventArgs> Button11Pressed;

        public event EventHandler<ActionEventArgs> Button11Released;

        public event EventHandler<ActionEventArgs> Button12Pressed;

        public event EventHandler<ActionEventArgs> Button12Released;

        public event EventHandler<ActionEventArgs> Button13Pressed;

        public event EventHandler<ActionEventArgs> Button13Released;

        public event EventHandler<ActionEventArgs> Button14Pressed;

        public event EventHandler<ActionEventArgs> Button14Released;

        public event EventHandler<ActionEventArgs> Button15Pressed;

        public event EventHandler<ActionEventArgs> Button15Released;

        public event EventHandler<ActionEventArgs> Button16Pressed;

        public event EventHandler<ActionEventArgs> Button16Released;

        public event EventHandler<ActionEventArgs> Button17Pressed;

        public event EventHandler<ActionEventArgs> Button17Released;

        public event EventHandler<ActionEventArgs> Button18Pressed;

        public event EventHandler<ActionEventArgs> Button18Released;

        public event EventHandler<ActionEventArgs> Button19Pressed;

        public event EventHandler<ActionEventArgs> Button19Released;
    }

    public class ActionEventArgs : EventArgs
    {
        public ActionEventArgs()
        {
            this.Instance = 0;
        }

        public ActionEventArgs(int ControllerInstance)
        {
            this.Instance = ControllerInstance;
        }

        public int Instance { get; set; }

        public GamePadState GamePadState { get { return GamePad.GetState(this.Instance); } }

        public JoystickState JoystickState { get { return Joystick.GetState(this.Instance); } }
    }
}