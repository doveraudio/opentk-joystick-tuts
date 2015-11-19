using OpenTK.Input;
using System;
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

        // Event Declaration
        // GamePadAction: Triggered when the oldgstate is different from the current GamePadState
        // JoystickAction: Triggered when the oldjstate is different from the current JoystickState
        public event EventHandler<ActionEventArgs> GamePadAction;

        public event EventHandler<ActionEventArgs> JoystickAction;

        private int clockspeed = 25; // 25 millisecond window for clock on joystick polling.

        public ControllerEngine()
        {
            this.ActiveDevice = 0;
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
                OnJoystickAction(args);
                oldjstate = args.JoystickState;
            }
        }
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