using System;
using OpenTK.Input;

namespace TestOpenTK
{
    public class ActionEventArgs : EventArgs
    {
        public ActionEventArgs()
        {
            this.Instance = 0;
        }

        public ActionEventArgs(int controllerInstance)
        {
            this.Instance = controllerInstance;
        }

        public int Instance { get; set; }

        public GamePadState GamepadState { get { return GamePad.GetState(this.Instance); } }

        public JoystickState JoystickState { get { return OpenTK.Input.Joystick.GetState(this.Instance); } }
    }
}
