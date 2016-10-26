using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserAuthorizations
{
    public class ClassQuyen
    {
        #region propeties

        private string _MaQuyen;

        public string MaQuyen
        {
            get { return _MaQuyen; }
            private set 
            {
                _MaQuyen = string.Format("{0}{1}{2}{3}", _QuyenXem ? 1 : 0, _QuyenThem ? 1 : 0, _QuyenSua ? 1 : 0, _QuyenXoa ? 1 : 0);
            }
        }
        private bool _QuyenXem;

        public bool QuyenXem
        {
            get { return _QuyenXem; }
            set 
            {
                if (_QuyenXoa || _QuyenThem || _QuyenSua)
                    _QuyenXem = true;
                else _QuyenXem = value;
            }
        }
        private bool _QuyenThem;

        public bool QuyenThem
        {
            get { return _QuyenThem; }
            set { _QuyenThem = value; }
        }
        private bool _QuyenSua;

        public bool QuyenSua
        {
            get { return _QuyenSua; }
            set { _QuyenSua = value; }
        }
        private bool _QuyenXoa;

        public bool QuyenXoa
        {
            get { return _QuyenXoa; }
            set { _QuyenXoa = value; }
        }
        #endregion

        public ClassQuyen()
        {

        }
        public ClassQuyen(bool Xem, bool Them, bool Sua, bool Xoa)
        {
            _QuyenXem = Xem;
            _QuyenThem = Them;
            _QuyenSua = Sua;
            _QuyenXoa = Xoa;
        }
    }
}
