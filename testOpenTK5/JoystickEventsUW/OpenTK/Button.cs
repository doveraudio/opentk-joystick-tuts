using System;
using JoystickEvents.OpenTk.Events;
namespace JoystickEvents.OpenTk
{
    public class Button
    {
        private int _index;
        private int _instance;
        public Button()
        {
            _instance = 0;
            _index = 0;
        }

        public Button(int instance, int index)
        {
            _instance = instance;
            _index = index;
        }

        public Button(int instance, int index, EventHandler<ActionEventArgs> pressed, EventHandler<ActionEventArgs> released)
        {
            _instance = instance;
            _index = index;
            this.Pressed = pressed;
            this.Released = released;
        }

        public event EventHandler<ActionEventArgs> Pressed;

        public event EventHandler<ActionEventArgs> Released;

        public int Index { get { return _index; } }

        public int Instance { get { return _instance; } }
        public virtual void Press()
        {
            this.OnPressed(new ActionEventArgs(this.Instance));
        }

        public virtual void Release()
        {
            this.OnReleased(new ActionEventArgs(this.Instance));
        }

        protected virtual void OnPressed(ActionEventArgs e)
        {
            if (this.Pressed != null)
            {
                this.Pressed(this, e);
            }
        }

        protected virtual void OnReleased(ActionEventArgs e)
        {
            if (this.Released != null)
            {
                this.Released(this, e);
            }
        }
    }
}