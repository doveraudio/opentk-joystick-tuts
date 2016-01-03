using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using OpenTK.Input;
namespace FreeInput
{

    public class ControllerEngine
    {
        private DispatcherTimer clock;
        //private GamePadState oldgstate;
        private Joystick _joystick;
        private Gamepad _gamepad;
        // Event Declaration
        // GamePadAction: Triggered when the oldgstate is different from the current GamePadState
        // Joystick.OnAction: Triggered when the joystick state is changed.

        private int clockspeed = 25; // 25 millisecond window for clock on joystick polling.

        public Joystick Joystick { get { return this._joystick; } }

        public Gamepad Gamepad { get { return this._gamepad; } }

        public ControllerEngine()
        {
            this._joystick = new Joystick();
            this._gamepad = new Gamepad();
            this.ActiveDevice = 0;
            //oldgstate = OpenTK.Input.GamePad.GetState(this.ActiveDevice);
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

        public GamePadCapabilities CapabilitiesGamepad { get { return OpenTK.Input.GamePad.GetCapabilities(this.ActiveDevice); } }

        public JoystickCapabilities CapabilitiesJoystick { get { return OpenTK.Input.Joystick.GetCapabilities(this.ActiveDevice); } }

        protected virtual void OnGamepadAction(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = GamepadAction;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void checkGamePads(Object sender, EventArgs e)
        {
            ActionEventArgs args = new ActionEventArgs(this.ActiveDevice);
            if (this.Gamepad.Changed())
            {
                this.Gamepad.Poll();
                this.Gamepad.Update();
                
            }
            if (this.Joystick.Changed())
            {
                this.Joystick.Poll();
                this.Joystick.Update();
            }
        }

        public event EventHandler<ActionEventArgs> GamepadAction;
    }

}
