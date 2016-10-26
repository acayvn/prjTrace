using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassUserControl
{
    public class clsTestEmun
    {
        public clsTestEmun()
        { 
        }
        public clsTestEmun(State stateNgay)
        {
            switch (stateNgay)
            {
                case State.Sang:
                    this._Sang = true;
                    break;
                case State.Trua:
                    this._Trua = true;
                    break;
                case State.Chieu:
                    this._Chieu = true;
                    break;
            }
        }
        public enum State
        { 
            Sang,
            Trua,
            Chieu
        };
        private bool _Sang;

        public bool Sang
        {
            get { return _Sang; }
            set { _Sang = value; }
        }
        private bool _Trua;

        public bool Trua
        {
            get { return _Trua; }
            set { _Trua = value; }
        }
        private bool _Chieu;

        public bool Chieu
        {
            get { return _Chieu; }
            set { _Chieu = value; }
        }


    }
}
