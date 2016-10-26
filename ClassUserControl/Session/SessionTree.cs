using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassUserControl.Session
{
    public class SessionTree
    {
        private int _IdTree;

        public int IdTree
        {
            get { return _IdTree; }
            set { _IdTree = value; }
        }
        public SessionTree()
        {

        }
        public SessionTree(int id)
        {
            _IdTree = id;
        }
    }
}
