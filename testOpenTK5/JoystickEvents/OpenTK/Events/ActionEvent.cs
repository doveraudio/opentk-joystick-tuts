using System;
namespace JoystickEvents.OpenTk.Events
{
    public class ActionEvent
    {
        public ActionEvent()
        {
        }

        public event EventHandler<ActionEventArgs> Action;

        public virtual void OnAction(ActionEventArgs e)
        {
            EventHandler<ActionEventArgs> handler = this.Action;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }

}
