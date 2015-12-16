﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Collections.ObjectModel;
using OpenTK.Input;
namespace TestOpenTK
{
    class Gamepad
    {
        public Gamepad() { 
        }


        private OpenTK.Input.GamePadState oldstate;
     
        public int Instance { get; set; }

        public OpenTK.Input.GamePadState State { get { return OpenTK.Input.GamePad.GetState(this.Instance); } }
        public OpenTK.Input.GamePadCapabilities Capabilities { 
            get 
            {
                return OpenTK.Input.GamePad.GetCapabilities(this.Instance);
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
        public virtual void Poll() {
            
            var buttons = this.State.Buttons;
            var oldbuttons = this.oldstate.Buttons;

            var triggers = this.State.Triggers;
            var oldtriggers = this.oldstate.Triggers;
            if (!buttons.A.Equals(oldbuttons.A) )
            {
                if (buttons.A == ButtonState.Pressed)
                {
                    A.Press();
                }
                else {
                    A.Release();
                }
                
            }

            if (!buttons.B.Equals(oldbuttons.B))
            {
                if (buttons.B == ButtonState.Pressed)
                {
                    B.Press();
                }
                else
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
