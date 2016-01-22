using System;
using OpenTK.Input;
using JoystickEvents.OpenTk.Events;
namespace JoystickEvents.OpenTk
{
    public class Gamepad
    {
        public Gamepad()
        {

            this.Instance = 0;
            this.oldstate = this.State;
            this.InitializeButtons();
        }
        public Gamepad(int instance)
        {

            this.Instance = instance;
            this.oldstate = this.State;
            this.InitializeButtons();
        }


        private OpenTK.Input.GamePadState oldstate;
     
        public int Instance { get; set; }

        public OpenTK.Input.GamePadState State { get { return OpenTK.Input.GamePad.GetState(this.Instance); } }
        public OpenTK.Input.GamePadCapabilities Capabilities { 
            get 

            {
                return OpenTK.Input.GamePad.GetCapabilities(Instance);
            } 
        }

        public virtual void OnAction(ActionEventArgs e)
        {

            EventHandler<ActionEventArgs> handler = this.Action;
        }

        public bool Changed() {
            return !this.State.Equals(this.oldstate);
        }

        public void Update() {

            this.oldstate = this.State;
        }

        protected void InitializeButtons() 
        {

            this.A = new Button();
            this.B = new Button();
            this.X = new Button();
            this.Y = new Button();
            
            this.Back = new Button();
            this.Start = new Button();
            this.BigButton = new Button();
            this.LeftStick = new Button();
            this.RightStick = new Button();
            this.LeftShoulder = new Button();
            this.RightShoulder = new Button();
            this.LeftTrigger = new Button();
            this.RightTrigger = new Button();

            this.LeftAxis = new Axis();
            this.RightAxis = new Axis();

            

        }

        public Button A;
        public Button B;
        public Button X;
        public Button Y;

        public Button Back;
        public Button Start;
        public Button BigButton;

        public Button LeftStick;
        public Button RightStick;
        public Button LeftShoulder;
        public Button RightShoulder;
        public Button LeftTrigger;
        public Button RightTrigger;

        public Axis LeftAxis;
        public Axis RightAxis;
        
        public virtual void Poll() {
            
            var buttons = this.State.Buttons;
            var oldbuttons = this.oldstate.Buttons;

            var triggers = this.State.Triggers;
            var oldtriggers = this.oldstate.Triggers;

            if (!this.oldstate.ThumbSticks.Left.Equals(this.State.ThumbSticks.Left)) {
                this.LeftAxis.Update(this.State.ThumbSticks.Left.X, this.State.ThumbSticks.Left.Y);
                this.LeftAxis.Move();
            }
            if (!this.oldstate.ThumbSticks.Right.Equals(this.State.ThumbSticks.Right))
            {
                this.RightAxis.Update(this.State.ThumbSticks.Right.X, this.State.ThumbSticks.Right.Y);
                this.RightAxis.Move();
            }



            if (!buttons.A.Equals(oldbuttons.A) )
            {
                if (buttons.A == ButtonState.Pressed)
                {
                    A.Press();
                }
                if (buttons.A == ButtonState.Released)
                {
                    A.Release();
                }
                
            }

            if (!buttons.B.Equals(oldbuttons.B))
            {
                if (buttons.B == ButtonState.Pressed)
                {
                    B.Press();
                }
                if (buttons.B == ButtonState.Released)
                {
                    B.Release();
                }

            }

            if (!buttons.X.Equals(oldbuttons.X))
            {
                if (buttons.X == ButtonState.Pressed)
                {
                    X.Press();
                }
                else
                {
                    X.Release();
                }

            }

            if (!buttons.Y.Equals(oldbuttons.Y))
            {
                if (buttons.Y == ButtonState.Pressed)
                {
                    Y.Press();
                }
                else
                {
                    Y.Release();
                }

            }

            if (!buttons.Back.Equals(oldbuttons.Back))
            {
                if (buttons.Back == ButtonState.Pressed)
                {
                    Back.Press();
                }
                else
                {
                    Back.Release();
                }

            }

            if (!buttons.Start.Equals(oldbuttons.Start))
            {
                if (buttons.Start == ButtonState.Pressed)
                {
                    Start.Press();
                }
                else
                {
                    Start.Release();
                }

            }
            if (!buttons.BigButton.Equals(oldbuttons.BigButton))
            {
                if (buttons.BigButton == ButtonState.Pressed)
                {
                    BigButton.Press();
                }
                else
                {
                    BigButton.Release();
                }

            }

            if (!buttons.LeftShoulder.Equals(oldbuttons.LeftShoulder))
            {
                if (buttons.LeftShoulder == ButtonState.Pressed)
                {
                    LeftShoulder.Press();
                }
                else
                {
                    LeftShoulder.Release();
                }

            }

            if (!buttons.RightShoulder.Equals(oldbuttons.RightShoulder))
            {
                if (buttons.RightShoulder == ButtonState.Pressed)
                {
                    RightShoulder.Press();
                }
                else
                {
                    RightShoulder.Release();
                }

            }


            if (!buttons.LeftStick.Equals(oldbuttons.LeftStick))
            {
                if (buttons.LeftStick == ButtonState.Pressed)
                {
                    LeftStick.Press();
                }
                else
                {
                    LeftStick.Release();
                }

            }

            if (!buttons.RightStick.Equals(oldbuttons.RightStick))
            {
                if (buttons.RightStick == ButtonState.Pressed)
                {
                    RightStick.Press();
                }
                else
                {
                    RightStick.Release();
                }

            }

            
            if (!triggers.Left.Equals(oldtriggers.Left))
            {
                if (triggers.Left > 0)
                {
                    LeftTrigger.Press();
                }
                else
                {
                    LeftTrigger.Release();
                }

            }

            if (!triggers.Right.Equals(oldtriggers.Right))
            {
                if (triggers.Right > 0)
                {
                    RightTrigger.Press();
                }
                else
                {
                    RightTrigger.Release();
                }

            }

        }

        


        public event EventHandler<ActionEventArgs> Action;
    }
}
