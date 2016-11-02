using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassUserControl
{
    public class SessionClass
    {
        #region properties
        private int _IdTree;
        private int _IdMenu;
        private int _IdCore;
        private int _IdUser;
        private string _Url;
        public int IdCore
        {
            get
            {
                return _IdCore;
            }

            set
            {
                _IdCore = value;
            }
        }

        public int IdMenu
        {
            get
            {
                return _IdMenu;
            }

            set
            {
                _IdMenu = value;
            }
        }

        public int IdTree
        {
            get
            {
                return _IdTree;
            }

            set
            {
                _IdTree = value;
            }
        }

        public int IdUser
        {
            get
            {
                return _IdUser;
            }

            set
            {
                _IdUser = value;
            }
        }

        public string Url
        {
            get
            {
                return _Url;
            }

            set
            {
                _Url = value;
            }
        }
        #endregion
        #region contruction
        public SessionClass(int idTree)
        {
            _IdTree = idTree;
        }
        public SessionClass(int idTree, int idMenu)
        {
            _IdTree = idTree;
            _IdMenu = IdMenu;
        }
        public SessionClass(int idTree, int idMenu, int idCore)
        {
            _IdMenu = idMenu;
            _IdTree = idTree;
            _IdCore = idCore;
        }
        public SessionClass(int idTree, int idMenu, int idCore, string url)
        {
            _IdMenu = idMenu;
            _IdTree = idTree;
            _IdCore = idCore;
            _Url = url;
        }
        public void Dispose()
        {
            return;
        }
        #endregion


        
    }
}
