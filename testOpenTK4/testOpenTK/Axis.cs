using System;
using System.Collections.Generic;
using System.Collections;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeInput
{
    public class Axis 
    {
        public Axis() {
            this._x = 0;
            this._y = 0;
        }

        private float _x;
        private float _y;
        private string _name;
        private int _index;
        private int _instance;

        public int Index { get; set; }
        public int Instance { get { return this._instance; } }
        public float X { get { return this._x; } }
        public float Y { get { return this._y; } }

        public string Name { get; set; }

        public event EventHandler<ActionEventArgs> Moved;

        public virtual void Move() {
            this.OnMoved(new ActionEventArgs(this.Instance));
        }

        protected virtual void OnMoved(ActionEventArgs e)
        {
            if (this.Moved != null) {
                this.Moved(this, e);
            }
        }


        public virtual void Update(float x,float y) {
            this._x = x;
            this._y = y;
        }


        
    }
}
